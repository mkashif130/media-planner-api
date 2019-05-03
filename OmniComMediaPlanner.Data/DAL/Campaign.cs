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
                        Repository.Campaign campaignEntity = new Repository.Campaign
                        {
                            Budget = campaign.Budget,
                            Client_Id = campaign.Client.Id,
                            Country = campaign.Country.IsoCode,
                            From_Date = campaign.FromDate,
                            To_Date = campaign.ToDate

                        };

                        db.Campaigns.Add(campaignEntity);
                        db.SaveChanges();
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
