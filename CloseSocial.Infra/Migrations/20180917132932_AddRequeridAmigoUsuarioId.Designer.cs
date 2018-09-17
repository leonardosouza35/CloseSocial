﻿// <auto-generated />
using System;
using CloseSocial.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloseSocial.Infra.Data.Migrations
{
    [DbContext(typeof(CloseSocialContext))]
    [Migration("20180917132932_AddRequeridAmigoUsuarioId")]
    partial class AddRequeridAmigoUsuarioId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CloseSocial.Domain.Entities.Amigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioAmigoId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioAmigoId");

                    b.ToTable("Amigos");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<int?>("PostagemId");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("PostagemId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Postagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.Property<string>("UrlConteudo");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Sexo");

                    b.Property<string>("SobreNome");

                    b.Property<string>("UrlFoto");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Amigo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Amigos")
                        .HasForeignKey("UsuarioAmigoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Comentario", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Postagem")
                        .WithMany("Comentarios")
                        .HasForeignKey("PostagemId");

                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Postagem", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Postagens")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}