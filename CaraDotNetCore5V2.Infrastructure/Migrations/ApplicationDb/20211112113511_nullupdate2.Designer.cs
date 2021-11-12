﻿// <auto-generated />
using System;
using CaraDotNetCore5V2.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211112113511_nullupdate2")]
    partial class nullupdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AspNetCoreHero.EntityFrameworkCore.AuditTrail.Models.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AffectedColumns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Catalog.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Catalog.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Data.DataLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("LogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoggedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("QRcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("camid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cardNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("certificateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("certificateType")
                        .HasColumnType("int");

                    b.Property<string>("commonUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("groupId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orgimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("temperature")
                        .HasColumnType("real");

                    b.Property<string>("temperatureAlarm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("time")
                        .HasColumnType("int");

                    b.Property<int?>("timelocal")
                        .HasColumnType("int");

                    b.Property<int?>("timestamp")
                        .HasColumnType("int");

                    b.Property<int?>("trackId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataLogs");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Data.Face", b =>
                {
                    b.Property<int>("FaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogId")
                        .HasColumnType("int");

                    b.Property<string>("QRcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScanLogsLogId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("cardNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("certificateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("certificateType")
                        .HasColumnType("int");

                    b.Property<string>("commonUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("groupId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orgimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("temperature")
                        .HasColumnType("real")
                        .HasColumnName("Temperature");

                    b.Property<string>("temperatureAlarm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("timestamp")
                        .HasColumnType("int");

                    b.Property<int>("trackId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FaceId");

                    b.HasIndex("ScanLogsLogId");

                    b.ToTable("Face");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Data.ScanLogs", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LoggedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("operator");

                    b.Property<string>("_event")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("event");

                    b.Property<string>("camid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devmac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("devno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("time")
                        .HasColumnType("int");

                    b.Property<int>("timelocal")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.ToTable("ScanLogs");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Catalog.Product", b =>
                {
                    b.HasOne("CaraDotNetCore5V2.Domain.Entities.Catalog.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Data.Face", b =>
                {
                    b.HasOne("CaraDotNetCore5V2.Domain.Entities.Data.ScanLogs", "ScanLogs")
                        .WithMany("Faces")
                        .HasForeignKey("ScanLogsLogId");

                    b.Navigation("ScanLogs");
                });

            modelBuilder.Entity("CaraDotNetCore5V2.Domain.Entities.Data.ScanLogs", b =>
                {
                    b.Navigation("Faces");
                });
#pragma warning restore 612, 618
        }
    }
}
