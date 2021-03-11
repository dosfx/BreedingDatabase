using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedingDatabase
{
    public class Batch
    {
        [BsonId]
        public Guid Id { get; set; }
        public DateTime BatchDate { get; set; }

        public Batch() : this(Guid.NewGuid(), DateTime.Now) { }

        [BsonCtor]
        public Batch(Guid id, DateTime batchDate)
        {
            Id = id;
            BatchDate = batchDate;
        }
    }
}
