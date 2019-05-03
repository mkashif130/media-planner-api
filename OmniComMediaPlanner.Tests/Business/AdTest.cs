using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class AdTest
    {
        [TestMethod]
        public void SaveAd()
        {
            Repository.IAd db = new Repository.DAL.Ad();
            OmniComMediaPlanner.Process.AdProcess campaign = new OmniComMediaPlanner.Process.AdProcess(db);
            Model.AdModel campaignModel = new Model.AdModel
            {
                Budget = 6000,
                Campaign = new Model.CampaignMode { CampaignId = 1 },
                MediaChannel = new Model.MediaChannel { Id = 1 },
                Supplier = new Model.SupplierModel { Id = 1 },
                Title = "Unit Test Ad 2",
                FromDate = DateTime.Now.AddDays(1),
                ToDate = DateTime.Now.AddDays(30)
            };
            int id = campaign.Save(campaignModel);
            Assert.AreNotEqual(id, 0);
        }
    }
}
