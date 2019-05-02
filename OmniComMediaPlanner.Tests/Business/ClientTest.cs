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
            Repository.IGet db = new Repository.DAL.Client();
            OmniComMediaPlanner.Process.ClientProcess country = new OmniComMediaPlanner.Process.ClientProcess(db);
            IEnumerable<Model.IModel> clients = country.Get();
            Assert.AreNotEqual(clients.Count(), 0);
        }
    }
}
