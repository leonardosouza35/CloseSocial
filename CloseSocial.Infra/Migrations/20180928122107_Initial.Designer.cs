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
    [Migration("20180928122107_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CloseSocial.Domain.Entities.Amigo", b =>
                {
                    b.Property<int>("UsuarioId");

                    b.Property<int>("UsuarioAmigoId");

                    b.HasKey("UsuarioId", "UsuarioAmigoId");

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

                    b.HasKey("Id");

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

            modelBuilder.Entity("CloseSocial.Domain.Entities.Notificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TipoNotificacaoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("TipoNotificacaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Notificacoes");
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

                    b.HasData(
                        new { Id = 1, Descricao = "NaoEspecificado" },
                        new { Id = 2, Descricao = "Namoro" },
                        new { Id = 3, Descricao = "Amizade" },
                        new { Id = 4, Descricao = "RelacionamentoSerio" }
                    );
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

            modelBuilder.Entity("CloseSocial.Domain.Entities.TipoNotificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("TipoNotificacao");

                    b.HasData(
                        new { Id = 1, Descricao = "AniversarioAmigo" },
                        new { Id = 2, Descricao = "SolicitacaoAmizade" }
                    );
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

            modelBuilder.Entity("CloseSocial.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.Property<int>("UsuarioId");

                    b.Property<int>("GrupoId");

                    b.Property<DateTime?>("DataCriacao");

                    b.Property<bool>("EhAdministrador");

                    b.HasKey("UsuarioId", "GrupoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("UsuarioGrupo");
                });

            modelBuilder.Entity("CloseSocial.Domain.Entities.Amigo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "UsuarioAmigo")
                        .WithMany()
                        .HasForeignKey("UsuarioAmigoId")
                        .OnDelete(DeleteBehavior.Cascade);

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

            modelBuilder.Entity("CloseSocial.Domain.Entities.Notificacao", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.TipoNotificacao", "TipoNotificacao")
                        .WithMany()
                        .HasForeignKey("TipoNotificacaoId");

                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Notificacoes")
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

            modelBuilder.Entity("CloseSocial.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.HasOne("CloseSocial.Domain.Entities.Grupo", "Grupo")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CloseSocial.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
