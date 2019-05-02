using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
    public class SupplierProcess :IConfigurational
    {
        private Repository.IGet _db;
        public SupplierProcess(Repository.IGet db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> Get()
        {
            return _db.Get();
        }
    }
}
