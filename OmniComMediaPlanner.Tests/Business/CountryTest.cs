using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniComMediaPlanner.Tests.Business
{

    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void ListCountries()
        {
            Data.IGet db = new Data.DAL.Country();
            OmniComMediaPlanner.Business.Country country = new OmniComMediaPlanner.Business.Country(db);
            IEnumerable<Model.IModel> countries = country.Get();
            Assert.AreNotEqual(countries.Count(), 0);
        }
    }
}
