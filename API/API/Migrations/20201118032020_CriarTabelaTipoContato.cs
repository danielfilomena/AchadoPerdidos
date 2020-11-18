using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriarTabelaTipoContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE tbCttTip(
                    cttTipCod INT NOT NULL IDENTITY(1,1),
                    cttTipDsc varChar(20) NOT NULL,
                        CONSTRAINT PK_tbCttTip_cttTipCod PRIMARY KEY(cttTipCod))
            ");

            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Celular')");
            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Comercial')");
            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Email')");
            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Fax')");
            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Residencial')");
            migrationBuilder.Sql("INSERT INTO tbCttTip(cttTipDsc) VALUES('Outros')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
