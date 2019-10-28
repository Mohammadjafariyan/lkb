using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication.abbas_lkb
{
    public partial class abbas_lkbContext : DbContext
    {
        public abbas_lkbContext()
        {
        }

        public abbas_lkbContext(DbContextOptions<abbas_lkbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCar> TblCar { get; set; }
        public virtual DbSet<TblCarCategory> TblCarCategory { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCategoryFeatures> TblCategoryFeatures { get; set; }
        public virtual DbSet<TblCategoryFeatureType> TblCategoryFeatureType { get; set; }
        public virtual DbSet<TblConfigs> TblConfigs { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblCustomerAddress> TblCustomerAddress { get; set; }
        public virtual DbSet<TblCustomerGcm> TblCustomerGcm { get; set; }
        public virtual DbSet<TblCustomerPoint> TblCustomerPoint { get; set; }
        public virtual DbSet<TblDepot> TblDepot { get; set; }
        public virtual DbSet<TblDiscount> TblDiscount { get; set; }
        public virtual DbSet<TblDiscountType> TblDiscountType { get; set; }
        public virtual DbSet<TblInstallPrice> TblInstallPrice { get; set; }
        public virtual DbSet<TblItem> TblItem { get; set; }
        public virtual DbSet<TblItemCar> TblItemCar { get; set; }
        public virtual DbSet<TblItemFeature> TblItemFeature { get; set; }
        public virtual DbSet<TblItemPics> TblItemPics { get; set; }
        public virtual DbSet<TblItemStockLog> TblItemStockLog { get; set; }
        public virtual DbSet<TblNotifyMe> TblNotifyMe { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrderItems> TblOrderItems { get; set; }
        public virtual DbSet<TblOrderPay> TblOrderPay { get; set; }
        public virtual DbSet<TblOrderRate> TblOrderRate { get; set; }
        public virtual DbSet<TblOrderStatus> TblOrderStatus { get; set; }
        public virtual DbSet<TblSection> TblSection { get; set; }
        public virtual DbSet<TblSectionItems> TblSectionItems { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblServiceCar> TblServiceCar { get; set; }
        public virtual DbSet<TblServiceCategory> TblServiceCategory { get; set; }
        public virtual DbSet<TblServiceman> TblServiceman { get; set; }
        public virtual DbSet<TblServicemanTrack> TblServicemanTrack { get; set; }
        public virtual DbSet<TblSlider> TblSlider { get; set; }
        public virtual DbSet<TblSliderType> TblSliderType { get; set; }
        public virtual DbSet<TblTicket> TblTicket { get; set; }
        public virtual DbSet<TblTicketMsg> TblTicketMsg { get; set; }
        public virtual DbSet<TblTimes> TblTimes { get; set; }
        public virtual DbSet<TblUpdate> TblUpdate { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=ruutAa;database=abbas_lkb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCar>(entity =>
            {
                entity.ToTable("tbl_car", "abbas_lkb");

                entity.HasIndex(e => e.CatId)
                    .HasName("fk_tblcar_cat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.TblCar)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tblcar_cat");
            });

            modelBuilder.Entity<TblCarCategory>(entity =>
            {
                entity.ToTable("tbl_car_category", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tbl_category", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCategoryFeatures>(entity =>
            {
                entity.ToTable("tbl_category_features", "abbas_lkb");

                entity.HasIndex(e => e.CatId)
                    .HasName("fk_catftr_cat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultValues)
                    .IsRequired()
                    .HasColumnName("default_values")
                    .IsUnicode(false);

                entity.Property(e => e.Feature)
                    .IsRequired()
                    .HasColumnName("feature")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsFilter)
                    .HasColumnName("is_filter")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.TblCategoryFeatures)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("fk_catftr_cat");
            });

            modelBuilder.Entity<TblCategoryFeatureType>(entity =>
            {
                entity.ToTable("tbl_category_feature_type", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblConfigs>(entity =>
            {
                entity.ToTable("tbl_configs", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_customer", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivationCode)
                    .IsRequired()
                    .HasColumnName("activation_code")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationTs)
                    .HasColumnName("activation_ts")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApiKey)
                    .IsRequired()
                    .HasColumnName("api_key")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReagentId)
                    .HasColumnName("reagent_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblCustomerAddress>(entity =>
            {
                entity.ToTable("tbl_customer_address", "abbas_lkb");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("fk_tblcusadd_cus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.AddressPhone)
                    .IsRequired()
                    .HasColumnName("address_phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_tblcusadd_cus");
            });

            modelBuilder.Entity<TblCustomerGcm>(entity =>
            {
                entity.ToTable("tbl_customer_gcm", "abbas_lkb");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("fk_user");

                entity.HasIndex(e => e.GcmId)
                    .HasName("gcm_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DevType)
                    .HasColumnName("dev_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GcmId)
                    .IsRequired()
                    .HasColumnName("gcm_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerGcm)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tbl_customer_gcm_ibfk_1");
            });

            modelBuilder.Entity<TblCustomerPoint>(entity =>
            {
                entity.ToTable("tbl_customer_point", "abbas_lkb");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("fk_point_customer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerPoint)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_point_customer");
            });

            modelBuilder.Entity<TblDepot>(entity =>
            {
                entity.ToTable("tbl_depot", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDiscount>(entity =>
            {
                entity.ToTable("tbl_discount", "abbas_lkb");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmountType)
                    .IsRequired()
                    .HasColumnName("amount_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MinFAmount)
                    .HasColumnName("min_f_amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StopDate)
                    .HasColumnName("stop_date")
                    .HasColumnType("date");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblDiscount)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tbl_discount_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblDiscount)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tbl_discount_ibfk_2");
            });

            modelBuilder.Entity<TblDiscountType>(entity =>
            {
                entity.ToTable("tbl_discount_type", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblInstallPrice>(entity =>
            {
                entity.ToTable("tbl_install_price", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblItem>(entity =>
            {
                entity.ToTable("tbl_item", "abbas_lkb");

                entity.HasIndex(e => e.CatId)
                    .HasName("fk_item_cat");

                entity.HasIndex(e => e.InstallPriceGroup)
                    .HasName("install_price_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ForceInstall)
                    .HasColumnName("force_install")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuarantyMonth)
                    .HasColumnName("guaranty_month")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InstallPriceGroup)
                    .HasColumnName("install_price_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsLimited)
                    .HasColumnName("is_limited")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimitPeriod)
                    .HasColumnName("limit_period")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxPerOrder)
                    .HasColumnName("max_per_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .HasColumnName("view")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.TblItem)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_item_cat");

                entity.HasOne(d => d.InstallPriceGroupNavigation)
                    .WithMany(p => p.TblItem)
                    .HasForeignKey(d => d.InstallPriceGroup)
                    .HasConstraintName("tbl_item_ibfk_1");
            });

            modelBuilder.Entity<TblItemCar>(entity =>
            {
                entity.ToTable("tbl_item_car", "abbas_lkb");

                entity.HasIndex(e => e.CarId)
                    .HasName("fk_itemcar_car");

                entity.HasIndex(e => e.ItemId)
                    .HasName("fk_itemcar_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblItemCar)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("fk_itemcar_car");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblItemCar)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_itemcar_item");
            });

            modelBuilder.Entity<TblItemFeature>(entity =>
            {
                entity.ToTable("tbl_item_feature", "abbas_lkb");

                entity.HasIndex(e => e.FeatureId)
                    .HasName("fk_itemftr_ftr");

                entity.HasIndex(e => e.ItemId)
                    .HasName("fk_itemftr_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.TblItemFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_itemftr_ftr");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblItemFeature)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_itemftr_item");
            });

            modelBuilder.Entity<TblItemPics>(entity =>
            {
                entity.ToTable("tbl_item_pics", "abbas_lkb");

                entity.HasIndex(e => e.ItemId)
                    .HasName("fk_itempic_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pic)
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblItemPics)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_itempic_item");
            });

            modelBuilder.Entity<TblItemStockLog>(entity =>
            {
                entity.ToTable("tbl_item_stock_log", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblNotifyMe>(entity =>
            {
                entity.ToTable("tbl_notify_me", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsNotified)
                    .HasColumnName("is_notified")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tbl_order", "abbas_lkb");

                entity.HasIndex(e => e.AddressId)
                    .HasName("fk_order_address");

                entity.HasIndex(e => e.CarId)
                    .HasName("fk_order_car");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("fk_order_customer");

                entity.HasIndex(e => e.DepotId)
                    .HasName("depot_id");

                entity.HasIndex(e => e.DiscountId)
                    .HasName("fk_order_discount");

                entity.HasIndex(e => e.ServicemanId)
                    .HasName("fk_order_serviceman");

                entity.HasIndex(e => e.TimeId)
                    .HasName("time_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DelayPenalty)
                    .HasColumnName("delay_penalty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeliverType)
                    .HasColumnName("deliver_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeliveryCost)
                    .HasColumnName("delivery_cost")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DepotId)
                    .HasColumnName("depot_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisAmount)
                    .HasColumnName("dis_amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiscountId)
                    .HasColumnName("discount_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FinalPrice)
                    .HasColumnName("final_price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InstallCost)
                    .HasColumnName("install_cost")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NationalId)
                    .HasColumnName("national_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PayType)
                    .HasColumnName("pay_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Plaque)
                    .IsRequired()
                    .HasColumnName("plaque")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServicemanId)
                    .HasColumnName("serviceman_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartedAt)
                    .HasColumnName("started_at")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StopedAt)
                    .HasColumnName("stoped_at")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TimeId)
                    .HasColumnName("time_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_order_address");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("fk_order_car");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_order_customer");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("tbl_order_ibfk_1");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("fk_order_discount");

                entity.HasOne(d => d.Serviceman)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.ServicemanId)
                    .HasConstraintName("fk_order_serviceman");

                entity.HasOne(d => d.TimeNavigation)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.TimeId)
                    .HasConstraintName("tbl_order_ibfk_2");
            });

            modelBuilder.Entity<TblOrderItems>(entity =>
            {
                entity.ToTable("tbl_order_items", "abbas_lkb");

                entity.HasIndex(e => e.ItemId)
                    .HasName("fk_orderitem_item");

                entity.HasIndex(e => e.OrderId)
                    .HasName("fk_orderitem_order");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("fk_orderitem_service");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChkNeed)
                    .HasColumnName("chk_need")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuarantyExpire)
                    .HasColumnName("guaranty_expire")
                    .HasColumnType("date");

                entity.Property(e => e.InstallNeed)
                    .HasColumnName("install_need")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qnt)
                    .HasColumnName("qnt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblOrderItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_orderitem_item");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_orderitem_order");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblOrderItems)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("fk_orderitem_service");
            });

            modelBuilder.Entity<TblOrderPay>(entity =>
            {
                entity.ToTable("tbl_order_pay", "abbas_lkb");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderpay_order_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderPay)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("orderpay_order");
            });

            modelBuilder.Entity<TblOrderRate>(entity =>
            {
                entity.ToTable("tbl_order_rate", "abbas_lkb");

                entity.HasIndex(e => e.OrderId)
                    .HasName("fk_rate_order");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderRate)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_rate_order");
            });

            modelBuilder.Entity<TblOrderStatus>(entity =>
            {
                entity.ToTable("tbl_order_status", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSection>(entity =>
            {
                entity.ToTable("tbl_section", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblSectionItems>(entity =>
            {
                entity.ToTable("tbl_section_items", "abbas_lkb");

                entity.HasIndex(e => e.ItemId)
                    .HasName("item_id");

                entity.HasIndex(e => e.SectionId)
                    .HasName("section_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionId)
                    .HasColumnName("section_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblSectionItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("tbl_section_items_ibfk_1");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TblSectionItems)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("tbl_section_items_ibfk_2");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("tbl_service", "abbas_lkb");

                entity.HasIndex(e => e.CatId)
                    .HasName("fk_service_cat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc")
                    .IsUnicode(false);

                entity.Property(e => e.HasCount)
                    .HasColumnName("has_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HasPrice)
                    .HasColumnName("has_price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.TblService)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("fk_service_cat");
            });

            modelBuilder.Entity<TblServiceCar>(entity =>
            {
                entity.ToTable("tbl_service_car", "abbas_lkb");

                entity.HasIndex(e => e.CarId)
                    .HasName("car_id");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblServiceCar)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("tbl_service_car_ibfk_2");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblServiceCar)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("tbl_service_car_ibfk_1");
            });

            modelBuilder.Entity<TblServiceCategory>(entity =>
            {
                entity.ToTable("tbl_service_category", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServiceman>(entity =>
            {
                entity.ToTable("tbl_serviceman", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApiKey)
                    .IsRequired()
                    .HasColumnName("api_key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServicemanTrack>(entity =>
            {
                entity.ToTable("tbl_serviceman_track", "abbas_lkb");

                entity.HasIndex(e => e.ServicemanId)
                    .HasName("fk_track_service");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.ServicemanId)
                    .HasColumnName("serviceman_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Serviceman)
                    .WithMany(p => p.TblServicemanTrack)
                    .HasForeignKey(d => d.ServicemanId)
                    .HasConstraintName("fk_track_service");
            });

            modelBuilder.Entity<TblSlider>(entity =>
            {
                entity.ToTable("tbl_slider", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WebUrl)
                    .IsRequired()
                    .HasColumnName("web_url")
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSliderType>(entity =>
            {
                entity.ToTable("tbl_slider_type", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTicket>(entity =>
            {
                entity.ToTable("tbl_ticket", "abbas_lkb");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("fk_ticket_customer");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("is_closed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblTicket)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ticket_customer");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblTicket)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("tbl_ticket_ibfk_1");
            });

            modelBuilder.Entity<TblTicketMsg>(entity =>
            {
                entity.ToTable("tbl_ticket_msg", "abbas_lkb");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FromUser)
                    .HasColumnName("from_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasColumnName("pic")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TblTicketMsg)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("tbl_ticket_msg_ibfk_1");
            });

            modelBuilder.Entity<TblTimes>(entity =>
            {
                entity.ToTable("tbl_times", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTs).HasColumnName("start_ts");

                entity.Property(e => e.StopTs).HasColumnName("stop_ts");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUpdate>(entity =>
            {
                entity.ToTable("tbl_update", "abbas_lkb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsEssential)
                    .HasColumnName("is_essential")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasColumnName("os")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ver)
                    .IsRequired()
                    .HasColumnName("ver")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users", "abbas_lkb");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DepotId)
                    .HasColumnName("depot_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
