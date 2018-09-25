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
    [Migration("20180925125829_NovasEtidades2")]
    partial class NovasEtidades2
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

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

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

            modelBuilder.Entity("CloseSocial.Domain.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UrlPhoto")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.InstituicaoEnsino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AnoFormacao");

                    b.Property<bool>("EstudandoAtualmente");

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InstituicaoEnsino");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.LocalTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAdmissao");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<bool>("EmpresaAtual");

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("LocalTrabalho");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.MembroGrupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GrupoId");

                    b.Property<int>("TipoMembroId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("TipoMembroId")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("MembrosGrupo");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Postagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<int?>("GrupoId");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.Property<string>("UrlConteudo");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.ProcurandoPor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("ProcurandoPor");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.StatusRelacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("StatusRelacionamento");

                    b.HasData(
                        new { Id = 1, Status = "NaoEspecificado" },
                        new { Id = 2, Status = "Solteiro" },
                        new { Id = 3, Status = "Casado" },
                        new { Id = 4, Status = "EmRelacionamentoSerio" }
                    );
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.TipoMembro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("MembrosGrupoId");

                    b.HasKey("Id");

                    b.ToTable("TiposMembro");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int?>("ProcurandoPorId");

                    b.Property<string>("Senha");

                    b.Property<int>("Sexo");

                    b.Property<string>("SobreNome");

                    b.Property<int?>("StatusRelacionamentoId");

                    b.Property<string>("UrlFoto");

                    b.HasKey("Id");

                    b.HasIndex("ProcurandoPorId");

                    b.HasIndex("StatusRelacionamentoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Amigo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Amigos")
                        .HasForeignKey("UsuarioId")
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

            modelBuilder.Entity("CloseSocial.Domain.Entities.Grupo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "CriadorGrupo")
                        .WithMany("Grupos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.InstituicaoEnsino", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("InstituicoesEnsino")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.LocalTrabalho", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("LocaisTrabalho")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.MembroGrupo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Grupo", "Grupo")
                        .WithMany("Membros")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CloseSocial.Domain.Entities.TipoMembro", "TipoMembro")
                        .WithOne("MembrosGrupo")
                        .HasForeignKey("CloseSocial.Domain.Entities.MembroGrupo", "TipoMembroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Postagem", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Grupo")
                        .WithMany("Postagens")
                        .HasForeignKey("GrupoId");

                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Postagens")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.ProcurandoPor", "ProcurandoPor")
                        .WithMany()
                        .HasForeignKey("ProcurandoPorId");

                    b.HasOne("CloseSocial.Domain.Entities.StatusRelacionamento", "StatusRelacionamento")
                        .WithMany()
                        .HasForeignKey("StatusRelacionamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}