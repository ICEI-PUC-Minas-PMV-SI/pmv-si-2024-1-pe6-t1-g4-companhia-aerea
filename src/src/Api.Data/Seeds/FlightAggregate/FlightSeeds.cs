using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds.FlightAggregate
{
    public static class FlightSeeds
    {
        public static void Flights(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightEntity>().HasData(
                    new FlightEntity()
                    {
                        Id = new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), //Cruzeiro do Sul - Porto Velho
                        FlightCode = "CZSPVH1400",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("5890b5e7-5a2d-4010-a75c-0e7723ab8eee")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5"), // Campo Grande - Belo Horizonte
                        FlightCode = "CGBBHZ1800",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("48641158-39ae-4d28-82e7-f1078f1995f5")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d"), // Maceió - Manaus
                        FlightCode = "MCZMOC2000",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("383ff610-8fff-4b51-92b5-bcc72dbbdea2")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("4e8c5a37-2c6d-4d6f-b68d-e6dd17e7a28c"), // Manaus - Goiânia
                        FlightCode = "MAOGYN1420",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("20cf46bb-1a36-4f3e-9495-1b0dce099620")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("5a9b4d7a-1e6c-456d-8b5c-dc7c9b8d7e6a"), // Goiânia - São Luís
                        FlightCode = "GYNSLZ0930",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("1f6a671b-0050-4d4e-ae85-2f29e42ac338")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("6c7d5b7a-2e7d-4c6f-8d5b-ec8c18e7d8a9"), // Cuiabá - São Luís
                        FlightCode = "CUISLZ1815",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("09db9236-9efe-4b6f-b1cc-37e6ef24bb07")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("7e8d6a4f-3e8d-4d7b-9d7e-f8d9e7d8a7b6"), // Macapá - Imperatriz
                        FlightCode = "MCPIMP0830",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("0dc25656-bd28-4b10-bf9e-1c43300fdf0f")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("8f9d7a5e-4f9e-4e6d-9d8e-e9a8e7d9c8a7"), // Confins - Campo Grande
                        FlightCode = "CNFCGR2050",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("e26a17de-9399-4585-8669-09703722aeab")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("9f8e7d6c-5e8f-4d7e-8d9e-f8a9e7d9c8b6"), // Salvador - Vitória
                        FlightCode = "SVOVIX1030",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("8327f40e-0558-4f3a-be2a-19e46af30205")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("af9e8d7b-6e9e-4d8f-9d8e-fa9e8d7c9b6a"), // Jericoacoara - Ilhéus
                        FlightCode = "JJDIOS0800",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("ed3048d4-5b1f-4be2-b1e6-d7bd533cc128")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("bf8d9e6c-7e9f-4e8f-9d8e-fa9b8e7d9c8b"), // Brasília - Fortaleza
                        FlightCode = "BSBFOR1245",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("befe1bd9-11a6-42da-8f63-6ec4d06a5c6d")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("cf7e8d5c-8e9f-4e8d-9d8e-fa9b8e7d9c8a"), // Rio Branco - Tabatinga
                        FlightCode = "RBTAB1610",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("88e97083-8def-48c6-b192-f7b152b835c7")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("df6e8d4c-9e9e-4e7d-8d9e-fb9b8e7d9c8a"), // Salvador - Rondonópolis
                        FlightCode = "SVORDN1215",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("5af14441-ea5c-44aa-a903-212e407283bd")
                    },
                    new FlightEntity()
                    {
                        Id = new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), // Belo Horizonte - Vitória
                        FlightCode = "CNFVIX1645",
                        FlightStatusId = FlightStatus.Active,
                        CreatedAt = DateTime.Now,
                        FlightIntineraryId = new Guid("6711aae2-1de5-49c3-9e9c-9ce14c4dbaf2")
                    }
                );
        }
    }
}
