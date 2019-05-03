using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace OmniComMediaPlanner.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]

    public class CampaignController : ApiController
    {
        private Process.ICampaignProcess _bl = null;
        public CampaignController(Process.ICampaignProcess bl)
        {
            _bl = bl;
        }



        [System.Web.Http.HttpPost]
        public HttpResponseMessage SaveCampaign(Model.CampaignMode campaignMode)
        {
            int campaignId = 0;
            try
            {
                campaignId = _bl.SaveCampaign(campaignMode);
            }
            catch (Exception)
            {
                //TODO: log error here
            }


            return Request.CreateResponse(System.Net.HttpStatusCode.OK, campaignId);
        }

        [System.Web.Http.Route("api/campaign/get/{id?}")]
        public HttpResponseMessage Get(int id=0)
        {
            IEnumerable<Model.CampaignMode> campaign = null;
            try
            {
                campaign = _bl.GetCampaign(id);
            }
            catch (Exception)
            {
                //TODO:// Log error here
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, campaign);
        }
    }
}