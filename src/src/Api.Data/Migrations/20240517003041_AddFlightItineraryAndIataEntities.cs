using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddFlightItineraryAndIataEntities : Migration
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
                    FlightItineraryId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iata", x => x.Id);
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
                    LeaveDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    ArriveDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    leaveiataid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    arriveiataid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intinerary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intinerary_Iata_arriveiataid",
                        column: x => x.arriveiataid,
                        principalTable: "Iata",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Intinerary_Iata_leaveiataid",
                        column: x => x.leaveiataid,
                        principalTable: "Iata",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Complement", "Country", "CreatedAt", "Neighborhood", "Number", "State", "Street", "UpdateAt", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), "Belo Horizonte", "Casa", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2488), "Esmelo", "0", "MG", "Rua dos Bobos", null, "31615-520" },
                    { new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), "Rio de Janeiro", "Casa 2", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2499), "Tijuca", "123", "RJ", "Rua Conde de Bonfim", null, "20540-060" },
                    { new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), "Brasília", "Apartamento", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2491), "Asa Sul", "S/N", "DF", "Quadra 300", null, "70000-000" },
                    { new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), "Belo Horizonte", "Sala 301", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2502), "Centro", "250", "MG", "Avenida Afonso Pena", null, "30140-061" },
                    { new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), "São Paulo", "Bloco B", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2497), "Vila Mariana", "1000", "SP", "Avenida Paulista", null, "04101-000" },
                    { new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), "Piracicaba", "Loja", "Brasil", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2505), "Centro", "789", "SP", "Rua do Rosário", null, "13400-000" }
                });

            migrationBuilder.InsertData(
                table: "Career",
                columns: new[] { "Id", "AverageWage", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), 6000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2667), "Designer Gráfico", "", null },
                    { new Guid("2fc86ba3-6479-454a-9bc7-9e8ec1b78492"), 2800.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2692), "Auxiliar Administrativo", "", null },
                    { new Guid("30254dd1-bd95-4e12-9e7c-5bdc40aa61b1"), 9500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2550), "Advogado", "", null },
                    { new Guid("46e17017-2f85-4968-80b6-4ff1c0fc2db7"), 9500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2544), "Engenheiro Civil", "", null },
                    { new Guid("4b42eeed-b9c4-43e2-8151-eb18df5f1e2b"), 7000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2690), "Analista de Marketing", "", null },
                    { new Guid("506cb080-4a8b-42a3-9f34-bde6e1a40e9b"), 6000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2670), "Chef de Cozinha", "", null },
                    { new Guid("5af956fc-1bb9-44d0-9ee1-6435ff7e5de2"), 8500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2685), "Dentista", "", null },
                    { new Guid("61ad6489-fb49-4782-8c4b-ef9b7fb5b4c7"), 8500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2672), "Engenheiro de Software", "", null },
                    { new Guid("6371818f-7e95-4c65-a67f-19b74f87f47e"), 8000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2682), "Arquiteto", "", null },
                    { new Guid("671892c6-002f-4a48-9913-3b10e20697d3"), 3000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2695), "Recepcionista", "", null },
                    { new Guid("79295cb4-f755-4575-8049-f13e74cb19f4"), 7800.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2683), "Analista de Sistemas", "", null },
                    { new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), 18000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2546), "Médico Cirurgião", "", null },
                    { new Guid("82301e43-8ec9-4e7f-8a5a-3c9bc2a1a660"), 5500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2552), "Enfermeiro", "", null },
                    { new Guid("8b3e12cf-8a0b-4d96-8a29-7614bf18d2bc"), 5000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2688), "Fotógrafo", "", null },
                    { new Guid("8e088726-ae8b-4211-8c19-cb20f97a0948"), 12000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2680), "Piloto de Avião", "", null },
                    { new Guid("94edfb10-7361-4708-924f-50b3b3ff17d6"), 2000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2696), "Auxiliar de Limpeza", "", null },
                    { new Guid("a76f70c6-6c2d-4d09-b9a0-7dc7f21ef16d"), 1800.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2699), "Ajudante de Cozinha", "", null },
                    { new Guid("a882f777-00a3-4b98-92e8-625ca8d444c0"), 7500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2669), "Farmacêutico", "", null },
                    { new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), 7000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2675), "Psicólogo Clínico", "", null },
                    { new Guid("c55e8fb0-df1f-43e8-8e07-f81a4463d0a4"), 8000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2687), "Contador", "", null },
                    { new Guid("d60ed8ae-6d30-4c2a-b946-6c751a18b871"), 2500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2693), "Atendente de Telemarketing", "", null },
                    { new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), 7650.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2541), "Desenvolvedor de Software", "", null },
                    { new Guid("ebbe4f7a-f025-4db4-8b52-ae0a0e3d09f7"), 8500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2554), "Analista Financeiro", "", null },
                    { new Guid("f22844bb-7601-439d-b6f0-d6cc1d510e0e"), 8500.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2548), "Professor Universitário", "", null },
                    { new Guid("fd484e11-26b4-4e54-9f1e-66e3e529180d"), 9000.0, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2677), "Engenheiro Mecânico", "", null }
                });

            migrationBuilder.InsertData(
                table: "Iata",
                columns: new[] { "Id", "Airport", "Available", "CreatedAt", "FlightItineraryId", "IATACode", "Location", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0f31f0df-a89d-4df5-a7d0-b62e4a633043"), "Aeroporto Lauro Kortz", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3216), null, "PFB", "Passo Fundo", null },
                    { new Guid("1561fee0-fd49-4bd8-bb5a-ab923d63b29a"), "Aeroporto de Congonhas", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3234), null, "CGH", "São Paulo", null },
                    { new Guid("1c380a61-bc40-409c-a050-dbb0d8d8c2ee"), "Aeroporto de Londrina", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3189), null, "LDB", "Londrina", null },
                    { new Guid("33e02c8e-253d-4f4f-b73c-18da45ca0817"), "Aeroporto de Campina Grande", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3169), null, "CPV", "Campina Grande", null },
                    { new Guid("35444197-16d7-471c-8695-d91753d44d77"), "Aeroporto Internacional de Viracopos", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3235), null, "VCP", "Campinas", null },
                    { new Guid("39eb8e1a-be3c-462f-8dcc-9f5a079381c0"), "Aeroporto de Petrolina", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3196), null, "PNZ", "Petrolina", null },
                    { new Guid("3fbeaba7-c3b3-4d2b-8b1b-9b05dfeaa4c5"), "Aeroporto Santos Dumont", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3202), null, "SDU", "Rio de Janeiro", null },
                    { new Guid("4178772e-1940-42cc-8d05-cab1a472c7f3"), "Aeroporto Internacional de Belém", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3161), null, "BEL", "Belém", null },
                    { new Guid("45fd78b8-d1fd-4dea-8769-85e995a79bda"), "Aeroporto Brigadeiro Lysias Rodrigues", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3241), null, "PMW", "Palmas", null },
                    { new Guid("4e2c18f0-3eb7-424e-a5ff-18f878d5543d"), "Aeroporto Internacional dos Guararapes", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3194), null, "REC", "Recife", null },
                    { new Guid("549c8ed9-bfba-4705-996c-b368c1fa47e9"), "Aeroporto Internacional Afonso Pena", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3170), null, "CWB", "Curitiba", null },
                    { new Guid("558d56a8-92aa-4a20-986f-30154245358f"), "Aeroporto Internacional Governador Jorge Teixeira de Oliveira", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3218), null, "PVH", "Porto Velho", null },
                    { new Guid("5b4ac581-4947-469c-a72a-62a4c9d38034"), "Aeroporto Internacional de Aracaju", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3239), null, "AJU", "Aracaju", null },
                    { new Guid("6a76a905-cd07-4f99-a0ef-8af2e6e99d23"), "Aeroporto de Araguaína", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3243), null, "AUX", "Araguaína", null },
                    { new Guid("6b3e4a9d-8a1c-4c3d-8d2e-b4a6f7e8c9d1"), "Aeroporto Internacional de Rio Branco", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3079), null, "RBR", "Rio Branco", null },
                    { new Guid("6ecf260f-d927-42ec-a624-df681b3c45fb"), "Aeroporto Internacional de Foz do Iguaçu", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3192), null, "IGU", "Foz do Iguaçu", null },
                    { new Guid("706d3702-8fd3-4de7-8610-89c0244a5e68"), "Aeroporto Internacional Salgado Filho", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3212), null, "POA", "Porto Alegre", null },
                    { new Guid("71b1e0d3-5214-462d-96ba-b87f7f624dc1"), "Aeroporto Internacional Atlas Brasil Cantanhede", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3226), null, "BVB", "Boa Vista", null },
                    { new Guid("759f3a80-d441-4b75-b590-5418f96f80ca"), "Aeroporto José Coleto", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3219), null, "JPR", "Ji-Paraná", null },
                    { new Guid("75d5984e-734e-4d42-bb94-70035333aaa8"), "Aeroporto de Cabo Frio", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3206), null, "CFB", "Cabo Frio", null },
                    { new Guid("7c5846cf-4797-41ea-86ef-7ccb7564d365"), "Aeroporto Lauro Carneiro de Loyola", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3231), null, "JOI", "Joinville", null },
                    { new Guid("852bccc0-c1ea-4d61-a01d-1a2cb92b2e78"), "Aeroporto Internacional de Navegantes", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3229), null, "NVT", "Navegantes", null },
                    { new Guid("8d45c3c4-3c1e-4b3f-8d9e-c8a7d6f7b8a1"), "Aeroporto Internacional de Cruzeiro do Sul", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3033), null, "CZS", "Cruzeiro do Sul", null },
                    { new Guid("8df9948b-d1b9-4e31-8777-de92415e0dab"), "Aeroporto Internacional Hercílio Luz", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3227), null, "FLN", "Florianópolis", null },
                    { new Guid("966963e4-dc10-4576-a9e7-7e178943febc"), "Aeroporto Senador Petrônio Portella", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3197), null, "THE", "Teresina", null },
                    { new Guid("99a7b440-6cc4-4d63-b094-490f5867892a"), "Aeroporto Internacional do Galeão", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3200), null, "GIG", "Rio de Janeiro", null },
                    { new Guid("a2c7d9e6-8b4a-4d1c-8a5e-b6c7f8e9d4b5"), "Aeroporto Internacional Eduardo Gomes", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3088), null, "MAO", "Manaus", null },
                    { new Guid("a8d7c6e5-3b4a-4d9b-8e1c-c5a7f8b6d3e1"), "Aeroporto Nelson Ribeiro Guimarães", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3112), null, "CLV", "Caldas Novas", null },
                    { new Guid("a8d7c9e6-3b4a-4d1c-8e5e-c5a7f8b6d3e4"), "Aeroporto de Uberlândia", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3133), null, "UDI", "Uberlândia", null },
                    { new Guid("a8d7f9e6-3b4a-4d1c-8e9e-c5a7f8d6c3b4"), "Aeroporto Internacional de Rondonópolis", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3124), null, "ROO", "Rondonópolis", null },
                    { new Guid("a96e7a82-f70a-4f92-a317-96bf339c32f9"), "Aeroporto de Marabá", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3165), null, "MAB", "Marabá", null },
                    { new Guid("b4d3c9e6-8a3e-4d1b-8e5c-c6a7f8d9b3e2"), "Aeroporto Prefeito Renato Moreira", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3118), null, "IMP", "Imperatriz", null },
                    { new Guid("b4d3f9e6-8a4e-4d1b-8e5c-c6a7f8b3d9e2"), "Aeroporto Francisco de Matos Pereira", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3128), null, "DOU", "Dourados", null },
                    { new Guid("b4d9e6c8-7a3e-4d2b-9c1d-d5a7f8b6c3e1"), "Aeroporto Regional de Jericoacoara", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3103), null, "JJD", "Jericoacoara", null },
                    { new Guid("b9f5a4d8-7c3e-4d9b-8a1d-c6a7f8e9b4c3"), "Aeroporto Internacional Zumbi dos Palmares", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3083), null, "MCZ", "Maceió", null },
                    { new Guid("ba8f4871-33aa-4889-9c52-9a813a5f1b1e"), "Aeroporto Internacional de Guarulhos", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3232), null, "GRU", "São Paulo", null },
                    { new Guid("bb29986d-b495-4b9b-ba03-bec26d6d2977"), "Aeroporto de Vilhena", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3223), null, "BVH", "Vilhena", null },
                    { new Guid("c5d6e7f9-4a3c-4b2d-8a1c-d7b8f9e5c4a2"), "Aeroporto Internacional de Tabatinga", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3090), null, "TBT", "Tabatinga", null },
                    { new Guid("c6a7d5b8-8b4e-4a1d-8c9e-b7a8f6e9c3d4"), "Aeroporto Regional do Cariri", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3105), null, "QXQ", "Juazeiro do Norte", null },
                    { new Guid("c6a7d9e8-7e3b-4d1b-9e8c-d5a7f6c9b4e1"), "Aeroporto Internacional de Campo Grande", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3125), null, "CGR", "Campo Grande", null },
                    { new Guid("c6a7f9b8-7e3d-4a1b-9c8e-d5a7f6e9b4d3"), "Aeroporto Internacional Marechal Cunha Machado", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3115), null, "SLZ", "São Luís", null },
                    { new Guid("d136ceb0-ec31-4e54-86c2-5a9030150dd3"), "Aeroporto Regional Hugo Cantergiani", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3214), null, "CXJ", "Caxias do Sul", null },
                    { new Guid("d1c39dd1-09ef-4e8e-9590-ffccd2089bb7"), "Aeroporto Internacional Presidente Castro Pinto", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3166), null, "JPA", "João Pessoa", null },
                    { new Guid("d4b3c9a6-7e4a-4d1b-8c5e-b7a8f9e6c3d4"), "Aeroporto Eurico de Aguiar Salles", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3108), null, "VIX", "Vitória", null },
                    { new Guid("d4b5c3e7-6a2d-4b9e-8c1d-b6a7f9e8c3d1"), "Aeroporto Jorge Amado", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3095), null, "IOS", "Ilhéus", null },
                    { new Guid("d5b3c6a7-8b4e-4a1b-8c9e-c7a8f6e9b4d2"), "Aeroporto Municipal de Sinop", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3122), null, "OPS", "Sinop", null },
                    { new Guid("d5b3e6c7-8a4e-4a1b-8c9e-c7a8f6e5b9d2"), "Aeroporto da Pampulha", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3132), null, "PLU", "Belo Horizonte", null },
                    { new Guid("d8b9c7e4-3a2d-4d1c-8b5e-a6c7f8e5b9d2"), "Aeroporto Internacional Pinto Martins", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3101), null, "FOR", "Fortaleza", null },
                    { new Guid("df1cfd5d-8102-438b-842a-84d4b5c3be5a"), "Aeroporto Regional de Mossoró", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3210), null, "MII", "Mossoró", null },
                    { new Guid("e2a3d4c5-8b4a-4d2b-8e1c-c5a7f6d9b3e6"), "Aeroporto Pedro Otacílio Figueiredo", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3096), null, "VDC", "Vitória da Conquista", null },
                    { new Guid("e3d5c7f8-4a2d-4c1b-9d8e-c5a7f6e8b3d2"), "Aeroporto Internacional de Macapá", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3085), null, "MCP", "Macapá", null },
                    { new Guid("e5b4c3a7-8b3d-4d1b-8e9e-c6a7f8e4d3c2"), "Aeroporto Santa Genoveva", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3110), null, "GYN", "Goiânia", null },
                    { new Guid("e7632821-dc68-4d1b-aca9-4a3c06472a85"), "Aeroporto Internacional Prefeito Doutor João Silva Filho", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3199), null, "PHB", "Parnaíba", null },
                    { new Guid("e7d8c9b5-3a4d-4d1c-9e8e-c5a7f6d9b3e1"), "Aeroporto Internacional de Confins", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3130), null, "CNF", "Belo Horizonte", null },
                    { new Guid("f34ce5f8-4447-4bfc-964a-2bbb44b00826"), "Aeroporto Internacional de Santarém", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3163), null, "STM", "Santarém", null },
                    { new Guid("f5dcffed-b74e-4cd1-9629-2070e1e8bc1d"), "Aeroporto de Gurupi", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3245), null, "GMP", "Gurupi", null },
                    { new Guid("f6b8e7c9-3a4d-4d1b-9c8e-c5a7f6e3b2d1"), "Aeroporto Internacional Presidente Juscelino Kubitschek", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3106), null, "BSB", "Brasília", null },
                    { new Guid("f7d8c9b5-3e4d-4a1b-9c8e-c9a7f6e5b3d4"), "Aeroporto Internacional Deputado Luís Eduardo Magalhães", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3092), null, "SSA", "Salvador", null },
                    { new Guid("f7d8e9c5-3a4b-4d1c-9e8e-b6a7f9e6d3c1"), "Aeroporto Internacional Marechal Rondon", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3120), null, "CGB", "Cuiabá", null },
                    { new Guid("f7d8e9c5-4a3b-4d1c-9e8e-b6a7f6d9b3c1"), "Aeroporto de Montes Claros", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3135), null, "MOC", "Montes Claros", null },
                    { new Guid("fcb34970-5948-4d77-8c7d-ee17919ce064"), "Aeroporto Internacional Governador Aluízio Alves", true, new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(3209), null, "NAT", "Natal", null }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0a3a3f5f-bf97-4a64-bd07-1b45468de336"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2744), "Inglesa", "", null },
                    { new Guid("0e61a8b8-0a65-4e3e-9203-dbe526054bb4"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2766), "Indiana", "", null },
                    { new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2741), "Argentina", "", null },
                    { new Guid("334f5a76-3b27-45f0-8371-75f36a7381c2"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2746), "Francesa", "", null },
                    { new Guid("5f5e0a2c-4201-4a2e-80e5-85d1ee8cf077"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2743), "Chilena", "", null },
                    { new Guid("66d38f80-5b2c-409e-b4f6-68b017af22db"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2734), "Americana", "", null },
                    { new Guid("7ff9a21e-3ff2-4ef0-aac1-1181a6ff7a78"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2757), "Norueguesa", "", null },
                    { new Guid("96e01522-d4b5-4d07-bfe6-f4c6151b2f33"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2751), "Espanhola", "", null },
                    { new Guid("a5658e1d-61ff-4e48-9a38-95bfb631e7a1"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2764), "Russa", "", null },
                    { new Guid("ae7c6886-4a8c-4878-8ff6-5755046a93d8"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2736), "Canadense", "", null },
                    { new Guid("bb179145-250f-4260-80e0-232e5743ec7b"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2768), "Coreana", "", null },
                    { new Guid("bd609feb-4d8e-4384-bcd1-7641fb4b3e1a"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2759), "Japonesa", "", null },
                    { new Guid("c301e7a7-d90e-47e3-b241-3fdad89d0b79"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2754), "Sueca", "", null },
                    { new Guid("ca7ae9c3-62f3-4a05-b7ac-0c6e3f29b10e"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2749), "Alemã", "", null },
                    { new Guid("cd1b540e-119a-4417-bf69-6fd4f8a558c1"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2770), "Australiana", "", null },
                    { new Guid("d8f23df8-d9f6-4696-9b0b-1613c1e4ef63"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2748), "Italiana", "", null },
                    { new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2732), "Brasileira", "", null },
                    { new Guid("ec91c3d3-fb1c-44d1-a01e-af4bb1a4f3f5"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2761), "Chinesa", "", null },
                    { new Guid("f700bd3b-1256-4f55-a682-d1e7c10f59a1"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2740), "Mexicana", "", null },
                    { new Guid("f920c11e-f6f7-42a3-b3bc-83701241c781"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2753), "Portuguesa", "", null }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CountryCode", "CreatedAt", "DDD", "Number", "TypePhone", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2815), "61", "8765-4321", 3, null },
                    { new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2807), "11", "3123-4567", 2, null },
                    { new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2810), "21", "98765-4321", 3, null },
                    { new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2814), "51", "3030-2020", 2, null },
                    { new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2812), "41", "99988-7766", 1, null },
                    { new Guid("f56171aa-4179-4668-9618-ca1676679449"), "55", new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2803), "31", "9 9944-2621", 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DateBirth", "Email", "FirstName", "LastName", "Password", "Status", "TypeUser", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new DateTime(2024, 5, 17, 0, 30, 40, 638, DateTimeKind.Utc).AddTicks(1426), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@email.com", "User Adm", "Adm Master", "$2a$11$4QtyP4E8H5cU5tYamqhe1.DLl9JShlRsHkygu9Sn8NywtUQLSfWLq", 1, 1, null },
                    { new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"), new DateTime(2024, 5, 17, 0, 30, 40, 942, DateTimeKind.Utc).AddTicks(2399), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@email.com", "User Regular", "Last Regular", "$2a$11$Iqmaq65KT6UIN6eSwJ9wuuwZap72V9VR9UpU29ya8ziEJzGEr/aXi", 1, 2, null },
                    { new Guid("7fc20e97-a58d-4c92-b2c2-a41eedd931e1"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(1956), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose@email.com", "Jose", "Pereira", "$2a$11$7Won8n0r6T.e29xTRbcFku67mQDylqbAUlgjWuwm7OXfy.E94vkN.", 1, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "AddressId", "CareerId", "CreatedAt", "DateBirth", "Document", "Email", "FirstName", "LastName", "NationalityId", "PhoneId", "StatusId", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("039cd0f7-1506-4daf-9648-be0fa40434fb"), new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), null, new DateTime(2024, 5, 17, 0, 40, 41, 222, DateTimeKind.Utc).AddTicks(2895), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "543.609.281-49", "customer03@email.com", "Customer 03 do Adm ", "Last Name Customer 03", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("0c0e881c-61cf-4d12-8788-94e118d22177"), new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 5, 17, 3, 30, 41, 222, DateTimeKind.Utc).AddTicks(3001), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "367.195.482-34", "customer03r@email.com", "Customer 03 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), new DateTime(2024, 5, 17, 0, 30, 41, 222, DateTimeKind.Utc).AddTicks(2868), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "116.987.659-96", "customer01@email.com", "Customer 01 do Adm ", "Last Name Customer 01", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("f56171aa-4179-4668-9618-ca1676679449"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("7c259bf1-ee8b-4d1d-949e-b4a3aca134c4"), new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), new DateTime(2024, 5, 17, 2, 30, 41, 222, DateTimeKind.Utc).AddTicks(2881), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "189.847.392-05", "customer02@email.com", "Customer 02 do Adm ", "Last Name Customer 02", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("f3b171ea-047a-4e9d-a282-4115a76f419f"), new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), new DateTime(2024, 5, 17, 1, 30, 41, 222, DateTimeKind.Utc).AddTicks(2979), new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "786.123.549-02", "customer01r@email.com", "Customer 01 do regular 01 ", "Last Name Customer 01R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("fdf6777d-f6d3-4c54-96c3-4c498aa0903b"), new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 5, 17, 3, 30, 41, 222, DateTimeKind.Utc).AddTicks(2989), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "952.746.830-61", "customer02r@email.com", "Customer 02 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") }
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
                name: "IX_Iata_FlightItineraryId",
                table: "Iata",
                column: "FlightItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Intinerary_arriveiataid",
                table: "Intinerary",
                column: "arriveiataid");

            migrationBuilder.CreateIndex(
                name: "IX_Intinerary_leaveiataid",
                table: "Intinerary",
                column: "leaveiataid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Iata_Intinerary_FlightItineraryId",
                table: "Iata",
                column: "FlightItineraryId",
                principalTable: "Intinerary",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iata_Intinerary_FlightItineraryId",
                table: "Iata");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Intinerary");

            migrationBuilder.DropTable(
                name: "Iata");
        }
    }
}
