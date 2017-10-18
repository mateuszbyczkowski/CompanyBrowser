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
    public class CompanyAPIController : ApiController
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyAPIController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Company Get(string number)
        {
            string cleanNumber = CleanNumber(number);
            return _companyRepository.GetCompanyByNumber(cleanNumber);
        }
        
        public string CleanNumber(string number)
        {
            string cleanedNumber = new string(number.Where(char.IsDigit).ToArray());
            return cleanedNumber;
        }

        protected override void Dispose(bool disposing)
        {
            _companyRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}

