using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityGasWebApi.Migrations
{
    public partial class initCityGas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    GId = table.Column<Guid>(nullable: false),
                    DeviceNo = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    InspectNo = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    DeviceName = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    BaiduLongitude = table.Column<string>(nullable: true),
                    BaiduLatitude = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.GId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
