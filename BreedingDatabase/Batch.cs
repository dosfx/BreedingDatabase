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
        public Guid Id { get; private set; }
        public DateTime BatchDate { get; private set; }

        public Batch()
        {
            Id = Guid.NewGuid();
            BatchDate = DateTime.Now;
        }
    }
}
