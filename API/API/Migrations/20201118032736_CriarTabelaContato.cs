using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriarTabelaContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE tbCtt(
                    cttCod INT NOT NULL IDENTITY(1,1),
                    cttTipCod INT NOT NULL,
                    pesCod INT NOT NULL,
                    cttDsc VARCHAR(50) NOT NULL,
                        CONSTRAINT PK_tbCtt_cttCod PRIMARY KEY(cttCod))
            ");

            migrationBuilder.Sql(@"ALTER TABLE tbCtt ADD CONSTRAINT FK_tbCtt_tbCttTip_cttTipCod FOREIGN KEY(cttTipCod) REFERENCES tbCttTip(cttTipCod)");
            migrationBuilder.Sql(@"ALTER TABLE tbCtt ADD CONSTRAINT FK_tbCtt_tbPes_pesCod FOREIGN KEY(pesCod) REFERENCES tbPes(pesCod)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
