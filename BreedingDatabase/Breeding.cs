using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [BsonRef]
        public Batch Batch { get; set; }
    }
}
