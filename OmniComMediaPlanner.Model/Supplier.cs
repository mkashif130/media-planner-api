using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class SupplierModel :IModel
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public MediaChannel Channel { get; set; }
    }
}
