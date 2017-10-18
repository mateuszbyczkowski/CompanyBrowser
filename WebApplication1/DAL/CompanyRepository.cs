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
        public CompanyContext _context = new CompanyContext();

        public IEnumerable<Company> GetCompanies()
        {
            return _context.Company.ToList();
        }

        public Company GetCompanyByNumber(string number)
        {
            var companyData = _context.Company.SingleOrDefault(c => c.Krs == number || c.Nip == number || c.Regon == number);
            if (companyData == null) return new Company() {};
            return companyData;
        }

        public void InsertCompany(Company company)
        {
            _context.Company.Add(company);
        }

        public void DeleteCompany(int companyId)
        {
            Company student = _context.Company.Find(companyId);
            if (student == null) throw new ArgumentNullException(nameof(student));
            _context.Company.Remove(student);
        }

        public void UpdateCompany(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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