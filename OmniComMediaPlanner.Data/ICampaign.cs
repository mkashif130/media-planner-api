using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository
{
    public interface ICampaign
    {
        int Save(Model.CampaignMode campaign);
        IEnumerable<Model.CampaignMode> Get(int campaignId);
    }
}
