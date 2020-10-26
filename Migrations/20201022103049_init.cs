using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityGasWebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    GId = table.Column<Guid>(nullable: false),
                    AssetNo = table.Column<string>(nullable: true),
                    Depreciation = table.Column<string>(nullable: true),
                    DeviceName = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    DeviceType1 = table.Column<string>(nullable: true),
                    InstallAddress = table.Column<string>(nullable: true),
                    UsePart = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true),
                    Spec = table.Column<string>(nullable: true),
                    Ability = table.Column<string>(nullable: true),
                    Factory = table.Column<string>(nullable: true),
                    FacPhone = table.Column<string>(nullable: true),
                    FactoryDate = table.Column<DateTime>(nullable: false),
                    DebugFinishDate = table.Column<DateTime>(nullable: false),
                    FactoryNo = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    BuyDate = table.Column<DateTime>(nullable: false),
                    BuyContractNo = table.Column<string>(nullable: true),
                    UseDate = table.Column<DateTime>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    AcceptDate = table.Column<DateTime>(nullable: false),
                    QualityYears = table.Column<double>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    ResponseUser = table.Column<string>(nullable: true),
                    IsSpecial = table.Column<string>(nullable: true),
                    IsKeyPart = table.Column<string>(nullable: true),
                    HolderSituation = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    PressType = table.Column<string>(nullable: true),
                    UseRegistNo = table.Column<string>(nullable: true),
                    LicensesCompany = table.Column<string>(nullable: true),
                    InspectCycle = table.Column<double>(nullable: false),
                    Formalities = table.Column<string>(nullable: true),
                    OtherParams = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    PK = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.PK);
                });

            migrationBuilder.CreateTable(
                name: "OilStation",
                columns: table => new
                {
                    PK = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    PLCIP = table.Column<string>(nullable: true),
                    HMIIP = table.Column<string>(nullable: true),
                    VolumnPer1cm = table.Column<float>(nullable: false),
                    LevelCalcFactor = table.Column<float>(nullable: false),
                    LevelCalcOffset = table.Column<float>(nullable: false),
                    PumpRatedFlow = table.Column<float>(nullable: false),
                    PumpCalcFactor = table.Column<float>(nullable: false),
                    PumpCalcOffset = table.Column<float>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilStation", x => x.PK);
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    PK = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Volumn = table.Column<float>(nullable: false),
                    LeadSealNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.PK);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CurrentAuthority = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "OilStation");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
