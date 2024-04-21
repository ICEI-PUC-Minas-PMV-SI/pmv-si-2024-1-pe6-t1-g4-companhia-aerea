using Api.Data;
using Api.Data.Repository;
using Api.Domain.Entities.CustomerAggregate;
using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class PurchaseImplementation : BaseRepository<PurchaseEntity>, IPurchaseRepository
    {
        private DbSet<OffersEntity> _dbOffer;
        private DbSet<PaymentEntity> _dbPayment;
        private DbSet<PurchaseEntity> _dbPurchase;

        public PurchaseImplementation(MyContext context) : base(context)
        {
            _dbOffer = context.Set<OffersEntity>();
            _dbPayment = context.Set<PaymentEntity>();
            _dbPurchase = context.Set<PurchaseEntity>();
        }
        public async Task<IEnumerable<OffersEntity>> GetAllOffers()
        {
            try
            {
                return await _dbOffer.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PaymentEntity>> GetAllPayment()
        {
            try
            {
                return await _dbPayment.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<OffersEntity> GetOfferById(Guid id)
        {
            return await _dbOffer.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<PaymentEntity> GetPaymentById(Guid id)
        {
            return await _dbPayment.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<OffersEntity> InsertOfferAsync(OffersEntity offer)
        {
            try
            {
                offer.Id = offer.Id == Guid.Empty ? Guid.NewGuid() : offer.Id;
                offer.CreatedAt = DateTime.UtcNow;

                _dbOffer.Add(offer);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return offer;
        }

        public async Task<PaymentEntity> InsertPaymentAsync(PaymentEntity payment, Guid userId)
        {
            try
            {
                payment.Id = payment.Id == Guid.Empty ? Guid.NewGuid() : payment.Id;
                payment.CreatedAt = DateTime.UtcNow;


                var purchaseEntity = new PurchaseEntity() {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    PaymentId = payment.Id,
                    Status = StatusPurchase.Active,
                    CreatedAt = DateTime.UtcNow,
                };

                _dbPayment.Add(payment);
                _dbPurchase.Add(purchaseEntity);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return payment;
        }
    }
}
