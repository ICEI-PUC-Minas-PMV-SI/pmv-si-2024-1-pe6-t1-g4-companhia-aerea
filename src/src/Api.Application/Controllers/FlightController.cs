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
    //[Authorize("Bearer")]
    public class FlightController : CustomController
    {
        public IFlightService _flightService { get; set; }
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }
        
        [HttpGet("get/iata")]
        [AllowAnonymous]
        public async Task<ActionResult> GetIata(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightService.GetIata(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
        [HttpGet("search/iata")]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllIata()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _flightService.GetAllIata());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
        [HttpPost]
        [Authorize("Bearer")]
        public async Task<ActionResult> CreateIata([FromBody] IataDtoCreate iata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightService.PostIata(iata);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("get/iata", new { id = result.Id })), result);
                }
                return BadRequest();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
        [HttpPut]
        [Authorize("Bearer")]
        public async Task<ActionResult> UpdateIata([FromBody] IataDtoUpdate iata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _flightService.PutIata(iata);
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

        [HttpGet("search/searchflights")]
        [AllowAnonymous]
        public async Task<ActionResult> SearchFlights([FromQuery] FlightDetailRequestDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                model.DepeartureDate = model.DepeartureDate.Date;
                model.ReturnDate = model.ReturnDate.HasValue ? model.ReturnDate.Value.Date : null;
                return Ok(await _flightService.SearchFlights(model));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("search/seats")]
        [AllowAnonymous]
        public async Task<ActionResult> SearchSeats([FromQuery] SearchSeatsRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }
            try
            {
                return Ok(await _flightService.SearchSeats(model));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
