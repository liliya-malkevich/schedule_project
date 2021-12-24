﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace schedule.Migrations
{
    public partial class migrat : Migration
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
                    numGroup = table.Column<string>(nullable: true),
                    numCourse = table.Column<int>(nullable: false),
                    numLesson = table.Column<int>(nullable: false),
                    timeLesson = table.Column<string>(nullable: true),
                    nameLesson = table.Column<string>(nullable: true),
                    TName = table.Column<string>(nullable: true),
                    lectureHall = table.Column<int>(nullable: false),
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
                    { "43fa553a-294d-4eaf-bfab-8c3ed913c486", "0cd55936-d431-4262-a5fe-8e9cf01cd5c7", "teacher", "TEACHER" },
                    { "ab1d43f0-1ab6-4282-bb2f-d95cc94aef92", "35d63291-b511-463f-9ca2-db462888bbf5", "student", "STUDENT" },
                    { "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6", "c621beeb-2050-43b2-8e53-0273b53be85d", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "df589529-387e-46e1-9c49-1a9388f1aa9d", 0, "dc106043-6a66-4d1a-b6f5-bddb131ac4c7", null, false, false, null, null, "TEACHER", "AQAAAAEAACcQAAAAEAkLW4GbeV6em3Ood/dSbopuWuW1w3FOrQ5XzgWYOrzSWKnlaFKaOH/rfnHAt0FwyA==", null, false, "", false, "teacher" },
                    { "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b", 0, "3ca7a311-d533-4d81-a483-6f9af27ce021", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEIfI5gHzuszFiboxvqPOIVGFvE1w9ZFFrz7NJyQBCKjos/BsqM6bdyn0X8wleEVCpA==", null, false, "", false, "admin" },
                    { "810ab629-9970-4f2a-9664-784024ce1744", 0, "a9027db2-8337-44ac-b8b5-1a4be180128f", null, false, false, null, null, "STUDENT", "AQAAAAEAACcQAAAAEC9C5LEUGfcLl8kVMyawfvWfpSdwgf3nQ7LHXeQbu1qQ9H9I6QXPZOd4yKGkZKcrQA==", null, false, "", false, "student" }
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
                columns: new[] { "Id", "Format", "TName", "lectureHall", "nameLesson", "numCourse", "numGroup", "numLesson", "timeLesson" },
                values: new object[,]
                {
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c785"), null, null, 0, null, 0, null, 5, "15:20-16:40" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c783"), null, null, 0, null, 0, null, 3, "12:00-13:20" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c787"), null, null, 0, null, 0, null, 7, "18:20-19:40" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c782"), null, null, 0, null, 0, null, 2, "10:30-11:50" },
                    { new Guid("1da51176-c1cc-400b-8847-68ef52c8c778"), "Лекция", "Поляков А.В", 117, "Физика", 1, "1", 1, "9:00-10:20" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c784"), null, null, 0, null, 0, null, 4, "13:50-15:10" },
                    { new Guid("1da60173-c1cc-500b-8847-68ef52c8c786"), null, null, 0, null, 0, null, 6, "16:50-18:10" }
                });

            migrationBuilder.InsertData(
                table: "Methodist",
                columns: new[] { "Id", "Name", "Patronimic", "Surname" },
                values: new object[] { new Guid("01973f1d-44f6-4341-a9db-178c7ab552f5"), "Мирослава", "Марьяновна", "Синкевич" });

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