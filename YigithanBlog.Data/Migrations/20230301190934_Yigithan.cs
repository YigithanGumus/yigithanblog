using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YigithanBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Yigithan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0eb48b07-5923-4549-a4c1-023bc029f864"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c0b2ed9e-5ffb-4157-a231-97d97bdcf0c8"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("790becf9-ad2f-497b-a135-3a8f2ab16d8a"), new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(7666), null, null, new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("d45c17cc-bd4b-47f8-9fd7-795739bc3ecd"), new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(7646), null, null, new Guid("d033f821-f516-4651-929a-f11f85db6188"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("76ba5e4a-5a9e-4e21-9efc-1e4070e5f60f"),
                column: "ConcurrencyStamp",
                value: "723dbde1-744a-4852-8837-8cbe677a6abc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8b0a99bf-d084-4296-a098-604bddc523cb"),
                column: "ConcurrencyStamp",
                value: "492ea35a-0411-4b43-adda-193b540a919a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5540c40-8dd2-46fc-9f93-0d5e5fbb0921"),
                column: "ConcurrencyStamp",
                value: "6444f25b-6e52-48d1-bef5-80da6da92e3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1620ef01-506b-4c6e-8043-2bd7d57a3e5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "947846f5-7864-4891-ba0b-3431ad4e00e9", "AQAAAAIAAYagAAAAEOMD7JmhVWpfUIaC1+VYtF2wOtL3OEKlhvGtGFIRiV6h2+IV6hlWKGMT2M1oFJN0tA==", "68409431-6b79-49dd-9b24-5e8948424ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebaee967-4354-45db-858e-7268a2bcaef5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50711746-52f7-4680-9f5b-7ccd6c4e1d5f", "AQAAAAIAAYagAAAAEEejI7ExVNbE/RRHaF5ByDWbt1JlnDTcahz1yY9T+XMVVJZU+BIKfbZBS3ua8t62iA==", "93845423-7577-489d-91c9-71d500f501b2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d033f821-f516-4651-929a-f11f85db6188"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 22, 9, 33, 800, DateTimeKind.Local).AddTicks(8172));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("790becf9-ad2f-497b-a135-3a8f2ab16d8a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d45c17cc-bd4b-47f8-9fd7-795739bc3ecd"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0eb48b07-5923-4549-a4c1-023bc029f864"), new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"), "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 1, 16, 53, 26, 631, DateTimeKind.Local).AddTicks(9802), null, null, new Guid("d033f821-f516-4651-929a-f11f85db6188"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("c0b2ed9e-5ffb-4157-a231-97d97bdcf0c8"), new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"), "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 1, 16, 53, 26, 631, DateTimeKind.Local).AddTicks(9808), null, null, new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("76ba5e4a-5a9e-4e21-9efc-1e4070e5f60f"),
                column: "ConcurrencyStamp",
                value: "549756cc-6bc3-4f2b-aa57-58ef21648e81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8b0a99bf-d084-4296-a098-604bddc523cb"),
                column: "ConcurrencyStamp",
                value: "09f5dae9-9cb9-48ed-9c34-3f54980f6a5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5540c40-8dd2-46fc-9f93-0d5e5fbb0921"),
                column: "ConcurrencyStamp",
                value: "a0d7f5eb-c68e-4a27-9d19-34157ac0db4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1620ef01-506b-4c6e-8043-2bd7d57a3e5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "693ed86f-9460-429c-8b52-423cf3677c46", "AQAAAAIAAYagAAAAEPKpn8FYmwmKBWyH5dvD7DzUGYha3IhYOkDRObZn+A1/0elweIb16JaoQfssbPlrSg==", "db2beae9-8dd2-47ab-b0cb-5d5596e1f8e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebaee967-4354-45db-858e-7268a2bcaef5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b314d5f-9e78-4324-84af-a0553eaed672", "AQAAAAIAAYagAAAAEOCSBGXcNlRPgjKdR4zZNhwP+/K5N/f1Oh5QI38NLHh35EkVxTEvzGs6QuYDfFlHLA==", "d78ca461-b837-4f2e-ade7-7c554cd9464b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6225c7a6-dd70-4cc4-aec4-c7b7612cde27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 16, 53, 26, 632, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4af5a5-7950-453d-96dd-efdd253d9e22"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 16, 53, 26, 632, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c3559b7-e1df-4fd0-a475-6712b386d91b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 16, 53, 26, 632, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d033f821-f516-4651-929a-f11f85db6188"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 1, 16, 53, 26, 632, DateTimeKind.Local).AddTicks(175));
        }
    }
}
