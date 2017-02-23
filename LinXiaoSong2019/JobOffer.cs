using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinXiaoSong2019
{
    public class JobOffer
    {
        public Guid JobOfferId { get; set; }
        public string JobTitle { get; set; }
        public string JobDetails { get; set; }
        public JobOfferState State { get; set; }
        public City City { get; set; }


        //Insurance
        public bool InsuranceInfo { get; set; }

        //advantage
        public int PaidVacationNumber { get; set; }
    }

    public enum JobOfferState
    {
        
    }
}
