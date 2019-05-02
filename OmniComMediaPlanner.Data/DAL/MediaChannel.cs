using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class MediaChannel : IGet
    {
        public IEnumerable<Model.IModel> Get()
        {
            List<Model.IModel> mediaChannels = new List<Model.IModel>();
            try
            {
                using (var db = new MediaPlannerEntities())
                {
                    var query = from c in db.MediaChannels
                                select c;
                    foreach (var item in query)
                    {
                        mediaChannels.Add(new Model.MediaChannel { Id=item.Id, Channel= item.Channel});
                    }
                   
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Error here
            }
            return mediaChannels;
        }
    }
}
