using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class AdModel :IModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("adTitle")]
        public string Title { get; set; }
        
        public MediaChannel MediaChannel { get; set; }
        [JsonProperty("supplier")]
        public SupplierModel Supplier { get; set; }
        [JsonProperty("budget")]
        public decimal Budget { get; set; }
        [JsonProperty("fromDate")]
        public DateTime FromDate { get; set; }
        [JsonProperty("toDate")]
        public DateTime ToDate { get; set; }
        [JsonProperty("campaign")]
        public CampaignMode Campaign { get; set; }
    }
}
