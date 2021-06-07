using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TulsaJobSpot.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string LegalName { get; set; }
        public string Website { get; set; }
        public string JobBoard { get; set; }
        public int Type { get; set; }
        public string Size { get; set; }
        public Boolean diversity { get; set; }
        public DateTime DateFounded { get; set; }
        public DateTime DateClosed { get; set; }
        public ICollection<CompanySite> CompanySites { get; set; }
        public ICollection<CompanyIndustry> CompanyIndustries { get; set; }
        public ICollection<CompanyFunction> CompanyFunctions { get; set; }
        public ICollection<CompanyBenefit> CompanyBenefits { get; set; }
    }
}
