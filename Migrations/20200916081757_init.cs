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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
