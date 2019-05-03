using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Process
{
    public interface IAdProcess
    {
        int Save(Model.AdModel ad);
        IEnumerable<Model.AdModel> GetByCampaignId(int cid);
    }
}
