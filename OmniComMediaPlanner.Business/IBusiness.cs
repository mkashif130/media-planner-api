using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Business
{
    public interface IConfigurationalBusiness
    {
         IEnumerable<Model.IModel> Get();
    }
}
