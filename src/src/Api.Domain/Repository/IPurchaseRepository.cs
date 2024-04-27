using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Interfaces;
using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IPurchaseRepository : IRepository<PurchaseEntity>
    {
        //Offers
        Task<OffersEntity> InsertOfferAsync(OffersEntity offer);
        Task<OffersEntity> GetOfferById(Guid id);
        Task<IEnumerable<OffersEntity>> GetAllOffers();

        //Payments
        Task<PaymentEntity> InsertPaymentAsync(PaymentEntity payment, Guid userId);
        Task<PaymentEntity> GetPaymentById(Guid id);
        Task<IEnumerable<PaymentEntity>> GetAllPayment();

        //Purchase
        Task<PurchaseEntity> GetpurchaseById(Guid id);
        Task<IEnumerable<PurchaseEntity>> GetAllPurchase();


    }
}
