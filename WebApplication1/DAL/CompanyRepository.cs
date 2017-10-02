using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CompanyWebAPI.Models;

namespace CompanyWebAPI.DAL
{
    public class CompanyRepository : ICompanyRepository, IDisposable
    {
        private CompanyContext context;
        public CompanyRepository(CompanyContext context)
        {
            this.context = context;
        }
        public IEnumerable<Company> GetCompanies()
        {
            return context.Company.ToList();
        }

        public Company GetCompanyByNumber(string number)
        {
            string cleanNumber = CleanNumber(number);
            var companyData = context.Company.SingleOrDefault(c => c.Krs == cleanNumber || c.Nip == cleanNumber || c.Regon == cleanNumber);
            if (companyData == null) return new Company() {};
            return companyData;
        }

        public string CleanNumber(string number)
        {
            string cleanedNumber = new string(number.Where(char.IsDigit).ToArray());
            return cleanedNumber;
        }

        public void InsertCompany(Company company)
        {
            context.Company.Add(company);
        }

        public void DeleteCompany(int companyId)
        {
            Company student = context.Company.Find(companyId);
            if (student == null) throw new ArgumentNullException(nameof(student));
            context.Company.Remove(student);
        }

        public void UpdateCompany(Company company)
        {
            context.Entry(company).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}