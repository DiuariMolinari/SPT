using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPT.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consorcios",
                columns: table => new
                {
                    ConsorcioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeSegmento = table.Column<string>(nullable: true),
                    TaxaSeguro = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    QtdMesPlano = table.Column<int>(nullable: false),
                    DescricaoPlano = table.Column<string>(nullable: true),
                    ValorCarta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consorcios", x => x.ConsorcioId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ValorHora = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "Investimentos",
                columns: table => new
                {
                    InvestimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValorInvestido = table.Column<double>(nullable: false),
                    Periodo = table.Column<double>(nullable: false),
                    TipoInvestimento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investimentos", x => x.InvestimentoId);
                });

            migrationBuilder.CreateTable(
                name: "FolhaPagamentos",
                columns: table => new
                {
                    FolhaPagamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FuncionarioId = table.Column<int>(nullable: false),
                    HorasTrabalhadas = table.Column<double>(nullable: false),
                    Periodo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPagamentos", x => x.FolhaPagamentoId);
                    table.ForeignKey(
                        name: "FK_FolhaPagamentos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consorcios");

            migrationBuilder.DropTable(
                name: "FolhaPagamentos");

            migrationBuilder.DropTable(
                name: "Investimentos");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
