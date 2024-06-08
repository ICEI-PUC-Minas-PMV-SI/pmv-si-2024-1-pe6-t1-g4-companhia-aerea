using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Neighborhood = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complement = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Career",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AverageWage = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Iata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IATACode = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Airport = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iata", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CountryCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DDD = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TypePhone = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TypeUser = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Intinerary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ArriveDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LeaveIATAId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ArriveIATAID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intinerary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intinerary_Iata_ArriveIATAID",
                        column: x => x.ArriveIATAID,
                        principalTable: "Iata",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Intinerary_Iata_LeaveIATAId",
                        column: x => x.LeaveIATAId,
                        principalTable: "Iata",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Document = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AddressId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PhoneId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CareerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Career",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FlightCode = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FlightStatusId = table.Column<int>(type: "int", nullable: false),
                    flightintineraryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Intinerary_flightintineraryId",
                        column: x => x.flightintineraryId,
                        principalTable: "Intinerary",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Column = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Row = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    FlightClassId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Complement", "Country", "CreatedAt", "Neighborhood", "Number", "State", "Street", "UpdateAt", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), "Belo Horizonte", "Casa", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4767), "Esmelo", "0", "MG", "Rua dos Bobos", null, "31615-520" },
                    { new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), "Rio de Janeiro", "Casa 2", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4780), "Tijuca", "123", "RJ", "Rua Conde de Bonfim", null, "20540-060" },
                    { new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), "Brasília", "Apartamento", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4773), "Asa Sul", "S/N", "DF", "Quadra 300", null, "70000-000" },
                    { new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), "Belo Horizonte", "Sala 301", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4782), "Centro", "250", "MG", "Avenida Afonso Pena", null, "30140-061" },
                    { new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), "São Paulo", "Bloco B", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4776), "Vila Mariana", "1000", "SP", "Avenida Paulista", null, "04101-000" },
                    { new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), "Piracicaba", "Loja", "Brasil", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4785), "Centro", "789", "SP", "Rua do Rosário", null, "13400-000" }
                });

            migrationBuilder.InsertData(
                table: "Career",
                columns: new[] { "Id", "AverageWage", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), 6000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4839), "Designer Gráfico", "", null },
                    { new Guid("2fc86ba3-6479-454a-9bc7-9e8ec1b78492"), 2800.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4977), "Auxiliar Administrativo", "", null },
                    { new Guid("30254dd1-bd95-4e12-9e7c-5bdc40aa61b1"), 9500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4832), "Advogado", "", null },
                    { new Guid("46e17017-2f85-4968-80b6-4ff1c0fc2db7"), 9500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4823), "Engenheiro Civil", "", null },
                    { new Guid("4b42eeed-b9c4-43e2-8151-eb18df5f1e2b"), 7000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4871), "Analista de Marketing", "", null },
                    { new Guid("506cb080-4a8b-42a3-9f34-bde6e1a40e9b"), 6000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4850), "Chef de Cozinha", "", null },
                    { new Guid("5af956fc-1bb9-44d0-9ee1-6435ff7e5de2"), 8500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4865), "Dentista", "", null },
                    { new Guid("61ad6489-fb49-4782-8c4b-ef9b7fb5b4c7"), 8500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4852), "Engenheiro de Software", "", null },
                    { new Guid("6371818f-7e95-4c65-a67f-19b74f87f47e"), 8000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4861), "Arquiteto", "", null },
                    { new Guid("671892c6-002f-4a48-9913-3b10e20697d3"), 3000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4981), "Recepcionista", "", null },
                    { new Guid("79295cb4-f755-4575-8049-f13e74cb19f4"), 7800.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4863), "Analista de Sistemas", "", null },
                    { new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), 18000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4825), "Médico Cirurgião", "", null },
                    { new Guid("82301e43-8ec9-4e7f-8a5a-3c9bc2a1a660"), 5500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4834), "Enfermeiro", "", null },
                    { new Guid("8b3e12cf-8a0b-4d96-8a29-7614bf18d2bc"), 5000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4869), "Fotógrafo", "", null },
                    { new Guid("8e088726-ae8b-4211-8c19-cb20f97a0948"), 12000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4858), "Piloto de Avião", "", null },
                    { new Guid("94edfb10-7361-4708-924f-50b3b3ff17d6"), 2000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4983), "Auxiliar de Limpeza", "", null },
                    { new Guid("a76f70c6-6c2d-4d09-b9a0-7dc7f21ef16d"), 1800.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4985), "Ajudante de Cozinha", "", null },
                    { new Guid("a882f777-00a3-4b98-92e8-625ca8d444c0"), 7500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4848), "Farmacêutico", "", null },
                    { new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), 7000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4854), "Psicólogo Clínico", "", null },
                    { new Guid("c55e8fb0-df1f-43e8-8e07-f81a4463d0a4"), 8000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4867), "Contador", "", null },
                    { new Guid("d60ed8ae-6d30-4c2a-b946-6c751a18b871"), 2500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4979), "Atendente de Telemarketing", "", null },
                    { new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), 7650.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4821), "Desenvolvedor de Software", "", null },
                    { new Guid("ebbe4f7a-f025-4db4-8b52-ae0a0e3d09f7"), 8500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4836), "Analista Financeiro", "", null },
                    { new Guid("f22844bb-7601-439d-b6f0-d6cc1d510e0e"), 8500.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4829), "Professor Universitário", "", null },
                    { new Guid("fd484e11-26b4-4e54-9f1e-66e3e529180d"), 9000.0, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4856), "Engenheiro Mecânico", "", null }
                });

            migrationBuilder.InsertData(
                table: "Iata",
                columns: new[] { "Id", "Airport", "Available", "CreatedAt", "IATACode", "Location", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("088fa7f4-3233-4a22-9df7-d05f8994d737"), "Aeroporto Internacional de Foz do Iguaçu", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5436), "IGU", "Foz do Iguaçu", null },
                    { new Guid("136e0cbf-6af8-4cd8-bee5-403c00156e94"), "Aeroporto de Campina Grande", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5430), "CPV", "Campina Grande", null },
                    { new Guid("20e0d080-1d7d-4c74-b903-474f3b90ebf9"), "Aeroporto Lauro Kortz", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5463), "PFB", "Passo Fundo", null },
                    { new Guid("210077b0-da3d-40fa-b771-8f1dca65fb3e"), "Aeroporto de Vilhena", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5470), "BVH", "Vilhena", null },
                    { new Guid("250356da-4d51-4753-8b1d-ae0247006940"), "Aeroporto Internacional Governador Aluízio Alves", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5454), "NAT", "Natal", null },
                    { new Guid("2700dfa3-6bf7-4d5f-9ff0-680b2fae003a"), "Aeroporto de Marabá", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5410), "MAB", "Marabá", null },
                    { new Guid("37cc1e69-20f2-4b08-84c7-5d0d1cdfac38"), "Aeroporto Santos Dumont", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5450), "SDU", "Rio de Janeiro", null },
                    { new Guid("39720aa4-cd10-49a1-b676-c32a8f9d98d6"), "Aeroporto Internacional de Viracopos", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5486), "VCP", "Campinas", null },
                    { new Guid("441e99af-28d8-4aee-a36b-64bfe4dbb561"), "Aeroporto de Londrina", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5434), "LDB", "Londrina", null },
                    { new Guid("61d65e60-b214-4a0e-b61c-2f52397bc084"), "Aeroporto Internacional do Galeão", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5448), "GIG", "Rio de Janeiro", null },
                    { new Guid("672f8e63-5dd7-4ff6-a586-eda463022e16"), "Aeroporto Internacional de Guarulhos", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5480), "GRU", "São Paulo", null },
                    { new Guid("6b3e4a9d-8a1c-4c3d-8d2e-b4a6f7e8c9d1"), "Aeroporto Internacional de Rio Branco", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5275), "RBR", "Rio Branco", null },
                    { new Guid("701647f7-e2ec-4b8f-bdaa-0566b956ed31"), "Aeroporto Internacional de Aracaju", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5488), "AJU", "Aracaju", null },
                    { new Guid("716ed2cf-fdff-4bc5-bd09-ba0f340294f7"), "Aeroporto Internacional Afonso Pena", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5432), "CWB", "Curitiba", null },
                    { new Guid("737edfc1-9c5c-4c5a-9d67-76901645fcf7"), "Aeroporto Regional Hugo Cantergiani", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5461), "CXJ", "Caxias do Sul", null },
                    { new Guid("7ac1c44b-6399-486d-80d4-9e0be150d406"), "Aeroporto Brigadeiro Lysias Rodrigues", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5490), "PMW", "Palmas", null },
                    { new Guid("806c455c-61a6-4dec-ac0f-1c2d83fc96fc"), "Aeroporto Internacional Hercílio Luz", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5474), "FLN", "Florianópolis", null },
                    { new Guid("843294ec-6e70-44bf-b577-05cdb82e7cf6"), "Aeroporto de Petrolina", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5440), "PNZ", "Petrolina", null },
                    { new Guid("8553a750-2d63-45d3-91e5-66ea196de9bf"), "Aeroporto Internacional Governador Jorge Teixeira de Oliveira", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5467), "PVH", "Porto Velho", null },
                    { new Guid("8d45c3c4-3c1e-4b3f-8d9e-c8a7d6f7b8a1"), "Aeroporto Internacional de Cruzeiro do Sul", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5272), "CZS", "Cruzeiro do Sul", null },
                    { new Guid("945d0b87-29d5-4652-a808-ba98d4b5f06d"), "Aeroporto Internacional Atlas Brasil Cantanhede", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5472), "BVB", "Boa Vista", null },
                    { new Guid("9b7190e3-4eb0-4a82-a49e-9333b657de22"), "Aeroporto de Araguaína", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5492), "AUX", "Araguaína", null },
                    { new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), "Aeroporto Internacional Eduardo Gomes", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5282), "MAO", "Manaus", null },
                    { new Guid("a52ea88b-02ad-4bbb-8f63-9217dcacfa8a"), "Aeroporto de Gurupi", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5493), "GMP", "Gurupi", null },
                    { new Guid("a8d7c6e5-3b4a-4d9b-8e1c-c5a7f8b6d3e1"), "Aeroporto Nelson Ribeiro Guimarães", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5342), "CLV", "Caldas Novas", null },
                    { new Guid("a8d7c9e6-3b4a-4d1c-8e5e-c5a7f8b6d3e4"), "Aeroporto de Uberlândia", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5365), "UDI", "Uberlândia", null },
                    { new Guid("a8d7f9e6-3b4a-4d1c-8e9e-c5a7f8d6c3b4"), "Aeroporto Internacional de Rondonópolis", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5354), "ROO", "Rondonópolis", null },
                    { new Guid("a99567f2-fd5e-4f42-8e8f-20e6c587bd9a"), "Aeroporto Internacional Salgado Filho", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5458), "POA", "Porto Alegre", null },
                    { new Guid("add6b8c9-fb06-46f8-b4e0-c554fa1f3a86"), "Aeroporto Senador Petrônio Portella", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5442), "THE", "Teresina", null },
                    { new Guid("b0a6b811-9b42-4a85-85d5-a89e202f5923"), "Aeroporto Internacional de Belém", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5406), "BEL", "Belém", null },
                    { new Guid("b13a7643-1929-4907-9eb1-ab19641cb002"), "Aeroporto José Coleto", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5469), "JPR", "Ji-Paraná", null },
                    { new Guid("b4d3c9e6-8a3e-4d1b-8e5c-c6a7f8d9b3e2"), "Aeroporto Prefeito Renato Moreira", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5348), "IMP", "Imperatriz", null },
                    { new Guid("b4d3f9e6-8a4e-4d1b-8e5c-c6a7f8b3d9e2"), "Aeroporto Francisco de Matos Pereira", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5358), "DOU", "Dourados", null },
                    { new Guid("b4d9e6c8-7a3e-4d2b-9c1d-d5a7f8b6c3e1"), "Aeroporto Regional de Jericoacoara", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5292), "JJD", "Jericoacoara", null },
                    { new Guid("b73c6180-32d1-4d56-a6a9-371a91d2cb57"), "Aeroporto Lauro Carneiro de Loyola", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5478), "JOI", "Joinville", null },
                    { new Guid("b9f5a4d8-7c3e-4d9b-8a1d-c6a7f8e9b4c3"), "Aeroporto Internacional Zumbi dos Palmares", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5277), "MCZ", "Maceió", null },
                    { new Guid("c0318bda-b2b2-4ada-9f84-cb8cd5ce7533"), "Aeroporto de Congonhas", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5484), "CGH", "São Paulo", null },
                    { new Guid("c5d6e7f9-4a3c-4b2d-8a1c-d7b8f9e5c4a2"), "Aeroporto Internacional de Tabatinga", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5283), "TBT", "Tabatinga", null },
                    { new Guid("c6a7d5b8-8b4e-4a1d-8c9e-b7a8f6e9c3d4"), "Aeroporto Regional do Cariri", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5294), "QXQ", "Juazeiro do Norte", null },
                    { new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), "Aeroporto Internacional de Campo Grande", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5356), "CGR", "Campo Grande", null },
                    { new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), "Aeroporto Internacional Marechal Cunha Machado", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5345), "SLZ", "São Luís", null },
                    { new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), "Aeroporto Eurico de Aguiar Salles", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5337), "VIX", "Vitória", null },
                    { new Guid("d4b5c3e7-6a2d-4b9e-8c1d-b6a7f9e8c3d1"), "Aeroporto Jorge Amado", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5287), "IOS", "Ilhéus", null },
                    { new Guid("d5b3c6a7-8b4e-4a1b-8c9e-c7a8f6e9b4d2"), "Aeroporto Municipal de Sinop", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5352), "OPS", "Sinop", null },
                    { new Guid("d5b3e6c7-8a4e-4a1b-8c9e-c7a8f6e5b9d2"), "Aeroporto da Pampulha", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5363), "PLU", "Belo Horizonte", null },
                    { new Guid("d8b9c7e4-3a2d-4d1c-8b5e-a6c7f8e5b9d2"), "Aeroporto Internacional Pinto Martins", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5290), "FOR", "Fortaleza", null },
                    { new Guid("db444757-1026-4bb2-94db-e84755475039"), "Aeroporto Internacional de Santarém", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5408), "STM", "Santarém", null },
                    { new Guid("e2a3d4c5-8b4a-4d2b-8e1c-c5a7f6d9b3e6"), "Aeroporto Pedro Otacílio Figueiredo", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5288), "VDC", "Vitória da Conquista", null },
                    { new Guid("e3d5c7f8-4a2d-4c1b-9d8e-c5a7f6e8b3d2"), "Aeroporto Internacional de Macapá", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5280), "MCP", "Macapá", null },
                    { new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), "Aeroporto Santa Genoveva", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5339), "GYN", "Goiânia", null },
                    { new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), "Aeroporto Internacional de Confins", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5362), "CNF", "Belo Horizonte", null },
                    { new Guid("e9d1a5f5-c30c-42ef-8a89-22ba984736b3"), "Aeroporto Internacional dos Guararapes", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5438), "REC", "Recife", null },
                    { new Guid("ec457b05-b3d9-4860-83a9-396616293d4c"), "Aeroporto de Cabo Frio", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5452), "CFB", "Cabo Frio", null },
                    { new Guid("edca152a-a044-444c-bdaa-07cf61ef4017"), "Aeroporto Internacional Prefeito Doutor João Silva Filho", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5444), "PHB", "Parnaíba", null },
                    { new Guid("f486cb8b-9bab-4146-9bef-70041dceac10"), "Aeroporto Internacional de Navegantes", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5476), "NVT", "Navegantes", null },
                    { new Guid("f6b8e7c9-3a4d-4d1b-9c8e-c5a7f6e3b2d1"), "Aeroporto Internacional Presidente Juscelino Kubitschek", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5295), "BSB", "Brasília", null },
                    { new Guid("f700c131-ff3c-4b17-98b4-a23bf1c659ed"), "Aeroporto Regional de Mossoró", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5456), "MII", "Mossoró", null },
                    { new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), "Aeroporto Internacional Deputado Luís Eduardo Magalhães", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5285), "SSA", "Salvador", null },
                    { new Guid("f7d8e9c5-3a4b-4d1c-9e8e-b6a7f9e6d3c1"), "Aeroporto Internacional Marechal Rondon", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5350), "CGB", "Cuiabá", null },
                    { new Guid("f7d8e9c5-4a3b-4d1c-9e8e-b6a7f6d9b3c1"), "Aeroporto de Montes Claros", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5367), "MOC", "Montes Claros", null },
                    { new Guid("fe365ba8-a237-47c1-a442-ff7e65cdc6eb"), "Aeroporto Internacional Presidente Castro Pinto", true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5412), "JPA", "João Pessoa", null }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0a3a3f5f-bf97-4a64-bd07-1b45468de336"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5027), "Inglesa", "", null },
                    { new Guid("0e61a8b8-0a65-4e3e-9203-dbe526054bb4"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5048), "Indiana", "", null },
                    { new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5024), "Argentina", "", null },
                    { new Guid("334f5a76-3b27-45f0-8371-75f36a7381c2"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5029), "Francesa", "", null },
                    { new Guid("5f5e0a2c-4201-4a2e-80e5-85d1ee8cf077"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5026), "Chilena", "", null },
                    { new Guid("66d38f80-5b2c-409e-b4f6-68b017af22db"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5018), "Americana", "", null },
                    { new Guid("7ff9a21e-3ff2-4ef0-aac1-1181a6ff7a78"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5041), "Norueguesa", "", null },
                    { new Guid("96e01522-d4b5-4d07-bfe6-f4c6151b2f33"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5034), "Espanhola", "", null },
                    { new Guid("a5658e1d-61ff-4e48-9a38-95bfb631e7a1"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5047), "Russa", "", null },
                    { new Guid("ae7c6886-4a8c-4878-8ff6-5755046a93d8"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5020), "Canadense", "", null },
                    { new Guid("bb179145-250f-4260-80e0-232e5743ec7b"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5050), "Coreana", "", null },
                    { new Guid("bd609feb-4d8e-4384-bcd1-7641fb4b3e1a"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5043), "Japonesa", "", null },
                    { new Guid("c301e7a7-d90e-47e3-b241-3fdad89d0b79"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5039), "Sueca", "", null },
                    { new Guid("ca7ae9c3-62f3-4a05-b7ac-0c6e3f29b10e"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5032), "Alemã", "", null },
                    { new Guid("cd1b540e-119a-4417-bf69-6fd4f8a558c1"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5052), "Australiana", "", null },
                    { new Guid("d8f23df8-d9f6-4696-9b0b-1613c1e4ef63"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5031), "Italiana", "", null },
                    { new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5015), "Brasileira", "", null },
                    { new Guid("ec91c3d3-fb1c-44d1-a01e-af4bb1a4f3f5"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5045), "Chinesa", "", null },
                    { new Guid("f700bd3b-1256-4f55-a682-d1e7c10f59a1"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5022), "Mexicana", "", null },
                    { new Guid("f920c11e-f6f7-42a3-b3bc-83701241c781"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5037), "Portuguesa", "", null }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CountryCode", "CreatedAt", "DDD", "Number", "TypePhone", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5089), "61", "8765-4321", 3, null },
                    { new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5081), "11", "3123-4567", 2, null },
                    { new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5083), "21", "98765-4321", 3, null },
                    { new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5086), "51", "3030-2020", 2, null },
                    { new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5085), "41", "99988-7766", 1, null },
                    { new Guid("f56171aa-4179-4668-9618-ca1676679449"), "55", new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5079), "31", "9 9944-2621", 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DateBirth", "Email", "FirstName", "LastName", "Password", "Status", "TypeUser", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new DateTime(2024, 5, 18, 21, 17, 50, 42, DateTimeKind.Utc).AddTicks(8057), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@email.com", "User Adm", "Adm Master", "$2a$11$ANjXlNCC/fi.lG8HVEsEwuuxDQVfLDldHVOUNyoEcDYwxaCy1DIpm", 1, 1, null },
                    { new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"), new DateTime(2024, 5, 18, 21, 17, 50, 253, DateTimeKind.Utc).AddTicks(8714), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@email.com", "User Regular", "Last Regular", "$2a$11$c5IOx1djUzE/OFQw.2iPh.2Z8x3srTctrvlaD1fh9OP/Sr3pYvXPG", 1, 2, null },
                    { new Guid("7fc20e97-a58d-4c92-b2c2-a41eedd931e1"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(4195), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose@email.com", "Jose", "Pereira", "$2a$11$V13RPFvPXQJmjlmA02mxt.BeVjg5xQpVtSjUJns/NKc96bH3Huf7W", 1, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "AddressId", "CareerId", "CreatedAt", "DateBirth", "Document", "Email", "FirstName", "LastName", "NationalityId", "PhoneId", "StatusId", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("039cd0f7-1506-4daf-9648-be0fa40434fb"), new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), null, new DateTime(2024, 5, 18, 21, 27, 50, 456, DateTimeKind.Utc).AddTicks(5189), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "543.609.281-49", "customer03@email.com", "Customer 03 do Adm ", "Last Name Customer 03", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("0c0e881c-61cf-4d12-8788-94e118d22177"), new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 5, 19, 0, 17, 50, 456, DateTimeKind.Utc).AddTicks(5237), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "367.195.482-34", "customer03r@email.com", "Customer 03 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5151), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "116.987.659-96", "customer01@email.com", "Customer 01 do Adm ", "Last Name Customer 01", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("f56171aa-4179-4668-9618-ca1676679449"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("7c259bf1-ee8b-4d1d-949e-b4a3aca134c4"), new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), new DateTime(2024, 5, 18, 23, 17, 50, 456, DateTimeKind.Utc).AddTicks(5173), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "189.847.392-05", "customer02@email.com", "Customer 02 do Adm ", "Last Name Customer 02", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("f3b171ea-047a-4e9d-a282-4115a76f419f"), new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), new DateTime(2024, 5, 18, 22, 17, 50, 456, DateTimeKind.Utc).AddTicks(5200), new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "786.123.549-02", "customer01r@email.com", "Customer 01 do regular 01 ", "Last Name Customer 01R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("fdf6777d-f6d3-4c54-96c3-4c498aa0903b"), new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 5, 19, 0, 17, 50, 456, DateTimeKind.Utc).AddTicks(5227), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "952.746.830-61", "customer02r@email.com", "Customer 02 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") }
                });

            migrationBuilder.InsertData(
                table: "Intinerary",
                columns: new[] { "Id", "ArriveDate", "ArriveIATAID", "Available", "CreatedAt", "Description", "LeaveDate", "LeaveIATAId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("09db9236-9efe-4b6f-b1cc-37e6ef24bb07"), new DateTime(2024, 5, 18, 21, 10, 0, 0, DateTimeKind.Unspecified), new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5568), "Cuiabá - São Luís", new DateTime(2024, 5, 18, 18, 15, 0, 0, DateTimeKind.Unspecified), new Guid("f7d8e9c5-3a4b-4d1c-9e8e-b6a7f9e6d3c1"), null },
                    { new Guid("0dc25656-bd28-4b10-bf9e-1c43300fdf0f"), new DateTime(2024, 5, 21, 10, 45, 0, 0, DateTimeKind.Unspecified), new Guid("b4d3c9e6-8a3e-4d1b-8e5c-c6a7f8d9b3e2"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5572), "Macapá - Imperatriz", new DateTime(2024, 5, 21, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e3d5c7f8-4a2d-4c1b-9d8e-c5a7f6e8b3d2"), null },
                    { new Guid("1f6a671b-0050-4d4e-ae85-2f29e42ac338"), new DateTime(2024, 5, 20, 12, 20, 0, 0, DateTimeKind.Unspecified), new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5564), "Goiânia - São Luís", new DateTime(2024, 5, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), null },
                    { new Guid("20cf46bb-1a36-4f3e-9495-1b0dce099620"), new DateTime(2024, 5, 18, 17, 35, 0, 0, DateTimeKind.Unspecified), new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5559), "Manaus - Goiânia", new DateTime(2024, 5, 18, 14, 20, 0, 0, DateTimeKind.Unspecified), new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), null },
                    { new Guid("383ff610-8fff-4b51-92b5-bcc72dbbdea2"), new DateTime(2024, 5, 19, 23, 30, 0, 0, DateTimeKind.Unspecified), new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5554), "Maceió - Manaus", new DateTime(2024, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9f5a4d8-7c3e-4d9b-8a1d-c6a7f8e9b4c3"), null },
                    { new Guid("48641158-39ae-4d28-82e7-f1078f1995f5"), new DateTime(2024, 5, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5549), "Campo Grande - Belo Horizonte", new DateTime(2024, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), null },
                    { new Guid("5890b5e7-5a2d-4010-a75c-0e7723ab8eee"), new DateTime(2024, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("f7d8e9c5-4a3b-4d1c-9e8e-b6a7f6d9b3c1"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5545), "Cruzeiro do Sul - Porto Velho", new DateTime(2024, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d45c3c4-3c1e-4b3f-8d9e-c8a7d6f7b8a1"), null },
                    { new Guid("5af14441-ea5c-44aa-a903-212e407283bd"), new DateTime(2024, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8d7f9e6-3b4a-4d1c-8e9e-c5a7f8d6c3b4"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5598), "Salvador - Rondonópolis", new DateTime(2024, 5, 21, 12, 15, 0, 0, DateTimeKind.Unspecified), new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), null },
                    { new Guid("6711aae2-1de5-49c3-9e9c-9ce14c4dbaf2"), new DateTime(2024, 5, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5603), "Belo Horizonte - Vitória", new DateTime(2024, 5, 21, 16, 45, 0, 0, DateTimeKind.Unspecified), new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), null },
                    { new Guid("8327f40e-0558-4f3a-be2a-19e46af30205"), new DateTime(2024, 5, 18, 12, 45, 0, 0, DateTimeKind.Unspecified), new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5580), "Salvador - Vitória", new DateTime(2024, 5, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), null },
                    { new Guid("88e97083-8def-48c6-b192-f7b152b835c7"), new DateTime(2024, 5, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), new Guid("c5d6e7f9-4a3c-4b2d-8a1c-d7b8f9e5c4a2"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5594), "Rio Branco - Tabatinga", new DateTime(2024, 5, 19, 16, 10, 0, 0, DateTimeKind.Unspecified), new Guid("6b3e4a9d-8a1c-4c3d-8d2e-b4a6f7e8c9d1"), null },
                    { new Guid("befe1bd9-11a6-42da-8f63-6ec4d06a5c6d"), new DateTime(2024, 5, 19, 15, 20, 0, 0, DateTimeKind.Unspecified), new Guid("d8b9c7e4-3a2d-4d1c-8b5e-a6c7f8e5b9d2"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5590), "Brasília - Fortaleza", new DateTime(2024, 5, 19, 12, 45, 0, 0, DateTimeKind.Unspecified), new Guid("f6b8e7c9-3a4d-4d1b-9c8e-c5a7f6e3b2d1"), null },
                    { new Guid("e26a17de-9399-4585-8669-09703722aeab"), new DateTime(2024, 5, 18, 22, 40, 0, 0, DateTimeKind.Unspecified), new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5576), "Confins - Campo Grande", new DateTime(2024, 5, 18, 20, 50, 0, 0, DateTimeKind.Unspecified), new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), null },
                    { new Guid("ed3048d4-5b1f-4be2-b1e6-d7bd533cc128"), new DateTime(2024, 5, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("d4b5c3e7-6a2d-4b9e-8c1d-b6a7f9e8c3d1"), true, new DateTime(2024, 5, 18, 21, 17, 50, 456, DateTimeKind.Utc).AddTicks(5586), "Jericoacoara - Ilhéus", new DateTime(2024, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4d9e6c8-7a3e-4d2b-9c1d-d5a7f8b6c3e1"), null }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "CreatedAt", "FlightCode", "flightintineraryId", "FlightStatusId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5698), "CGBBHZ1800", new Guid("48641158-39ae-4d28-82e7-f1078f1995f5"), 1, null },
                    { new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5701), "MCZMOC2000", new Guid("383ff610-8fff-4b51-92b5-bcc72dbbdea2"), 1, null },
                    { new Guid("4e8c5a37-2c6d-4d6f-b68d-e6dd17e7a28c"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5704), "MAOGYN1420", new Guid("20cf46bb-1a36-4f3e-9495-1b0dce099620"), 1, null },
                    { new Guid("5a9b4d7a-1e6c-456d-8b5c-dc7c9b8d7e6a"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5707), "GYNSLZ0930", new Guid("1f6a671b-0050-4d4e-ae85-2f29e42ac338"), 1, null },
                    { new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5684), "CZSPVH1400", new Guid("5890b5e7-5a2d-4010-a75c-0e7723ab8eee"), 1, null },
                    { new Guid("6c7d5b7a-2e7d-4c6f-8d5b-ec8c18e7d8a9"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5710), "CUISLZ1815", new Guid("09db9236-9efe-4b6f-b1cc-37e6ef24bb07"), 1, null },
                    { new Guid("7e8d6a4f-3e8d-4d7b-9d7e-f8d9e7d8a7b6"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5713), "MCPIMP0830", new Guid("0dc25656-bd28-4b10-bf9e-1c43300fdf0f"), 1, null },
                    { new Guid("8f9d7a5e-4f9e-4e6d-9d8e-e9a8e7d9c8a7"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5718), "CNFCGR2050", new Guid("e26a17de-9399-4585-8669-09703722aeab"), 1, null },
                    { new Guid("9f8e7d6c-5e8f-4d7e-8d9e-f8a9e7d9c8b6"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5721), "SVOVIX1030", new Guid("8327f40e-0558-4f3a-be2a-19e46af30205"), 1, null },
                    { new Guid("af9e8d7b-6e9e-4d8f-9d8e-fa9e8d7c9b6a"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5724), "JJDIOS0800", new Guid("ed3048d4-5b1f-4be2-b1e6-d7bd533cc128"), 1, null },
                    { new Guid("bf8d9e6c-7e9f-4e8f-9d8e-fa9b8e7d9c8b"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5726), "BSBFOR1245", new Guid("befe1bd9-11a6-42da-8f63-6ec4d06a5c6d"), 1, null },
                    { new Guid("cf7e8d5c-8e9f-4e8d-9d8e-fa9b8e7d9c8a"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5729), "RBTAB1610", new Guid("88e97083-8def-48c6-b192-f7b152b835c7"), 1, null },
                    { new Guid("df6e8d4c-9e9e-4e7d-8d9e-fb9b8e7d9c8a"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5731), "SVORDN1215", new Guid("5af14441-ea5c-44aa-a903-212e407283bd"), 1, null },
                    { new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5734), "CNFVIX1645", new Guid("6711aae2-1de5-49c3-9e9c-9ce14c4dbaf2"), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "Column", "CreatedAt", "FlightClassId", "FlightId", "Price", "Row", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("14aa0f40-e437-4480-b83b-62ac7272ce3e"), true, "1", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5790), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "A", null },
                    { new Guid("1f7762bc-6705-4da1-b6cf-5d590198268a"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5836), 1, new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5"), 4500.50m, "B", null },
                    { new Guid("29e524ff-2eba-4f1c-8914-1cc0f57e212a"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5832), 2, new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5"), 1500.25m, "C", null },
                    { new Guid("2e7ed05f-d3b2-4613-8f25-0ce788879bc3"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5811), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "C", null },
                    { new Guid("36020bf8-4c20-4b6d-a64c-345efa7ab1cb"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5817), 1, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 5200.50m, "A", null },
                    { new Guid("39dba4b3-37d7-4690-b1b5-a9b1a2cefc37"), true, "20", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5839), 1, new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d"), 4200.50m, "A", null },
                    { new Guid("4e583900-4556-4cab-a799-dc7cf6c42f7b"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5886), 1, new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), 4500.75m, "B", null },
                    { new Guid("6ea80293-26e4-4ff6-96fa-87eb412a2dc2"), true, "1", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5794), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "B", null },
                    { new Guid("711104fb-0a1e-4ffc-99f4-b7678ffdd908"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5853), 1, new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d"), 5300.75m, "B", null },
                    { new Guid("7b10187c-16f1-4983-9a8f-31cfb637fd24"), true, "3", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5892), 2, new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), 4100.25m, "A", null },
                    { new Guid("87662bde-aa85-441f-9150-b9115c7d650d"), true, "20", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5877), 1, new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), 2800.50m, "B", null },
                    { new Guid("99de9812-e0a5-4b97-b959-89999b86a129"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5880), 2, new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), 1300.25m, "C", null },
                    { new Guid("9ba41d07-6b0d-40b4-8e5b-3b2e15853147"), true, "20", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5889), 1, new Guid("ef5e8d3c-8e9f-4d7d-8d9e-fb9b8e7d9c8a"), 2200.50m, "A", null },
                    { new Guid("a6769afd-66df-44f4-a5c9-5e771403be8b"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5842), 2, new Guid("3d6f8437-4f82-4096-bf1d-fcdd16e68b8d"), 1800.25m, "A", null },
                    { new Guid("ac9e6c2c-c5a7-433a-ae09-2211c0827e97"), true, "1", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5801), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "C", null },
                    { new Guid("acc65ea5-9498-4600-a6a1-82017fa3995c"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5814), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "B", null },
                    { new Guid("ad52bdb3-49cf-4b09-89bf-2c56957f39f5"), true, "20", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5823), 1, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 5200.50m, "A", null },
                    { new Guid("c13ac68e-1b85-45da-9b45-c80fc1a5cb29"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5820), 1, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 5200.50m, "B", null },
                    { new Guid("c55f6743-433f-4a76-b941-9d9e5a4e42fa"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5807), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "B", null },
                    { new Guid("eb55d44b-bc5f-4b29-9231-46264af27796"), true, "2", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5804), 2, new Guid("60ca7a4d-e64c-4145-adee-e5e0abd94d2e"), 1200.25m, "A", null },
                    { new Guid("f87dbbab-8d6f-48d7-b584-19d2eb1c7633"), true, "10", new DateTime(2024, 5, 18, 18, 17, 50, 456, DateTimeKind.Local).AddTicks(5829), 1, new Guid("2b4a6e27-43fa-4d9a-920e-9b9c752d1ab5"), 3000.75m, "A", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressId",
                table: "Customer",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CareerId",
                table: "Customer",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PhoneId",
                table: "Customer",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserId",
                table: "Customer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FlightCode",
                table: "Flights",
                column: "FlightCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_flightintineraryId",
                table: "Flights",
                column: "flightintineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Intinerary_ArriveIATAID",
                table: "Intinerary",
                column: "ArriveIATAID");

            migrationBuilder.CreateIndex(
                name: "IX_Intinerary_LeaveIATAId",
                table: "Intinerary",
                column: "LeaveIATAId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_FlightId",
                table: "Seats",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Intinerary");

            migrationBuilder.DropTable(
                name: "Iata");
        }
    }
}
