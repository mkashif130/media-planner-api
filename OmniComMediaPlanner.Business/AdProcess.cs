using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniComMediaPlanner.Model;

namespace OmniComMediaPlanner.Process
{
   public class AdProcess : IAdProcess
    {
        private Repository.IAd _db;
        public AdProcess(Repository.IAd db)
        {
            _db = db;
        }

        public IEnumerable<AdModel> GetByCampaignId(int cid)
        {
            return _db.GetAdByCampaignId(cid);
        }

        public int Save(AdModel ad)
        {
            return _db.Save(ad);
        }
    }
}
