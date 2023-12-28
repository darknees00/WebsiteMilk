using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebsiteBanSua.Models
{
    public partial class WebBanSuaContext : DbContext
    {
        public WebBanSuaContext()
        {
        }

        public WebBanSuaContext(DbContextOptions<WebBanSuaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAdv> TbAdvs { get; set; } = null!;
        public virtual DbSet<TbCategory> TbCategories { get; set; } = null!;
        public virtual DbSet<TbContact> TbContacts { get; set; } = null!;
        public virtual DbSet<TbNew> TbNews { get; set; } = null!;
        public virtual DbSet<TbOrder> TbOrders { get; set; } = null!;
        public virtual DbSet<TbOrderDertail> TbOrderDertails { get; set; } = null!;
        public virtual DbSet<TbPost> TbPosts { get; set; } = null!;
        public virtual DbSet<TbProduct> TbProducts { get; set; } = null!;
        public virtual DbSet<TbProductCategory> TbProductCategories { get; set; } = null!;
        public virtual DbSet<TbSubscribe> TbSubscribes { get; set; } = null!;
        public virtual DbSet<TbSystemSetting> TbSystemSettings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-984KKD3\\SQLEXPRESS;Database=WebBanSua;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAdv>(entity =>
            {
                entity.ToTable("tb_Adv");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.ToTable("tb_Category");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.SeoDescription).HasMaxLength(550);

                entity.Property(e => e.SeoKeywords).HasMaxLength(250);

                entity.Property(e => e.SeoTitle).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<TbContact>(entity =>
            {
                entity.ToTable("tb_Contact");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Website).HasMaxLength(150);
            });

            modelBuilder.Entity<TbNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_New");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.ToTable("tb_Order");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(150);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbOrderDertail>(entity =>
            {
                entity.ToTable("tb_OrderDertail");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbPost>(entity =>
            {
                entity.ToTable("tb_Post");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.SeoDescription).HasMaxLength(550);

                entity.Property(e => e.SeoKeywords).HasMaxLength(250);

                entity.Property(e => e.SeoTitle).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<TbProduct>(entity =>
            {
                entity.ToTable("tb_Product");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<TbProductCategory>(entity =>
            {
                entity.ToTable("tb_ProductCategory");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedrDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<TbSubscribe>(entity =>
            {
                entity.ToTable("tb_Subscribe");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);
            });

            modelBuilder.Entity<TbSystemSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_SystemSetting");

                entity.Property(e => e.SettingDescrtipion).HasMaxLength(250);

                entity.Property(e => e.SettingKey).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
