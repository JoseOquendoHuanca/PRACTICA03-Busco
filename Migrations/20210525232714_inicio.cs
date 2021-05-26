using Microsoft.EntityFrameworkCore.Migrations;

namespace PRACTICA03.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arteId = table.Column<int>(type: "int", nullable: false),
                    ropaId = table.Column<int>(type: "int", nullable: false),
                    muebleId = table.Column<int>(type: "int", nullable: false),
                    tecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mueble",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mueble", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ropas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ropas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tecnologias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arteId = table.Column<int>(type: "int", nullable: false),
                    ropaId = table.Column<int>(type: "int", nullable: false),
                    muebleId = table.Column<int>(type: "int", nullable: false),
                    tecnologiaId = table.Column<int>(type: "int", nullable: false),
                    mueblesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoria_artes_arteId",
                        column: x => x.arteId,
                        principalTable: "artes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoria_mueble_mueblesId",
                        column: x => x.mueblesId,
                        principalTable: "mueble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_categoria_ropas_ropaId",
                        column: x => x.ropaId,
                        principalTable: "ropas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoria_tecnologias_tecnologiaId",
                        column: x => x.tecnologiaId,
                        principalTable: "tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriaId = table.Column<int>(type: "int", nullable: true),
                    arteId = table.Column<int>(type: "int", nullable: false),
                    ropaId = table.Column<int>(type: "int", nullable: false),
                    muebleId = table.Column<int>(type: "int", nullable: false),
                    tecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoria_arteId",
                table: "categoria",
                column: "arteId");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_mueblesId",
                table: "categoria",
                column: "mueblesId");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_ropaId",
                table: "categoria",
                column: "ropaId");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_tecnologiaId",
                table: "categoria",
                column: "tecnologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_categoriaId",
                table: "usuario",
                column: "categoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "artes");

            migrationBuilder.DropTable(
                name: "mueble");

            migrationBuilder.DropTable(
                name: "ropas");

            migrationBuilder.DropTable(
                name: "tecnologias");
        }
    }
}
