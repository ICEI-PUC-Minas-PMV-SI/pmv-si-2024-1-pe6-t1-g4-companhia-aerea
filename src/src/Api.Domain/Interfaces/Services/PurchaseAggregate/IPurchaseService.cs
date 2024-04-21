using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;
using Domain.Dtos.CustomerAggregate;
using Domain.Dtos.PurchaseAggregate;

namespace Api.Domain.Interfaces.Services.PurchaseAggregate
{
    public interface IPurchaseService
    {
        //Offers
        Task<OffersDtoCreateResult> CreateOffer(OffersDtoCreate offer);
        Task<OffersDtoGetResult> GetOffer(Guid id);
        Task<IEnumerable<OffersDtoSearchResult>> GetAllOffers();
        Task<bool> Delete(Guid id);

        //Payment
        Task<PaymentDtoCreateResult> CreatePayment(PaymentDtoCreate payment, Guid userId);
        Task<PaymentDtoGetResult> GetPayment(Guid id);
        Task<IEnumerable<PaymentDtoSearchResult>> GetAllPayment();
        Task<bool> DeletePayment(Guid id);


        //Purchase
        //Task<PurchaseDtoResult> GetPurchase(Guid id);
        //Task<IEnumerable<PurchaseDtoResult>> GetAllPurchase();

    }
}
