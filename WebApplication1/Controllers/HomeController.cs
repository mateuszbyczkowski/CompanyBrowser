using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CompanyWebAPI.DAL;
using CompanyWebAPI.Models;
using WebGrease.Css.Extensions;

namespace CompanyWebAPI.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext context = new CompanyContext();
        private ICompanyRepository companyRepository;

        public HomeController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}