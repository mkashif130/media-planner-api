using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class CampaignTest
    {
        [TestMethod]
        public void SaveCampaign()
        {
            Repository.ICampaign db = new Repository.DAL.Campaign();
            OmniComMediaPlanner.Process.CampaignProcess campaign = new OmniComMediaPlanner.Process.CampaignProcess(db);
            Model.CampaignMode campaignModel = new Model.CampaignMode
            {
                Budget = 6000,
                Client = new Model.Client { Id = 1 },
                Country = new Model.CountryModel { IsoCode = "UAE" },
                FromDate = DateTime.Now.AddDays(1),
                ToDate = DateTime.Now.AddDays(30)
            };
            int id = campaign.SaveCampaign(campaignModel);
            Assert.AreNotEqual(id, 0);
        }
    }
}
