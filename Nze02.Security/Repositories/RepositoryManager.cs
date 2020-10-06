using Nze02.Security.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        ApplicationDbContext _db;
        ICompanyRepository company;

        public RepositoryManager(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICompanyRepository Company {
            get {
                if (company == null) {
                    company = new CompanyRepository(_db);
                }

                return company;
            }
        }

    }
}
