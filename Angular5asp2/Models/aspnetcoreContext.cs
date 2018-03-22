using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular5asp2.Models
{
    public partial class aspnetcoreContext : DbContext
    {
        public virtual DbSet<AdRole> AdRole { get; set; }
        public virtual DbSet<AdUser> AdUser { get; set; }

        public aspnetcoreContext(DbContextOptions<aspnetcoreContext> options)
                   : base(options)
        { }

        public aspnetcoreContext()
           : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(PublicFunction.connectstring);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdRole>(entity =>
            {
                entity.ToTable("ad_role");

                entity.Property(e => e.AdRoleId)
                    .HasColumnName("ad_role_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Createby)
                    .HasColumnName("createby")
                    .HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rolecode)
                    .HasColumnName("rolecode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(150);

                entity.Property(e => e.Updateby)
                    .HasColumnName("updateby")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AdUser>(entity =>
            {
                entity.ToTable("ad_user");

                entity.Property(e => e.AdUserId)
                    .HasColumnName("ad_user_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AdRoleId)
                    .HasColumnName("ad_role_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(150);

                entity.Property(e => e.BackgroundLayout)
                    .HasColumnName("background_layout")
                    .HasMaxLength(150);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(150);

                entity.Property(e => e.Createby)
                    .HasColumnName("createby")
                    .HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(150);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(5);

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(150);

                entity.Property(e => e.Marital)
                    .HasColumnName("marital")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Skype)
                    .HasColumnName("skype")
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updateby)
                    .HasColumnName("updateby")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usercode)
                    .HasColumnName("usercode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(150);
            });
        }
    }
}
