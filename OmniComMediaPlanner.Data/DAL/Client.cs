using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class Client : IGet
    {
        public IEnumerable<Model.IModel> Get()
        {
            List<Model.IModel> clients = new List<Model.IModel>();
            try
            {
                using (var db = new MediaPlannerEntities())
                {
                    var query = from c in db.Clients
                                select c;

                    foreach (var item in query)
                    {
                        clients.Add(new Model.Client { Id = item.Id, ClientName = item.name });
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Error here
            }
            return clients;
        }
    }
}
