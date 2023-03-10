using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Domain.Entity
{
    public class Product : EntityBase
    {

        public string Description { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Id")]
        public Category Category { get; set; }

    }
}
