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
            Data.IGet db = new Data.DAL.Supplier();
            OmniComMediaPlanner.Business.Supplier supplier = new OmniComMediaPlanner.Business.Supplier(db);
            IEnumerable<Model.IModel> suppliers = supplier.GetSuppliers();
            Assert.AreNotEqual(suppliers.Count(), 0);
        }
    }
}
