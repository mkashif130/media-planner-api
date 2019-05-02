﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Business 
{
    public class Country : IConfigurationalBusiness
    {
        private Data.IGet _db;
        public Country(Data.IGet db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> Get()
        {
            return _db.Get();
        }
    }
}
