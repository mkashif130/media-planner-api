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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdController : ApiController
    {
        private Process.IAdProcess _bl = null;
        public AdController(Process.IAdProcess bl)
        {
            _bl = bl;
        }



        [System.Web.Http.HttpPost]
        public HttpResponseMessage Save(Model.AdModel admodel)
        {
            int adId = 0;
            try
            {
                adId = _bl.Save(admodel);
            }
            catch (Exception)
            {
                //TODO: log error here
            }


            return Request.CreateResponse(System.Net.HttpStatusCode.OK, adId);
        }

        [System.Web.Http.HttpGet()]
        [System.Web.Http.Route("api/ad/getbycampaign/{id?}")]
        public HttpResponseMessage GetByCampaignId(int id=0)
        {
            IEnumerable<Model.AdModel> ads = null;
            try
            {
                ads = _bl.GetByCampaignId(id);
            }
            catch (Exception)
            {
                //TODO:// Log error here
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, ads);
        }
    }
}