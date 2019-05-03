using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class AdTest
    {
        [TestMethod]
        public void SaveAd()
        {
            OmniComMediaPlanner.Repository.DAL.Ad client = new Repository.DAL.Ad();
            Model.AdModel campaign = new Model.AdModel
            {
                Budget = 100,
                Campaign = new Model.CampaignMode { CampaignId = 1 },
                MediaChannel = new Model.MediaChannel { Id = 1 },
                Supplier = new Model.SupplierModel { Id = 1 },
                Title = "Unit Test Ad",
                FromDate = DateTime.Now.AddDays(1),
                ToDate = DateTime.Now.AddDays(30)
            };
            int campaignId = client.Save(campaign);
            Assert.AreNotEqual(campaignId, 0);
        }

        [TestMethod]
        public void GetAdsByCampaignId()
        {
            OmniComMediaPlanner.Repository.DAL.Ad repo = new Repository.DAL.Ad();

            IEnumerable<Model.AdModel> campaign = repo.GetAdByCampaignId(1);

            Assert.AreNotEqual(campaign.Count(), 0);
        }
    }
}
