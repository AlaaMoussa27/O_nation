using Microsoft.EntityFrameworkCore.Migrations;

namespace final_project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COUNTRY",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Country_Continent = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Country_Notes = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTRY", x => x.Country_ID);
                });

            migrationBuilder.CreateTable(
                name: "PAPER",
                columns: table => new
                {
                    Paper_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paper_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Paper_Place = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAPER", x => x.Paper_ID);
                });

            migrationBuilder.CreateTable(
                name: "PURPOSE",
                columns: table => new
                {
                    Purpose_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Purpose_Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURPOSE", x => x.Purpose_ID);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY_GROUP",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Country_Group = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COUNTRY___B597CE1D98FD4CF2", x => new { x.Country_ID, x.Country_Group });
                    table.ForeignKey(
                        name: "FK__COUNTRY_G__Count__398D8EEE",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY_IMAGES",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Image_ID = table.Column<int>(type: "int", nullable: false),
                    Image_Data = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COUNTRY___03FC7F9DFA5FF4B5", x => new { x.Country_ID, x.Image_ID });
                    table.ForeignKey(
                        name: "FK__COUNTRY_I__Count__3C69FB99",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EMBASSIES",
                columns: table => new
                {
                    Embassies_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Embassies_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Embassies_Location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Embassies_Phone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Embassies_Fax = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Embassies_Mail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Country_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EMBASSIE__54B2753CBEAFBDAC", x => x.Embassies_ID);
                    table.ForeignKey(
                        name: "FK__EMBASSIES__Count__5812160E",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TOURISTIC_PLACES",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Place_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TOURISTI__AD46DB979129963D", x => new { x.Country_ID, x.Place_Name });
                    table.ForeignKey(
                        name: "FK__TOURISTIC__Count__3F466844",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "_USER",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    User_Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    User_Photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Country_ID = table.Column<int>(type: "int", nullable: true),
                    Purpose_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK___USER__Country_I__440B1D61",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK___USER__Purpose_I__44FF419A",
                        column: x => x.Purpose_ID,
                        principalTable: "PURPOSE",
                        principalColumn: "Purpose_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY_PURPOSE_PAPER",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Paper_ID = table.Column<int>(type: "int", nullable: false),
                    Purpose_ID = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COUNTRY___53CACEC2C1B15C81", x => new { x.Country_ID, x.Paper_ID, x.Purpose_ID });
                    table.ForeignKey(
                        name: "FK__COUNTRY_P__Count__5535A963",
                        column: x => x.Country_ID,
                        principalTable: "COUNTRY",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__COUNTRY_P__Paper__534D60F1",
                        column: x => x.Paper_ID,
                        principalTable: "PAPER",
                        principalColumn: "Paper_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__COUNTRY_P__Purpo__5441852A",
                        column: x => x.Purpose_ID,
                        principalTable: "PURPOSE",
                        principalColumn: "Purpose_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER_EMAIL",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER_EMA__6AF081C3299FC144", x => new { x.User_ID, x.Email });
                    table.ForeignKey(
                        name: "FK__USER_EMAI__User___4CA06362",
                        column: x => x.User_ID,
                        principalTable: "_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER_PAPER",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Paper_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER_PAP__5E664E502AF73A2F", x => new { x.User_ID, x.Paper_ID });
                    table.ForeignKey(
                        name: "FK__USER_PAPE__Paper__5070F446",
                        column: x => x.Paper_ID,
                        principalTable: "PAPER",
                        principalColumn: "Paper_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__USER_PAPE__User___4F7CD00D",
                        column: x => x.User_ID,
                        principalTable: "_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER_PHONE",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Phone_Num = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER_PHO__8731B6833F2FD4BA", x => new { x.User_ID, x.Phone_Num });
                    table.ForeignKey(
                        name: "FK__USER_PHON__User___49C3F6B7",
                        column: x => x.User_ID,
                        principalTable: "_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX__USER_Country_ID",
                table: "_USER",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX__USER_Purpose_ID",
                table: "_USER",
                column: "Purpose_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COUNTRY_PURPOSE_PAPER_Paper_ID",
                table: "COUNTRY_PURPOSE_PAPER",
                column: "Paper_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COUNTRY_PURPOSE_PAPER_Purpose_ID",
                table: "COUNTRY_PURPOSE_PAPER",
                column: "Purpose_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBASSIES_Country_ID",
                table: "EMBASSIES",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_PAPER_Paper_ID",
                table: "USER_PAPER",
                column: "Paper_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COUNTRY_GROUP");

            migrationBuilder.DropTable(
                name: "COUNTRY_IMAGES");

            migrationBuilder.DropTable(
                name: "COUNTRY_PURPOSE_PAPER");

            migrationBuilder.DropTable(
                name: "EMBASSIES");

            migrationBuilder.DropTable(
                name: "TOURISTIC_PLACES");

            migrationBuilder.DropTable(
                name: "USER_EMAIL");

            migrationBuilder.DropTable(
                name: "USER_PAPER");

            migrationBuilder.DropTable(
                name: "USER_PHONE");

            migrationBuilder.DropTable(
                name: "PAPER");

            migrationBuilder.DropTable(
                name: "_USER");

            migrationBuilder.DropTable(
                name: "COUNTRY");

            migrationBuilder.DropTable(
                name: "PURPOSE");
        }
    }
}
