using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace schedule.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    numCourse = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    numGroup = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nameLesson = table.Column<string>(nullable: false),
                    numGroup = table.Column<string>(nullable: true),
                    numCourse = table.Column<int>(nullable: false),
                    TName = table.Column<string>(nullable: true),
                    TSurname = table.Column<string>(nullable: true),
                    TPatronimic = table.Column<string>(nullable: true),
                    Format = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Methodist",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Patronimic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Patronimic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43fa553a-294d-4eaf-bfab-8c3ed913c486", "b6622cd0-c6b7-408f-9bd1-abe90821092a", "teacher", "TEACHER" },
                    { "ab1d43f0-1ab6-4282-bb2f-d95cc94aef92", "0895b331-143d-4881-b5c7-7ce53aca76a2", "student", "STUDENT" },
                    { "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6", "54fd3b86-8610-4e58-af99-33be7d5de406", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "df589529-387e-46e1-9c49-1a9388f1aa9d", 0, "4d7f98fd-a4bf-4536-9b51-e905d3533060", null, false, false, null, null, "TEACHER", "AQAAAAEAACcQAAAAEPpT/RA2q//vVf2AsFVcJvdsdHpFmCH4H5b+aZ7iYXwQtLtsDY0Eh2DmpSiKfMRpKg==", null, false, "", false, "teacher" },
                    { "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b", 0, "732b49bd-14d6-4d3a-8c27-897b6531f9da", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEENasGsklTl8w4K2orUGtD2eptkAIQuAZIN70mKq9HSmo1wfAjF99QoIrzLbJsiUqA==", null, false, "", false, "admin" },
                    { "810ab629-9970-4f2a-9664-784024ce1744", 0, "6f63859f-86f0-43b2-8a7b-b5b9da8013b5", null, false, false, null, null, "STUDENT", "AQAAAAEAACcQAAAAEIxI7J/l/vuuVgymXOvbIVaoMFsnHyCGk1qAp+tRLGmEBioFBNMrD/cKIU5r62BwTA==", null, false, "", false, "student" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "numCourse" },
                values: new object[,]
                {
                    { new Guid("a4d7652d-d884-4851-8c20-9bd87154d761"), 1 },
                    { new Guid("1e23063e-2fb8-4a89-88b5-d64276fdd3d8"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "numGroup" },
                values: new object[] { new Guid("703d2975-31cf-4607-abaa-7488ad9b9c8f"), "1" });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "Id", "Format", "TName", "TPatronimic", "TSurname", "nameLesson", "numCourse", "numGroup" },
                values: new object[,]
                {
                    { new Guid("1da60142-c1cc-500b-8847-68ef52c8c779"), null, "Соболь А.М", null, null, "Компьютерные сети", 0, "2+8АРИСТ" },
                    { new Guid("1da60173-c1cc-400b-8847-68ef52c8c779"), "Лаб. занятие", "Шпак К.С", "Сергеевич", "Кирилл", "Технологии программирования", 3, "6+7ПИ" },
                    { new Guid("1da51173-c1cc-400b-8847-68ef52c8c779"), "Практика", "Чехменок Т.А", "Александровна", "Татьяна", "Мат.Анализ", 2, "2" },
                    { new Guid("1da51176-c1cc-400b-8847-68ef52c8c778"), "Лекция", "Поляков А.В", null, null, "Физика", 1, "1" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c779"), "Семинар", "Белый Н.М", null, null, "Физ.Культура", 4, "4+5КБ" }
                });

            migrationBuilder.InsertData(
                table: "Methodist",
                columns: new[] { "Id", "Name", "Patronimic", "Surname" },
                values: new object[] { new Guid("01973f1d-44f6-4341-a9db-178c7ab552f5"), "Мирослава", "Марьяновна", "Синкевич" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Name", "Patronimic", "Surname" },
                values: new object[,]
                {
                    { new Guid("66bd0fe7-4270-43b0-aaa9-f23487da064f"), "Кирилл", "Сергеевич", "Шпак" },
                    { new Guid("1da51176-c1cc-400b-8847-68ef52c8c776"), "Татьяна", "Петровна", "Янукович" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b", "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "810ab629-9970-4f2a-9664-784024ce1744", "ab1d43f0-1ab6-4282-bb2f-d95cc94aef92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "df589529-387e-46e1-9c49-1a9388f1aa9d", "43fa553a-294d-4eaf-bfab-8c3ed913c486" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Methodist");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
