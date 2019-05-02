using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace OmniComMediaPlanner.Model
{
    public class CountryModel : IModel
    {
        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
        [JsonProperty("name")]
        public string Country { get; set; }
    }
}
