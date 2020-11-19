using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UmsAppconfig> UmsAppconfig { get; set; }
        public virtual DbSet<UmsAuthque> UmsAuthque { get; set; }
        public virtual DbSet<UmsAuthquedetail> UmsAuthquedetail { get; set; }
        public virtual DbSet<UmsCategory> UmsCategory { get; set; }
        public virtual DbSet<UmsFeatureconfig> UmsFeatureconfig { get; set; }
        public virtual DbSet<UmsLoginfailuretemp> UmsLoginfailuretemp { get; set; }
        public virtual DbSet<UmsMenu> UmsMenu { get; set; }
        public virtual DbSet<UmsModuleconfig> UmsModuleconfig { get; set; }
        public virtual DbSet<UmsNotification> UmsNotification { get; set; }
        public virtual DbSet<UmsNotificationAssign> UmsNotificationAssign { get; set; }
        public virtual DbSet<UmsNotificationType> UmsNotificationType { get; set; }
        public virtual DbSet<UmsNotificationdetail> UmsNotificationdetail { get; set; }
        public virtual DbSet<UmsPass> UmsPass { get; set; }
        public virtual DbSet<UmsPasspolicy> UmsPasspolicy { get; set; }
        public virtual DbSet<UmsReporting> UmsReporting { get; set; }
        public virtual DbSet<UmsReportparameter> UmsReportparameter { get; set; }
        public virtual DbSet<UmsReportpermission> UmsReportpermission { get; set; }
        public virtual DbSet<UmsRole> UmsRole { get; set; }
        public virtual DbSet<UmsRoleassign> UmsRoleassign { get; set; }
        public virtual DbSet<UmsRoledtl> UmsRoledtl { get; set; }
        public virtual DbSet<UmsUserfavorite> UmsUserfavorite { get; set; }
        public virtual DbSet<UmsUserinfo> UmsUserinfo { get; set; }
        public virtual DbSet<UmsUsersession> UmsUsersession { get; set; }
        public virtual DbSet<UmsUsersessionlog> UmsUsersessionlog { get; set; }
        public virtual DbSet<VwReportpermission> VwReportpermission { get; set; }
        public virtual DbSet<VwRoleassign> VwRoleassign { get; set; }
        public virtual DbSet<VwRoledetails> VwRoledetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("User Id=UMS;Password=UMS;Data Source=10.11.201.42:1521/XE;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "UMS");

            modelBuilder.Entity<UmsAppconfig>(entity =>
            {
                entity.HasKey(e => e.Appid);

                entity.ToTable("UMS_APPCONFIG");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appconfid)
                    .HasColumnName("APPCONFID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Framework)
                    .IsRequired()
                    .HasColumnName("FRAMEWORK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnName("PLATFORM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasColumnName("PURPOSE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UmsAuthque>(entity =>
            {
                entity.HasKey(e => e.Authqueid);

                entity.ToTable("UMS_AUTHQUE");

                entity.Property(e => e.Authqueid).HasColumnName("AUTHQUEID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("ACTION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Appauthlevel).HasColumnName("APPAUTHLEVEL");

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .IsRequired()
                    .HasColumnName("ENTRYDATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Featureid)
                    .IsRequired()
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Isauthcancel)
                    .IsRequired()
                    .HasColumnName("ISAUTHCANCEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.Maxauthlevel).HasColumnName("MAXAUTHLEVEL");

                entity.Property(e => e.Moduleid)
                    .IsRequired()
                    .HasColumnName("MODULEID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Newrecord)
                    .HasColumnName("NEWRECORD")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Oldrecord)
                    .HasColumnName("OLDRECORD")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Oldstatus)
                    .HasColumnName("OLDSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pkvalue)
                    .IsRequired()
                    .HasColumnName("PKVALUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasColumnName("TABLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urllink)
                    .HasColumnName("URLLINK")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsAuthque)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_AUTHQUE_UMS_APPCONFIG");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.UmsAuthque)
                    .HasForeignKey(d => d.Featureid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_AUTHQUE_UMS_FEATURECONF");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UmsAuthque)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_AUTHQUE_UMS_MODULECONFI");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsAuthque)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERID");
            });

            modelBuilder.Entity<UmsAuthquedetail>(entity =>
            {
                entity.HasKey(e => e.Authquedtlid);

                entity.ToTable("UMS_AUTHQUEDETAIL");

                entity.Property(e => e.Authquedtlid).HasColumnName("AUTHQUEDTLID");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Authaction)
                    .IsRequired()
                    .HasColumnName("AUTHACTION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Authqueid).HasColumnName("AUTHQUEID");

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Authque)
                    .WithMany(p => p.UmsAuthquedetail)
                    .HasForeignKey(d => d.Authqueid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_AUTHQUEDETAIL_UMS_AUTHQ");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsAuthquedetail)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_AUTHQUEDETAIL_USERID");
            });

            modelBuilder.Entity<UmsCategory>(entity =>
            {
                entity.HasKey(e => e.Categoryid);

                entity.ToTable("UMS_CATEGORY");

                entity.HasIndex(e => e.Categoryname)
                    .HasName("UK_UMS_CATEGORY")
                    .IsUnique();

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("CATEGORYNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'P'");
            });

            modelBuilder.Entity<UmsFeatureconfig>(entity =>
            {
                entity.HasKey(e => e.Featureid);

                entity.ToTable("UMS_FEATURECONFIG");

                entity.Property(e => e.Featureid)
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authlevel).HasColumnName("AUTHLEVEL");

                entity.Property(e => e.Authyn)
                    .IsRequired()
                    .HasColumnName("AUTHYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cancelyn)
                    .IsRequired()
                    .HasColumnName("CANCELYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Createyn)
                    .IsRequired()
                    .HasColumnName("CREATEYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dataset)
                    .HasColumnName("DATASET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edityn)
                    .IsRequired()
                    .HasColumnName("EDITYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Featureconfid)
                    .HasColumnName("FEATURECONFID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Featuretype).HasColumnName("FEATURETYPE");

                entity.Property(e => e.Mfa)
                    .IsRequired()
                    .HasColumnName("MFA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid)
                    .IsRequired()
                    .HasColumnName("MODULEID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .IsRequired()
                    .HasColumnName("OTP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasColumnName("PURPOSE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Reportaction)
                    .HasColumnName("REPORTACTION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reportpath)
                    .HasColumnName("REPORTPATH")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Viewdetailyn)
                    .IsRequired()
                    .HasColumnName("VIEWDETAILYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsFeatureconfig)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_FEATURECONFIG_UMS_APPCO");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UmsFeatureconfig)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_FEATURECONFIG_UMS_MODUL");
            });

            modelBuilder.Entity<UmsLoginfailuretemp>(entity =>
            {
                entity.ToTable("UMS_LOGINFAILURETEMP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPADDRESS")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Logindatetime)
                    .HasColumnName("LOGINDATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsLoginfailuretemp)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_UMS_LOGINFAILURETEMP_UMS_US");
            });

            modelBuilder.Entity<UmsMenu>(entity =>
            {
                entity.HasKey(e => e.Menuid);

                entity.ToTable("UMS_MENU");

                entity.Property(e => e.Menuid).HasColumnName("MENUID");

                entity.Property(e => e.Menufeatureid)
                    .HasColumnName("MENUFEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Menulocation)
                    .HasColumnName("MENULOCATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname)
                    .HasColumnName("MENUNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Menusequence).HasColumnName("MENUSEQUENCE");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)");

                entity.HasOne(d => d.Menufeature)
                    .WithMany(p => p.UmsMenu)
                    .HasForeignKey(d => d.Menufeatureid)
                    .HasConstraintName("FK_UMS_MENU_UMS_FEATURECONFIG");
            });

            modelBuilder.Entity<UmsModuleconfig>(entity =>
            {
                entity.HasKey(e => e.Moduleid);

                entity.ToTable("UMS_MODULECONFIG");

                entity.HasIndex(e => new { e.Name, e.Appid })
                    .HasName("UK1_UMS_MODULECONFIG")
                    .IsUnique();

                entity.Property(e => e.Moduleid)
                    .HasColumnName("MODULEID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Imagepath)
                    .HasColumnName("IMAGEPATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleconfid)
                    .HasColumnName("MODULECONFID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasColumnName("PURPOSE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsModuleconfig)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_MODULECONFIG_UMS_APPCON");
            });

            modelBuilder.Entity<UmsNotification>(entity =>
            {
                entity.HasKey(e => e.Notificationid);

                entity.ToTable("UMS_NOTIFICATION");

                entity.Property(e => e.Notificationid)
                    .HasColumnName("NOTIFICATIONID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("ENTRYDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Featureid)
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Messagedesc)
                    .HasColumnName("MESSAGEDESC")
                    .HasColumnType("NCLOB");

                entity.Property(e => e.NotificationMaker)
                    .HasColumnName("NOTIFICATION_MAKER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("NOTIFICATION_TYPE_ID")
                    .HasColumnType("NUMBER(6)");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasColumnType("NCLOB");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsNotification)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_NOTIFICATION_UMS_APPCON");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.UmsNotification)
                    .HasForeignKey(d => d.Featureid)
                    .HasConstraintName("FK_UMS_NOTIFICATION_UMS_FEATUR");
            });

            modelBuilder.Entity<UmsNotificationAssign>(entity =>
            {
                entity.HasKey(e => e.NotificationAssignId)
                    .HasName("UMS_NOTIFICATION_ASSIGN_PK");

                entity.ToTable("UMS_NOTIFICATION_ASSIGN");

                entity.Property(e => e.NotificationAssignId)
                    .HasColumnName("NOTIFICATION_ASSIGN_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.InvestigationUserId)
                    .HasColumnName("INVESTIGATION_USER_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("NOTIFICATION_TYPE_ID")
                    .HasColumnType("NUMBER(6)");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'                   ");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.UserTypeId).HasColumnName("USER_TYPE_ID");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.UmsNotificationAssign)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("NOTIFICATION_ID_ASSIGN_PK");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.UmsNotificationAssign)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTIFICATION_ASSIGN_TYPE");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmsNotificationAssign)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLE_NOTIFICATION_ASS_ROLE");
            });

            modelBuilder.Entity<UmsNotificationType>(entity =>
            {
                entity.HasKey(e => e.NotificationTypeId)
                    .HasName("UMS_NOTIFICATION_TYPE_PK");

                entity.ToTable("UMS_NOTIFICATION_TYPE");

                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("NOTIFICATION_TYPE_ID")
                    .HasColumnType("NUMBER(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("APP_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'                   ");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsNotificationType)
                    .HasForeignKey(d => d.AppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UMS_APP_NOTIFICATION_TYPE_FK");
            });

            modelBuilder.Entity<UmsNotificationdetail>(entity =>
            {
                entity.ToTable("UMS_NOTIFICATIONDETAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notificationid).HasColumnName("NOTIFICATIONID");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.UmsNotificationdetail)
                    .HasForeignKey(d => d.Notificationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTIFICATIONDETAIL_UMS_NOTI");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsNotificationdetail)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTIFICATIONDETAIL_UMS_USER");
            });

            modelBuilder.Entity<UmsPass>(entity =>
            {
                entity.HasKey(e => e.Passid);

                entity.ToTable("UMS_PASS");

                entity.Property(e => e.Passid).HasColumnName("PASSID");

                entity.Property(e => e.Createdate)
                    .HasColumnName("CREATEDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("EXPIREDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasColumnName("USERPASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsPass)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_PASS_UMS_USERINFO");
            });

            modelBuilder.Entity<UmsPasspolicy>(entity =>
            {
                entity.HasKey(e => e.Passpolicyid)
                    .HasName("PK_UMS_PWD_POLICY");

                entity.ToTable("UMS_PASSPOLICY");

                entity.Property(e => e.Passpolicyid).HasColumnName("PASSPOLICYID");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Expireafter)
                    .HasColumnName("EXPIREAFTER")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.Islowercase)
                    .IsRequired()
                    .HasColumnName("ISLOWERCASE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Isspecialchar)
                    .IsRequired()
                    .HasColumnName("ISSPECIALCHAR")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Isuppercase)
                    .IsRequired()
                    .HasColumnName("ISUPPERCASE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Maxlength)
                    .HasColumnName("MAXLENGTH")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Minlength)
                    .HasColumnName("MINLENGTH")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Reuse)
                    .HasColumnName("REUSE")
                    .HasColumnType("NUMBER(8)");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsPasspolicy)
                    .HasForeignKey(d => d.Appid)
                    .HasConstraintName("FK_UMS_PASSPOLICY_APPID");
            });

            modelBuilder.Entity<UmsReporting>(entity =>
            {
                entity.HasKey(e => e.Reportingid)
                    .HasName("PK_REPORTING");

                entity.ToTable("UMS_REPORTING");

                entity.Property(e => e.Reportingid)
                    .HasColumnName("REPORTINGID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Dataset)
                    .HasColumnName("DATASET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("ENTRYDATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("LASTUPDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Level1)
                    .HasColumnName("LEVEL1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Level2)
                    .HasColumnName("LEVEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Level3)
                    .HasColumnName("LEVEL3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Reportaction)
                    .HasColumnName("REPORTACTION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reportlevel)
                    .HasColumnName("REPORTLEVEL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Reportname)
                    .HasColumnName("REPORTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reportpath)
                    .HasColumnName("REPORTPATH")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Slno)
                    .HasColumnName("SLNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UmsReportparameter>(entity =>
            {
                entity.HasKey(e => e.Reportparameterid)
                    .HasName("PK_REPORTPARAMETER");

                entity.ToTable("UMS_REPORTPARAMETER");

                entity.Property(e => e.Reportparameterid).HasColumnName("REPORTPARAMETERID");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Featureid)
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Levelname)
                    .HasColumnName("LEVELNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parametername)
                    .HasColumnName("PARAMETERNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.UmsReportparameter)
                    .HasForeignKey(d => d.Featureid)
                    .HasConstraintName("FK_UMS_REPORTPARAMETER_FEATURE");
            });

            modelBuilder.Entity<UmsReportpermission>(entity =>
            {
                entity.HasKey(e => e.Reportpermissionid)
                    .HasName("PK_REPORTPERMISSION");

                entity.ToTable("UMS_REPORTPERMISSION");

                entity.Property(e => e.Reportpermissionid).HasColumnName("REPORTPERMISSIONID");

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Reportid)
                    .IsRequired()
                    .HasColumnName("REPORTID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsReportpermission)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_REPORTPERMISSION_UMS_AP");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.UmsReportpermission)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORTPERMISSION_REPORTING");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmsReportpermission)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_REPORTPERMISSION_ROLE");
            });

            modelBuilder.Entity<UmsRole>(entity =>
            {
                entity.HasKey(e => e.Roleid);

                entity.ToTable("UMS_ROLE");

                entity.HasIndex(e => e.Rolename)
                    .HasName("UK_UMS_ROLE")
                    .IsUnique();

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.AppId)
                    .HasColumnName("APP_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasColumnName("PURPOSE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasColumnName("ROLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UmsRoleassign>(entity =>
            {
                entity.HasKey(e => e.Roleassignid)
                    .HasName("PK_UMS_ROLE_ASSIGN");

                entity.ToTable("UMS_ROLEASSIGN");

                entity.HasIndex(e => new { e.Userid, e.Roleid })
                    .HasName("UK_UMS_ROLEASSIGN")
                    .IsUnique();

                entity.Property(e => e.Roleassignid).HasColumnName("ROLEASSIGNID");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmsRoleassign)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLE_ASSIGN_UMS_ROLE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsRoleassign)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLE_ASSIGN_UMS_USERINF");
            });

            modelBuilder.Entity<UmsRoledtl>(entity =>
            {
                entity.HasKey(e => e.Roledtlid);

                entity.ToTable("UMS_ROLEDTL");

                entity.HasIndex(e => new { e.Roleid, e.Featureid })
                    .HasName("UK_UMS_ROLEDTL")
                    .IsUnique();

                entity.Property(e => e.Roledtlid).HasColumnName("ROLEDTLID");

                entity.Property(e => e.Appid)
                    .IsRequired()
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authyn)
                    .IsRequired()
                    .HasColumnName("AUTHYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Cancelyn)
                    .IsRequired()
                    .HasColumnName("CANCELYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Createyn)
                    .IsRequired()
                    .HasColumnName("CREATEYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("DELETEYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Edityn)
                    .IsRequired()
                    .HasColumnName("EDITYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Featureid)
                    .IsRequired()
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid)
                    .IsRequired()
                    .HasColumnName("MODULEID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Viewdetailyn)
                    .IsRequired()
                    .HasColumnName("VIEWDETAILYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsRoledtl)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLEDTL_UMS_APPCONFIG");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.UmsRoledtl)
                    .HasForeignKey(d => d.Featureid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLEDTL_UMS_FEATURECONF");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UmsRoledtl)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLEDTL_UMS_MODULECONFI");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmsRoledtl)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_ROLEDTL_UMS_ROLE");
            });

            modelBuilder.Entity<UmsUserfavorite>(entity =>
            {
                entity.ToTable("UMS_USERFAVORITE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .HasColumnName("ACTION")
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.Appid)
                    .HasColumnName("APPID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasColumnName("CONTROLLER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pagetitle)
                    .HasColumnName("PAGETITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Urllink)
                    .HasColumnName("URLLINK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsUserfavorite)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_USERFAVORITE_USERINFO");
            });

            modelBuilder.Entity<UmsUserinfo>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("UMS_USERINFO");

                entity.HasIndex(e => e.Catidval)
                    .HasName("UK_UMS_USERINFO_ID")
                    .IsUnique();

                entity.HasIndex(e => e.Cellno)
                    .HasName("UK_UMS_USERINFO_CELLNO")
                    .IsUnique();

                entity.HasIndex(e => e.Email)
                    .HasName("UK_UMS_USERINFO_EMAIL")
                    .IsUnique();

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Catidval)
                    .IsRequired()
                    .HasColumnName("CATIDVAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cellno)
                    .IsRequired()
                    .HasColumnName("CELLNO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Macaddress)
                    .HasColumnName("MACADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mfa)
                    .IsRequired()
                    .HasColumnName("MFA")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnName("PICTURE")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnName("SIGNATURE")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Thumb)
                    .HasColumnName("THUMB")
                    .HasColumnType("BLOB");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.UmsUserinfo)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UMS_USERINFO_UMS_CATEGORY");
            });

            modelBuilder.Entity<UmsUsersession>(entity =>
            {
                entity.HasKey(e => e.Sessionid)
                    .HasName("PK_UMS_USER_SESSION");

                entity.ToTable("UMS_USERSESSION");

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPADDRESS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logindatetime)
                    .HasColumnName("LOGINDATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Logoutdatetime)
                    .HasColumnName("LOGOUTDATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.UmsUsersession)
                    .HasForeignKey(d => d.Appid)
                    .HasConstraintName("FK_UMS_USERSESSION_APPID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmsUsersession)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_UMS_USERSESSION_USERID");
            });

            modelBuilder.Entity<UmsUsersessionlog>(entity =>
            {
                entity.HasKey(e => e.Activityid);

                entity.ToTable("UMS_USERSESSIONLOG");

                entity.Property(e => e.Activityid).HasColumnName("ACTIVITYID");

                entity.Property(e => e.Actiondatetime)
                    .HasColumnName("ACTIONDATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Actionid)
                    .HasColumnName("ACTIONID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Actionname)
                    .HasColumnName("ACTIONNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Actiontype)
                    .HasColumnName("ACTIONTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Featureid)
                    .HasColumnName("FEATUREID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid)
                    .HasColumnName("MODULEID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.UmsUsersessionlog)
                    .HasForeignKey(d => d.Featureid)
                    .HasConstraintName("FK_UMS_USERSESSIONLOG_FEATUREI");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UmsUsersessionlog)
                    .HasForeignKey(d => d.Moduleid)
                    .HasConstraintName("FK_UMS_USERSESSIONLOG_MODULEID");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.UmsUsersessionlog)
                    .HasForeignKey(d => d.Sessionid)
                    .HasConstraintName("FK_UMS_USERSESSIONLOG_SESSIONI");
            });

            modelBuilder.Entity<VwReportpermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REPORTPERMISSION");

                entity.Property(e => e.Applicationname)
                    .HasColumnName("APPLICATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Reportname)
                    .HasColumnName("REPORTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("ROLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRoleassign>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ROLEASSIGN");

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Rolename)
                    .HasColumnName("ROLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRoledetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ROLEDETAILS");

                entity.Property(e => e.Applicationname)
                    .HasColumnName("APPLICATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Authyn)
                    .IsRequired()
                    .HasColumnName("AUTHYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Createyn)
                    .IsRequired()
                    .HasColumnName("CREATEYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("DELETEYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Edityn)
                    .IsRequired()
                    .HasColumnName("EDITYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Featurename)
                    .HasColumnName("FEATURENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modulename)
                    .HasColumnName("MODULENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus)
                    .IsRequired()
                    .HasColumnName("RECSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("ROLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Viewdetailyn)
                    .IsRequired()
                    .HasColumnName("VIEWDETAILYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("DBOBJECTID_SEQUENCE");

            modelBuilder.HasSequence("UMS_APPCONFIG_APPCONFID_SEQ");

            modelBuilder.HasSequence("UMS_AUTHQUE_AUTHQUEID_SEQ");

            modelBuilder.HasSequence("UMS_AUTHQUEDETAIL_AUTHQUEDTLID");

            modelBuilder.HasSequence("UMS_CATEGORY_CATEGORYID_SEQ");

            modelBuilder.HasSequence("UMS_FEATURECONFIG_FEATURECONFI");

            modelBuilder.HasSequence("UMS_LOGINFAILURETEMP_ID_SEQ");

            modelBuilder.HasSequence("UMS_MENU_MENUID_SEQ");

            modelBuilder.HasSequence("UMS_MODULECONFIG_MODULECONFID_");

            modelBuilder.HasSequence("UMS_NOTIFICATION_ASSIGN_SEQ");

            modelBuilder.HasSequence("UMS_NOTIFICATION_NOTIFICATIONI");

            modelBuilder.HasSequence("UMS_NOTIFICATION_SEQ");

            modelBuilder.HasSequence("UMS_NOTIFICATION_TYPE_SEQ");

            modelBuilder.HasSequence("UMS_NOTIFICATIONDETAIL_ID_SEQ");

            modelBuilder.HasSequence("UMS_PASS_PASSID_SEQ");

            modelBuilder.HasSequence("UMS_PASSPOLICY_PASSPOLICYID_SE");

            modelBuilder.HasSequence("UMS_REPORTPARAMETER_REPORTPARA");

            modelBuilder.HasSequence("UMS_REPORTPERMISSION_REPORTPER");

            modelBuilder.HasSequence("UMS_ROLE_ROLEID_SEQ");

            modelBuilder.HasSequence("UMS_ROLEASSIGN_ROLEASSIGNID_SE");

            modelBuilder.HasSequence("UMS_ROLEDTL_ROLEDTLID_SEQ");

            modelBuilder.HasSequence("UMS_USERFAVORITE_ID_SEQ");

            modelBuilder.HasSequence("UMS_USERSESSION_SESSIONID_SEQ");

            modelBuilder.HasSequence("UMS_USERSESSIONLOG_ACTIVITYID_");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
