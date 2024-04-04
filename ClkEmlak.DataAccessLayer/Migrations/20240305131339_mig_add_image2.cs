using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClkEmlak.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_image2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Estates_EstateID",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameIndex(
                name: "IX_Image_EstateID",
                table: "Images",
                newName: "IX_Images_EstateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Estates_EstateID",
                table: "Images",
                column: "EstateID",
                principalTable: "Estates",
                principalColumn: "EstateID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Estates_EstateID",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameIndex(
                name: "IX_Images_EstateID",
                table: "Image",
                newName: "IX_Image_EstateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Estates_EstateID",
                table: "Image",
                column: "EstateID",
                principalTable: "Estates",
                principalColumn: "EstateID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
