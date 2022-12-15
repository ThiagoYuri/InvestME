using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestME.DAL.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CodeAcao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CodeAcao);
                });

            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    PVPA = table.Column<float>(type: "real", nullable: false),
                    PBIT = table.Column<float>(type: "real", nullable: false),
                    EVBIT = table.Column<float>(type: "real", nullable: false),
                    DividendYield = table.Column<float>(type: "real", nullable: false),
                    VolumeFinanceiro = table.Column<float>(type: "real", nullable: false),
                    DateLote = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyCodeAcao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilterMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acoes_Company_CompanyCodeAcao",
                        column: x => x.CompanyCodeAcao,
                        principalTable: "Company",
                        principalColumn: "CodeAcao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcaoId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ValueInvested = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Investments_Acoes_AcaoId",
                        column: x => x.AcaoId,
                        principalTable: "Acoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acoes_CompanyCodeAcao",
                table: "Acoes",
                column: "CompanyCodeAcao");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_AcaoId",
                table: "Investments",
                column: "AcaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investments");

            migrationBuilder.DropTable(
                name: "Acoes");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
