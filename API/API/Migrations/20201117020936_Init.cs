using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                CREATE TABLE tbPes(
                    pesCod INT NOT NULL IDENTITY(1,1),
                    pesNome VARCHAR(30) NOT NULL,
                    pesUltNome VARCHAR(30) NOT NULL,
                    pesCPF VARCHAR(11) NOT NULL,
                    pesDtaCad DateTime NULL,
                    pesDtaAlt DateTime NULL,
                    pesSenha VARCHAR(10) NOT NULL,
                    pesInativo Bit NOT NULL CONSTRAINT DF_tbPes_pesInativo DEFAULT(0),
                    pesExcluido Bit NOT NULL CONSTRAINT DF_tbPes_pesExcluido DEFAULT(0),
                    pesTs TimeStamp NOT NULL,
                        CONSTRAINT PK_tbPes_pesCod PRIMARY KEY(pesCod))
            ");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
