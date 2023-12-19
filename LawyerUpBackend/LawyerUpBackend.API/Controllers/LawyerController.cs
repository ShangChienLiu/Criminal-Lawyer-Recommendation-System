using AutoMapper;
using LawyerUpBackend.Application;
using LawyerUpBackend.Application.Exceptions;
using LawyerUpBackend.Application.Models.Lawyer;
using LawyerUpBackend.Application.Services;
using LawyerUpBackend.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LawyerUpBackend.API.Controllers
{
    public class LawyerController : ApiController
    {
        //private readonly ILawyerListService _lawyerListService;
        private readonly ILawyerService _lawyerService;
        public LawyerController(ILawyerService lawyerService)
        {
            //  _lawyerListService = lawyerListService;
            _lawyerService = lawyerService;

        }
        /*[HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            return Ok(await _lawyerService.GetAllAsync());
        }*/
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _lawyerService.GetByIdAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetListByName([FromQuery] LawyerListQueryModel query)
        {
            try
            {
                return Ok(await _lawyerService.GetListByQuery(query));

            }catch (SearchNotFoundException)
            {
                return NoContent();
            }

        }
    }
}
