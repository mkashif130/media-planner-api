using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class MediaChannelTest
    {
        [TestMethod]
        public void ListMediaChannels()
        {
            OmniComMediaPlanner.Repository.DAL.MediaChannel mediaChannel = new Repository.DAL.MediaChannel();
            IEnumerable<Model.IModel> mediaChannels = mediaChannel.Get();
            Assert.AreNotEqual(mediaChannels.Count(), 0);
        }
    }
}
