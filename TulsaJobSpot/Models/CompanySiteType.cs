using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TulsaJobSpot.Models
{
    public class CompanySiteType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<CompanySite> CompanySites { get; set; }
    }
}
