using Microsoft.EntityFrameworkCore;
using Enceja.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Enceja.Domain.Entities;

namespace Enceja.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<Usuario, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Professor_Disciplina> Professores_Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Professor_Disciplina>()
            .HasKey(pd => new { pd.IdProfessor, pd.IdDisciplina });

            modelBuilder.Entity<Professor_Disciplina>()
            .HasOne(pd => pd.Professor)
            .WithMany(p => p.Professores_Disciplinas)
            .HasForeignKey(pd => pd.IdProfessor);

            modelBuilder.Entity<Professor_Disciplina>()
            .HasOne(pd => pd.Disciplina)
            .WithMany(d => d.Professores_Disciplinas)
            .HasForeignKey(pd => pd.IdDisciplina);
        }
    }
}
