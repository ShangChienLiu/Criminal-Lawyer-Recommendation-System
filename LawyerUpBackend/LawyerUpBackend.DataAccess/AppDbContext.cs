using LawyerUpBackend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.DataAccess
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<Case> Cases { get; set; } = null!;
        public virtual DbSet<Lawyer> Lawyers { get; set; } = null!;
        public virtual DbSet<LawyerCaseMatch> LawyerCaseMatches { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;database=LawyerUP_1.0;Trusted_Connection=true");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeforeMain).HasColumnName("before_main");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .HasColumnName("classification");

                entity.Property(e => e.CourtCode)
                    .HasMaxLength(20)
                    .HasColumnName("court_code");

                entity.Property(e => e.DetailUrl)
                    .HasMaxLength(300)
                    .HasColumnName("detail_url");

                entity.Property(e => e.FactReason).HasColumnName("fact_reason");

                entity.Property(e => e.JudgeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("judge_date");

                entity.Property(e => e.MainContent).HasColumnName("main_content");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.Word)
                    .HasMaxLength(10)
                    .HasColumnName("word");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Lawyer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .HasColumnName("addr");

                entity.Property(e => e.Birthyear).HasColumnName("birthyear");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Guild_name)
                    .HasMaxLength(100)
                    .HasColumnName("guild_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Now_lic_no)
                    .HasMaxLength(100)
                    .HasColumnName("now_lic_no");

                entity.Property(e => e.Office)
                    .HasMaxLength(100)
                    .HasColumnName("office");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.Tel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tel");

            });

            modelBuilder.Entity<LawyerCaseMatch>(entity =>
            {
                entity.ToTable("Lawyer_Case_match");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.LawyerId).HasColumnName("lawyer_id");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.LawyerCaseMatches)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lawyer_Ca__case___3D5E1FD2");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.LawyerCaseMatches)
                    .HasForeignKey(d => d.LawyerId)
                    .HasConstraintName("FK__Lawyer_Ca__lawye__3E52440B");
            });

            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

