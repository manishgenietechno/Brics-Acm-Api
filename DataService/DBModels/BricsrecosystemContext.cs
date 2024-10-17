using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataService.DBModels;

public partial class BricsrecosystemContext : DbContext
{
    public BricsrecosystemContext()
    {
    }

    public BricsrecosystemContext(DbContextOptions<BricsrecosystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apimaster> Apimasters { get; set; }

    public virtual DbSet<Hdfccorealertstaging> Hdfccorealertstagings { get; set; }

    public virtual DbSet<IcicialertNotification> IcicialertNotifications { get; set; }

    public virtual DbSet<Icicilog> Icicilogs { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DELL;Database=bricsrecosystem;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apimaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apimaste__3213E83F1C565787");

            entity.ToTable("apimaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apiname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apiname");
            entity.Property(e => e.Apitoken)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("apitoken");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("apiurl");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Secretkey)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("secretkey");
        });

        modelBuilder.Entity<Hdfccorealertstaging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hdfccore__3214EC0771248EEE");

            entity.ToTable("Hdfccorealertstaging");

            entity.Property(e => e.Accountnumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Alertsequenceno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Amount)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Chequeno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Debitcredit)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Mnemoniccode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remitteraccount)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remitterbank)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remitterifsc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remittername)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Requestdatetime).HasColumnType("datetime");
            entity.Property(e => e.Transactiondate)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Transactiondescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Userreferencenumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Valuedate)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Virtualaccount)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IcicialertNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__iciciale__3213E83FC19755FC");

            entity.ToTable("icicialertNotification");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountNumber");
            entity.Property(e => e.AlertSequenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alertSequenceNumber");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chequeNumber");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("createdOn");
            entity.Property(e => e.DebitCredit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("debitCredit");
            entity.Property(e => e.MnemonicCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mnemonicCode");
            entity.Property(e => e.RemitterAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remitterAccount");
            entity.Property(e => e.RemitterBank)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remitterBank");
            entity.Property(e => e.RemitterIfscCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remitterIfscCode");
            entity.Property(e => e.RemitterName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remitterName");
            entity.Property(e => e.TransactionDate)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("transactionDate");
            entity.Property(e => e.UserReferenceNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userReferenceNumber");
            entity.Property(e => e.ValueDate).HasColumnName("valueDate");
            entity.Property(e => e.VirtualAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("virtualAccount");
        });

        modelBuilder.Entity<Icicilog>(entity =>
        {
            entity.HasKey(e => e.Requestid).HasName("PK__icicilog__E3C6D2495976D5FA");

            entity.ToTable("icicilog");

            entity.Property(e => e.Requestid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("requestid");
            entity.Property(e => e.Encryptedbody)
                .HasColumnType("text")
                .HasColumnName("encryptedbody");
            entity.Property(e => e.Errorlog)
                .HasColumnType("text")
                .HasColumnName("errorlog");
            entity.Property(e => e.Logdatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("logdatetime");
            entity.Property(e => e.Plainbody)
                .HasColumnType("text")
                .HasColumnName("plainbody");
            entity.Property(e => e.Response)
                .HasColumnType("text")
                .HasColumnName("response");
            entity.Property(e => e.Sourceapiid).HasColumnName("sourceapiid");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Requestid).HasName("PK__Log__33AB5552C59245BF");

            entity.ToTable("Log");

            entity.Property(e => e.Requestid)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Encryptedbody).HasColumnType("text");
            entity.Property(e => e.Errorlog).HasColumnType("text");
            entity.Property(e => e.Logdatetime).HasColumnType("datetime");
            entity.Property(e => e.Plainbody).HasColumnType("text");
            entity.Property(e => e.Response).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
