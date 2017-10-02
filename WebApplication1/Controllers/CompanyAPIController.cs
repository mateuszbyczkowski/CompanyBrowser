using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompanyWebAPI.DAL;
using CompanyWebAPI.Models;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace CompanyWebAPI.Controllers
{
    public class CompanyAPIController : BaseAPIController
    {
        private ICompanyRepository companyRepository;

        //public CompanyAPIController()
        //{
        //    this.companyRepository = new CompanyRepository(new CompanyContext());
        //}
        public CompanyAPIController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public HttpResponseMessage Get(string number)
        {
            return ToJson(companyRepository.GetCompanyByNumber(number));
        }

        protected override void Dispose(bool disposing)
        {
            companyRepository.Dispose();
            base.Dispose(disposing);
        }

        /*public HttpResponseMessage Post([FromBody]Company value)
        {
            context.Company.Add(value);
            return ToJson(context.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]Company value)
        {
            context.Entry(value).State = EntityState.Modified;
            return ToJson(context.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            context.Company.Remove(context.Company.FirstOrDefault(x => x.CompanyId == id));
            return ToJson(context.SaveChanges());
        }*/
    }
}

