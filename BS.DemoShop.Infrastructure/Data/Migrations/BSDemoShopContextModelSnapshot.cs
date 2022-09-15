﻿// <auto-generated />
using System;
using BS.DemoShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BS.DemoShop.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BSDemoShopContext))]
    partial class BSDemoShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 622, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "預設分類1",
                            Sort = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 622, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "預設分類2",
                            Sort = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 622, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "預設分類3",
                            Sort = 2
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnTheMarket")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 623, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, 0, 0, 0, 0)),
                            ImgPath = "https://picsum.photos/300/200/?random=1",
                            IsOnTheMarket = true,
                            Name = "種子商品1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 623, DateTimeKind.Unspecified).AddTicks(8050), new TimeSpan(0, 0, 0, 0, 0)),
                            ImgPath = "https://picsum.photos/300/200/?random=2",
                            IsOnTheMarket = false,
                            Name = "種子商品2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 623, DateTimeKind.Unspecified).AddTicks(8050), new TimeSpan(0, 0, 0, 0, 0)),
                            ImgPath = "https://picsum.photos/300/200/?random=3",
                            IsOnTheMarket = true,
                            Name = "種子商品3"
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 100,
                            Name = "種子規格1",
                            ProductId = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 10,
                            Name = "種子規格2",
                            ProductId = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 8,
                            Name = "種子規格3",
                            ProductId = 1,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 4,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 18,
                            Name = "種子規格4",
                            ProductId = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 5,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 0,
                            Name = "種子規格4",
                            ProductId = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 6,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 120,
                            Name = "種子規格4",
                            ProductId = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 7,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 624, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            Inventory = 20,
                            Name = "種子規格4",
                            ProductId = 3,
                            UnitPrice = 100m
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleType")
                        .HasColumnType("int")
                        .HasComment(" 0:NormalUser, 1:Administrator, 2:Developer");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "NormalUser",
                            RoleType = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Administrator",
                            RoleType = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Developer",
                            RoleType = 2
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 630, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "AdminUser@gmail.com",
                            Gender = 0,
                            Name = "AdminUser",
                            Password = "8095B76E4B6D46F529D65C8E75936C8D3BD689189B68CCA59826783031B64F79"
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 15, 7, 17, 20, 630, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "Developer@gmail.com",
                            Gender = 0,
                            Name = "Developer",
                            Password = "3FB7B39416F1D067268747FC214494D759D2609F863ACE1A8A76705618D5C80B"
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            RoleId = 3,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Product", b =>
                {
                    b.HasOne("BS.DemoShop.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.ProductDetail", b =>
                {
                    b.HasOne("BS.DemoShop.Core.Entities.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.UserRole", b =>
                {
                    b.HasOne("BS.DemoShop.Core.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BS.DemoShop.Core.Entities.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Product", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BS.DemoShop.Core.Entities.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
