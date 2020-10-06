using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nze02.Security.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
