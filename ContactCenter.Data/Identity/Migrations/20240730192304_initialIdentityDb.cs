using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ContactCenter.Data.Identity.Migrations
{
    public partial class initialIdentityDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EdrsmAppUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    MunicipalityAccountNumber = table.Column<string>(type: "text", nullable: true),
                    CellphoneNumber = table.Column<string>(type: "text", nullable: true),
                    PreferredContactMethodId = table.Column<int>(type: "integer", nullable: false),
                    IdentificationTypeId = table.Column<int>(type: "integer", nullable: false),
                    CountryOfOriginId = table.Column<int>(type: "integer", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "text", nullable: true),
                    AgreedToTerms = table.Column<bool>(type: "boolean", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    Ward = table.Column<string>(type: "text", nullable: true),
                    ProfileImageUrl = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmAppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EdrsmUserClaims_EdrsmAppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "EdrsmAppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_EdrsmUserLogins_EdrsmAppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "EdrsmAppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_EdrsmUserTokens_EdrsmAppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "EdrsmAppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EdrsmRoleClaims_EdrsmRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "EdrsmRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EdrsmUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdrsmUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EdrsmUserRoles_EdrsmAppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "EdrsmAppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EdrsmUserRoles_EdrsmRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "EdrsmRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "EdrsmAppUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "EdrsmAppUser",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EdrsmRoleClaims_RoleId",
                table: "EdrsmRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "EdrsmRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EdrsmUserClaims_UserId",
                table: "EdrsmUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EdrsmUserLogins_UserId",
                table: "EdrsmUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EdrsmUserRoles_RoleId",
                table: "EdrsmUserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EdrsmRoleClaims");

            migrationBuilder.DropTable(
                name: "EdrsmUserClaims");

            migrationBuilder.DropTable(
                name: "EdrsmUserLogins");

            migrationBuilder.DropTable(
                name: "EdrsmUserRoles");

            migrationBuilder.DropTable(
                name: "EdrsmUserTokens");

            migrationBuilder.DropTable(
                name: "EdrsmRoles");

            migrationBuilder.DropTable(
                name: "EdrsmAppUser");
        }
    }
}
