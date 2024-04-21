using Domain.Dtos.FlightAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Net;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;
using Api.Domain.Interfaces.Services.UserAggregate;

namespace application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize("Bearer")]
    public class FlightIntineraryController : CustomController
    {
        public IFlightIntineraryService _flightIntineraryService { get; set; }
        public ILoginService _loginService { get; set; }
        public FlightIntineraryController(IFlightIntineraryService flightIntineraryService, ILoginService loginService)
        {
            _flightIntineraryService = flightIntineraryService;
            _loginService = loginService;
        }
        [HttpGet("getallintinerary")]
        public async Task<ActionResult> GetAllIntinerary()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _flightIntineraryService.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "getflightintinerary")]
        public async Task<ActionResult> GetFlightIntinerary(Guid id)
        {
            var session = GetSessionData();
            var email = GetSessionData().Email;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightIntineraryService.Get(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] FlightIntineraryDtoCreate flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var email = GetSessionData().Email;

                var baseUser = await _loginService.FindByLogin(email);
                if (baseUser != null)
                {
                    var result = await _flightIntineraryService.Post(flight);
                    if (result != null)
                    {
                        return Created(new Uri(Url.Link("GetFlightIntinerary", new { id = result.Id })), result);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                return BadRequest();

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] FlightIntineraryDtoUpdate flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightIntineraryService.Put(flight);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
