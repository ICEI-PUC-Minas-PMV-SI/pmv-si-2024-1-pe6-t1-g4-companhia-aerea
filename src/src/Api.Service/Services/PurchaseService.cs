using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Interfaces.Services.PurchaseAggregate;
using Api.Domain.Repository;
using AutoMapper;
using Domain.Dtos.CustomerAggregate;
using Domain.Dtos.PurchaseAggregate;
using Domain.Entities.PurchaseAggregate;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PurchaseService : IPurchaseService
    {
        private IPurchaseRepository _repository;
        private readonly IMapper _mapper;
        public PurchaseService(IPurchaseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OffersDtoCreateResult> CreateOffer(OffersDtoCreate offer)
        {
            var offerEntity = new OffersEntity()
            {
                Id = Guid.NewGuid(),
                InitialDate = offer.InitialDate,
                ExpirationDate = offer.ExpirationDate,
                PromotionalCode = offer.PromotionalCode,
                Discount = offer.Discount,
                CreatedAt = DateTime.UtcNow,
            };
            var offerDb = await _repository.InsertOfferAsync(offerEntity);

            var offerResult = new OffersDtoCreateResult()
            {
                Id = offerDb.Id,
                InitialDate = offerDb.InitialDate,
                ExpirationDate = offerDb.ExpirationDate,
                PromotionalCode = offerDb.PromotionalCode,
                Discount = offerDb.Discount,
                CreatedAt = DateTime.UtcNow,
            };
            return offerResult;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OffersDtoSearchResult>> GetAllOffers()
        {
            var listEntity = await _repository.GetAllOffers();
            var listDto = new List<OffersDtoSearchResult>();

            foreach (var offer in listEntity)
            {
                var dto = new OffersDtoSearchResult()
                {
                    Id = offer.Id,
                    InitialDate = offer.InitialDate,
                    ExpirationDate = offer.ExpirationDate,
                    PromotionalCode = offer.PromotionalCode,
                    Discount = offer.Discount,
                };
                listDto.Add(dto);
            }

            return listDto;
        }

        public async Task<OffersDtoGetResult> GetOffer(Guid id)
        {
            var offer = await _repository.GetOfferById(id);

            return new OffersDtoGetResult()
            {
                Id = offer.Id,
                InitialDate = offer.InitialDate,
                ExpirationDate = offer.ExpirationDate,
                PromotionalCode = offer.PromotionalCode,
                Discount = offer.Discount,
                CreatedAt = offer.CreatedAt.Value,
            };
        }
    }
}
