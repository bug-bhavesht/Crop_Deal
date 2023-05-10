using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crop_Deal.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crop_Id",
                table: "Crop_Detail");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Crop_Detail");

            migrationBuilder.RenameColumn(
                name: "CropDetail_id",
                table: "Invoices",
                newName: "CropDetail_Id");

            migrationBuilder.AlterColumn<string>(
                name: "User_Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CropDetail_Id",
                table: "Crop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CropDetail_Id",
                table: "Invoices",
                column: "CropDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_User_id",
                table: "Invoices",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crop_CropDetail_Id",
                table: "Crop",
                column: "CropDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Crop_User_Id",
                table: "Crop",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_User_Id",
                table: "Bank",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Users_User_Id",
                table: "Bank",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crop_Crop_Detail_CropDetail_Id",
                table: "Crop",
                column: "CropDetail_Id",
                principalTable: "Crop_Detail",
                principalColumn: "CropDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crop_Users_User_Id",
                table: "Crop",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Crop_Detail_CropDetail_Id",
                table: "Invoices",
                column: "CropDetail_Id",
                principalTable: "Crop_Detail",
                principalColumn: "CropDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_User_id",
                table: "Invoices",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Users_User_Id",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_Crop_Crop_Detail_CropDetail_Id",
                table: "Crop");

            migrationBuilder.DropForeignKey(
                name: "FK_Crop_Users_User_Id",
                table: "Crop");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Crop_Detail_CropDetail_Id",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_User_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CropDetail_Id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_User_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Crop_CropDetail_Id",
                table: "Crop");

            migrationBuilder.DropIndex(
                name: "IX_Crop_User_Id",
                table: "Crop");

            migrationBuilder.DropIndex(
                name: "IX_Bank_User_Id",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CropDetail_Id",
                table: "Crop");

            migrationBuilder.RenameColumn(
                name: "CropDetail_Id",
                table: "Invoices",
                newName: "CropDetail_id");

            migrationBuilder.AlterColumn<string>(
                name: "User_Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Crop_Id",
                table: "Crop_Detail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "Crop_Detail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
