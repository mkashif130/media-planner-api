using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void ListClients()
        {
            Data.IGet db = new Data.DAL.Client();
            OmniComMediaPlanner.Business.Client country = new OmniComMediaPlanner.Business.Client(db);
            IEnumerable<Model.IModel> clients = country.GetClients();
            Assert.AreNotEqual(clients.Count(), 0);
        }
    }
}
