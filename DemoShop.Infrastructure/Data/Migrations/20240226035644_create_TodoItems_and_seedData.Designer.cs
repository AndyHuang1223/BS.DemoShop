﻿// <auto-generated />
using System;
using DemoShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoShop.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BSDemoShopContext))]
    [Migration("20240226035644_create_TodoItems_and_seedData")]
    partial class create_TodoItems_and_seedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountPercentage")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Coupons", (string)null);
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Members", (string)null);
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuyerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CouponId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(14)
                        .HasColumnType("decimal(14,0)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("MemberId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems", (string)null);
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnTheMarket")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2740),
                            Description = "米奇潮T",
                            ImagePath = "https://picsum.photos/300/200/?random=1",
                            IsDelete = false,
                            IsOnTheMarket = true,
                            ProductName = "潮T",
                            Seq = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2740),
                            Description = "圍巾 DESC.",
                            ImagePath = "https://picsum.photos/300/200/?random=2",
                            IsDelete = false,
                            IsOnTheMarket = true,
                            ProductName = "圍巾",
                            Seq = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2740),
                            Description = "蛋糕 DESC.",
                            ImagePath = "https://picsum.photos/300/200/?random=3",
                            IsDelete = false,
                            IsOnTheMarket = true,
                            ProductName = "蛋糕",
                            Seq = 0
                        });
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2750),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Black-S",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Black-M",
                            Seq = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Black-L",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Black-XL",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-White-XL",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-White-M",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Red-XS",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 10,
                            IsDelete = false,
                            ProductId = 1,
                            SKU = "Micky-Gray-S",
                            Seq = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2760),
                            Inventory = 5,
                            IsDelete = false,
                            ProductId = 2,
                            SKU = "Scarf",
                            Seq = 0,
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = 10,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2770),
                            Inventory = 15,
                            IsDelete = false,
                            ProductId = 3,
                            SKU = "Cake-Banana",
                            Seq = 0,
                            UnitPrice = 599m
                        },
                        new
                        {
                            Id = 11,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2770),
                            Inventory = 20,
                            IsDelete = false,
                            ProductId = 3,
                            SKU = "Cake-Chocolate",
                            Seq = 1,
                            UnitPrice = 599m
                        });
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<int>("SpecificationReferenceId")
                        .HasColumnType("int");

                    b.Property<string>("SpecificationValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("SpecificationReferenceId");

                    b.ToTable("Specifications", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 1,
                            Seq = 0,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "S"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 2,
                            Seq = 1,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "M"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 3,
                            Seq = 2,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "L"
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 4,
                            Seq = 3,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "XL"
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 1,
                            Seq = 0,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "黑色"
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 2,
                            Seq = 0,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "黑色"
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 3,
                            Seq = 0,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "黑色"
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 4,
                            Seq = 0,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "黑色"
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 5,
                            Seq = 1,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "白色"
                        },
                        new
                        {
                            Id = 10,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 6,
                            Seq = 1,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "白色"
                        },
                        new
                        {
                            Id = 11,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 5,
                            Seq = 0,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "M"
                        },
                        new
                        {
                            Id = 12,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 6,
                            Seq = 1,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "XL"
                        },
                        new
                        {
                            Id = 13,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 7,
                            Seq = 2,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "紅色"
                        },
                        new
                        {
                            Id = 14,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 7,
                            Seq = 0,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "XS"
                        },
                        new
                        {
                            Id = 15,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 8,
                            Seq = 3,
                            SpecificationReferenceId = 3,
                            SpecificationValue = "灰色"
                        },
                        new
                        {
                            Id = 16,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 8,
                            Seq = 0,
                            SpecificationReferenceId = 1,
                            SpecificationValue = "S"
                        },
                        new
                        {
                            Id = 17,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 9,
                            Seq = 0,
                            SpecificationReferenceId = 2,
                            SpecificationValue = "單一規格"
                        },
                        new
                        {
                            Id = 18,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 10,
                            Seq = 1,
                            SpecificationReferenceId = 4,
                            SpecificationValue = "香蕉"
                        },
                        new
                        {
                            Id = 19,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            ProductDetailId = 11,
                            Seq = 0,
                            SpecificationReferenceId = 4,
                            SpecificationValue = "巧克力"
                        });
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.SpecificationReference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<string>("SpecificationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SpecificationReferences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Seq = 1,
                            SpecificationName = "尺寸"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Seq = 0,
                            SpecificationName = "規格"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Seq = 0,
                            SpecificationName = "顏色"
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Seq = 0,
                            SpecificationName = "口味"
                        });
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int>("Seq")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TodoItems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2780),
                            Description = "TodoItem 1",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2780),
                            Description = "TodoItem 2",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2780),
                            Description = "TodoItem 3",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2780),
                            Description = "TodoItem 4",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 5",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 6",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 7",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 8",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 9",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        },
                        new
                        {
                            Id = 10,
                            CreateAt = new DateTime(2024, 2, 26, 3, 56, 44, 472, DateTimeKind.Utc).AddTicks(2790),
                            Description = "TodoItem 10",
                            IsDelete = false,
                            IsDone = false,
                            Seq = 0
                        });
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Order", b =>
                {
                    b.HasOne("DemoShop.ApplicationCore.Entities.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId");

                    b.HasOne("DemoShop.ApplicationCore.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coupon");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.OrderItem", b =>
                {
                    b.HasOne("DemoShop.ApplicationCore.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.ProductDetail", b =>
                {
                    b.HasOne("DemoShop.ApplicationCore.Entities.Product", "Product")
                        .WithMany("ProductDeatils")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Specification", b =>
                {
                    b.HasOne("DemoShop.ApplicationCore.Entities.ProductDetail", "ProductDetail")
                        .WithMany("Specifications")
                        .HasForeignKey("ProductDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoShop.ApplicationCore.Entities.SpecificationReference", "SpecificationReference")
                        .WithMany("Specifications")
                        .HasForeignKey("SpecificationReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductDetail");

                    b.Navigation("SpecificationReference");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.Product", b =>
                {
                    b.Navigation("ProductDeatils");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.ProductDetail", b =>
                {
                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("DemoShop.ApplicationCore.Entities.SpecificationReference", b =>
                {
                    b.Navigation("Specifications");
                });
#pragma warning restore 612, 618
        }
    }
}
