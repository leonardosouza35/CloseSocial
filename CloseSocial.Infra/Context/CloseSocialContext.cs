﻿using CloseSocial.Domain.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Infra.Data.Context
{
    public class CloseSocialContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }                
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        

        public CloseSocialContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new AmigoConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());            
            modelBuilder.ApplyConfiguration(new StatusRelacionamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ProcurandoPorConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacaoConfiguration());            
            modelBuilder.ApplyConfiguration(new TipoNotificacaoConfiguration());            

            base.OnModelCreating(modelBuilder); 
        }
      
    }
}
