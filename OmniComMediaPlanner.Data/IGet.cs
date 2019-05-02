using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository
{
    public interface IGet
    {
        IEnumerable<Model.IModel> Get();
    }
}
