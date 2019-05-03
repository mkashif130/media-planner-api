using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class AdModel :IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public MediaChannel MediaChannel { get; set; }
        public SupplierModel Supplier { get; set; }
        public decimal Budget { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public CampaignMode Campaign { get; set; }
    }
}
