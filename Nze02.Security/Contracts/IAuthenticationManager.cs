using Nze02.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValdiateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
