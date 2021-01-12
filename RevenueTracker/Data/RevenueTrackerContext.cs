using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class RevenueTrackerContext : DbContext
    {
        public RevenueTrackerContext(DbContextOptions<RevenueTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblClientAgreementMaster> TblClientAgreementMasters { get; set; }
        public virtual DbSet<TblClientContactMaster> TblClientContactMasters { get; set; }
        public virtual DbSet<TblClientMaster> TblClientMasters { get; set; }
        public virtual DbSet<TblCompanyMaster> TblCompanyMasters { get; set; }
        public virtual DbSet<TblCountryMaster> TblCountryMasters { get; set; }
        public virtual DbSet<TblCurrencyMaster> TblCurrencyMasters { get; set; }
        public virtual DbSet<TblDivisionMaster> TblDivisionMasters { get; set; }
        public virtual DbSet<TblOrganizationMaster> TblOrganizationMasters { get; set; }
        public virtual DbSet<TblPaymentModeMaster> TblPaymentModeMasters { get; set; }
        public virtual DbSet<TblPracticeMaster> TblPracticeMasters { get; set; }
        public virtual DbSet<TblProjectMaster> TblProjectMasters { get; set; }
        public virtual DbSet<TblProjectPaymentDetail> TblProjectPaymentDetails { get; set; }
        public virtual DbSet<TblProjectTypeMaster> TblProjectTypeMasters { get; set; }
        public virtual DbSet<TblRevenueTargetMaster> TblRevenueTargetMasters { get; set; }
        public virtual DbSet<TblStateMaster> TblStateMasters { get; set; }
        public virtual DbSet<TblTaxTypeMaster> TblTaxTypeMasters { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=HOSADURGA\\SQLEXPRESS;Initial Catalog=RevenueTracker;Integrated Security=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblClientAgreementMaster>(entity =>
            {
                entity.ToTable("tbl_ClientAgreementMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblClientContactMaster>(entity =>
            {
                entity.ToTable("tbl_ClientContactMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblClientMaster>(entity =>
            {
                entity.ToTable("tbl_ClientMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCompanyMaster>(entity =>
            {
                entity.ToTable("tbl_CompanyMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCountryMaster>(entity =>
            {
                entity.ToTable("tbl_CountryMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCurrencyMaster>(entity =>
            {
                entity.ToTable("tbl_CurrencyMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDivisionMaster>(entity =>
            {
                entity.ToTable("tbl_DivisionMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOrganizationMaster>(entity =>
            {
                entity.ToTable("tbl_OrganizationMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(1024);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPaymentModeMaster>(entity =>
            {
                entity.ToTable("tbl_PaymentModeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPracticeMaster>(entity =>
            {
                entity.ToTable("tbl_PracticeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblProjectMaster>(entity =>
            {
                entity.ToTable("tbl_ProjectMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectEndDate).HasColumnType("date");

                entity.Property(e => e.ProjectStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Project StartDate");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblProjectPaymentDetail>(entity =>
            {
                entity.ToTable("tbl_ProjectPaymentDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblProjectTypeMaster>(entity =>
            {
                entity.ToTable("tbl_ProjectTypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRevenueTargetMaster>(entity =>
            {
                entity.ToTable("tbl_RevenueTargetMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConversionRate)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.FinancialYearEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("FinancialYearEND");

                entity.Property(e => e.FinancialYearStart).HasColumnType("datetime");

                entity.Property(e => e.TargetAmount)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblStateMaster>(entity =>
            {
                entity.ToTable("tbl_StateMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTaxTypeMaster>(entity =>
            {
                entity.ToTable("tbl_TaxTypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
