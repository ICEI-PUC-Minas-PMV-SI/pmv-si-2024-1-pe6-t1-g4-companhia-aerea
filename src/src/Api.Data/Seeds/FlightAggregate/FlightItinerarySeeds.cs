using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds.FlightAggregate
{
    public static class FlightItinerarySeeds
    {
        public static void Intineraries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightItineraryEntity>().HasData(
                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("5890b5e7-5a2d-4010-a75c-0e7723ab8eee"),
                        Description = "Cruzeiro do Sul - Porto Velho",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 20, 14, 0, 0),
                        ArriveDate = new DateTime(2024, 5, 20, 16, 30, 0),
                        LeaveIATAId = new Guid("8d45c3c4-3c1e-4b3f-8d9e-c8a7d6f7b8a1"), // Cruzeiro do Sul
                        ArriveIATAId = new Guid("f7d8e9c5-4a3b-4d1c-9e8e-b6a7f6d9b3c1"), // Porto Velho
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },
                    // 0
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("48641158-39ae-4d28-82e7-f1078f1995f5"),
                        Description = "Campo Grande - Belo Horizonte",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 20, 18, 0, 0),
                        ArriveDate = new DateTime(2024, 5, 20, 20, 30, 0),
                        LeaveIATAId = new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), // Campo Grande
                        ArriveIATAId = new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), // Belo Horizonte
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },
                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("383ff610-8fff-4b51-92b5-bcc72dbbdea2"),
                        Description = "Maceió - Manaus",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 19, 20, 0, 0),
                        ArriveDate = new DateTime(2024, 5, 19, 23, 30, 0),
                        LeaveIATAId = new Guid("b9f5a4d8-7c3e-4d9b-8a1d-c6a7f8e9b4c3"), // Maceió
                        ArriveIATAId = new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), // Manaus
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },
                     new FlightItineraryEntity()
                     {
                         Id = new Guid("20cf46bb-1a36-4f3e-9495-1b0dce099620"),
                         Description = "Manaus - Goiânia",
                         Available = true,
                         LeaveDate = new DateTime(2024, 5, 18, 14, 20, 0),
                         ArriveDate = new DateTime(2024, 5, 18, 17, 35, 0),
                         LeaveIATAId = new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), // Manaus
                         ArriveIATAId = new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), // Goiânia
                         CreatedAt = DateTime.UtcNow
                         //Passou
                     },
                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("1f6a671b-0050-4d4e-ae85-2f29e42ac338"),
                        Description = "Goiânia - São Luís",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 20, 9, 30, 0),
                        ArriveDate = new DateTime(2024, 5, 20, 12, 20, 0),
                        LeaveIATAId = new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), // Goiânia
                        ArriveIATAId = new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), // São Luís
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("09db9236-9efe-4b6f-b1cc-37e6ef24bb07"),
                        Description = "Cuiabá - São Luís",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 18, 18, 15, 0),
                        ArriveDate = new DateTime(2024, 5, 18, 21, 10, 0),
                        LeaveIATAId = new Guid("f7d8e9c5-3a4b-4d1c-9e8e-b6a7f9e6d3c1"), // Cuiabá
                        ArriveIATAId = new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), // São Luís
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },
                    // 1
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("0dc25656-bd28-4b10-bf9e-1c43300fdf0f"),
                        Description = "Macapá - Imperatriz",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 21, 8, 30, 0),
                        ArriveDate = new DateTime(2024, 5, 21, 10, 45, 0),
                        LeaveIATAId = new Guid("e3d5c7f8-4a2d-4c1b-9d8e-c5a7f6e8b3d2"), // Macapá
                        ArriveIATAId = new Guid("b4d3c9e6-8a3e-4d1b-8e5c-c6a7f8d9b3e2"), // Imperatriz
                        CreatedAt = DateTime.UtcNow
                        //Passou
                    },

                    //---------------------------//

                     new FlightItineraryEntity()
                     {

                         Id = new Guid("e26a17de-9399-4585-8669-09703722aeab"),
                         Description = "Confins - Campo Grande",
                         Available = true,
                         LeaveDate = new DateTime(2024, 5, 18, 20, 50, 0),
                         ArriveDate = new DateTime(2024, 5, 18, 22, 40, 0),
                         LeaveIATAId = new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"),//Confins
                         ArriveIATAId = new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), //Campo Grande
                         CreatedAt = DateTime.UtcNow
                         //*

                     },
                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("8327f40e-0558-4f3a-be2a-19e46af30205"),
                        Description = "Salvador - Vitória",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 18, 10, 30, 0),
                        ArriveDate = new DateTime(2024, 5, 18, 12, 45, 0),
                        LeaveIATAId = new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), // Salvador
                        ArriveIATAId = new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), // Vitória
                        CreatedAt = DateTime.UtcNow
                        //*
                    },

                    new FlightItineraryEntity()
                    {
                        Id = new Guid("ed3048d4-5b1f-4be2-b1e6-d7bd533cc128"),
                        Description = "Jericoacoara - Ilhéus",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 19, 8, 0, 0),
                        ArriveDate = new DateTime(2024, 5, 19, 10, 30, 0),
                        LeaveIATAId = new Guid("b4d9e6c8-7a3e-4d2b-9c1d-d5a7f8b6c3e1"), // Jericoacoara
                        ArriveIATAId = new Guid("d4b5c3e7-6a2d-4b9e-8c1d-b6a7f9e8c3d1"),// Ilhéus
                        CreatedAt = DateTime.UtcNow
                        //*
                    },

                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("befe1bd9-11a6-42da-8f63-6ec4d06a5c6d"),
                        Description = "Brasília - Fortaleza",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 19, 12, 45, 0),
                        ArriveDate = new DateTime(2024, 5, 19, 15, 20, 0),
                        LeaveIATAId = new Guid("f6b8e7c9-3a4d-4d1b-9c8e-c5a7f6e3b2d1"), // Brasília
                        ArriveIATAId = new Guid("d8b9c7e4-3a2d-4d1c-8b5e-a6c7f8e5b9d2"), // Fortaleza
                        CreatedAt = DateTime.UtcNow
                    },

                    // 
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("88e97083-8def-48c6-b192-f7b152b835c7"),
                        Description = "Rio Branco - Tabatinga",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 19, 16, 10, 0),
                        ArriveDate = new DateTime(2024, 5, 19, 18, 30, 0),
                        LeaveIATAId = new Guid("6b3e4a9d-8a1c-4c3d-8d2e-b4a6f7e8c9d1"), // Rio Branco
                        ArriveIATAId = new Guid("c5d6e7f9-4a3c-4b2d-8a1c-d7b8f9e5c4a2"), // Tabatinga
                        CreatedAt = DateTime.UtcNow
                        //***
                    },

                    // 2
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("5af14441-ea5c-44aa-a903-212e407283bd"),
                        Description = "Salvador - Rondonópolis",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 21, 12, 15, 0),
                        ArriveDate = new DateTime(2024, 5, 21, 15, 0, 0),
                        LeaveIATAId = new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), // Salvador
                        ArriveIATAId = new Guid("a8d7f9e6-3b4a-4d1c-8e9e-c5a7f8d6c3b4"), // Rondonópolis
                        CreatedAt = DateTime.UtcNow
                    },

                    // 3
                    new FlightItineraryEntity()
                    {
                        Id = new Guid("6711aae2-1de5-49c3-9e9c-9ce14c4dbaf2"),
                        Description = "Belo Horizonte - Vitória",
                        Available = true,
                        LeaveDate = new DateTime(2024, 5, 21, 16, 45, 0),
                        ArriveDate = new DateTime(2024, 5, 21, 18, 30, 0),
                        LeaveIATAId = new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), // Belo Horizonte
                        ArriveIATAId = new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), // Vitória
                        CreatedAt = DateTime.UtcNow
                    }

                );
        }
    }
}
