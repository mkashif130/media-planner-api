using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class CampaignTest
    {
        [TestMethod]
        public void SaveCampaign()
        {
            OmniComMediaPlanner.Repository.DAL.Campaign client = new Repository.DAL.Campaign();
            Model.CampaignMode campaign = new Model.CampaignMode
            {
                Budget = 5000,
                Client = new Model.Client { Id = 1 },
                Country = new Model.CountryModel { IsoCode = "UAE" },
                FromDate = DateTime.Now.AddDays(1),
                ToDate = DateTime.Now.AddDays(30)
            };
            int campaignId = client.Save(campaign);
            Assert.AreNotEqual(campaignId, 0);
        }
    }
}
