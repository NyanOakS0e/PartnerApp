using System;
using System.Collections.Generic;
using Eagle.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Eagle.Api.Context;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Erefill;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;User Id=sa;Password=sasa@123;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SystemUser>(entity =>
        {
            entity.ToTable("SystemUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchGuid).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasMaxLength(50);
            entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            entity.Property(e => e.DepartmentGuid)
                .HasMaxLength(50)
                .HasColumnName("DepartmentGUID");
            entity.Property(e => e.EndTime).HasMaxLength(200);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.RoleCode).HasMaxLength(50);
            entity.Property(e => e.RoleGuid)
                .HasMaxLength(50)
                .HasColumnName("RoleGUID");
            entity.Property(e => e.StartTime).HasMaxLength(200);
            entity.Property(e => e.SystemUserCode).HasMaxLength(50);
            entity.Property(e => e.SystemUserName).HasMaxLength(50);
            entity.Property(e => e.SystemUserType).HasMaxLength(50);
            entity.Property(e => e.Theme).HasMaxLength(50);
            entity.Property(e => e.UpDatedBy).HasMaxLength(50);
            entity.Property(e => e.UpDatedDate).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
