using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YigithanBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0ea7a5e2-1d5f-4e73-8e8f-b485e9b7484b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("db33c3fa-c719-4de1-8f86-8cdf2ad11f86"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8ff7f4a4-3e2a-4466-b934-a843aa39a23f"), new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(4772), null, null, new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("dea30a6a-7324-40df-892f-b573f956463a"), new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(4767), null, null, new Guid("d033f821-f516-4651-929a-f11f85db6188"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d033f821-f516-4651-929a-f11f85db6188"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 28, 15, 19, 53, 945, DateTimeKind.Local).AddTicks(5024));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8ff7f4a4-3e2a-4466-b934-a843aa39a23f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dea30a6a-7324-40df-892f-b573f956463a"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0ea7a5e2-1d5f-4e73-8e8f-b485e9b7484b"), new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6069), null, null, new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("db33c3fa-c719-4de1-8f86-8cdf2ad11f86"), new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6054), null, null, new Guid("d033f821-f516-4651-929a-f11f85db6188"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d033f821-f516-4651-929a-f11f85db6188"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 27, 15, 53, 19, 349, DateTimeKind.Local).AddTicks(6698));
        }
    }
}
