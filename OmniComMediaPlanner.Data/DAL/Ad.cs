using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniComMediaPlanner.Model;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class Ad : IAd
    {
        public int Save(Model.AdModel ad)
        {
            int adId = 0;
            try
            {
                if (ad != null)
                {
                    using (var db = new MediaPlannerEntities())
                    {
                        Repository.Ad adEntity = new Repository.Ad
                        {
                            Ad_Title = ad.Title,
                            Budget = ad.Budget,
                            Campaign_Id = ad.Campaign.CampaignId,
                            From_Date = ad.FromDate,
                            To_Date = ad.ToDate,
                            Supplier_Id = ad.Supplier.Id,
                            MediaChannel_Id = ad.MediaChannel.Id
                        };

                        db.Ads.Add(adEntity);
                        db.SaveChanges();
                        adId = adEntity.Id;
                    }


                }
            }
            catch (Exception ex)
            {

                //TODO: Log Exception here
            }

            return adId;
        }


        public IEnumerable<AdModel> GetAdByCampaignId(int campaignId)
        {
            List<AdModel> ads = null;
            try
            {
                {
                    using (var db = new MediaPlannerEntities())
                    {
                        var adEntities = db.Ads.Where(a => a.Campaign_Id == campaignId);
                        if (adEntities != null && adEntities.Count() > 0)
                        {
                            ads = new List<AdModel>();
                            foreach (var item in adEntities)
                            {
                                ads.Add(new AdModel
                                {
                                    Budget = item.Budget,
                                    Campaign = new CampaignMode
                                    {
                                        Budget = item.Campaign.Budget,
                                        CampaignId = item.Campaign.Id,
                                    },
                                    MediaChannel = new Model.MediaChannel { Id = item.MediaChannel.Id, Channel = item.MediaChannel.Channel },
                                    Supplier = new Model.SupplierModel { Id = item.Supplier.Id, Supplier = item.Supplier.Supplier1 },
                                    Id = item.Id,
                                    FromDate = item.From_Date,
                                    Title = item.Ad_Title,
                                    ToDate = item.To_Date
                                });
                            }
                        }

                    }


                }
            }
            catch (Exception ex)
            {

                //TODO: Log Exception here
            }

            return ads;
        }
    }
}
