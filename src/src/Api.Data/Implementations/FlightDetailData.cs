using Domain.Dtos.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public static class FlightDetailData
    {
        public static List<FlightDetailDto> GetFlights()
        {
            List<FlightDetailDto> flights = new List<FlightDetailDto>
        {
            new FlightDetailDto
            {
                FlightCode = "G3 1234",
                Description = "Flight from São Paulo to Rio de Janeiro",
                LeaveDate = new DateTime(2024, 6, 10, 14, 30, 0),
                ArriveDate = new DateTime(2024, 6, 10, 15, 30, 0),
                LeaveIATACode = "GRU",
                ArriveIATACode = "GIG",
                LeaveAirport = "São Paulo/Guarulhos – Governador André Franco Montoro International Airport",
                ArriveAirport = "Rio de Janeiro–Galeão International Airport",
                LeaveLocation = "São Paulo, SP",
                ArriveLocation = "Rio de Janeiro, RJ",
                PriceExecutive = 750.00m,
                PriceEconomy = 350.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 0910",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 11, 9, 0, 0),
                ArriveDate = new DateTime(2024, 6, 11, 10, 30, 0),
                LeaveIATACode = "CNF",
                ArriveIATACode = "BSB",
                LeaveAirport = "Tancredo Neves/Confins International Airport",
                ArriveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 650.00m,
                PriceEconomy = 300.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 2021",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 11, 20, 0, 0),
                ArriveDate = new DateTime(2024, 6, 11, 21, 30, 0),
                LeaveIATACode = "CNF",
                ArriveIATACode = "BSB",
                LeaveAirport = "Tancredo Neves/Confins International Airport",
                ArriveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 750.00m,
                PriceEconomy = 400.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 1617",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 11, 16, 0, 0),
                ArriveDate = new DateTime(2024, 6, 11, 17, 30, 0),
                LeaveIATACode = "CNF",
                ArriveIATACode = "BSB",
                LeaveAirport = "Tancredo Neves/Confins International Airport",
                ArriveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 750.00m,
                PriceEconomy = 400.00m
            },
             new FlightDetailDto
            {
                FlightCode = "AD 0809",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 11, 8, 0, 0),
                ArriveDate = new DateTime(2024, 6, 11, 9, 30, 0),
                LeaveIATACode = "CNF",
                ArriveIATACode = "BSB",
                LeaveAirport = "Tancredo Neves/Confins International Airport",
                ArriveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 750.00m,
                PriceEconomy = 400.00m
            },
              new FlightDetailDto
            {
                FlightCode = "VO 0809",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 20, 8, 0, 0),
                ArriveDate = new DateTime(2024, 6, 20, 9, 30, 0),
                LeaveIATACode = "BSB",
                ArriveIATACode = "CNF",
                ArriveAirport = "Tancredo Neves/Confins International Airport",
                LeaveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 750.00m,
                PriceEconomy = 400.00m
            },
               new FlightDetailDto
            {
                FlightCode = "VO 1718",
                Description = "Flight from Belo Horizonte to Brasília",
                LeaveDate = new DateTime(2024, 6, 20, 17, 0, 0),
                ArriveDate = new DateTime(2024, 6, 20, 18, 30, 0),
                LeaveIATACode = "BSB",
                ArriveIATACode = "CNF",
                ArriveAirport = "Tancredo Neves/Confins International Airport",
                LeaveAirport = "Brasília International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Brasília, DF",
                PriceExecutive = 750.00m,
                PriceEconomy = 400.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 9102",
                Description = "Flight from Porto Alegre to Salvador",
                LeaveDate = new DateTime(2024, 6, 12, 13, 15, 0),
                ArriveDate = new DateTime(2024, 6, 12, 16, 45, 0),
                LeaveIATACode = "POA",
                ArriveIATACode = "SSA",
                LeaveAirport = "Salgado Filho International Airport",
                ArriveAirport = "Deputado Luís Eduardo Magalhães International Airport",
                LeaveLocation = "Porto Alegre, RS",
                ArriveLocation = "Salvador, BA",
                PriceExecutive = 850.00m,
                PriceEconomy = 450.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 3456",
                Description = "Flight from Recife to Natal",
                LeaveDate = new DateTime(2024, 6, 13, 16, 0, 0),
                ArriveDate = new DateTime(2024, 6, 13, 17, 0, 0),
                LeaveIATACode = "REC",
                ArriveIATACode = "NAT",
                LeaveAirport = "Recife/Guararapes–Gilberto Freyre International Airport",
                ArriveAirport = "São Gonçalo do Amarante–Governador Aluízio Alves International Airport",
                LeaveLocation = "Recife, PE",
                ArriveLocation = "Natal, RN",
                PriceExecutive = 500.00m,
                PriceEconomy = 250.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 7890",
                Description = "Flight from Manaus to Belém",
                LeaveDate = new DateTime(2024, 6, 14, 10, 0, 0),
                ArriveDate = new DateTime(2024, 6, 14, 12, 0, 0),
                LeaveIATACode = "MAO",
                ArriveIATACode = "BEL",
                LeaveAirport = "Eduardo Gomes International Airport",
                ArriveAirport = "Val de Cans International Airport",
                LeaveLocation = "Manaus, AM",
                ArriveLocation = "Belém, PA",
                PriceExecutive = 700.00m,
                PriceEconomy = 350.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 3456",
                Description = "Flight from Fortaleza to Recife",
                LeaveDate = new DateTime(2024, 6, 15, 14, 0, 0),
                ArriveDate = new DateTime(2024, 6, 15, 15, 30, 0),
                LeaveIATACode = "FOR",
                ArriveIATACode = "REC",
                LeaveAirport = "Pinto Martins – Fortaleza International Airport",
                ArriveAirport = "Recife/Guararapes–Gilberto Freyre International Airport",
                LeaveLocation = "Fortaleza, CE",
                ArriveLocation = "Recife, PE",
                PriceExecutive = 550.00m,
                PriceEconomy = 275.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 4567",
                Description = "Flight from Curitiba to Florianópolis",
                LeaveDate = new DateTime(2024, 6, 16, 8, 0, 0),
                ArriveDate = new DateTime(2024, 6, 16, 9, 0, 0),
                LeaveIATACode = "CWB",
                ArriveIATACode = "FLN",
                LeaveAirport = "Afonso Pena International Airport",
                ArriveAirport = "Hercílio Luz International Airport",
                LeaveLocation = "Curitiba, PR",
                ArriveLocation = "Florianópolis, SC",
                PriceExecutive = 450.00m,
                PriceEconomy = 225.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 6789",
                Description = "Flight from Goiânia to São Paulo",
                LeaveDate = new DateTime(2024, 6, 17, 6, 0, 0),
                ArriveDate = new DateTime(2024, 6, 17, 7, 30, 0),
                LeaveIATACode = "GYN",
                ArriveIATACode = "CGH",
                LeaveAirport = "Santa Genoveva/Goiânia International Airport",
                ArriveAirport = "Congonhas Airport",
                LeaveLocation = "Goiânia, GO",
                ArriveLocation = "São Paulo, SP",
                PriceExecutive = 650.00m,
                PriceEconomy = 325.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 5678",
                Description = "Flight from Salvador to Porto Alegre",
                LeaveDate = new DateTime(2024, 6, 18, 11, 0, 0),
                ArriveDate = new DateTime(2024, 6, 18, 14, 30, 0),
                LeaveIATACode = "SSA",
                ArriveIATACode = "POA",
                LeaveAirport = "Deputado Luís Eduardo Magalhães International Airport",
                ArriveAirport = "Salgado Filho International Airport",
                LeaveLocation = "Salvador, BA",
                ArriveLocation = "Porto Alegre, RS",
                PriceExecutive = 900.00m,
                PriceEconomy = 450.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 6789",
                Description = "Flight from Rio de Janeiro to Belo Horizonte",
                LeaveDate = new DateTime(2024, 6, 19, 12, 0, 0),
                ArriveDate = new DateTime(2024, 6, 19, 13, 0, 0),
                LeaveIATACode = "SDU",
                ArriveIATACode = "CNF",
                LeaveAirport = "Santos Dumont Airport",
                ArriveAirport = "Tancredo Neves/Confins International Airport",
                LeaveLocation = "Rio de Janeiro, RJ",
                ArriveLocation = "Belo Horizonte, MG",
                PriceExecutive = 500.00m,
                PriceEconomy = 250.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 8901",
                Description = "Flight from Brasília to Fortaleza",
                LeaveDate = new DateTime(2024, 6, 20, 15, 0, 0),
                ArriveDate = new DateTime(2024, 6, 20, 17, 0, 0),
                LeaveIATACode = "BSB",
                ArriveIATACode = "FOR",
                LeaveAirport = "Brasília International Airport",
                ArriveAirport = "Pinto Martins – Fortaleza International Airport",
                LeaveLocation = "Brasília, DF",
                ArriveLocation = "Fortaleza, CE",
                PriceExecutive = 750.00m,
                PriceEconomy = 375.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 6789",
                Description = "Flight from São Paulo to Porto Alegre",
                LeaveDate = new DateTime(2024, 6, 21, 8, 30, 0),
                ArriveDate = new DateTime(2024, 6, 21, 10, 0, 0),
                LeaveIATACode = "CGH",
                ArriveIATACode = "POA",
                LeaveAirport = "Congonhas Airport",
                ArriveAirport = "Salgado Filho International Airport",
                LeaveLocation = "São Paulo, SP",
                ArriveLocation = "Porto Alegre, RS",
                PriceExecutive = 650.00m,
                PriceEconomy = 325.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 7890",
                Description = "Flight from Rio de Janeiro to Salvador",
                LeaveDate = new DateTime(2024, 6, 22, 13, 0, 0),
                ArriveDate = new DateTime(2024, 6, 22, 14, 30, 0),
                LeaveIATACode = "GIG",
                ArriveIATACode = "SSA",
                LeaveAirport = "Rio de Janeiro–Galeão International Airport",
                ArriveAirport = "Deputado Luís Eduardo Magalhães International Airport",
                LeaveLocation = "Rio de Janeiro, RJ",
                ArriveLocation = "Salvador, BA",
                PriceExecutive = 800.00m,
                PriceEconomy = 400.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 9012",
                Description = "Flight from Recife to Fortaleza",
                LeaveDate = new DateTime(2024, 6, 23, 10, 30, 0),
                ArriveDate = new DateTime(2024, 6, 23, 12, 0, 0),
                LeaveIATACode = "REC",
                ArriveIATACode = "FOR",
                LeaveAirport = "Recife/Guararapes–Gilberto Freyre International Airport",
                ArriveAirport = "Pinto Martins – Fortaleza International Airport",
                LeaveLocation = "Recife, PE",
                ArriveLocation = "Fortaleza, CE",
                PriceExecutive = 600.00m,
                PriceEconomy = 300.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 7890",
                Description = "Flight from Belo Horizonte to Curitiba",
                LeaveDate = new DateTime(2024, 6, 24, 7, 0, 0),
                ArriveDate = new DateTime(2024, 6, 24, 8, 30, 0),
                LeaveIATACode = "CNF",
                ArriveIATACode = "CWB",
                LeaveAirport = "Tancredo Neves/Confins International Airport",
                ArriveAirport = "Afonso Pena International Airport",
                LeaveLocation = "Belo Horizonte, MG",
                ArriveLocation = "Curitiba, PR",
                PriceExecutive = 550.00m,
                PriceEconomy = 275.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 8901",
                Description = "Flight from Natal to Salvador",
                LeaveDate = new DateTime(2024, 6, 25, 9, 0, 0),
                ArriveDate = new DateTime(2024, 6, 25, 10, 30, 0),
                LeaveIATACode = "NAT",
                ArriveIATACode = "SSA",
                LeaveAirport = "São Gonçalo do Amarante–Governador Aluízio Alves International Airport",
                ArriveAirport = "Deputado Luís Eduardo Magalhães International Airport",
                LeaveLocation = "Natal, RN",
                ArriveLocation = "Salvador, BA",
                PriceExecutive = 500.00m,
                PriceEconomy = 250.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 1234",
                Description = "Flight from Brasília to São Paulo",
                LeaveDate = new DateTime(2024, 6, 26, 18, 0, 0),
                ArriveDate = new DateTime(2024, 6, 26, 19, 30, 0),
                LeaveIATACode = "BSB",
                ArriveIATACode = "GRU",
                LeaveAirport = "Brasília International Airport",
                ArriveAirport = "São Paulo/Guarulhos – Governador André Franco Montoro International Airport",
                LeaveLocation = "Brasília, DF",
                ArriveLocation = "São Paulo, SP",
                PriceExecutive = 700.00m,
                PriceEconomy = 350.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 9012",
                Description = "Flight from Porto Alegre to Recife",
                LeaveDate = new DateTime(2024, 6, 27, 11, 0, 0),
                ArriveDate = new DateTime(2024, 6, 27, 14, 30, 0),
                LeaveIATACode = "POA",
                ArriveIATACode = "REC",
                LeaveAirport = "Salgado Filho International Airport",
                ArriveAirport = "Recife/Guararapes–Gilberto Freyre International Airport",
                LeaveLocation = "Porto Alegre, RS",
                ArriveLocation = "Recife, PE",
                PriceExecutive = 900.00m,
                PriceEconomy = 450.00m
            },
            new FlightDetailDto
            {
                FlightCode = "G3 9012",
                Description = "Flight from Rio de Janeiro to Manaus",
                LeaveDate = new DateTime(2024, 6, 28, 14, 0, 0),
                ArriveDate = new DateTime(2024, 6, 28, 17, 30, 0),
                LeaveIATACode = "GIG",
                ArriveIATACode = "MAO",
                LeaveAirport = "Rio de Janeiro–Galeão International Airport",
                ArriveAirport = "Eduardo Gomes International Airport",
                LeaveLocation = "Rio de Janeiro, RJ",
                ArriveLocation = "Manaus, AM",
                PriceExecutive = 1100.00m,
                PriceEconomy = 550.00m
            },
            new FlightDetailDto
            {
                FlightCode = "AD 2345",
                Description = "Flight from Fortaleza to Belém",
                LeaveDate = new DateTime(2024, 6, 29, 7, 30, 0),
                ArriveDate = new DateTime(2024, 6, 29, 9, 0, 0),
                LeaveIATACode = "FOR",
                ArriveIATACode = "BEL",
                LeaveAirport = "Pinto Martins – Fortaleza International Airport",
                ArriveAirport = "Val de Cans International Airport",
                LeaveLocation = "Fortaleza, CE",
                ArriveLocation = "Belém, PA",
                PriceExecutive = 600.00m,
                PriceEconomy = 300.00m
            },
            new FlightDetailDto
            {
                FlightCode = "LA 2345",
                Description = "Flight from Salvador to Goiânia",
                LeaveDate = new DateTime(2024, 6, 30, 16, 0, 0),
                ArriveDate = new DateTime(2024, 6, 30, 18, 30, 0),
                LeaveIATACode = "SSA",
                ArriveIATACode = "GYN",
                LeaveAirport = "Deputado Luís Eduardo Magalhães International Airport",
                ArriveAirport = "Santa Genoveva/Goiânia International Airport",
                LeaveLocation = "Salvador, BA",
                ArriveLocation = "Goiânia, GO",
                PriceExecutive = 800.00m,
                PriceEconomy = 400.00m
            },
        };
            return flights;
        }
    }
}

