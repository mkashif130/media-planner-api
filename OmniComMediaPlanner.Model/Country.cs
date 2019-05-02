using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class CountryModel : IModel
    {
        public string IsoCode { get; set; }
        public string Country { get; set; }
    }
}
