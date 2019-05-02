using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Business
{
    public class Supplier
    {
        private Data.IGet _db;
        public Supplier(Data.IGet db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> GetSuppliers()
        {
            return _db.Get();
        }
    }
}
