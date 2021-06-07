using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TulsaJobSpot.Models
{
    public class CompanyBenefit
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BenefitId { get; set; }
        public DateTime LastVerified { get; set; }

    }
}