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

        public PurchaseImplementation(MyContext context) : base(context)
        {
            _dbOffer = context.Set<OffersEntity>();
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

        public async Task<OffersEntity> GetOfferById(Guid id)
        {
            return await _dbOffer.SingleOrDefaultAsync(p => p.Id.Equals(id));
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
    }
}
