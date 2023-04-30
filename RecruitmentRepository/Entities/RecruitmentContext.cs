using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RecruitmentRepository.Entities
{
    public partial class RecruitmentContext : DbContext
    {
        public RecruitmentContext()
        {
        }

        public RecruitmentContext(DbContextOptions<RecruitmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<KnowledgeForWorker> KnowledgeForWorkers { get; set; }
        public virtual DbSet<Llanguage> Llanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-UNOI3OU0\\MSSQLSERVER01;Database=Recruitment ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("candidate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CandidateName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("candidateName");

                entity.Property(e => e.LastUpdateDetails)
                    .HasColumnType("date")
                    .HasColumnName("lastUpdateDetails");

                entity.Property(e => e.YearOfStartWork).HasColumnName("yearOfStartWork");
            });

            modelBuilder.Entity<KnowledgeForWorker>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.LanguageId })
                    .HasName("PK__knowledg__45113222DAAC2CD9");

                entity.ToTable("knowledgeForWorker");

                entity.Property(e => e.CandidateId).HasColumnName("candidateId");

                entity.Property(e => e.LanguageId).HasColumnName("languageId");

                entity.Property(e => e.KnowledgeLevel).HasColumnName("knowledgeLevel");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.KnowledgeForWorkers)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__knowledge__candi__286302EC");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.KnowledgeForWorkers)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__knowledge__langu__29572725");
            });

            modelBuilder.Entity<Llanguage>(entity =>
            {
                entity.ToTable("llanguage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("languageName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
