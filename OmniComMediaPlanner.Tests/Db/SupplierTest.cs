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
            OmniComMediaPlanner.Data.DAL.Supplier supplier = new Data.DAL.Supplier();
            IEnumerable<OmniComMediaPlanner.Data.Supplier> suppliers = supplier.GetSuppliers();
            Assert.AreNotEqual(suppliers.Count(), 0);
        }
    }
}
