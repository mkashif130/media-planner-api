using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class CampaignMode : IModel
    {
        [JsonProperty("id")]
        public int CampaignId { get; set; }
        [JsonProperty("country")]
        public CountryModel Country { get; set; }
        [JsonProperty("suppliers")]
        public List<SupplierModel> Suppliers { get; set; }
        [JsonProperty("client")]
        public Client Client { get; set; }
        [JsonProperty("campaignBudget")]
        public decimal Budget { get; set; }
        [JsonProperty("fromDate")]
        public DateTime FromDate { get; set; }
        [JsonProperty("toDate")]
        public DateTime ToDate { get; set; }
    }
}
