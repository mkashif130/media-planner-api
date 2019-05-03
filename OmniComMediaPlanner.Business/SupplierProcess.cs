using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniComMediaPlanner.Model;

namespace OmniComMediaPlanner.Process
{
    public class SupplierProcess :ISupplier
    {
        private Repository.ISupplier _db;
        public SupplierProcess(Repository.ISupplier db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> Get()
        {
            return _db.Get();
        }

        public IEnumerable<IModel> GetSupplierByMCId(int mcId)
        {
            return _db.GetSupplierByMCId(mcId);
        }
    }
}
