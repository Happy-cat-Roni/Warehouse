using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouseDAL.Migrations
{
    /// <inheritdoc />
    public partial class renameWareHousetoWareHouses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesWareHouse_WareHouse_WareHousesId",
                table: "EmployeesWareHouse");

            migrationBuilder.DropForeignKey(
                name: "FK_WareHouse_Directors_DirectorId",
                table: "WareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse");

            migrationBuilder.RenameTable(
                name: "WareHouse",
                newName: "WareHouses");

            migrationBuilder.RenameIndex(
                name: "IX_WareHouse_DirectorId",
                table: "WareHouses",
                newName: "IX_WareHouses_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WareHouses",
                table: "WareHouses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesWareHouse_WareHouses_WareHousesId",
                table: "EmployeesWareHouse",
                column: "WareHousesId",
                principalTable: "WareHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WareHouses_Directors_DirectorId",
                table: "WareHouses",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesWareHouse_WareHouses_WareHousesId",
                table: "EmployeesWareHouse");

            migrationBuilder.DropForeignKey(
                name: "FK_WareHouses_Directors_DirectorId",
                table: "WareHouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WareHouses",
                table: "WareHouses");

            migrationBuilder.RenameTable(
                name: "WareHouses",
                newName: "WareHouse");

            migrationBuilder.RenameIndex(
                name: "IX_WareHouses_DirectorId",
                table: "WareHouse",
                newName: "IX_WareHouse_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesWareHouse_WareHouse_WareHousesId",
                table: "EmployeesWareHouse",
                column: "WareHousesId",
                principalTable: "WareHouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WareHouse_Directors_DirectorId",
                table: "WareHouse",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }
    }
}
