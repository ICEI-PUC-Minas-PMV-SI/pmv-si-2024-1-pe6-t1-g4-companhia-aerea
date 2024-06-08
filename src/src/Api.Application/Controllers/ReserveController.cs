using Api.Domain.Interfaces.Services.ReserveAggregate;
using Api.Domain.Interfaces.Services.UserAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using System;
using Api.Domain.Dtos.UserAggregate;
using Domain.Dtos.ReserveAggregate;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserveController : ControllerBase { }
    //{
    //    public IReserveService _service { get; set; }
    //    public ReserveController(IReserveService service)
    //    {
    //        _service = service;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult> GetAll()
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);  
    //        }
    //        try
    //        {
    //            return Ok(await _service.GetAll());
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }

    //    [HttpGet]
    //    [Route("{id}", Name = "GetReserveById")]
    //    public async Task<ActionResult> Get(Guid id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        try
    //        {
    //            var result = await _service.Get(id);
    //            return Ok(result);
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }

    //    [HttpGet]
    //    [Route("{id}", Name = "GetByCustomer")]
    //    public async Task<ActionResult> GetReserveByCustomer(Guid id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        try
    //        {
    //            var result = await _service.GetReserveByCustomer(id);
    //            return Ok(result);
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }


    //    [HttpPost]
    //    public async Task<ActionResult> Create([FromBody] ReserveDtoCreate reserve)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        try
    //        {
    //            var result = await _service.Post(reserve);
    //            if (result != null)
    //            {
    //                return Created(new Uri(Url.Link("GetReserveById", new { id = result.Id })), result);
    //            }
    //            else
    //            {
    //                return BadRequest();
    //            }
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }

    //    [HttpPut]
    //    public async Task<ActionResult> Update([FromBody] ReserveDtoUpdate reserve)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        try
    //        {
    //            var result = await _service.Put(reserve);
    //            if (result != null)
    //            {
    //                return Ok(result);
    //            }
    //            else
    //            {
    //                return BadRequest();
    //            }
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult> Delete(Guid id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        try
    //        {
    //            return Ok(await _service.Delete(id));
    //        }
    //        catch (ArgumentException e)
    //        {
    //            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
    //        }
    //    }

    }


