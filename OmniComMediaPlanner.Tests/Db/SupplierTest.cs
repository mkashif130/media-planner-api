using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class SupplierTest
    {
        [TestMethod]
        public void ListSuppliers()
        {
            OmniComMediaPlanner.Repository.DAL.Supplier supplier = new Repository.DAL.Supplier();
            IEnumerable<Model.IModel> suppliers = supplier.Get();
            Assert.AreNotEqual(suppliers.Count(), 0);
        }
    }
}
