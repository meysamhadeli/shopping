﻿// <auto-generated />
using System;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    partial class ECommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Categories.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("ECommerce.Customers.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("ECommerce.Inventories.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Inventory", (string)null);
                });

            modelBuilder.Entity("ECommerce.Inventories.Models.InventoryItems", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("InStock");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("InventoryItems", (string)null);
                });

            modelBuilder.Entity("ECommerce.Orders.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Pending");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("ECommerce.Orders.Models.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("ECommerce.Products.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsBreakable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("ECommerce.Categories.Models.Category", b =>
                {
                    b.OwnsOne("ECommerce.Categories.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("CategoryId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("character varying(50)")
                                .HasColumnName("Name");

                            b1.HasKey("CategoryId");

                            b1.ToTable("Category");

                            b1.WithOwner()
                                .HasForeignKey("CategoryId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("ECommerce.Customers.Models.Customer", b =>
                {
                    b.OwnsOne("ECommerce.Customers.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Address");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsOne("ECommerce.Customers.ValueObjects.Mobile", "Mobile", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Mobile");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsOne("ECommerce.Customers.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Name");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.Navigation("Address");

                    b.Navigation("Mobile");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("ECommerce.Inventories.Models.Inventory", b =>
                {
                    b.OwnsOne("ECommerce.Inventories.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("InventoryId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("character varying(50)")
                                .HasColumnName("Name");

                            b1.HasKey("InventoryId");

                            b1.ToTable("Inventory");

                            b1.WithOwner()
                                .HasForeignKey("InventoryId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("ECommerce.Inventories.Models.InventoryItems", b =>
                {
                    b.HasOne("ECommerce.Inventories.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId");

                    b.HasOne("ECommerce.Products.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.OwnsOne("ECommerce.Inventories.ValueObjects.Quantity", "Quantity", b1 =>
                        {
                            b1.Property<Guid>("InventoryItemsId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Value")
                                .HasMaxLength(20)
                                .HasColumnType("integer")
                                .HasColumnName("Quantity");

                            b1.HasKey("InventoryItemsId");

                            b1.ToTable("InventoryItems");

                            b1.WithOwner()
                                .HasForeignKey("InventoryItemsId");
                        });

                    b.Navigation("Inventory");

                    b.Navigation("Product");

                    b.Navigation("Quantity");
                });

            modelBuilder.Entity("ECommerce.Orders.Models.Order", b =>
                {
                    b.HasOne("ECommerce.Customers.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.OwnsOne("ECommerce.Orders.ValueObjects.OrderDate", "OrderDate", b1 =>
                        {
                            b1.Property<Guid>("OrderId")
                                .HasColumnType("uuid");

                            b1.Property<DateTime>("Value")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("OrderDate");

                            b1.HasKey("OrderId");

                            b1.ToTable("Order");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsOne("ECommerce.Orders.ValueObjects.TotalPrice", "TotalPrice", b1 =>
                        {
                            b1.Property<Guid>("OrderId")
                                .HasColumnType("uuid");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TotalPrice");

                            b1.HasKey("OrderId");

                            b1.ToTable("Order");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("Customer");

                    b.Navigation("OrderDate");

                    b.Navigation("TotalPrice");
                });

            modelBuilder.Entity("ECommerce.Orders.Models.OrderItem", b =>
                {
                    b.HasOne("ECommerce.Orders.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("ECommerce.Products.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.OwnsOne("ECommerce.Orders.ValueObjects.Quantity", "Quantity", b1 =>
                        {
                            b1.Property<Guid>("OrderItemId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Value")
                                .HasColumnType("integer")
                                .HasColumnName("Quantity");

                            b1.HasKey("OrderItemId");

                            b1.ToTable("OrderItem");

                            b1.WithOwner()
                                .HasForeignKey("OrderItemId");
                        });

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Quantity");
                });

            modelBuilder.Entity("ECommerce.Products.Models.Product", b =>
                {
                    b.HasOne("ECommerce.Categories.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.OwnsOne("ECommerce.Products.ValueObjects.Barcode", "Barcode", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("Barcode");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ECommerce.Products.ValueObjects.Description", "Description", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("Description");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ECommerce.Products.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("character varying(50)")
                                .HasColumnName("Name");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ECommerce.Products.ValueObjects.NetPrice", "NetPrice", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("NetPrice");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ECommerce.Products.ValueObjects.Price", "Price", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Price");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ECommerce.Products.ValueObjects.ProfitMargin", "ProfitMargin", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("ProfitMargin");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Barcode");

                    b.Navigation("Category");

                    b.Navigation("Description");

                    b.Navigation("Name");

                    b.Navigation("NetPrice");

                    b.Navigation("Price");

                    b.Navigation("ProfitMargin");
                });
#pragma warning restore 612, 618
        }
    }
}