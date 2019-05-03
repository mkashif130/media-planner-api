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
    public class MediaChannelController : ApiController
    {
        private Process.IConfigurational _bl = null;
        public MediaChannelController(Process.IConfigurational bl)
        {
            _bl = bl;
        }

        // GET: Country
        public HttpResponseMessage Get()
        {
            IEnumerable<Model.IModel> model = null;
            try
            {
                model = _bl.Get();
            }
            catch (Exception)
            {
                //TODO: log error here
            }


            return Request.CreateResponse(System.Net.HttpStatusCode.OK,model);
        }
    }
}