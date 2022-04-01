﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Szakdoga.Data;

#nullable disable

namespace Szakdoga.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220324112856_AddSeeds")]
    partial class AddSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                            ConcurrencyStamp = "faf8b631-dfde-4c43-9b94-6848e2db12cf",
                            Name = "Boss",
                            NormalizedName = "BOSS"
                        },
                        new
                        {
                            Id = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                            ConcurrencyStamp = "59bf4b9f-b9bb-4370-a5f5-9a58f2d9620f",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf"
                        },
                        new
                        {
                            UserId = "53543ce-822c-457d-9c2a-b5454f39b3b31",
                            RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Szakdoga.Data.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            AccessFailedCount = 0,
                            Address = "8900, Zalegerszeg Teszt utca 3.",
                            ConcurrencyStamp = "2ed8a72b-3d73-4aee-97f6-47f45eda5d76",
                            Email = "boss@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastLogin = new DateTime(2022, 3, 24, 12, 28, 55, 555, DateTimeKind.Local).AddTicks(9278),
                            LastName = "Boss",
                            LockoutEnabled = false,
                            NormalizedEmail = "BOSS@LOCALHOST.COM",
                            NormalizedUserName = "BOSS@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFmm2xAI5UorEFloY1bMHprQMvnDd4PT7KslvQbwFMOSgAnGhm63g+hdDUtmSjKGag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f162b7b6-caf9-44e0-a1a7-930945a2fd71",
                            TwoFactorEnabled = false,
                            UserName = "boss@localhost.com"
                        },
                        new
                        {
                            Id = "53543ce-822c-457d-9c2a-b5454f39b3b31",
                            AccessFailedCount = 0,
                            Address = "8976, Nemesnép Király utca 6.",
                            ConcurrencyStamp = "5df8aaee-5693-4685-8816-bc918eb082f4",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastLogin = new DateTime(2022, 3, 24, 12, 28, 55, 565, DateTimeKind.Local).AddTicks(1883),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELVwecovgyR9X38ZoDrlBQrvzoL+p2fu2w8PTw4d9KyZ+/kMD/eDhqvbPRCHEP/ljQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "20773c38-18f2-496c-8c34-ade0994c3f15",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com"
                        });
                });

            modelBuilder.Entity("Szakdoga.Data.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Adult")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("FoodTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Szakdoga.Data.FoodAllergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodAllergyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FoodAllergyTypeId");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodAllergies");
                });

            modelBuilder.Entity("Szakdoga.Data.FoodAllergyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodAllergyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9105),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9144),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Laktóz"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9147),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9149),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Diófélék"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9227),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9230),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Glutén"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9232),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9234),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Alkohol"
                        });
                });

            modelBuilder.Entity("Szakdoga.Data.FoodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9302),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9305),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Leves"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9308),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9309),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Ital"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9311),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9313),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Fő étel"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9315),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9316),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Desszert"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9319),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9320),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Savanyúság"
                        });
                });

            modelBuilder.Entity("Szakdoga.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Szakdoga.Data.OrderFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderFoods");
                });

            modelBuilder.Entity("Szakdoga.Data.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("Szakdoga.Data.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9396),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9399),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Kis asztal",
                            SeatsNumber = 4
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9403),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9405),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Közepes asztal",
                            SeatsNumber = 8
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9407),
                            CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            LastModifyDate = new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9408),
                            LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                            Name = "Nagy asztal",
                            SeatsNumber = 12
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Szakdoga.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Szakdoga.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szakdoga.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Szakdoga.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szakdoga.Data.Food", b =>
                {
                    b.HasOne("Szakdoga.Data.FoodType", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("Szakdoga.Data.FoodAllergy", b =>
                {
                    b.HasOne("Szakdoga.Data.FoodAllergyType", "FoodAllergyType")
                        .WithMany()
                        .HasForeignKey("FoodAllergyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szakdoga.Data.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("FoodAllergyType");
                });

            modelBuilder.Entity("Szakdoga.Data.Order", b =>
                {
                    b.HasOne("Szakdoga.Data.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Szakdoga.Data.OrderFood", b =>
                {
                    b.HasOne("Szakdoga.Data.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szakdoga.Data.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}