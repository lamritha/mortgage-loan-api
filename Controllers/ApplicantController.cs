using Microsoft.AspNetCore.Mvc;
using MortgageLoanAPI.Repositories;
using MortgageLoanAPI.DTOs;

namespace MortgageLoanAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository _applicantRepository;
        public ApplicantController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok("coming soon");
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateApplicantDTO createApplicantDTO)
        {
            return Ok("coming soon");
        }
    }
}
