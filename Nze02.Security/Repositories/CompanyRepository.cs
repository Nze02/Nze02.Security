using Microsoft.EntityFrameworkCore;
using Nze02.Security.Contracts;
using Nze02.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }


        public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(e => e.Id)
            .ToListAsync();


        public async Task<Company> GetCompanyAsync(int LGAOID, bool trackChanges) =>
            await FindByCondition(e => e.Id.Equals(LGAOID), trackChanges)
            .SingleOrDefaultAsync();


        public void CreateCompany(Company company) => Create(company);

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }
    }
}
