using Nze02.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Contracts
{
    interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<Company> GetCompanyAsync(int CompanyID, bool trackchanges);
        void CreateCompany(Company company);
        void DeleteCompany(Company company);
    }
}
