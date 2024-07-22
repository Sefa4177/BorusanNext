using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_brand_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("088ee669-769c-447a-a153-b98d060e966a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93042a6a-b758-4c83-ae82-eb9fa7943966"));

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 227, 50, 175, 77, 205, 62, 2, 226, 3, 72, 75, 40, 191, 176, 16, 143, 135, 187, 7, 229, 241, 63, 52, 72, 41, 74, 44, 6, 149, 168, 68, 9, 75, 56, 159, 208, 153, 20, 111, 207, 41, 244, 85, 124, 107, 130, 104, 105, 138, 48, 132, 118, 202, 194, 159, 37, 172, 174, 253, 106, 86, 12, 60, 244 }, new byte[] { 6, 22, 5, 63, 212, 107, 233, 36, 216, 175, 165, 164, 42, 153, 30, 13, 235, 25, 173, 41, 196, 141, 73, 169, 51, 233, 137, 55, 144, 106, 181, 99, 224, 80, 124, 242, 93, 23, 240, 125, 237, 104, 128, 20, 67, 5, 107, 166, 60, 77, 31, 223, 119, 247, 242, 155, 190, 164, 70, 190, 139, 84, 197, 162, 122, 188, 0, 6, 166, 211, 200, 86, 245, 99, 197, 169, 15, 197, 13, 166, 227, 165, 162, 205, 14, 250, 2, 180, 236, 119, 184, 17, 73, 76, 171, 96, 71, 182, 168, 166, 229, 204, 75, 159, 116, 124, 11, 39, 145, 177, 44, 115, 114, 102, 173, 138, 198, 3, 7, 112, 112, 16, 30, 29, 92, 221, 177, 65 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e0131193-fd2c-408a-b06e-62b801d84a21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e0131193-fd2c-408a-b06e-62b801d84a21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b40bd04-d7f3-439f-8968-f5269ef56038"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("93042a6a-b758-4c83-ae82-eb9fa7943966"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 56, 5, 136, 233, 108, 227, 151, 175, 108, 109, 65, 136, 124, 25, 21, 235, 59, 46, 45, 255, 104, 131, 128, 118, 135, 223, 154, 223, 129, 185, 227, 151, 249, 8, 184, 115, 160, 125, 221, 81, 177, 85, 158, 169, 209, 220, 100, 185, 93, 247, 146, 195, 128, 153, 186, 177, 151, 11, 201, 86, 185, 207, 86, 226 }, new byte[] { 110, 225, 164, 214, 17, 137, 254, 75, 246, 51, 17, 240, 198, 113, 108, 96, 251, 159, 141, 233, 149, 193, 129, 255, 116, 23, 137, 71, 0, 69, 191, 48, 246, 205, 71, 117, 144, 14, 42, 222, 49, 34, 254, 128, 131, 181, 243, 231, 66, 170, 12, 245, 24, 177, 225, 249, 226, 121, 120, 215, 120, 25, 155, 95, 97, 3, 169, 72, 192, 163, 66, 122, 180, 82, 83, 89, 186, 103, 11, 113, 215, 55, 50, 126, 193, 208, 156, 152, 205, 68, 227, 254, 112, 155, 137, 11, 50, 128, 126, 115, 182, 86, 207, 205, 87, 56, 200, 236, 72, 171, 44, 203, 211, 236, 64, 173, 106, 170, 33, 171, 253, 32, 247, 182, 106, 137, 135, 86 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("088ee669-769c-447a-a153-b98d060e966a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("93042a6a-b758-4c83-ae82-eb9fa7943966") });
        }
    }
}
