using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedingDatabase
{
    public class Artist
    {
        public static readonly Artist UserArtist = new Artist()
        {
            Id = new Guid("{2DB01122-A8A5-42CD-844E-52ADB3E4DD4C}"),
            Name = "User Prediction",
            IsActive = true
        };

        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return Name;
        }
    }
}
