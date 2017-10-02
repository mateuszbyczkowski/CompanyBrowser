using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyWebAPI.Models;

namespace CompanyWebAPI.DAL
{
    public interface ICompanyRepository : IDisposable
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyByNumber(string number);
        void InsertCompany(Company company);
        void DeleteCompany(int companyId);
        void UpdateCompany(Company company);
        void Save();
    }
}
