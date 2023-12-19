using LawyerUpBackend.Application.Exceptions;
using LawyerUpBackend.Application.Models.PredictionModel;
using LawyerUpBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LawyerUpBackend.API.Controllers
{
    [Route("api/[controller]")]
    public class PredictionModelController : ApiController
    {
        private readonly IPredictionModelService _predictionModelService;

        public PredictionModelController(IPredictionModelService predictionModelService)
        {
            _predictionModelService = predictionModelService;
        }
        
        [HttpPost]
        public async Task<IActionResult> SearchAsync([FromBody] PredictionModelQuery predictionModelQuery)
        {
            try
            {
                return Ok(await _predictionModelService.GetPredictionAsync(predictionModelQuery));
            }catch(SearchNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
