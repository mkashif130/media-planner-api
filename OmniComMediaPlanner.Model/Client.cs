using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Model
{
    public class Client : IModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
    }
}
