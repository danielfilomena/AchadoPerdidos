using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriarTabelaItemFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                CREATE TABLE tbItePic(
                    itePicCod INT NOT NULL IDENTITY(1,1),
                    iteCod  INT NOT NULL,
                    itePicPath VARCHAR(500) NOT NULL,
                        CONSTRAINT PK_tbItePic_itePicCod PRIMARY KEY(itePicCod))
            ");

            migrationBuilder.Sql(@"ALTER TABLE tbItePic ADD CONSTRAINT FK_tbItePic_tbIte_iteCod FOREIGN KEY(iteCod) REFERENCES tbIte(iteCod)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
