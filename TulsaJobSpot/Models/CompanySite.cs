using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TulsaJobSpot.Models
{
    public class CompanySite
    {
        public int Id { get; set; }
        public int SiteTypeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string SiteWebsite { get; set; }
        public string SiteJobBoard { get; set; }
        public Boolean PublicTransit { get; set; }
    }
}