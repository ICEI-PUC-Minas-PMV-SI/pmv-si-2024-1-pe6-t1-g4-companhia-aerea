using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Interfaces.Services.PurchaseAggregate;
using Api.Domain.Repository;
using AutoMapper;
using Domain.Dtos.CustomerAggregate;
using Domain.Dtos.PurchaseAggregate;
using Domain.Entities.PaymentAggregate;
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

        public async Task<PaymentDtoCreateResult> CreatePayment(PaymentDtoCreate payment, Guid userId)
        {
            var paymentEntity = new PaymentEntity()
            {
                Id = Guid.NewGuid(),
                OfferId = payment.OfferId,
                PaymentCode = PaymentEntity.GeneratePaymentCode(),
                CreatedAt = DateTime.UtcNow,
            };
            var paymentDb = await _repository.InsertPaymentAsync(paymentEntity, userId);

            var paymentResult = new PaymentDtoCreateResult()
            {
                Id = paymentDb.Id,
                OfferId = paymentDb.OfferId,
                PaymentCode = paymentDb.PaymentCode,
                TypePayment = (int)paymentDb.TypePayment,
                SubTotal = paymentDb.SubTotal,
                Total = paymentDb.Total,
                CreatedAt = DateTime.UtcNow,
            };
            return paymentResult;
        }

        public async Task<PaymentDtoGetResult> GetPayment(Guid id)
        {
            var paymentDb = await _repository.GetPaymentById(id);

            return new PaymentDtoGetResult()
            {
                Id = paymentDb.Id,
                OfferId = paymentDb.OfferId,
                PaymentCode = paymentDb.PaymentCode,
                TypePayment = (int)paymentDb.TypePayment,
                SubTotal = paymentDb.SubTotal,
                Total = paymentDb.Total,
                CreatedAt = paymentDb.CreatedAt.Value,
            };
        }

        public async Task<IEnumerable<PaymentDtoSearchResult>> GetAllPayment()
        {
            var listEntity = await _repository.GetAllPayment();
            var listDto = new List<PaymentDtoSearchResult>();

            foreach (var payment in listEntity)
            {
                var dto = new PaymentDtoSearchResult()
                {
                    Id = payment.Id,
                    OfferId = payment.OfferId,
                    PaymentCode = payment.PaymentCode,
                    TypePayment = (int)payment.TypePayment,
                    SubTotal = payment.SubTotal,
                    Total = payment.Total
                };
                listDto.Add(dto);
            }

            return listDto;
        }

        public Task<bool> DeletePayment(Guid id)
        {
            throw new InvalidOperationException("Something went wrong on the server.");
        }

        public async Task<PurchaseDtoResult> GetPurchase(Guid id)
        {
            var purchaseDb = await _repository.GetpurchaseById(id);

            return new PurchaseDtoResult()
            {
                Id = purchaseDb.Id,
                UserId = purchaseDb.UserId,
                PaymentId = purchaseDb.Id,
                CreatedAt = purchaseDb.CreatedAt.Value,
            };
        }

        public async Task<IEnumerable<PurchaseDtoResult>> GetAllPurchase()
        {
            var listEntity = await _repository.GetAllPurchase();
            var listDto = new List<PurchaseDtoResult>();

            foreach (var purchase in listEntity)
            {
                var dto = new PurchaseDtoResult()
                {
                    Id = purchase.Id,
                    UserId = purchase.UserId,
                    PaymentId = purchase.PaymentId,
                    CreatedAt = purchase.CreatedAt.Value,
                };
                listDto.Add(dto);
            }

            return listDto;
        }
    }
}
