using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
    }
}
