using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void ListClients()
        {
            OmniComMediaPlanner.Data.DAL.Client client = new Data.DAL.Client();
            IEnumerable<Model.IModel> clients = client.Get();
            Assert.AreNotEqual(clients.Count(), 0);
        }
    }
}
