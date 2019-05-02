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
            Repository.IGet db = new Repository.DAL.MediaChannel();
            OmniComMediaPlanner.Process.MediaChannelProcess mediaChannel = new OmniComMediaPlanner.Process.MediaChannelProcess(db);
            IEnumerable<Model.IModel> mediaChannels = mediaChannel.Get();
            Assert.AreNotEqual(mediaChannels.Count(), 0);
        }
    }
}
