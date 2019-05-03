using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class CampaignMode : IModel
    {
        public int CampaignId { get; set; }
        public CountryModel Country { get; set; }
        public Client Client { get; set; }
        public decimal Budget { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
