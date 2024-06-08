using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.ReserveAggregate;
using AutoMapper;
using Domain.Dtos.ReserveAggregate;
using Domain.Models.ReserveAggregate;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class ReserveService 
    {
        //private  IRepository<ReserveEntity> _repository;
        //private IReserveRepository _reserveRepository;
        //private readonly IMapper _mapper;
        

        //public ReserveService(IRepository<ReserveEntity> repository,IReserveRepository reserveRepository, IMapper mapper)
        //{
        //    _repository = repository;
        //    _mapper = mapper;
        //}

     

        //public async Task<bool> Delete(Guid id)
        //{
        //    return await _repository.DeleteAsync(id);
        //}

        //public async Task<ReserveDto> Get(Guid id)
        //{
        //    var reserveEntity = await _repository.SelectByIdAsync(id);
        //    var reserveDto = _mapper.Map<ReserveDto>(reserveEntity);
        //    return reserveDto;
        //}

        //public async Task<IEnumerable<ReserveDto>> GetAll()
        //{
        //   var listEntity = await _repository.SelectAllAsync();
        //    var listDto = _mapper.Map<IEnumerable<ReserveDto>>(listEntity);
        //    return listDto;
        //}

        //public async Task<ReserveDtoCreateResult> Post(ReserveDtoCreate reserve)
        //{
        //    var model = _mapper.Map<ReserveModel>(reserve);
        //    var entity = _mapper.Map<ReserveEntity>(model);
           
        //    var result = await _repository.InsertAsync(entity);
        //    entity.ReserveStatus = 0;

        //    return _mapper.Map<ReserveDtoCreateResult>(result);

        //}

        //public async Task<ReserveDtoUpdateResult> Put(ReserveDtoUpdate reserve)
        //{
        //    var model = _mapper.Map<ReserveModel>(reserve);
        //    var entity = _mapper.Map<ReserveEntity>(model);

        //    var result = await _repository.InsertAsync(entity);

        //    return _mapper.Map<ReserveDtoUpdateResult>(result);
        //}

        //public async Task<IEnumerable<ReserveDto>> GetReserveByCustomer(Guid customerId)
        //{
        //    var entityList =  await _reserveRepository.GetReserveByCustomer(customerId);
        //    var result = _mapper.Map<IEnumerable<ReserveDto>>(entityList);
        //    return result;

        //}
    }
}
