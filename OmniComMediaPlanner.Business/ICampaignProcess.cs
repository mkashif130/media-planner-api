using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
    public interface ICampaignProcess
    {
        int SaveCampaign(Model.CampaignMode campaignMode);
        IEnumerable<Model.CampaignMode> GetCampaign(int campaignId);
    }
}
