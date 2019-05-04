using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniComMediaPlanner.Model;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class Campaign : ICampaign
    {
        public IEnumerable<CampaignMode> Get(int campaignId)
        {
            List<Model.CampaignMode> campaign = null;
            try
            {
                {
                    using (var db = new MediaPlannerEntities())
                    {
                        var campaignsEntity = db.Campaigns.Where(c => c.Id == campaignId || campaignId == 0);

                        if (campaignsEntity != null && campaignsEntity.Count() > 0)
                        {
                            campaign = new List<CampaignMode>();
                            foreach (var campaignEntity in campaignsEntity)
                            {
                                campaign.Add(new CampaignMode
                                {
                                    Budget = campaignEntity.Budget,
                                    RemainingBudget = campaignEntity.Remaining_Budget,
                                    CampaignId = campaignEntity.Id,
                                    Client = new Model.Client { Id = campaignEntity.Client.Id, ClientName = campaignEntity.Client.name },
                                    Country = new Model.CountryModel { Country = campaignEntity.Country1.Name, IsoCode = campaignEntity.Country1.IsoCode },
                                    FromDate = campaignEntity.From_Date,
                                    ToDate = campaignEntity.To_Date
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

            return campaign;
        }

        public int Save(Model.CampaignMode campaign)
        {
            int campaignID = 0;
            try
            {
                if (campaign != null)
                {
                    using (var db = new MediaPlannerEntities())
                    {
                        //for some reason, i am not able to pass client id from front end
                        // autocomplete not working as expected
                        //this needs to be fixed.
                        Repository.Client clientEntity = db.Clients.FirstOrDefault(c => c.name.ToLower() == campaign.Client.ClientName.ToLower());
                        Repository.Country countryEntity = db.Countries.FirstOrDefault(c => c.Name.ToLower() == campaign.Country.Country.ToLower());
                        Repository.Campaign campaignEntity = new Repository.Campaign
                        {
                            Budget = campaign.Budget,
                            Remaining_Budget = campaign.Budget,
                            Client_Id = clientEntity.Id,
                            Country =countryEntity.IsoCode,
                            From_Date = campaign.FromDate,
                            To_Date = campaign.ToDate,


                        };

                        db.Campaigns.Add(campaignEntity);
                        db.SaveChanges();

                        foreach (var item in campaign.Suppliers)
                        {

                            Repository.Campaign_Supplier campaign_Supplier = new Campaign_Supplier
                            {
                                Campaign_Id = campaignEntity.Id,
                                Supplier_Id = item.Id
                            };

                            db.Campaign_Supplier.Add(campaign_Supplier);
                            db.SaveChanges();
                        }
                        campaignID = campaignEntity.Id;
                    }


                }
            }
            catch (Exception ex)
            {

                //TODO: Log Exception here
            }

            return campaignID;
        }
    }
}
