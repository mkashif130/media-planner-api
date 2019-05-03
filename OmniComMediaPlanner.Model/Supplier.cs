using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class SupplierModel :IModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Supplier { get; set; }
        [JsonProperty("mc")]
        public MediaChannel Channel { get; set; }
    }
}
