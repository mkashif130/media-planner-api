using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Data.DAL
{
    public class Supplier 
    {
        public IEnumerable<OmniComMediaPlanner.Data.Supplier> GetSuppliers()
        {
            IEnumerable<Data.Supplier> suppliers = null;
            try
            {
                using (var db = new MediaPlannerEntities())
                {
                    var query = from c in db.Suppliers
                                select c;

                    suppliers = query.ToList();
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Error here
            }
            return suppliers;
        }
    }
}
