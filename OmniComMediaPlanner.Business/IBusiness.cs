using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
    public interface IConfigurational
    {
         IEnumerable<Model.IModel> Get();
    }
}
