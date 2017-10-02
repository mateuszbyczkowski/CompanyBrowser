using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using CompanyWebAPI.DAL;
using CompanyWebAPI.Models;
using Newtonsoft.Json;

namespace CompanyWebAPI.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected CompanyContext context = new CompanyContext();

        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
