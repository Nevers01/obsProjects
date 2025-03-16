using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace obsProjects.Models;

public partial class SahObsContext : DbContext
{
    public SahObsContext()
    {
    }

    public SahObsContext(DbContextOptions<SahObsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DersProgrami> DersProgramis { get; set; }

    public virtual DbSet<Dersler> Derslers { get; set; }

    public virtual DbSet<Devamsizlik> Devamsizliks { get; set; }

    public virtual DbSet<Duyurular> Duyurulars { get; set; }

    public virtual DbSet<KullaniciRolleri> KullaniciRolleris { get; set; }

    public virtual DbSet<Notlar> Notlars { get; set; }

    public virtual DbSet<Odevler> Odevlers { get; set; }

    public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }

    public virtual DbSet<Ogretmenler> Ogretmenlers { get; set; }

    public virtual DbSet<Roller> Rollers { get; set; }

    public virtual DbSet<Sohbetler> Sohbetlers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=141.98.112.152;Database=sah_obs;User Id=Nevers;Password=Nevers231_;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DersProgrami>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DersProg__3213E83F44E04599");

            entity.ToTable("DersProgrami");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.OgrenciId).HasColumnName("ogrenci_id");

            entity.HasOne(d => d.Ders).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.DersId)
                .HasConstraintName("FK__DersProgr__ders___4222D4EF");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK__DersProgr__ogren__412EB0B6");
        });

        modelBuilder.Entity<Dersler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dersler__3213E83F8E98D615");

            entity.ToTable("Dersler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.OgretmenId).HasColumnName("ogretmen_id");

            entity.HasOne(d => d.Ogretmen).WithMany(p => p.Derslers)
                .HasForeignKey(d => d.OgretmenId)
                .HasConstraintName("FK__Dersler__ogretme__3E52440B");
        });

        modelBuilder.Entity<Devamsizlik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Devamsiz__3213E83FE58A3BA3");

            entity.ToTable("Devamsizlik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.OgrenciId).HasColumnName("ogrenci_id");
            entity.Property(e => e.Tarih).HasColumnName("tarih");

            entity.HasOne(d => d.Ders).WithMany(p => p.Devamsizliks)
                .HasForeignKey(d => d.DersId)
                .HasConstraintName("FK__Devamsizl__ders___4D94879B");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Devamsizliks)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK__Devamsizl__ogren__4CA06362");
        });

        modelBuilder.Entity<Duyurular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Duyurula__3213E83FADDA2FFE");

            entity.ToTable("Duyurular");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Baslik)
                .HasMaxLength(255)
                .HasColumnName("baslik");
            entity.Property(e => e.OgretmenId).HasColumnName("ogretmen_id");
            entity.Property(e => e.YayinTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("yayin_tarihi");

            entity.HasOne(d => d.Ogretmen).WithMany(p => p.Duyurulars)
                .HasForeignKey(d => d.OgretmenId)
                .HasConstraintName("FK__Duyurular__ogret__5629CD9C");
        });

        modelBuilder.Entity<KullaniciRolleri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kullanic__3213E83FC87A9938");

            entity.ToTable("KullaniciRolleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.KullaniciRolleris)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__Kullanici__rol_i__5BE2A6F2");
        });

        modelBuilder.Entity<Notlar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notlar__3213E83F116390F3");

            entity.ToTable("Notlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.FinalNotu)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("final_notu");
            entity.Property(e => e.OgrenciId).HasColumnName("ogrenci_id");
            entity.Property(e => e.SozluNotu)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("sozlu_notu");
            entity.Property(e => e.VizeNotu)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("vize_notu");

            entity.HasOne(d => d.Ders).WithMany(p => p.Notlars)
                .HasForeignKey(d => d.DersId)
                .HasConstraintName("FK__Notlar__ders_id__45F365D3");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Notlars)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK__Notlar__ogrenci___44FF419A");
        });

        modelBuilder.Entity<Odevler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Odevler__3213E83FDA27A037");

            entity.ToTable("Odevler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Baslik)
                .HasMaxLength(255)
                .HasColumnName("baslik");
            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.DosyaYolu)
                .HasMaxLength(255)
                .HasColumnName("dosya_yolu");
            entity.Property(e => e.OgrenciId).HasColumnName("ogrenci_id");
            entity.Property(e => e.SonTarih).HasColumnName("son_tarih");

            entity.HasOne(d => d.Ders).WithMany(p => p.Odevlers)
                .HasForeignKey(d => d.DersId)
                .HasConstraintName("FK__Odevler__ders_id__48CFD27E");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Odevlers)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK__Odevler__ogrenci__49C3F6B7");
        });

        modelBuilder.Entity<Ogrenciler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ogrencil__3213E83FC908C9E0");

            entity.ToTable("Ogrenciler");

            entity.HasIndex(e => e.OgrenciNo, "UQ__Ogrencil__8B48CB5A99B7BB2E").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Ogrencil__AB6E61644581C66D").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.OgrenciNo)
                .HasMaxLength(20)
                .HasColumnName("ogrenci_no");
            entity.Property(e => e.SifreHash)
                .HasMaxLength(255)
                .HasColumnName("sifre_hash");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .HasColumnName("soyad");
        });

        modelBuilder.Entity<Ogretmenler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ogretmen__3213E83F7A7E6F72");

            entity.ToTable("Ogretmenler");

            entity.HasIndex(e => e.Email, "UQ__Ogretmen__AB6E6164E3AD1C0F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.SifreHash)
                .HasMaxLength(255)
                .HasColumnName("sifre_hash");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .HasColumnName("soyad");
        });

        modelBuilder.Entity<Roller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roller__3213E83F2BA89D80");

            entity.ToTable("Roller");

            entity.HasIndex(e => e.RolAdi, "UQ__Roller__604EFF735D646DB2").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RolAdi)
                .HasMaxLength(50)
                .HasColumnName("rol_adi");
        });

        modelBuilder.Entity<Sohbetler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sohbetle__3213E83F4FC3790E");

            entity.ToTable("Sohbetler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliciId).HasColumnName("alici_id");
            entity.Property(e => e.GonderenId).HasColumnName("gonderen_id");
            entity.Property(e => e.GonderimTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("gonderim_tarihi");
            entity.Property(e => e.Mesaj).HasColumnName("mesaj");

            entity.HasOne(d => d.Alici).WithMany(p => p.Sohbetlers)
                .HasForeignKey(d => d.AliciId)
                .HasConstraintName("FK__Sohbetler__alici__52593CB8");

            entity.HasOne(d => d.Gonderen).WithMany(p => p.Sohbetlers)
                .HasForeignKey(d => d.GonderenId)
                .HasConstraintName("FK__Sohbetler__gonde__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
