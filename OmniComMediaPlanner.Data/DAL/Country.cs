using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Data.DAL
{
    public class Country : IGet
    {
        public IEnumerable<Model.IModel> Get()
        {
            List<Model.CountryModel> countries = new List<Model.CountryModel>();
            try
            {
                using (var db = new MediaPlannerEntities())
                {
                    var query = from c in db.Countries
                                select c;
                    foreach (var c in query)
                    {
                        countries.Add(new Model.CountryModel { Country = c.Name, IsoCode = c.IsoCode });
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Error here
            }
            return countries;
        }
    }
}
