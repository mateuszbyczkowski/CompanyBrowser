using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CompanyWebAPI.Models;

namespace CompanyWebAPI.DAL
{
    public class CompanyInitializer : CreateDatabaseIfNotExists<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            SeedCompanyData(context).Wait();
            base.Seed(context);
        }

        protected static async Task SeedCompanyData(CompanyContext context)
        {
            var companies = new List<Company>
            {
                new Company()
                {
                    Name = "Firma ABC Polska Sp. z o.o.",
                    City = "Poznań",
                    Postcode = "61-100",
                    Street = "Warszawska",
                    StreetNumber = "72/2a",
                    Regon = "7777777",
                    Nip = "7777777777",
                    Krs = "0000777777"
                },
                new Company()
                {
                    Name = "Firma Sklep Komputerowy S.A.",
                    City = "Warszawa",
                    Postcode = "21-121",
                    Street = "Poznańska",
                    StreetNumber = "3",
                    Regon = "950427384",
                    Nip = "9222367183",
                    Krs = "0000133156"
                },
                new Company()
                {
                    Name = "Firma Księgarnia Sp. z o.o.",
                    City = "Gniezno",
                    Postcode = "62-200",
                    Street = "Krakowska",
                    StreetNumber = "13",
                    Regon = "888888888",
                    Nip = "8888888888",
                    Krs = "0000888888"
                }
            };
            companies.ForEach(company => context.Company.Add(company));
            await context.SaveChangesAsync();
        }
    }
}