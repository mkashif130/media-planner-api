using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Repository.DAL
{
    public class Campaign : ICampaign
    {
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
