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
        public string Id { get; set; }
        public bool IsMutant { get; set; }
        public bool IsRare { get; set; }
        public bool IsHybrid { get; set; }
        [BsonRef]
        public Batch Batch { get; set; }
    }
}
