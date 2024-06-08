using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds.FlightAggregate
{
    public static class SeatsSeed
    {
        public static void Seats(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeatsEntity>().HasData(
                    new SeatsEntity()
                    {
                        Id= Guid.NewGuid(),
                        Column = "1",
                        Row= "A",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "1",
                        Row = "B",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "1",
                        Row = "C",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "2",
                        Row = "A",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "2",
                        Row = "B",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "2",
                        Row = "C",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "2",
                        Row = "B",
                        Available = true,
                        Price = 1200.25m,
                        FlightClassId = FlightClass.Economic,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                    new SeatsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Column = "10",
                        Row = "A",
                        Available = true,
                        Price = 5200.50m,
                        FlightClassId = FlightClass.Executive,
                        CreatedAt = DateTime.Now,
                        FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                    },
                     new SeatsEntity()
                     {
                         Id = Guid.NewGuid(),
                         Column = "10",
                         Row = "B",
                         Available = true,
                         Price = 5200.50m,
                         FlightClassId = FlightClass.Executive,
                         CreatedAt = DateTime.Now,
                         FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                     },
                      new SeatsEntity()
                      {
                          Id = Guid.NewGuid(),
                          Column = "20",
                          Row = "A",
                          Available = true,
                          Price = 5200.50m,
                          FlightClassId = FlightClass.Executive,
                          CreatedAt = DateTime.Now,
                          FlightId = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                      },
                        // Campo Grande - Belo Horizonte
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "10",
                            Row = "A",
                            Available = true,
                            Price = 3000.75m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "2",
                            Row = "C",
                            Available = true,
                            Price = 1500.25m,
                            FlightClassId = FlightClass.Economic,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "10",
                            Row = "B",
                            Available = true,
                            Price = 4500.50m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5")
                        },

                        // Maceió - Manaus
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "20",
                            Row = "A",
                            Available = true,
                            Price = 4200.50m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "2",
                            Row = "A",
                            Available = true,
                            Price = 1800.25m,
                            FlightClassId = FlightClass.Economic,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "10",
                            Row = "B",
                            Available = true,
                            Price = 5300.75m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d")
                        },
                        // Belo Horizonte - Vitória
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "20",
                            Row = "B",
                            Available = true,
                            Price = 2800.50m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "2",
                            Row = "C",
                            Available = true,
                            Price = 1300.25m,
                            FlightClassId = FlightClass.Economic,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "10",
                            Row = "B",
                            Available = true,
                            Price = 4500.75m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "20",
                            Row = "A",
                            Available = true,
                            Price = 2200.50m,
                            FlightClassId = FlightClass.Executive,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a")
                        },
                        new SeatsEntity()
                        {
                            Id = Guid.NewGuid(),
                            Column = "3",
                            Row = "A",
                            Available = true,
                            Price = 4100.25m,
                            FlightClassId = FlightClass.Economic,
                            CreatedAt = DateTime.Now,
                            FlightId = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a")
                        }

                );
        }
    }
}
