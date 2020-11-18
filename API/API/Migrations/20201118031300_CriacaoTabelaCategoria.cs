using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriacaoTabelaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE tbCat(
                    catCod INT NOT NULL IDENTITY(1, 1),
                    catDsc VARCHAR(30) NOT NULL,
                    catDtaCad DateTime NULL,
                    catDtaAlt DateTime NULL,
                    catInativo bit NOT NULL CONSTRAINT DF_tbCat_catInativo DEFAULT(0),
                    catExcluido bit NOT NULL CONSTRAINT DF_tbCat_catExcluido DEFAULT(0),
                    catTs TimeStamp NOT NULL,
                        CONSTRAINT PK_tbCat_catCod PRIMARY KEY(catCod))
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
