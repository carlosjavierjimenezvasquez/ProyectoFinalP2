﻿// <auto-generated />
using System;
using FastFoodRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FastFoodRestaurant.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211025221552_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Carrito", b =>
                {
                    b.Property<int>("carrito_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidadP")
                        .HasColumnType("int");

                    b.Property<int>("combo_FK")
                        .HasColumnType("int");

                    b.Property<int>("producto_Fk")
                        .HasColumnType("int");

                    b.Property<int>("usuario_FK")
                        .HasColumnType("int");

                    b.HasKey("carrito_id");

                    b.ToTable("tbl_Carrito");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Combo", b =>
                {
                    b.Property<int>("menu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codCombo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoCombo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCreacionC")
                        .HasColumnType("datetime2");

                    b.Property<int>("menu_Fk")
                        .HasColumnType("int");

                    b.Property<string>("nombreCombo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioC")
                        .HasColumnType("float");

                    b.Property<int?>("tbl_Menumenu_id")
                        .HasColumnType("int");

                    b.HasKey("menu_id");

                    b.HasIndex("tbl_Menumenu_id");

                    b.ToTable("tbl_Combo");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_DetalleCombo", b =>
                {
                    b.Property<int>("detalleCombo_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidadP")
                        .HasColumnType("int");

                    b.Property<int>("combo_FK")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("producto_Fk")
                        .HasColumnType("int");

                    b.HasKey("detalleCombo_id");

                    b.ToTable("tbl_DetalleCombo");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_DetalleOrden", b =>
                {
                    b.Property<int>("detalleOden_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("combo_FK")
                        .HasColumnType("int");

                    b.Property<int>("orden_FK")
                        .HasColumnType("int");

                    b.Property<int>("producto_Fk")
                        .HasColumnType("int");

                    b.Property<double>("totalFinal")
                        .HasColumnType("float");

                    b.HasKey("detalleOden_id");

                    b.ToTable("tbl_DetalleOrden");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Documento", b =>
                {
                    b.Property<int>("documento_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("documento_id");

                    b.ToTable("tbl_Documento");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Domicilio", b =>
                {
                    b.Property<int>("domicilio_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("domicilio_id");

                    b.ToTable("tbl_Domicilio");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Menu", b =>
                {
                    b.Property<int>("menu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreMenu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("menu_id");

                    b.ToTable("tbl_Menu");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_MetodoPago", b =>
                {
                    b.Property<int>("metodoPago_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreMetodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("metodoPago_id");

                    b.ToTable("tbl_MetodoPago");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Orden", b =>
                {
                    b.Property<int>("orden_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codOrden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("documento_Fk")
                        .HasColumnType("int");

                    b.Property<string>("estadoOrden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaOrden")
                        .HasColumnType("datetime2");

                    b.Property<int>("metodoPago_FK")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_Documentodocumento_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_MetodoPagometodoPago_id")
                        .HasColumnType("int");

                    b.Property<int>("user_FK")
                        .HasColumnType("int");

                    b.HasKey("orden_id");

                    b.HasIndex("tbl_Documentodocumento_id");

                    b.HasIndex("tbl_MetodoPagometodoPago_id");

                    b.ToTable("tbl_Orden");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Producto", b =>
                {
                    b.Property<int>("producto_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCreacionP")
                        .HasColumnType("datetime2");

                    b.Property<int>("menu_Fk")
                        .HasColumnType("int");

                    b.Property<string>("nombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioP")
                        .HasColumnType("float");

                    b.Property<int?>("tbl_Menumenu_id")
                        .HasColumnType("int");

                    b.HasKey("producto_id");

                    b.HasIndex("tbl_Menumenu_id");

                    b.ToTable("tbl_Producto");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_RolUsuario", b =>
                {
                    b.Property<int>("rol_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreRol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("rol_id");

                    b.ToTable("tbl_RolUsuarios");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_User", b =>
                {
                    b.Property<int>("usuario_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidoU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("domicilio_Fk")
                        .HasColumnType("int");

                    b.Property<string>("nombreU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rolUsuario_Fk")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_Domiciliodomicilio_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_RolUsuariorol_id")
                        .HasColumnType("int");

                    b.HasKey("usuario_id");

                    b.HasIndex("tbl_Domiciliodomicilio_id");

                    b.HasIndex("tbl_RolUsuariorol_id");

                    b.ToTable("tbl_User");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Combo", b =>
                {
                    b.HasOne("FastFoodRestaurant.Entidades.tbl_Menu", null)
                        .WithMany("tbl_Combo")
                        .HasForeignKey("tbl_Menumenu_id");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Orden", b =>
                {
                    b.HasOne("FastFoodRestaurant.Entidades.tbl_Documento", null)
                        .WithMany("tbl_Orden")
                        .HasForeignKey("tbl_Documentodocumento_id");

                    b.HasOne("FastFoodRestaurant.Entidades.tbl_MetodoPago", null)
                        .WithMany("tbl_Orden")
                        .HasForeignKey("tbl_MetodoPagometodoPago_id");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Producto", b =>
                {
                    b.HasOne("FastFoodRestaurant.Entidades.tbl_Menu", null)
                        .WithMany("tbl_Producto")
                        .HasForeignKey("tbl_Menumenu_id");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_User", b =>
                {
                    b.HasOne("FastFoodRestaurant.Entidades.tbl_Domicilio", null)
                        .WithMany("tbl_User")
                        .HasForeignKey("tbl_Domiciliodomicilio_id");

                    b.HasOne("FastFoodRestaurant.Entidades.tbl_RolUsuario", null)
                        .WithMany("tbl_User")
                        .HasForeignKey("tbl_RolUsuariorol_id");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Documento", b =>
                {
                    b.Navigation("tbl_Orden");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Domicilio", b =>
                {
                    b.Navigation("tbl_User");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_Menu", b =>
                {
                    b.Navigation("tbl_Combo");

                    b.Navigation("tbl_Producto");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_MetodoPago", b =>
                {
                    b.Navigation("tbl_Orden");
                });

            modelBuilder.Entity("FastFoodRestaurant.Entidades.tbl_RolUsuario", b =>
                {
                    b.Navigation("tbl_User");
                });
#pragma warning restore 612, 618
        }
    }
}
