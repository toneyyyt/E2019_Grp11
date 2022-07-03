using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Business
{
    public partial class AppDb : DbContext
    {
        public AppDb()
            : base("name=AppDb")
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MensDate> MensDates { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>()
                .Property(e => e.MenstrualFlow)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Moods)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Symptoms)
                .IsUnicode(false);

            modelBuilder.Entity<MensDate>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<MensDate>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<MensDate>()
                .Property(e => e.DoctorRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountUserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountEmail)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountType)
                .IsUnicode(false);
        }
    }
}
