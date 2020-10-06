using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nze02.Security.Contracts;

namespace Nze02.Security.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly IRepositoryManager _repository;


        public CompanyController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> GetAllCompaniesAsync()
        {
            var companies = await _repository.Company.GetAllCompaniesAsync(trackChanges: false);

            return Ok(companies);
        }
    }
}
