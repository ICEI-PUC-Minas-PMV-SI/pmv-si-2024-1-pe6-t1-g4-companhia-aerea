using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    InitialDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    PromotionalCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OfferId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PaymentCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TypePayment = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
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
                    AddressId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CareerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    NationalityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PhoneId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Complement", "Country", "CreatedAt", "Neighborhood", "Number", "State", "Street", "UpdateAt", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), "Belo Horizonte", "Casa", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7165), "Esmelo", "0", "MG", "Rua dos Bobos", null, "31615-520" },
                    { new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), "Rio de Janeiro", "Casa 2", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7177), "Tijuca", "123", "RJ", "Rua Conde de Bonfim", null, "20540-060" },
                    { new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), "Brasília", "Apartamento", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7171), "Asa Sul", "S/N", "DF", "Quadra 300", null, "70000-000" },
                    { new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), "Belo Horizonte", "Sala 301", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7180), "Centro", "250", "MG", "Avenida Afonso Pena", null, "30140-061" },
                    { new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), "São Paulo", "Bloco B", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7174), "Vila Mariana", "1000", "SP", "Avenida Paulista", null, "04101-000" },
                    { new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), "Piracicaba", "Loja", "Brasil", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7183), "Centro", "789", "SP", "Rua do Rosário", null, "13400-000" }
                });

            migrationBuilder.InsertData(
                table: "Career",
                columns: new[] { "Id", "AverageWage", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), 6000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7228), "Designer Gráfico", "", null },
                    { new Guid("2fc86ba3-6479-454a-9bc7-9e8ec1b78492"), 2800.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7277), "Auxiliar Administrativo", "", null },
                    { new Guid("30254dd1-bd95-4e12-9e7c-5bdc40aa61b1"), 9500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7222), "Advogado", "", null },
                    { new Guid("46e17017-2f85-4968-80b6-4ff1c0fc2db7"), 9500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7215), "Engenheiro Civil", "", null },
                    { new Guid("4b42eeed-b9c4-43e2-8151-eb18df5f1e2b"), 7000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7254), "Analista de Marketing", "", null },
                    { new Guid("506cb080-4a8b-42a3-9f34-bde6e1a40e9b"), 6000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7232), "Chef de Cozinha", "", null },
                    { new Guid("5af956fc-1bb9-44d0-9ee1-6435ff7e5de2"), 8500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7248), "Dentista", "", null },
                    { new Guid("61ad6489-fb49-4782-8c4b-ef9b7fb5b4c7"), 8500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7234), "Engenheiro de Software", "", null },
                    { new Guid("6371818f-7e95-4c65-a67f-19b74f87f47e"), 8000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7244), "Arquiteto", "", null },
                    { new Guid("671892c6-002f-4a48-9913-3b10e20697d3"), 3000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7281), "Recepcionista", "", null },
                    { new Guid("79295cb4-f755-4575-8049-f13e74cb19f4"), 7800.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7246), "Analista de Sistemas", "", null },
                    { new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), 18000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7218), "Médico Cirurgião", "", null },
                    { new Guid("82301e43-8ec9-4e7f-8a5a-3c9bc2a1a660"), 5500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7224), "Enfermeiro", "", null },
                    { new Guid("8b3e12cf-8a0b-4d96-8a29-7614bf18d2bc"), 5000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7252), "Fotógrafo", "", null },
                    { new Guid("8e088726-ae8b-4211-8c19-cb20f97a0948"), 12000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7242), "Piloto de Avião", "", null },
                    { new Guid("94edfb10-7361-4708-924f-50b3b3ff17d6"), 2000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7285), "Auxiliar de Limpeza", "", null },
                    { new Guid("a76f70c6-6c2d-4d09-b9a0-7dc7f21ef16d"), 1800.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7286), "Ajudante de Cozinha", "", null },
                    { new Guid("a882f777-00a3-4b98-92e8-625ca8d444c0"), 7500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7230), "Farmacêutico", "", null },
                    { new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), 7000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7237), "Psicólogo Clínico", "", null },
                    { new Guid("c55e8fb0-df1f-43e8-8e07-f81a4463d0a4"), 8000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7250), "Contador", "", null },
                    { new Guid("d60ed8ae-6d30-4c2a-b946-6c751a18b871"), 2500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7279), "Atendente de Telemarketing", "", null },
                    { new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), 7650.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7213), "Desenvolvedor de Software", "", null },
                    { new Guid("ebbe4f7a-f025-4db4-8b52-ae0a0e3d09f7"), 8500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7226), "Analista Financeiro", "", null },
                    { new Guid("f22844bb-7601-439d-b6f0-d6cc1d510e0e"), 8500.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7220), "Professor Universitário", "", null },
                    { new Guid("fd484e11-26b4-4e54-9f1e-66e3e529180d"), 9000.0, new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7239), "Engenheiro Mecânico", "", null }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "CreatedAt", "Description", "Note", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0a3a3f5f-bf97-4a64-bd07-1b45468de336"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7330), "Inglesa", "", null },
                    { new Guid("0e61a8b8-0a65-4e3e-9203-dbe526054bb4"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7350), "Indiana", "", null },
                    { new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7325), "Argentina", "", null },
                    { new Guid("334f5a76-3b27-45f0-8371-75f36a7381c2"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7332), "Francesa", "", null },
                    { new Guid("5f5e0a2c-4201-4a2e-80e5-85d1ee8cf077"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7328), "Chilena", "", null },
                    { new Guid("66d38f80-5b2c-409e-b4f6-68b017af22db"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7319), "Americana", "", null },
                    { new Guid("7ff9a21e-3ff2-4ef0-aac1-1181a6ff7a78"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7343), "Norueguesa", "", null },
                    { new Guid("96e01522-d4b5-4d07-bfe6-f4c6151b2f33"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7337), "Espanhola", "", null },
                    { new Guid("a5658e1d-61ff-4e48-9a38-95bfb631e7a1"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7348), "Russa", "", null },
                    { new Guid("ae7c6886-4a8c-4878-8ff6-5755046a93d8"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7321), "Canadense", "", null },
                    { new Guid("bb179145-250f-4260-80e0-232e5743ec7b"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7352), "Coreana", "", null },
                    { new Guid("bd609feb-4d8e-4384-bcd1-7641fb4b3e1a"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7344), "Japonesa", "", null },
                    { new Guid("c301e7a7-d90e-47e3-b241-3fdad89d0b79"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7341), "Sueca", "", null },
                    { new Guid("ca7ae9c3-62f3-4a05-b7ac-0c6e3f29b10e"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7336), "Alemã", "", null },
                    { new Guid("cd1b540e-119a-4417-bf69-6fd4f8a558c1"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7353), "Australiana", "", null },
                    { new Guid("d8f23df8-d9f6-4696-9b0b-1613c1e4ef63"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7333), "Italiana", "", null },
                    { new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7316), "Brasileira", "", null },
                    { new Guid("ec91c3d3-fb1c-44d1-a01e-af4bb1a4f3f5"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7346), "Chinesa", "", null },
                    { new Guid("f700bd3b-1256-4f55-a682-d1e7c10f59a1"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7323), "Mexicana", "", null },
                    { new Guid("f920c11e-f6f7-42a3-b3bc-83701241c781"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7339), "Portuguesa", "", null }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CountryCode", "CreatedAt", "DDD", "Number", "TypePhone", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7460), "61", "8765-4321", 3, null },
                    { new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7450), "11", "3123-4567", 2, null },
                    { new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7452), "21", "98765-4321", 3, null },
                    { new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7458), "51", "3030-2020", 2, null },
                    { new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7456), "41", "99988-7766", 1, null },
                    { new Guid("f56171aa-4179-4668-9618-ca1676679449"), "55", new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7447), "31", "9 9944-2621", 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DateBirth", "Email", "FirstName", "LastName", "Password", "Status", "TypeUser", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new DateTime(2024, 4, 21, 18, 0, 30, 286, DateTimeKind.Utc).AddTicks(2497), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@email.com", "User Adm", "Adm Master", "$2a$11$8hMld80gzntYV.DCuFARHOHN0oJzmjgY95YUOBQmoASrucBNtaGRG", 1, 1, null },
                    { new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"), new DateTime(2024, 4, 21, 18, 0, 30, 518, DateTimeKind.Utc).AddTicks(1668), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@email.com", "User Regular", "Last Regular", "$2a$11$DBTRgjtQP9ooBQOROCE6ROaNCqstPV6UBuaUg4FDeWT/FeEHXTvF2", 1, 2, null },
                    { new Guid("7fc20e97-a58d-4c92-b2c2-a41eedd931e1"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(6665), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose@email.com", "Jose", "Pereira", "$2a$11$3xaLae8UHUvgd0l2SL7jy.zawj9f6Ypw1V9VjMbO3Au4THvu.GMnu", 1, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "AddressId", "CareerId", "CreatedAt", "DateBirth", "Document", "Email", "FirstName", "LastName", "NationalityId", "PhoneId", "StatusId", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("039cd0f7-1506-4daf-9648-be0fa40434fb"), new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"), null, new DateTime(2024, 4, 21, 18, 10, 30, 767, DateTimeKind.Utc).AddTicks(7549), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "543.609.281-49", "customer03@email.com", "Customer 03 do Adm ", "Last Name Customer 03", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("0c0e881c-61cf-4d12-8788-94e118d22177"), new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 4, 21, 21, 0, 30, 767, DateTimeKind.Utc).AddTicks(7594), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "367.195.482-34", "customer03r@email.com", "Customer 03 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"), new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"), new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"), new DateTime(2024, 4, 21, 18, 0, 30, 767, DateTimeKind.Utc).AddTicks(7518), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "116.987.659-96", "customer01@email.com", "Customer 01 do Adm ", "Last Name Customer 01", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("f56171aa-4179-4668-9618-ca1676679449"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("7c259bf1-ee8b-4d1d-949e-b4a3aca134c4"), new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"), new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"), new DateTime(2024, 4, 21, 20, 0, 30, 767, DateTimeKind.Utc).AddTicks(7533), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "189.847.392-05", "customer02@email.com", "Customer 02 do Adm ", "Last Name Customer 02", new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"), new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"), 1, null, new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8") },
                    { new Guid("f3b171ea-047a-4e9d-a282-4115a76f419f"), new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"), new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"), new DateTime(2024, 4, 21, 19, 0, 30, 767, DateTimeKind.Utc).AddTicks(7573), new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "786.123.549-02", "customer01r@email.com", "Customer 01 do regular 01 ", "Last Name Customer 01R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") },
                    { new Guid("fdf6777d-f6d3-4c54-96c3-4c498aa0903b"), new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"), new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"), new DateTime(2024, 4, 21, 21, 0, 30, 767, DateTimeKind.Utc).AddTicks(7584), new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "952.746.830-61", "customer02r@email.com", "Customer 02 do regular 01 ", "Last Name Customer 02R", new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"), new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"), 1, null, new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041") }
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
                name: "Offer");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
