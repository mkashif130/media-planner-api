using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository
{
    public interface IAd
    {
        int Save(Model.AdModel ad);
        IEnumerable<Model.AdModel> GetAdByCampaignId(int campaignId);
    }
}
