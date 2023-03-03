using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YigithanBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6441), null, null, false, null, null, "ASP.NET Core" },
                    { new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6466), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6703), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("d033f821-f516-4651-929a-f11f85db6188"), "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6698), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0ea7a5e2-1d5f-4e73-8e8f-b485e9b7484b"), new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6069), null, null, new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("db33c3fa-c719-4de1-8f86-8cdf2ad11f86"), new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6054), null, null, new Guid("d033f821-f516-4651-929a-f11f85db6188"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0ea7a5e2-1d5f-4e73-8e8f-b485e9b7484b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("db33c3fa-c719-4de1-8f86-8cdf2ad11f86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d033f821-f516-4651-929a-f11f85db6188"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
