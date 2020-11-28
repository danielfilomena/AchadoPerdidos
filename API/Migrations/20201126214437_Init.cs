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
                    pesCod  INT NOT NULL IDENTITY(1,1),
                    pesNome VARCHAR(30) NOT NULL,
                    pesUltNome  VARCHAR(30) NOT NULL,
                    pesCPF  VARCHAR(11) NOT NULL,
                    pesTel  VARCHAR(20) NOT NULL,
                    pesEmail    VARCHAR(200) NOT NULL,
                    pesSenha    VARCHAR(50) NOT NULL,
                    pesDtaCad   DATETIME NULL,
                    pesDtaAlt   DATETIME NULL,
                    pesInativo  BIT NOT NULL CONSTRAINT DF_tbPes_pesInativo DEFAULT(0),
                    pesExcluido BIT NOT NULL CONSTRAINT DF_tbPes_pesExcluido DEFAULT(0),
                    pesTs   TimeStamp NOT NULL,
                        CONSTRAINT PK_tbPes_pesCod PRIMARY KEY(pesCod))");

            migrationBuilder.Sql(@"CREATE INDEX IDX_tbPes_pesCPF ON tbPes(pesCPF)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
