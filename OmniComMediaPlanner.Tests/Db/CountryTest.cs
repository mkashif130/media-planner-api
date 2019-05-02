using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Db
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void ListCountries()
        {
            OmniComMediaPlanner.Data.DAL.Country country = new Data.DAL.Country();
            IEnumerable<Model.IModel> countries = country.Get();
            Assert.AreNotEqual(countries.Count(), 0);
        }
    }
}
