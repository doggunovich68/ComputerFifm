using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerFifm.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Виды_комплектующих",
                columns: table => new
                {
                    Код_вида = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Виды_комплектующих", x => x.Код_вида);
                });

            migrationBuilder.CreateTable(
                name: "Должность",
                columns: table => new
                {
                    Код_должности = table.Column<int>(type: "INT", nullable: false),
                    Наименование_должности = table.Column<int>(type: "INT", nullable: false),
                    Оклад = table.Column<int>(type: "INT", nullable: false),
                    Обязанности = table.Column<int>(type: "INT", nullable: false),
                    Требования = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должность", x => x.Код_должности);
                });

            migrationBuilder.CreateTable(
                name: "Заказчики",
                columns: table => new
                {
                    Код_заказчика = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Телефон = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Заказчики", x => x.Код_заказчика);
                });

            migrationBuilder.CreateTable(
                name: "Услуги",
                columns: table => new
                {
                    Код_услуги = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Стоимость = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Услуги", x => x.Код_услуги);
                });

            migrationBuilder.CreateTable(
                name: "Комплектующие",
                columns: table => new
                {
                    Код_комплектующего = table.Column<int>(type: "INT", nullable: false),
                    Марка = table.Column<int>(type: "INT", nullable: false),
                    Фирма_производитель = table.Column<int>(type: "INT", nullable: false),
                    Страна_производитель = table.Column<int>(type: "INT", nullable: false),
                    Дата_выпуска = table.Column<int>(type: "INT", nullable: false),
                    Характеристики = table.Column<int>(type: "INT", nullable: false),
                    Срок_гарантии = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Цена = table.Column<int>(type: "INT", nullable: false),
                    Код_вида = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Комплектующие", x => x.Код_комплектующего);
                    table.ForeignKey(
                        name: "FK_Комплектующие_Виды_комплектующих_Код_вида",
                        column: x => x.Код_вида,
                        principalTable: "Виды_комплектующих",
                        principalColumn: "Код_вида",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудники",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Телефон = table.Column<int>(type: "INT", nullable: false),
                    Паспортные_данные = table.Column<int>(type: "INT", nullable: false),
                    Код_должности = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудники", x => x.Код_сотрудника);
                    table.ForeignKey(
                        name: "FK_Сотрудники_Должность_Код_должности",
                        column: x => x.Код_должности,
                        principalTable: "Должность",
                        principalColumn: "Код_должности",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Заказы",
                columns: table => new
                {
                    Дата_заказа = table.Column<int>(type: "INT", nullable: false),
                    Дата_исполнения = table.Column<int>(type: "INT", nullable: false),
                    Доля_предоплаты = table.Column<int>(type: "INT", nullable: false),
                    Отметка_об_оплате = table.Column<int>(type: "INT", nullable: false),
                    Отметка_об_исполнении = table.Column<int>(type: "INT", nullable: false),
                    Общая_стоимость = table.Column<int>(type: "INT", nullable: false),
                    Срок_общей_гарантии = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    Код_комплектующего = table.Column<int>(type: "INT", nullable: false),
                    Код_комплектующего_1 = table.Column<int>(type: "INT", nullable: false),
                    Код_комплектующего_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_комплектующего_3 = table.Column<int>(type: "INT", nullable: false),
                    Код_заказчика = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_1 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_3 = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Заказы_Заказчики_Код_заказчика",
                        column: x => x.Код_заказчика,
                        principalTable: "Заказчики",
                        principalColumn: "Код_заказчика",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Комплектующие_Код_комплектующего",
                        column: x => x.Код_комплектующего,
                        principalTable: "Комплектующие",
                        principalColumn: "Код_комплектующего",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Комплектующие_Код_комплектующего_1",
                        column: x => x.Код_комплектующего_1,
                        principalTable: "Комплектующие",
                        principalColumn: "Код_комплектующего",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Комплектующие_Код_комплектующего_2",
                        column: x => x.Код_комплектующего_2,
                        principalTable: "Комплектующие",
                        principalColumn: "Код_комплектующего",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Комплектующие_Код_комплектующего_3",
                        column: x => x.Код_комплектующего_3,
                        principalTable: "Комплектующие",
                        principalColumn: "Код_комплектующего",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Сотрудники_Код_сотрудника",
                        column: x => x.Код_сотрудника,
                        principalTable: "Сотрудники",
                        principalColumn: "Код_сотрудника",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Услуги_Код_услуги",
                        column: x => x.Код_услуги,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Услуги_Код_услуги_1",
                        column: x => x.Код_услуги_1,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Услуги_Код_услуги_2",
                        column: x => x.Код_услуги_2,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Заказы_Услуги_Код_услуги_3",
                        column: x => x.Код_услуги_3,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_заказчика",
                table: "Заказы",
                column: "Код_заказчика");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_комплектующего",
                table: "Заказы",
                column: "Код_комплектующего");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_комплектующего_1",
                table: "Заказы",
                column: "Код_комплектующего_1");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_комплектующего_2",
                table: "Заказы",
                column: "Код_комплектующего_2");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_комплектующего_3",
                table: "Заказы",
                column: "Код_комплектующего_3");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_сотрудника",
                table: "Заказы",
                column: "Код_сотрудника");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_услуги",
                table: "Заказы",
                column: "Код_услуги");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_услуги_1",
                table: "Заказы",
                column: "Код_услуги_1");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_услуги_2",
                table: "Заказы",
                column: "Код_услуги_2");

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_услуги_3",
                table: "Заказы",
                column: "Код_услуги_3");

            migrationBuilder.CreateIndex(
                name: "IX_Комплектующие_Код_вида",
                table: "Комплектующие",
                column: "Код_вида");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Код_должности",
                table: "Сотрудники",
                column: "Код_должности");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Паспортные_данные",
                table: "Сотрудники",
                column: "Паспортные_данные",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Заказы");

            migrationBuilder.DropTable(
                name: "Заказчики");

            migrationBuilder.DropTable(
                name: "Комплектующие");

            migrationBuilder.DropTable(
                name: "Сотрудники");

            migrationBuilder.DropTable(
                name: "Услуги");

            migrationBuilder.DropTable(
                name: "Виды_комплектующих");

            migrationBuilder.DropTable(
                name: "Должность");
        }
    }
}
