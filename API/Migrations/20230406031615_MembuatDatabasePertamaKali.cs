using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MembuatDatabasePertamaKali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_m_employees",
                columns: table => new
                {
                    nik = table.Column<string>(type: "char(5)", nullable: false),
                    first_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    hiring_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    phone_number = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_employees", x => x.nik);
                });

            migrationBuilder.CreateTable(
                name: "tb_tr_profilings",
                columns: table => new
                {
                    employee_nik = table.Column<string>(type: "char(5)", nullable: false),
                    education_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tr_profilings", x => x.employee_nik);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_employees");

            migrationBuilder.DropTable(
                name: "tb_tr_profilings");
        }
    }
}
