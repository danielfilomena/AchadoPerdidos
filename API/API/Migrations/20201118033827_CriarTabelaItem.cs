using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriarTabelaItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE tbIte(
                    iteCod INT NOT NULL IDENTITY(1,1),
                    catCod INT NOT NULL,
                    pesCod INT NOT NULL,
                    iteDsc VARCHAR(100) NOT NULL,
                    iteLoc VARCHAR(100) NOT NULL,
                    iteDtaCad DateTime NOT NULL,
                    iteDtaAlt DateTime NULL,
                    iteDtaEnt DateTime NULL,
                    iteEntregue bit NOT NULL CONSTRAINT DF_tbIte_iteEntregue DEFAULT(0),
                    iteInativo bit NOT NULL CONSTRAINT DF_tbIte_iteInativo DEFAULT(0),
                    iteExcluido bit NOT NULL CONSTRAINT DF_tbIte_iteExcluido DEFAULT(0),
                    iteTs   TimeStamp,
                        CONSTRAINT PK_tbIte_iteCod PRIMARY KEY(iteCod))
            ");

            migrationBuilder.Sql(@"ALTER TABLE tbITE ADD CONSTRAINT FK_tbIte_tbCat_catCod FOREIGN KEY(catCod) REFERENCES tbCat(catCod)");
            migrationBuilder.Sql(@"ALTER TABLE tbITE ADD CONSTRAINT FK_tbIte_tbPes_pesCod FOREIGN KEY(pesCod) REFERENCES tbPes(pesCod)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
