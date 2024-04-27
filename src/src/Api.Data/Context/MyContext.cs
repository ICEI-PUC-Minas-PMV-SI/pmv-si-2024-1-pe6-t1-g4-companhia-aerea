using Api.Data.Mapping;
using Api.Data.Mapping.CustomerAggregate;
using Api.Domain.Entities;
using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        //CustomerAggregate
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<CareerEntity> Careers { get; set; }
        public DbSet<NationalityEntity> Nationalities { get; set; }
        public DbSet<PhoneEntity> Phones { get; set; }



        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

            //Customer Aggregate
            modelBuilder.Entity<CustomerEntity>(new CustomerMap().Configure);
            modelBuilder.Entity<AddressEntity>(new AddressMap().Configure);
            modelBuilder.Entity<CareerEntity>(new CareerMap().Configure);
            modelBuilder.Entity<NationalityEntity>(new NationalityMap().Configure);
            modelBuilder.Entity<PhoneEntity>(new PhoneMap().Configure);




            //Podemos tb configurar para popular o banco com dados fakes
        }
    }
}
