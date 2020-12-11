﻿// <auto-generated />
using System;
using CityGasWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CityGasWebApi.Migrations
{
    [DbContext(typeof(CityGasContext))]
    [Migration("20201210093556_initmysql")]
    partial class initmysql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CityGasWebApi.Models.Archives.Device", b =>
                {
                    b.Property<Guid>("GId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Ability")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("AcceptDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("AssetNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BuyContractNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Company")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DebugFinishDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Depreciation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DeviceName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DeviceType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DeviceType1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FacPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Factory")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("FactoryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FactoryNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Formalities")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Function")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HolderSituation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("InspectCycle")
                        .HasColumnType("double");

                    b.Property<string>("InstallAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IsKeyPart")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IsSpecial")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LicensesCompany")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OtherParams")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PressType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("QualityYears")
                        .HasColumnType("double");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResponseUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Size")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Source")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Spec")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UsePart")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UseRegistNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("GId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("CityGasWebApi.Models.BaseInfo.Driver", b =>
                {
                    b.Property<Guid>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Company")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PK");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("CityGasWebApi.Models.BaseInfo.OilStation", b =>
                {
                    b.Property<Guid>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("District")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HMIIP")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("LevelCalcFactor")
                        .HasColumnType("float");

                    b.Property<float>("LevelCalcOffset")
                        .HasColumnType("float");

                    b.Property<string>("Longitude")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PLCIP")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("PumpCalcFactor")
                        .HasColumnType("float");

                    b.Property<float>("PumpCalcOffset")
                        .HasColumnType("float");

                    b.Property<float>("PumpRatedFlow")
                        .HasColumnType("float");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("VolumnPer1cm")
                        .HasColumnType("float");

                    b.HasKey("PK");

                    b.ToTable("OilStation");
                });

            modelBuilder.Entity("CityGasWebApi.Models.BaseInfo.Truck", b =>
                {
                    b.Property<Guid>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Company")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LeadSealNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Number")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Volumn")
                        .HasColumnType("float");

                    b.HasKey("PK");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("CityGasWebApi.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Avatar")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CurrentAuthority")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mobile")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CityGasWebApi.Models.Work.WorkTicket", b =>
                {
                    b.Property<Guid>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CarNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Driver")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("LevelAfterLoad")
                        .HasColumnType("float");

                    b.Property<float>("LevelBeginLoad")
                        .HasColumnType("float");

                    b.Property<string>("LoadStation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LoadingActualBeginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LoadingActualEndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LoadingBeginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LoadingEndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("OilError")
                        .HasColumnType("float");

                    b.Property<float>("OilLoaded")
                        .HasColumnType("float");

                    b.Property<float>("OilLoadedMax")
                        .HasColumnType("float");

                    b.Property<string>("OilLoader")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("OilUnloaded")
                        .HasColumnType("float");

                    b.Property<string>("OilUnloader")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Reviewer")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SubSerialNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("TaskDuration")
                        .HasColumnType("float");

                    b.Property<string>("UnloadStation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UnloadingBeginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UnloadingEndTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PK");

                    b.ToTable("WorkTicket");
                });
#pragma warning restore 612, 618
        }
    }
}
