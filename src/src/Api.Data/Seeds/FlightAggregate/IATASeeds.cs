using System;
using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds.FlightAggregate;

public static class IATASeeds
{
    public static void IATAs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IataEntity>().HasData(
            // Acre
            new IataEntity()
            {
                Id = new Guid("8d45c3c4-3c1e-4b3f-8d9e-c8a7d6f7b8a1"),
                IATACode = "CZS",
                Airport = "Aeroporto Internacional de Cruzeiro do Sul",
                Location = "Cruzeiro do Sul",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },
            new IataEntity()
            {
                Id = new Guid("6b3e4a9d-8a1c-4c3d-8d2e-b4a6f7e8c9d1"),
                IATACode = "RBR",
                Airport = "Aeroporto Internacional de Rio Branco",
                Location = "Rio Branco",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },

            // Alagoas
            new IataEntity()
            {
                Id = new Guid("b9f5a4d8-7c3e-4d9b-8a1d-c6a7f8e9b4c3"),
                IATACode = "MCZ",
                Airport = "Aeroporto Internacional Zumbi dos Palmares",
                Location = "Maceió",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },

            // Amapá
            new IataEntity()
            {
                Id = new Guid("e3d5c7f8-4a2d-4c1b-9d8e-c5a7f6e8b3d2"),
                IATACode = "MCP",
                Airport = "Aeroporto Internacional de Macapá",
                Location = "Macapá",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },

            // Amazonas
            new IataEntity()
            {
                Id = new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"),
                IATACode = "MAO",
                Airport = "Aeroporto Internacional Eduardo Gomes",
                Location = "Manaus",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },
            new IataEntity()
            {
                Id = new Guid("c5d6e7f9-4a3c-4b2d-8a1c-d7b8f9e5c4a2"),
                IATACode = "TBT",
                Airport = "Aeroporto Internacional de Tabatinga",
                Location = "Tabatinga",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },

// Bahia
            new IataEntity()
            {
                Id = new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"),
                IATACode = "SSA",
                Airport = "Aeroporto Internacional Deputado Luís Eduardo Magalhães",
                Location = "Salvador",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },
            new IataEntity()
            {
                Id = new Guid("d4b5c3e7-6a2d-4b9e-8c1d-b6a7f9e8c3d1"),
                IATACode = "IOS",
                Airport = "Aeroporto Jorge Amado",
                Location = "Ilhéus",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },
            new IataEntity()
            {
                Id = new Guid("e2a3d4c5-8b4a-4d2b-8e1c-c5a7f6d9b3e6"),
                IATACode = "VDC",
                Airport = "Aeroporto Pedro Otacílio Figueiredo",
                Location = "Vitória da Conquista",
                Available = true,
                CreatedAt = DateTime.UtcNow
            },

        // Ceará
                    new IataEntity()
                    {
                        Id = new Guid("d8b9c7e4-3a2d-4d1c-8b5e-a6c7f8e5b9d2"),
                        IATACode = "FOR",
                        Airport = "Aeroporto Internacional Pinto Martins",
                        Location = "Fortaleza",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("b4d9e6c8-7a3e-4d2b-9c1d-d5a7f8b6c3e1"),
                        IATACode = "JJD",
                        Airport = "Aeroporto Regional de Jericoacoara",
                        Location = "Jericoacoara",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("c6a7d5b8-8b4e-4a1d-8c9e-b7a8f6e9c3d4"),
                        IATACode = "QXQ",
                        Airport = "Aeroporto Regional do Cariri",
                        Location = "Juazeiro do Norte",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Distrito Federal
                    new IataEntity()
                    {
                        Id = new Guid("f6b8e7c9-3a4d-4d1b-9c8e-c5a7f6e3b2d1"),
                        IATACode = "BSB",
                        Airport = "Aeroporto Internacional Presidente Juscelino Kubitschek",
                        Location = "Brasília",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Espírito Santo
                    new IataEntity()
                    {
                        Id = new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"),
                        IATACode = "VIX",
                        Airport = "Aeroporto Eurico de Aguiar Salles",
                        Location = "Vitória",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Goiás
                    new IataEntity()
                    {
                        Id = new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"),
                        IATACode = "GYN",
                        Airport = "Aeroporto Santa Genoveva",
                        Location = "Goiânia",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("a8d7c6e5-3b4a-4d9b-8e1c-c5a7f8b6d3e1"),
                        IATACode = "CLV",
                        Airport = "Aeroporto Nelson Ribeiro Guimarães",
                        Location = "Caldas Novas",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Maranhão
                    new IataEntity()
                    {
                        Id = new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"),
                        IATACode = "SLZ",
                        Airport = "Aeroporto Internacional Marechal Cunha Machado",
                        Location = "São Luís",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("b4d3c9e6-8a3e-4d1b-8e5c-c6a7f8d9b3e2"),
                        IATACode = "IMP",
                        Airport = "Aeroporto Prefeito Renato Moreira",
                        Location = "Imperatriz",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Mato Grosso
                    new IataEntity()
                    {
                        Id = new Guid("f7d8e9c5-3a4b-4d1c-9e8e-b6a7f9e6d3c1"),
                        IATACode = "CGB",
                        Airport = "Aeroporto Internacional Marechal Rondon",
                        Location = "Cuiabá",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("d5b3c6a7-8b4e-4a1b-8c9e-c7a8f6e9b4d2"),
                        IATACode = "OPS",
                        Airport = "Aeroporto Municipal de Sinop",
                        Location = "Sinop",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("a8d7f9e6-3b4a-4d1c-8e9e-c5a7f8d6c3b4"),
                        IATACode = "ROO",
                        Airport = "Aeroporto Internacional de Rondonópolis",
                        Location = "Rondonópolis",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    // Mato Grosso do Sul
                    new IataEntity()
                    {
                        Id = new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"),
                        IATACode = "CGR",
                        Airport = "Aeroporto Internacional de Campo Grande",
                        Location = "Campo Grande",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("b4d3f9e6-8a4e-4d1b-8e5c-c6a7f8b3d9e2"),
                        IATACode = "DOU",
                        Airport = "Aeroporto Francisco de Matos Pereira",
                        Location = "Dourados",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Minas Gerais
                    new IataEntity()
                    {
                        Id = new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"),
                        IATACode = "CNF",
                        Airport = "Aeroporto Internacional de Confins",
                        Location = "Belo Horizonte",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("d5b3e6c7-8a4e-4a1b-8c9e-c7a8f6e5b9d2"),
                        IATACode = "PLU",
                        Airport = "Aeroporto da Pampulha",
                        Location = "Belo Horizonte",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("a8d7c9e6-3b4a-4d1c-8e5e-c5a7f8b6d3e4"),
                        IATACode = "UDI",
                        Airport = "Aeroporto de Uberlândia",
                        Location = "Uberlândia",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = new Guid("f7d8e9c5-4a3b-4d1c-9e8e-b6a7f6d9b3c1"),
                        IATACode = "MOC",
                        Airport = "Aeroporto de Montes Claros",
                        Location = "Montes Claros",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Pará
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "BEL",
                        Airport = "Aeroporto Internacional de Belém",
                        Location = "Belém",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "STM",
                        Airport = "Aeroporto Internacional de Santarém",
                        Location = "Santarém",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "MAB",
                        Airport = "Aeroporto de Marabá",
                        Location = "Marabá",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Paraíba
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "JPA",
                        Airport = "Aeroporto Internacional Presidente Castro Pinto",
                        Location = "João Pessoa",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "CPV",
                        Airport = "Aeroporto de Campina Grande",
                        Location = "Campina Grande",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Paraná
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "CWB",
                        Airport = "Aeroporto Internacional Afonso Pena",
                        Location = "Curitiba",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "LDB",
                        Airport = "Aeroporto de Londrina",
                        Location = "Londrina",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "IGU",
                        Airport = "Aeroporto Internacional de Foz do Iguaçu",
                        Location = "Foz do Iguaçu",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Pernambuco
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "REC",
                        Airport = "Aeroporto Internacional dos Guararapes",
                        Location = "Recife",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "PNZ",
                        Airport = "Aeroporto de Petrolina",
                        Location = "Petrolina",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Piauí
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "THE",
                        Airport = "Aeroporto Senador Petrônio Portella",
                        Location = "Teresina",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "PHB",
                        Airport = "Aeroporto Internacional Prefeito Doutor João Silva Filho",
                        Location = "Parnaíba",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Rio de Janeiro
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "GIG",
                        Airport = "Aeroporto Internacional do Galeão",
                        Location = "Rio de Janeiro",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "SDU",
                        Airport = "Aeroporto Santos Dumont",
                        Location = "Rio de Janeiro",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "CFB",
                        Airport = "Aeroporto de Cabo Frio",
                        Location = "Cabo Frio",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    // Rio Grande do Norte
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "NAT",
                        Airport = "Aeroporto Internacional Governador Aluízio Alves",
                        Location = "Natal",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "MII",
                        Airport = "Aeroporto Regional de Mossoró",
                        Location = "Mossoró",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Rio Grande do Sul
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "POA",
                        Airport = "Aeroporto Internacional Salgado Filho",
                        Location = "Porto Alegre",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "CXJ",
                        Airport = "Aeroporto Regional Hugo Cantergiani",
                        Location = "Caxias do Sul",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "PFB",
                        Airport = "Aeroporto Lauro Kortz",
                        Location = "Passo Fundo",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Rondônia
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "PVH",
                        Airport = "Aeroporto Internacional Governador Jorge Teixeira de Oliveira",
                        Location = "Porto Velho",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "JPR",
                        Airport = "Aeroporto José Coleto",
                        Location = "Ji-Paraná",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "BVH",
                        Airport = "Aeroporto de Vilhena",
                        Location = "Vilhena",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    // Roraima
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "BVB",
                        Airport = "Aeroporto Internacional Atlas Brasil Cantanhede",
                        Location = "Boa Vista",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Santa Catarina
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "FLN",
                        Airport = "Aeroporto Internacional Hercílio Luz",
                        Location = "Florianópolis",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "NVT",
                        Airport = "Aeroporto Internacional de Navegantes",
                        Location = "Navegantes",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "JOI",
                        Airport = "Aeroporto Lauro Carneiro de Loyola",
                        Location = "Joinville",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // São Paulo
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "GRU",
                        Airport = "Aeroporto Internacional de Guarulhos",
                        Location = "São Paulo",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "CGH",
                        Airport = "Aeroporto de Congonhas",
                        Location = "São Paulo",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "VCP",
                        Airport = "Aeroporto Internacional de Viracopos",
                        Location = "Campinas",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Sergipe
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "AJU",
                        Airport = "Aeroporto Internacional de Aracaju",
                        Location = "Aracaju",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },

        // Tocantins
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "PMW",
                        Airport = "Aeroporto Brigadeiro Lysias Rodrigues",
                        Location = "Palmas",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "AUX",
                        Airport = "Aeroporto de Araguaína",
                        Location = "Araguaína",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    },
                    new IataEntity()
                    {
                        Id = Guid.NewGuid(),
                        IATACode = "GMP",
                        Airport = "Aeroporto de Gurupi",
                        Location = "Gurupi",
                        Available = true,
                        CreatedAt = DateTime.UtcNow
                    }
        );
    }
}