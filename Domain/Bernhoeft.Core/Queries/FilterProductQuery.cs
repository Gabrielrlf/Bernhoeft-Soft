using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Core.Queries
{
    public class FilterProductQuery
    {
        public string FilterCategory { get; set; }
        public string FilterDescription { get; set; }
        public string FilterSituation { get; set; }
    }
}
