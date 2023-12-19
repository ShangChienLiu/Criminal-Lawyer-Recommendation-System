using LawyerUpBackend.Application.Models.Case;
using LawyerUpBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LawyerUpBackend.API.Controllers
{
    public class SearchController : ApiController
    {
        private readonly IPredictionModelService predictionModelService;
        private readonly ICaseService caseService;
        public SearchController(IPredictionModelService predictionModelService, ICaseService caseService)
        {
            this.predictionModelService = predictionModelService;
            this.caseService = caseService;

        }
        // GET api/<SearchController>/5
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromBody] CaseSearchQueryModel query)
        {
            var searchResult = await caseService.SearchCaseListAsync(query.SearchQuery);
            return Ok(searchResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var searchResult = await caseService.GetByIdAsync(id);
            return Ok(searchResult);
        }

    }
}
