using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TulsaJobSpot.Models
{
    public class CompanyIndustry
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int IndustryId { get; set; }

    }
}