namespace masconsulta.Invoice;

public partial class MasconsultaContext : DbContext
{
    public MasconsultaContext()
    {
    }

    public MasconsultaContext(DbContextOptions<MasconsultaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Regime> Regimes { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__Cities__031491A8BA5E45A6");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .HasColumnName("city_name");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");

            entity.HasOne(d => d.Department).WithMany(p => p.Cities)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Cities__departme__412EB0B6");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Clients__BF21A424D238CA2E");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .HasColumnName("business_name");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("client_name");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasColumnName("nit");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.City).WithMany(p => p.Clients)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Clients__city_id__45F365D3");

            entity.HasOne(d => d.Country).WithMany(p => p.Clients)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Clients__country__440B1D61");

            entity.HasOne(d => d.Department).WithMany(p => p.Clients)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Clients__departm__44FF419A");

            entity.HasOne(d => d.User).WithMany(p => p.Clients)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Clients__user_id__46E78A0C");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__7E8CD0551E051E0B");

            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .HasColumnName("country_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__C223242248F80247");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");

            entity.HasOne(d => d.Country).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Departmen__count__3E52440B");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__Profiles__AEBB701F73451759");

            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .HasColumnName("profile_name");
        });

        modelBuilder.Entity<Regime>(entity =>
        {
            entity.HasKey(e => e.RegimeId).HasName("PK__Regimes__C8408DBFFB8644F7");

            entity.Property(e => e.RegimeId).HasColumnName("regime_id");
            entity.Property(e => e.RegimeName)
                .HasMaxLength(50)
                .HasColumnName("regime_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__6EE594E84C53D594");

            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .HasColumnName("business_name");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasColumnName("nit");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.RegimeId).HasColumnName("regime_id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .HasColumnName("supplier_name");

            entity.HasOne(d => d.City).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Suppliers__city___4D94879B");

            entity.HasOne(d => d.Country).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Suppliers__count__4BAC3F29");

            entity.HasOne(d => d.Department).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Suppliers__depar__4CA06362");

            entity.HasOne(d => d.Regime).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.RegimeId)
                .HasConstraintName("FK__Suppliers__regim__4E88ABD4");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370FDF66EBEE");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PerfilId).HasColumnName("perfil_id");

            entity.HasOne(d => d.Perfil).WithMany(p => p.Users)
                .HasForeignKey(d => d.PerfilId)
                .HasConstraintName("FK__Users__perfil_id__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}