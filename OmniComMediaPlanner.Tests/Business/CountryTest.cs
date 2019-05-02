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
            Repository.IGet db = new Repository.DAL.Country();
            OmniComMediaPlanner.Process.CountryProcess country = new OmniComMediaPlanner.Process.CountryProcess(db);
            IEnumerable<Model.IModel> countries = country.Get();
            Assert.AreNotEqual(countries.Count(), 0);
        }
    }
}
