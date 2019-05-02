using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Business
{
    public class Client
    {
        private Data.IGet _db;
        public Client(Data.IGet db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> GetClients()
        {
            return _db.Get();
        }
    }
}
