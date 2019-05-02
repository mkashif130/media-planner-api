using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class MediaChannelTest
    {
        [TestMethod]
        public void ListMediaChannels()
        {
            Data.IGet db = new Data.DAL.MediaChannel();
            OmniComMediaPlanner.Business.MediaChannel mediaChannel = new OmniComMediaPlanner.Business.MediaChannel(db);
            IEnumerable<Model.IModel> mediaChannels = mediaChannel.GetMediaChannels();
            Assert.AreNotEqual(mediaChannels.Count(), 0);
        }
    }
}
