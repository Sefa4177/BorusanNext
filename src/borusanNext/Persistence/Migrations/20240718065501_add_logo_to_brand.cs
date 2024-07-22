using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_logo_to_brand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e0131193-fd2c-408a-b06e-62b801d84a21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038"));

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("72ae1df4-6988-4d13-a9f1-d8b0724c96a0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 46, 48, 146, 35, 16, 186, 20, 204, 159, 153, 103, 244, 38, 141, 48, 18, 0, 95, 76, 112, 218, 46, 149, 102, 27, 123, 104, 130, 133, 103, 206, 184, 187, 129, 207, 165, 230, 128, 75, 173, 184, 50, 235, 184, 201, 100, 174, 3, 130, 120, 66, 131, 157, 5, 47, 158, 72, 15, 25, 42, 237, 233, 225, 191 }, new byte[] { 187, 255, 67, 117, 77, 42, 191, 42, 194, 166, 86, 100, 58, 235, 206, 14, 162, 117, 115, 198, 28, 254, 118, 7, 137, 16, 163, 177, 164, 2, 65, 71, 55, 18, 191, 15, 69, 108, 135, 114, 72, 1, 143, 154, 189, 248, 28, 106, 78, 195, 207, 220, 204, 52, 142, 174, 77, 111, 233, 40, 107, 6, 129, 134, 220, 50, 243, 163, 7, 153, 244, 114, 47, 239, 12, 175, 110, 148, 56, 26, 56, 35, 28, 215, 238, 249, 35, 91, 232, 169, 230, 148, 83, 214, 17, 101, 45, 31, 218, 215, 82, 255, 217, 239, 145, 173, 40, 160, 204, 249, 61, 237, 47, 84, 150, 233, 16, 172, 118, 58, 205, 140, 81, 155, 246, 116, 139, 222 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("28c68993-d2c4-4bce-ab0e-a48567a3bcb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("72ae1df4-6988-4d13-a9f1-d8b0724c96a0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("28c68993-d2c4-4bce-ab0e-a48567a3bcb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72ae1df4-6988-4d13-a9f1-d8b0724c96a0"));

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Brands");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 227, 50, 175, 77, 205, 62, 2, 226, 3, 72, 75, 40, 191, 176, 16, 143, 135, 187, 7, 229, 241, 63, 52, 72, 41, 74, 44, 6, 149, 168, 68, 9, 75, 56, 159, 208, 153, 20, 111, 207, 41, 244, 85, 124, 107, 130, 104, 105, 138, 48, 132, 118, 202, 194, 159, 37, 172, 174, 253, 106, 86, 12, 60, 244 }, new byte[] { 6, 22, 5, 63, 212, 107, 233, 36, 216, 175, 165, 164, 42, 153, 30, 13, 235, 25, 173, 41, 196, 141, 73, 169, 51, 233, 137, 55, 144, 106, 181, 99, 224, 80, 124, 242, 93, 23, 240, 125, 237, 104, 128, 20, 67, 5, 107, 166, 60, 77, 31, 223, 119, 247, 242, 155, 190, 164, 70, 190, 139, 84, 197, 162, 122, 188, 0, 6, 166, 211, 200, 86, 245, 99, 197, 169, 15, 197, 13, 166, 227, 165, 162, 205, 14, 250, 2, 180, 236, 119, 184, 17, 73, 76, 171, 96, 71, 182, 168, 166, 229, 204, 75, 159, 116, 124, 11, 39, 145, 177, 44, 115, 114, 102, 173, 138, 198, 3, 7, 112, 112, 16, 30, 29, 92, 221, 177, 65 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e0131193-fd2c-408a-b06e-62b801d84a21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038") });
        }
    }
}
