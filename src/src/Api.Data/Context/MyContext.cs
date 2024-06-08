using Api.Data.Mapping;
using Api.Data.Mapping.CustomerAggregate;
using Api.Domain.Entities;
using Api.Domain.Entities.CustomerAggregate;
using Data.Mapping.FlightAggregate;
using Data.Seeds.CustomerAggregates;
using Data.Seeds.FlightAggregate;
using Data.Seeds.UserAggregate;
using Domain.Entities.FlightAggregate;
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

        //FlightAggregate
        public DbSet<IataEntity> Iatas { get; set; }
        public DbSet<FlightItineraryEntity> Intineraries { get; set; }
        public DbSet<SeatsEntity> Seats { get; set; }
        public DbSet<FlightEntity> Flights { get; set; }



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

            //FlightAggregate
            modelBuilder.Entity<IataEntity>(new IataMap().Configure);
            modelBuilder.Entity<FlightItineraryEntity>(new FlightIntineraryMap().Configure);
            modelBuilder.Entity<SeatsEntity>(new SeatsMap().Configure);
            modelBuilder.Entity<FlightEntity>(new FlightMap().Configure);

            // ------------------------//
            //MOCKS
            //Cria os Mocks no banco de dados - Tem que apagar o BDD e gerar as migrations novamente

            //User
            UsersSeeds.Users(modelBuilder);

            //CustomerAggregate - O Customer foi o ultimo pois ele depende das outras tabelas
            AddressesSeeds.Addresses(modelBuilder);
            CareersSeeds.Careers(modelBuilder);
            NationalitiesSeeds.Nationalities(modelBuilder);
            PhonesSeeds.Phones(modelBuilder);
            CustomersSeeds.Customers(modelBuilder);

            //FlightAggregate
            IATASeeds.IATAs(modelBuilder);
            FlightItinerarySeeds.Intineraries(modelBuilder);
            FlightSeeds.Flights(modelBuilder);
            SeatsSeed.Seats(modelBuilder);
        }
    }
}