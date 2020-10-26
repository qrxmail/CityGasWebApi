using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityGasWebApi.Migrations
{
    public partial class workticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "OilStation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkTicket",
                columns: table => new
                {
                    PK = table.Column<Guid>(nullable: false),
                    LoadStation = table.Column<string>(nullable: true),
                    UnloadStation = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SubSerialNumber = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    LoadingBeginTime = table.Column<DateTime>(nullable: true),
                    LoadingEndTime = table.Column<DateTime>(nullable: true),
                    LoadingActualBeginTime = table.Column<DateTime>(nullable: true),
                    LoadingActualEndTime = table.Column<DateTime>(nullable: true),
                    OilLoaded = table.Column<float>(nullable: false),
                    Driver = table.Column<string>(nullable: true),
                    OilLoader = table.Column<string>(nullable: true),
                    UnloadingBeginTime = table.Column<DateTime>(nullable: true),
                    UnloadingEndTime = table.Column<DateTime>(nullable: true),
                    OilUnloaded = table.Column<float>(nullable: false),
                    OilError = table.Column<float>(nullable: false),
                    OilUnloader = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Reviewer = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    LevelBeginLoad = table.Column<float>(nullable: false),
                    LevelAfterLoad = table.Column<float>(nullable: false),
                    TaskDuration = table.Column<float>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTicket", x => x.PK);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkTicket");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "OilStation");
        }
    }
}
