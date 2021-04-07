using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BreedingDatabase
{
    public class Breeding
    {
        public long Id { get; set; }
        public BreedingType BreedingType { get; set; }
        public bool IsRare { get; set; }
        public string Ordering { get; set; }
        [BsonRef(nameof(Batch))]
        public Batch Batch { get; set; }
        public bool IsMooze { get; set; }
        public bool IsXaoc { get; set; }
        public bool RolledXoac { get; set; }

        public void CalcOrdering()
        {
            // throw on a ".0" after the number to match the google sheets hashing
            byte[] bytes = Encoding.UTF8.GetBytes(Id.ToString() + ".0");
            bytes = Encoding.UTF8.GetBytes(Convert.ToBase64String(bytes));
            using (SHA512 sha = SHA512.Create())
            {
                bytes = sha.ComputeHash(bytes);
            }

            StringBuilder builder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                builder.AppendFormat("{0:x2}", b);
            }

            Ordering = builder.ToString();
        }

        public void RollMutant()
        {
            // rolls mutant or not for user predictions
            if (IsMooze || !Chance(RollIndex.Mutant, 5))
            {
                BreedingType = BreedingType.Mutant;
            }
            else
            {
                RollBreedingType();
            }
        }

        public void RollRare()
        {
            if (BreedingType == BreedingType.Mutant) return;
            IsRare = Chance(RollIndex.Rare, 4);
        }

        public void RollBreedingType() => BreedingType = Chance(RollIndex.Type, 2) ? BreedingType.Hybrid : BreedingType.CommonUncommon;

        public void RollXoac()
        {
            if (BreedingType == BreedingType.Mutant) return;
            if (IsXaoc)
            {
                RolledXoac = Chance(RollIndex.Xoac, 100);
            }
        }

        public void SetTypeFromIndex(int index) => BreedingType = index % 10 == 4 ? BreedingType.Hybrid : BreedingType.CommonUncommon;

        private enum RollIndex : int
        {
            Rare = 0,
            Type = 1,
            Xoac = 2,
            Mutant = 3
        }

        private bool Chance(RollIndex index, int odds)
        {
            Random random = new Random((int)Id);
            while (index > 0)
            {
                random.Next();
                index--;
            }

            return random.Next(odds - 1) == 0;
        }
    }
}
