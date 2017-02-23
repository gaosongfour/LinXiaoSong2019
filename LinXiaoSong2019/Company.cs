using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinXiaoSong2019
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyName{ get; set; }
        public string Description { get; set; }
        public string Section { get; set; }

        public List<JobOffer> JobOfferList { get; set; }
        


    }
}
