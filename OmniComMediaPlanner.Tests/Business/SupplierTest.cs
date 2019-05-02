using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class SupplierTest
    {
        [TestMethod]
        public void ListSuppliers()
        {
            Repository.IGet db = new Repository.DAL.Supplier();
            OmniComMediaPlanner.Process.SupplierProcess supplier = new OmniComMediaPlanner.Process.SupplierProcess(db);
            IEnumerable<Model.IModel> suppliers = supplier.Get();
            Assert.AreNotEqual(suppliers.Count(), 0);
        }
    }
}
