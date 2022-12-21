using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Domain.Entity
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public bool Situation { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
