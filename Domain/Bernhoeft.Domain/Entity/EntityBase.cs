using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Domain.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public Situation Situation { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
