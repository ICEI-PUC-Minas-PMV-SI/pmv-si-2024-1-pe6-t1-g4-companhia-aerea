using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;
using Api.Domain.Interfaces.Services.CustomerAggregate;
using Api.Domain.Interfaces.Services.PurchaseAggregate;
using Api.Domain.Interfaces.Services.UserAggregate;
using application.Controllers;
using Domain.Dtos.PurchaseAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize("Bearer")]
    public class PurchaseController : CustomController
    {

        public IPurchaseService _service { get; set; }
        public ILoginService _loginService { get; set; }
        public PurchaseController(IPurchaseService service, ILoginService loginService)
        {
            _service = service;
            _loginService = loginService;
        }

        [HttpGet("getalloffers")]
        public async Task<ActionResult> GetAllOffers()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAllOffers());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "getoffer")]
        public async Task<ActionResult> GetOffer(Guid id)
        {
            var session = GetSessionData();
            var email = GetSessionData().Email;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.GetOffer(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] OffersDtoCreate offer)
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
                    var result = await _service.CreateOffer(offer);
                    if (result != null)
                    {
                        return Created(new Uri(Url.Link("GetCustomer", new { id = result.Id })), result);
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

        
        

    }
}
