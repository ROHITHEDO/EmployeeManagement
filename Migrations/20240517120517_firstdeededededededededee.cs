using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class firstdeededededededededee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5bd2f3a9-87c6-4d54-a0ef-a8d5e85d371a", "Admin@gmail.com", "Admin@gmail.com", "Admin@gmail.com", "AQAAAAIAAYagAAAAEOm1fhL1L+WjC++w0dhICWREdisbrJaFBCFQ21+N6g6fYjFvGoKv4Sb2RGLPqawO5A==", "25011a78-a341-4b06-bd4a-5fb7f2fc2b9a", "Admin@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4e75c02e-4c06-4fe4-a607-737d6fcf379d", "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEJVtW8PN4upwvgucN7WLjHUj4uOFH/ikRbgy2D4YUFJ+xwvEkMMSM5HiZSJwspyNLg==", "0233903a-c923-4351-a911-d34d011f01c3", "Admin" });
        }
    }
}
