﻿// <auto-generated />
using System;
using LojaSonhoDeCafe.Api.Banco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaSonhoDeCafe.Api.Migrations
{
    [DbContext(typeof(BancoDeDado))]
    [Migration("20240523174927_AddProdIdNoPagamentoDiario")]
    partial class AddProdIdNoPagamentoDiario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carrinhos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UsuarioId = "1"
                        },
                        new
                        {
                            Id = 2,
                            UsuarioId = "2"
                        });
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.CarrinhoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CarrinhoItens");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconeCss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconeCss = "fa-solid fa-wine-glass",
                            Nome = "Bebidas"
                        },
                        new
                        {
                            Id = 2,
                            IconeCss = "fa-solid fa-bread-slice",
                            Nome = "Salgados"
                        },
                        new
                        {
                            Id = 3,
                            IconeCss = "fa-solid fa-cake-candles",
                            Nome = "Doces"
                        },
                        new
                        {
                            Id = 4,
                            IconeCss = "fa-solid fa-burger",
                            Nome = "Lanches"
                        });
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.PagamentoDiario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EPagamento")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("HoraDoPagamento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrecoDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantDiaria")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("PagamentosDiarios");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsFavorito")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("QuantidadeEmEstoque")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2081115-6bdc-4031-9ce5-42e1654b989c"),
                            NomeUsuario = "David"
                        },
                        new
                        {
                            Id = new Guid("643466c7-4961-480c-8eb1-09f9c0c9a99e"),
                            NomeUsuario = "Adm"
                        });
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.CarrinhoItem", b =>
                {
                    b.HasOne("LojaSonhoDeCafe.Models.Entity.Carrinho", "Carrinho")
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LojaSonhoDeCafe.Models.Entity.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Produto", b =>
                {
                    b.HasOne("LojaSonhoDeCafe.Models.Entity.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Usuario", b =>
                {
                    b.HasOne("LojaSonhoDeCafe.Models.Entity.Carrinho", "Carrinho")
                        .WithMany()
                        .HasForeignKey("CarrinhoId");

                    b.Navigation("Carrinho");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Carrinho", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("LojaSonhoDeCafe.Models.Entity.Produto", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
