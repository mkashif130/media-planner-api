﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class Supplier : IGet
    {
        public IEnumerable<Model.IModel> Get()
        {
            List<Model.IModel> suppliers = new List<Model.IModel>();
            try
            {
                using (var db = new MediaPlannerEntities())
                {
                    var query = from c in db.Suppliers
                                select c;
                    foreach (var item in query)
                    {
                        suppliers.Add(new Model.SupplierModel
                        {
                            Id = item.Id,
                            Channel = new Model.MediaChannel { Id = item.MediaChannel.Id, Channel = item.MediaChannel.Channel },
                            Supplier = item.Supplier1
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Error here
            }
            return suppliers;
        }
    }
}
