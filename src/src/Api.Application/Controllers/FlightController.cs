using Api.Domain.Dtos.CustomerAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using System;
using Domain.Dtos.FlightAggregate;
using Api.Domain.Interfaces.Services.UserAggregate;

namespace application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize("Bearer")]
    public class FlightController : CustomController
    {
        public IFlightService _flightService { get; set; }
        public ILoginService _loginService { get; set; }
        public FlightController(IFlightService flightService, ILoginService loginService)
        {
            _flightService = flightService;
            _loginService = loginService;
        }
        [HttpGet("getallflights")]
        public async Task<ActionResult> GetAllFlights()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _flightService.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "getflight")]
        public async Task<ActionResult> GetFlight(Guid id)
        {
            var session = GetSessionData();
            var email = GetSessionData().Email;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightService.Get(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] FlightDtoCreate flight)
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
                    var result = await _flightService.Post(flight);
                    if (result != null)
                    {
                        return Created(new Uri(Url.Link("GetFlight", new { id = result.Id })), result);
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
        public async Task<ActionResult> Update([FromBody] FlightDtoUpdate flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightService.Put(flight);
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
