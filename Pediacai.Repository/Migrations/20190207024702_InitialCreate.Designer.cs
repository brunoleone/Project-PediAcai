﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pediacai.Repository.Contexts;

namespace Pediacai.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190207024702_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Pediacai.Domain.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int?>("ItemId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Pediacai.Domain.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("SiteURL");

                    b.Property<string>("Telefone");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("Pediacai.Domain.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("InscricaoEstadual");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("PerfilId");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Pediacai.Domain.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LojaId");

                    b.Property<int>("QtdItens");

                    b.HasKey("Id");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Pediacai.Domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int?>("EstoqueId");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("Pediacai.Domain.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("Pediacai.Domain.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataEntrega");

                    b.Property<DateTime>("DataPedido");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Pediacai.Domain.PedidoLoja", b =>
                {
                    b.Property<int>("LojaId");

                    b.Property<int>("PedidoId");

                    b.Property<int>("Id");

                    b.HasKey("LojaId", "PedidoId");

                    b.ToTable("PedidoLoja");
                });

            modelBuilder.Entity("Pediacai.Domain.Perfil", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataUltimaModificacao");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Nome");

                    b.Property<string>("Sobrenome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Pediacai.Domain.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nome");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Token");

                    b.Property<DateTime>("UltimoAcesso");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Pediacai.Domain.Categoria", b =>
                {
                    b.HasOne("Pediacai.Domain.Item")
                        .WithMany("Categorias")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("Pediacai.Domain.Contato", b =>
                {
                    b.HasOne("Pediacai.Domain.Empresa")
                        .WithMany("Contatos")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("Pediacai.Domain.Empresa", b =>
                {
                    b.HasOne("Pediacai.Domain.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");
                });

            modelBuilder.Entity("Pediacai.Domain.Item", b =>
                {
                    b.HasOne("Pediacai.Domain.Estoque")
                        .WithMany("Itens")
                        .HasForeignKey("EstoqueId");
                });

            modelBuilder.Entity("Pediacai.Domain.Loja", b =>
                {
                    b.HasOne("Pediacai.Domain.Empresa")
                        .WithMany("Lojas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pediacai.Domain.Usuario", b =>
                {
                    b.HasOne("Pediacai.Domain.Empresa")
                        .WithMany("Usuarios")
                        .HasForeignKey("EmpresaId");
                });
#pragma warning restore 612, 618
        }
    }
}
