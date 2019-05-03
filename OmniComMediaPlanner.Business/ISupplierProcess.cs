using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
    public interface ISupplier
    {
        IEnumerable<Model.IModel> Get();
        IEnumerable<Model.IModel> GetSupplierByMCId(int mcId);
    }
}
