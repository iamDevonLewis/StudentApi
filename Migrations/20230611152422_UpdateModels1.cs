using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "State", "Street", "StudentId" },
                values: new object[,]
                {
                    { new Guid("17eb6454-b9b0-4c8b-a764-ede233f098a1"), "Saint Louis", "Missouri", "51 Hazelwood", new Guid("2b107f52-c7b5-4879-a233-bf8805341f58") },
                    { new Guid("6094c3de-6b72-4927-afb3-9a89d0bcbfa8"), "Saint Louis", "Missouri", "23 Halls Ferry", new Guid("2e30682f-3937-4d87-bfab-6aae235d9123") }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("15fe46d3-7de1-43bd-ba1a-a81ab6e56105"), "Male" },
                    { new Guid("8fc6727e-6882-4c86-a5b1-f7ca2e326857"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AddressId", "DateOfBirth", "Email", "FirstName", "GenderId", "ImageUrl", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("2b107f52-c7b5-4879-a233-bf8805341f58"), new Guid("17eb6454-b9b0-4c8b-a764-ede233f098a1"), new DateTime(1990, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@yahoo.com", "John", new Guid("15fe46d3-7de1-43bd-ba1a-a81ab6e56105"), "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg/1200px-Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg", "Smith", 411 },
                    { new Guid("2e30682f-3937-4d87-bfab-6aae235d9123"), new Guid("6094c3de-6b72-4927-afb3-9a89d0bcbfa8"), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "whitney@yahoo.com", "Whitney", new Guid("8fc6727e-6882-4c86-a5b1-f7ca2e326857"), "https://upload.wikimedia.org/wikipedia/commons/5/52/Whitney_Houston_%28cropped3%29.JPEG", "Houston", 511 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b107f52-c7b5-4879-a233-bf8805341f58"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2e30682f-3937-4d87-bfab-6aae235d9123"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17eb6454-b9b0-4c8b-a764-ede233f098a1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6094c3de-6b72-4927-afb3-9a89d0bcbfa8"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("15fe46d3-7de1-43bd-ba1a-a81ab6e56105"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("8fc6727e-6882-4c86-a5b1-f7ca2e326857"));
        }
    }
}
