using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
   public class CampaignProcess :ICampaignProcess
    {
        private Repository.ICampaign _db;
        public CampaignProcess(Repository.ICampaign db)
        {
            _db = db;
        }
        public int SaveCampaign(Model.CampaignMode campaign)
        {
            return _db.Save(campaign);
        }
    }
}
