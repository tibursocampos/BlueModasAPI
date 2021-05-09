﻿// <auto-generated />
using BlueModas.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlueModas.Persistence.Migrations
{
    [DbContext(typeof(BlueModasContext))]
    [Migration("20210509125812_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlueModas.Domain.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("OrderId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "raphael@teste.com",
                            Name = "Raphael",
                            Phone = "(35) 98811-1492"
                        },
                        new
                        {
                            Id = 2,
                            Email = "aantonellasarahcristianearaujo@yahool.com",
                            Name = "Antonella Sarah Cristiane Araújo",
                            Phone = "(12) 99982-6766"
                        },
                        new
                        {
                            Id = 3,
                            Email = "cesarmurilomoreira..cesarmurilomoreira@ornatopresentes.com.br",
                            Name = "César Murilo Moreira",
                            Phone = "(82) 98635-7667"
                        },
                        new
                        {
                            Id = 4,
                            Email = "emanuellyclaudiadias..emanuellyclaudiadias@osbocops.com",
                            Name = "Emanuelly Cláudia Dias",
                            Phone = "(27) 98498-9488"
                        },
                        new
                        {
                            Id = 5,
                            Email = "iandavidanielfarias__iandavidanielfarias@silnave.com.br",
                            Name = "Ian Davi Daniel Farias",
                            Phone = "(21) 98907-0282"
                        },
                        new
                        {
                            Id = 6,
                            Email = "camilateresinhadamata-72@bds.com.br",
                            Name = "Camila Teresinha da Mata",
                            Phone = "(89) 98901-1497"
                        });
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100,
                            Category = 1,
                            Description = "Camiseta casual com tecido leve",
                            Gender = 1,
                            Name = "Camiseta Preta",
                            Price = 20.5,
                            Size = 3
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100,
                            Category = 1,
                            Description = "Camiseta casual com tecido leve",
                            Gender = 2,
                            Name = "Camiseta Preta",
                            Price = 25.0,
                            Size = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 100,
                            Category = 1,
                            Description = "Camiseta casual com tecido leve",
                            Gender = 1,
                            Name = "Camiseta Vermelha",
                            Price = 30.0,
                            Size = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 100,
                            Category = 1,
                            Description = "Camiseta casual com tecido leve",
                            Gender = 2,
                            Name = "Camiseta Rosa",
                            Price = 30.0,
                            Size = 1
                        },
                        new
                        {
                            Id = 5,
                            Amount = 100,
                            Category = 2,
                            Description = "Camisa social de algodão",
                            Gender = 1,
                            Name = "Camisa Preta",
                            Price = 60.0,
                            Size = 4
                        },
                        new
                        {
                            Id = 6,
                            Amount = 100,
                            Category = 2,
                            Description = "Camisa social de algodão",
                            Gender = 1,
                            Name = "Camisa Preta",
                            Price = 60.0,
                            Size = 3
                        },
                        new
                        {
                            Id = 7,
                            Amount = 100,
                            Category = 3,
                            Description = "Calça jeans",
                            Gender = 2,
                            Name = "Calça Branca",
                            Price = 110.5,
                            Size = 2
                        },
                        new
                        {
                            Id = 8,
                            Amount = 100,
                            Category = 3,
                            Description = "Calça jeans",
                            Gender = 1,
                            Name = "Calça Preta",
                            Price = 110.5,
                            Size = 3
                        },
                        new
                        {
                            Id = 9,
                            Amount = 100,
                            Category = 4,
                            Description = "Bermuda jeans",
                            Gender = 2,
                            Name = "Bermuda Azul",
                            Price = 40.0,
                            Size = 3
                        },
                        new
                        {
                            Id = 10,
                            Amount = 100,
                            Category = 4,
                            Description = "Bermuda tactel",
                            Gender = 1,
                            Name = "Bermuda Preta",
                            Price = 30.0,
                            Size = 4
                        });
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CartsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Cart", b =>
                {
                    b.HasOne("BlueModas.Domain.Entities.Client", "Client")
                        .WithMany("Carts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueModas.Domain.Entities.Order", "Order")
                        .WithMany("Carts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Order", b =>
                {
                    b.HasOne("BlueModas.Domain.Entities.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("BlueModas.Domain.Entities.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueModas.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Client", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BlueModas.Domain.Entities.Order", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
