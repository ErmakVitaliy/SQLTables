using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SQLTables.Migrations
{
    /// <inheritdoc />
    public partial class _initialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name_author = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.author_id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    city_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name_city = table.Column<string>(type: "TEXT", nullable: true),
                    days_delivery = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.city_id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    genre_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name_genre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.genre_id);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameStep = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name_client = table.Column<string>(type: "TEXT", nullable: true),
                    city_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.client_id);
                    table.ForeignKey(
                        name: "FK_Clients_Cities_city_id",
                        column: x => x.city_id,
                        principalTable: "Cities",
                        principalColumn: "city_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    author_id = table.Column<int>(type: "INTEGER", nullable: false),
                    genre_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.book_id);
                    table.ForeignKey(
                        name: "FK_Books_Author_author_id",
                        column: x => x.author_id,
                        principalTable: "Author",
                        principalColumn: "author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_genre_id",
                        column: x => x.genre_id,
                        principalTable: "Genres",
                        principalColumn: "genre_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    buy_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    buy_description = table.Column<string>(type: "TEXT", nullable: true),
                    client_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => x.buy_id);
                    table.ForeignKey(
                        name: "FK_Buys_Clients_client_id",
                        column: x => x.client_id,
                        principalTable: "Clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuyBooks",
                columns: table => new
                {
                    buy_book_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    buy_id = table.Column<int>(type: "INTEGER", nullable: false),
                    book_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyBooks", x => x.buy_book_id);
                    table.ForeignKey(
                        name: "FK_BuyBooks_Books_book_id",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyBooks_Buys_buy_id",
                        column: x => x.buy_id,
                        principalTable: "Buys",
                        principalColumn: "buy_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuySteps",
                columns: table => new
                {
                    buy_step_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    buy_id = table.Column<int>(type: "INTEGER", nullable: false),
                    step_id = table.Column<int>(type: "INTEGER", nullable: false),
                    date_step_beg = table.Column<DateTime>(type: "TEXT", nullable: true),
                    date_step_end = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuySteps", x => x.buy_step_id);
                    table.ForeignKey(
                        name: "FK_BuySteps_Buys_buy_id",
                        column: x => x.buy_id,
                        principalTable: "Buys",
                        principalColumn: "buy_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuySteps_Steps_step_id",
                        column: x => x.step_id,
                        principalTable: "Steps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "author_id", "name_author" },
                values: new object[,]
                {
                    { 1, "Булгаков М.А." },
                    { 2, "Достоевский Ф.М." },
                    { 3, "Есенин С.А" },
                    { 4, "Пастернак Б.Л" },
                    { 5, "Лермонтов М.Ю." }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "city_id", "days_delivery", "name_city" },
                values: new object[,]
                {
                    { 1, 5, "Москва" },
                    { 2, 3, "Санкт-Петербург" },
                    { 3, 12, "Владивосток" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "genre_id", "name_genre" },
                values: new object[,]
                {
                    { 1, "Роман" },
                    { 2, "Поэзия" },
                    { 3, "Приключения" }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "NameStep" },
                values: new object[,]
                {
                    { 1, "Оплата" },
                    { 2, "Упаковка" },
                    { 3, "Транспортировка" },
                    { 4, "Доставка" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "book_id", "Amount", "author_id", "genre_id", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 3, 1, 1, 670.99m, "Мастер и Маргарита" },
                    { 2, 5, 1, 1, 540.50m, "Белая гвардия" },
                    { 3, 10, 2, 1, 460.00m, "Идиот" },
                    { 4, 2, 2, 1, 799.01m, "Братья Карамазовы" },
                    { 5, 10, 2, 1, 480.50m, "Игрок" },
                    { 6, 15, 3, 2, 650.00m, "Стихотворения и поэмы" },
                    { 7, 6, 3, 2, 570.20m, "Черный человек" },
                    { 8, 2, 4, 2, 518.99m, "Лирика" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "city_id", "Email", "name_client" },
                values: new object[,]
                {
                    { 1, 3, "baranov@test", "Баранов Павел" },
                    { 2, 1, "abramova@test", "Абрамова Катя" },
                    { 3, 2, "semenov@test", "Семенонов Иван" },
                    { 4, 1, "yakovleva@test", "Яковлева Галина" }
                });

            migrationBuilder.InsertData(
                table: "Buys",
                columns: new[] { "buy_id", "client_id", "buy_description" },
                values: new object[,]
                {
                    { 1, 1, "Доставка только вечером" },
                    { 2, 3, "" },
                    { 3, 2, "Упаковать каждую книгу по отдельности" },
                    { 4, 1, "" }
                });

            migrationBuilder.InsertData(
                table: "BuyBooks",
                columns: new[] { "buy_book_id", "Amount", "book_id", "buy_id" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 7, 1 },
                    { 3, 1, 3, 1 },
                    { 4, 2, 8, 2 },
                    { 5, 2, 3, 3 },
                    { 6, 1, 2, 3 },
                    { 7, 1, 1, 3 },
                    { 8, 1, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "BuySteps",
                columns: new[] { "buy_step_id", "buy_id", "date_step_beg", "date_step_end", "step_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 1, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 1, new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, 2, new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 2, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 2, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 8, 2, null, null, 4 },
                    { 9, 3, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 3, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 3, new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 3, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 13, 4, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 14, 4, null, null, 2 },
                    { 15, 4, null, null, 3 },
                    { 16, 4, null, null, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_author_id",
                table: "Books",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_genre_id",
                table: "Books",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "IX_BuyBooks_book_id",
                table: "BuyBooks",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_BuyBooks_buy_id",
                table: "BuyBooks",
                column: "buy_id");

            migrationBuilder.CreateIndex(
                name: "IX_Buys_client_id",
                table: "Buys",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_BuySteps_buy_id",
                table: "BuySteps",
                column: "buy_id");

            migrationBuilder.CreateIndex(
                name: "IX_BuySteps_step_id",
                table: "BuySteps",
                column: "step_id",
                unique: false);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_city_id",
                table: "Clients",
                column: "city_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyBooks");

            migrationBuilder.DropTable(
                name: "BuySteps");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Buys");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
