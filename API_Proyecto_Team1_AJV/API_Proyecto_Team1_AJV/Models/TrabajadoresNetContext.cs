using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class TrabajadoresNetContext : DbContext
    {

        public TrabajadoresNetContext(DbContextOptions<TrabajadoresNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categors> Categors { get; set; }
        public virtual DbSet<ClasePer> ClasePer { get; set; }
        public virtual DbSet<Cuerpos> Cuerpos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Escala> Escala { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<NivOrg> NivOrg { get; set; }
        public virtual DbSet<Organig> Organig { get; set; }
        public virtual DbSet<Poblac> Poblac { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Siglas> Siglas { get; set; }
        public virtual DbSet<SitAdmv> SitAdmv { get; set; }
        public virtual DbSet<Subescala> Subescala { get; set; }
        public virtual DbSet<TProvis> TProvis { get; set; }
        public virtual DbSet<TokenUsers> TokenUsers { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }
        public virtual DbSet<VNivOrg> VNivOrg { get; set; }
        public virtual DbSet<VTrabajadores> VTrabajadores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categors>(entity =>
            {
                entity.HasKey(e => e.Categori);

                entity.ToTable("CATEGORS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_CATEGORS")
                    .IsUnique();

                entity.Property(e => e.Categori)
                    .HasColumnName("CATEGORI")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cuerpo)
                    .HasColumnName("CUERPO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DFunciones)
                    .HasColumnName("D_FUNCIONES")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasColumnName("DESCRIP")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FFinVigen)
                    .HasColumnName("F_FIN_VIGEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FIniVigen)
                    .HasColumnName("F_INI_VIGEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdClase)
                    .HasColumnName("ID_CLASE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdClasePer)
                    .IsRequired()
                    .HasColumnName("ID_CLASE_PER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdEscala)
                    .HasColumnName("ID_ESCALA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdSubescala)
                    .HasColumnName("ID_SUBESCALA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observac)
                    .HasColumnName("OBSERVAC")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClasePerNavigation)
                    .WithMany(p => p.Categors)
                    .HasForeignKey(d => d.IdClasePer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORS_CLASE_PER");

                entity.HasOne(d => d.IdEscalaNavigation)
                    .WithMany(p => p.Categors)
                    .HasForeignKey(d => d.IdEscala)
                    .HasConstraintName("FK_CATEGORS_ESCALA");

                entity.HasOne(d => d.IdSubescalaNavigation)
                    .WithMany(p => p.Categors)
                    .HasForeignKey(d => d.IdSubescala)
                    .HasConstraintName("FK_CATEGORS_SUBESCALA");
            });

            modelBuilder.Entity<ClasePer>(entity =>
            {
                entity.HasKey(e => e.IdClasePer);

                entity.ToTable("CLASE_PER");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_CLASE_PER")
                    .IsUnique();

                entity.Property(e => e.IdClasePer)
                    .HasColumnName("ID_CLASE_PER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asimilado)
                    .HasColumnName("ASIMILADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DClasePer)
                    .IsRequired()
                    .HasColumnName("D_CLASE_PER")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Cuerpos>(entity =>
            {
                entity.HasKey(e => e.Cuerpo);

                entity.ToTable("CUERPOS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_CUERPOS")
                    .IsUnique();

                entity.Property(e => e.Cuerpo)
                    .HasColumnName("CUERPO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categor)
                    .HasColumnName("CATEGOR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasColumnName("DESCRIP")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("EMPRESAS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_EMPRESAS")
                    .IsUnique();

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPOSTAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DEmpresa)
                    .IsRequired()
                    .HasColumnName("D_EMPRESA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasColumnName("DOMICILIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Escalera)
                    .HasColumnName("ESCALERA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPoblacion)
                    .IsRequired()
                    .HasColumnName("ID_POBLACION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdProvincia)
                    .IsRequired()
                    .HasColumnName("ID_PROVINCIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Km)
                    .HasColumnName("KM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasColumnName("PISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Puerta)
                    .HasColumnName("PUERTA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Siglas)
                    .HasColumnName("SIGLAS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasColumnName("TELEFONO1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("TELEFONO2")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Escala>(entity =>
            {
                entity.HasKey(e => e.IdEscala);

                entity.ToTable("ESCALA");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_ESCALA")
                    .IsUnique();

                entity.Property(e => e.IdEscala)
                    .HasColumnName("ID_ESCALA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Abreviacion)
                    .IsRequired()
                    .HasColumnName("ABREVIACION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEscala)
                    .IsRequired()
                    .HasColumnName("D_ESCALA")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.HasKey(e => e.Grupo);

                entity.ToTable("GRUPOS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_GRUPOS")
                    .IsUnique();

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DGrupo)
                    .HasColumnName("D_GRUPO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrupoPpension)
                    .HasColumnName("GRUPO_PPENSION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdClasePer)
                    .HasColumnName("ID_CLASE_PER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdClasePerNavigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdClasePer)
                    .HasConstraintName("FK_GRUPOS_CLASE_PER");
            });

            modelBuilder.Entity<NivOrg>(entity =>
            {
                entity.HasKey(e => new { e.IdOrganig, e.IdNivel });

                entity.ToTable("NIV_ORG");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_NIV_ORG")
                    .IsUnique();

                entity.Property(e => e.IdOrganig)
                    .HasColumnName("ID_ORGANIG")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivel)
                    .HasColumnName("ID_NIVEL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Camino)
                    .HasColumnName("CAMINO")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.CategNivel)
                    .IsRequired()
                    .HasColumnName("CATEG_NIVEL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DNivel)
                    .HasColumnName("D_NIVEL")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EsPuesto)
                    .IsRequired()
                    .HasColumnName("ES_PUESTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FCreacion)
                    .HasColumnName("F_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FInhabilitacion)
                    .HasColumnName("F_INHABILITACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IcoRes)
                    .IsRequired()
                    .HasColumnName("ICO_RES")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivelHijo)
                    .HasColumnName("ID_NIVEL_HIJO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivelPadre)
                    .HasColumnName("ID_NIVEL_PADRE")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPuesto)
                    .HasColumnName("ID_PUESTO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdentNivel)
                    .HasColumnName("IDENT_NIVEL")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.N9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.OrganigId).HasColumnName("ORGANIG_ID");

                entity.Property(e => e.TResponsable)
                    .HasColumnName("T_RESPONSABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdOrganigNavigation)
                    .WithMany(p => p.NivOrgIdOrganigNavigation)
                    .HasForeignKey(d => d.IdOrganig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NIV_ORG_ORGANIG");

                entity.HasOne(d => d.Organig)
                    .WithMany(p => p.NivOrgOrganig)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.OrganigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NIV_ORG_ORGANIG1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.InverseIdNavigation)
                    .HasForeignKey(d => new { d.IdOrganig, d.IdNivelPadre })
                    .HasConstraintName("FK_NIV_ORG_NIV_ORG");
            });

            modelBuilder.Entity<Organig>(entity =>
            {
                entity.HasKey(e => e.IdOrganig);

                entity.ToTable("ORGANIG");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_ORGANIG")
                    .IsUnique();

                entity.Property(e => e.IdOrganig)
                    .HasColumnName("ID_ORGANIG")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOrganig)
                    .IsRequired()
                    .HasColumnName("D_ORGANIG")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresasId).HasColumnName("EMPRESAS_ID");

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdEmpresa)
                    .IsRequired()
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Empresas)
                    .WithMany(p => p.OrganigEmpresas)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.EmpresasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGANIG_EMPRESAS1");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.OrganigIdEmpresaNavigation)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGANIG_EMPRESAS");
            });

            modelBuilder.Entity<Poblac>(entity =>
            {
                entity.HasKey(e => new { e.IdProvincia, e.IdPoblacion });

                entity.ToTable("POBLAC");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_POBLAC")
                    .IsUnique();

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("ID_PROVINCIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPoblacion)
                    .HasColumnName("ID_POBLACION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPoblacion)
                    .IsRequired()
                    .HasColumnName("D_POBLACION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Poblac)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POBLAC_PROVINCIAS");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.ToTable("PROVINCIAS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_PROVINCIAS")
                    .IsUnique();

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("ID_PROVINCIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DProvincia)
                    .IsRequired()
                    .HasColumnName("D_PROVINCIA")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Siglas>(entity =>
            {
                entity.HasKey(e => e.Siglas1);

                entity.ToTable("SIGLAS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.Siglas1)
                    .HasColumnName("SIGLAS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DSiglas)
                    .IsRequired()
                    .HasColumnName("D_SIGLAS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SitAdmv>(entity =>
            {
                entity.HasKey(e => e.SitAdmv1);

                entity.ToTable("SIT_ADMV");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_SIT_ADMV")
                    .IsUnique();

                entity.Property(e => e.SitAdmv1)
                    .HasColumnName("SIT_ADMV")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasColumnName("DESCRIP")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Subescala>(entity =>
            {
                entity.HasKey(e => e.IdSubescala);

                entity.ToTable("SUBESCALA");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_SUBESCALA")
                    .IsUnique();

                entity.Property(e => e.IdSubescala)
                    .HasColumnName("ID_SUBESCALA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DSubescala)
                    .IsRequired()
                    .HasColumnName("D_SUBESCALA")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdEscala)
                    .IsRequired()
                    .HasColumnName("ID_ESCALA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEscalaNavigation)
                    .WithMany(p => p.Subescala)
                    .HasForeignKey(d => d.IdEscala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBESCALA_ESCALA");
            });

            modelBuilder.Entity<TProvis>(entity =>
            {
                entity.HasKey(e => e.TProvis1);

                entity.ToTable("T_PROVIS");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_T_PROVIS")
                    .IsUnique();

                entity.Property(e => e.TProvis1)
                    .HasColumnName("T_PROVIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasColumnName("DESCRIP")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdClasePer)
                    .IsRequired()
                    .HasColumnName("ID_CLASE_PER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TokenUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__TokenUse__1788CC4CB98428C0");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Trabajadores>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdTrabajador, e.IdOrganig, e.IdNivel });

                entity.ToTable("TRABAJADORES");

                entity.HasIndex(e => e.Id)
                    .HasName("UIDX_TRABAJADORES")
                    .IsUnique();

                entity.HasIndex(e => e.Nif)
                    .HasName("UIDX_NIF")
                    .IsUnique();

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdTrabajador)
                    .HasColumnName("ID_TRABAJADOR")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdOrganig)
                    .HasColumnName("ID_ORGANIG")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivel)
                    .HasColumnName("ID_NIVEL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apellido1)
                    .HasColumnName("APELLIDO1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasColumnName("APELLIDO2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPOSTAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cuerpo)
                    .HasColumnName("CUERPO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasColumnName("DOMICILIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ECivil)
                    .HasColumnName("E_CIVIL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EsFamiliaNumerosa)
                    .HasColumnName("ES_FAMILIA_NUMEROSA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Escalera)
                    .HasColumnName("ESCALERA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FAlta)
                    .HasColumnName("F_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FBaja)
                    .HasColumnName("F_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FNac)
                    .HasColumnName("F_NAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrowver)
                    .HasColumnName("GCROWVER")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorasAnual).HasColumnName("HORAS_ANUAL");

                entity.Property(e => e.HstSitAdmv)
                    .HasColumnName("HST_SIT_ADMV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("ID_CATEGORIA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdHstSitAdmv).HasColumnName("ID_HST_SIT_ADMV");

                entity.Property(e => e.IdPais)
                    .HasColumnName("ID_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPaisNac)
                    .HasColumnName("ID_PAIS_NAC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPoblacion)
                    .HasColumnName("ID_POBLACION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPoblacionNac)
                    .HasColumnName("ID_POBLACION_NAC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("ID_PROVINCIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdProvinciaNac)
                    .HasColumnName("ID_PROVINCIA_NAC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPuesto)
                    .HasColumnName("ID_PUESTO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdTSitAdmv)
                    .HasColumnName("ID_T_SIT_ADMV")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Minusv)
                    .HasColumnName("MINUSV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NivOrgId).HasColumnName("NIV_ORG_ID");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PJornadaCto)
                    .HasColumnName("P_JORNADA_CTO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PJornadaTrab)
                    .HasColumnName("P_JORNADA_TRAB")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.POcupacion)
                    .HasColumnName("P_OCUPACION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PReducJornada)
                    .HasColumnName("P_REDUC_JORNADA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Piso)
                    .HasColumnName("PISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Puerta)
                    .HasColumnName("PUERTA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Residente)
                    .HasColumnName("RESIDENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Siglas)
                    .HasColumnName("SIGLAS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SitAdmv)
                    .IsRequired()
                    .HasColumnName("SIT_ADMV")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TProvis)
                    .IsRequired()
                    .HasColumnName("T_PROVIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefEmerg)
                    .HasColumnName("TELEF_EMERG")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasColumnName("TELEFONO1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("TELEFONO2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuerpoNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.Cuerpo)
                    .HasConstraintName("FK_TRABAJADORES_CUERPOS");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK_TRABAJADORES_GRUPOS");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_TRABAJADORES_CATEGORS");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.TrabajadoresIdProvinciaNavigation)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_TRABAJADORES_PROVINCIAS");

                entity.HasOne(d => d.IdProvinciaNacNavigation)
                    .WithMany(p => p.TrabajadoresIdProvinciaNacNavigation)
                    .HasForeignKey(d => d.IdProvinciaNac)
                    .HasConstraintName("FK_TRABAJADORES_PROVINCIAS_NAC");

                entity.HasOne(d => d.NivOrg)
                    .WithMany(p => p.TrabajadoresNivOrg)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.NivOrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJADORES_NIV_ORG");

                entity.HasOne(d => d.SiglasNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.Siglas)
                    .HasConstraintName("FK_TRABAJADORES_SIGLAS");

                entity.HasOne(d => d.SitAdmvNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.SitAdmv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJADORES_SIT_ADMV");

                entity.HasOne(d => d.TProvisNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.TProvis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJADORES_T_PROVIS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TrabajadoresIdNavigation)
                    .HasForeignKey(d => new { d.IdOrganig, d.IdNivel })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJADORES_NIV_ORG1");

                entity.HasOne(d => d.IdP)
                    .WithMany(p => p.TrabajadoresIdP)
                    .HasForeignKey(d => new { d.IdProvincia, d.IdPoblacion })
                    .HasConstraintName("FK_TRABAJADORES_POBLAC");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.TrabajadoresIdPNavigation)
                    .HasForeignKey(d => new { d.IdProvinciaNac, d.IdPoblacionNac })
                    .HasConstraintName("FK_TRABAJADORES_POBLAC_NAC");
            });

            modelBuilder.Entity<VNivOrg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_NIV_ORG");

                entity.Property(e => e.Camino)
                    .HasColumnName("CAMINO")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.DNivel)
                    .HasColumnName("D_NIVEL")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DNivelPadre)
                    .HasColumnName("D_NIVEL_PADRE")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivel)
                    .IsRequired()
                    .HasColumnName("ID_NIVEL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdNivelPadre)
                    .HasColumnName("ID_NIVEL_PADRE")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdOrganig)
                    .IsRequired()
                    .HasColumnName("ID_ORGANIG")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VTrabajadores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TRABAJADORES");

                entity.Property(e => e.Apellido1)
                    .HasColumnName("APELLIDO1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasColumnName("APELLIDO2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPOSTAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DPoblacion)
                    .IsRequired()
                    .HasColumnName("D_POBLACION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DProvincia)
                    .IsRequired()
                    .HasColumnName("D_PROVINCIA")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DSiglas)
                    .IsRequired()
                    .HasColumnName("D_SIGLAS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("DOMICILIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdEmpresa)
                    .IsRequired()
                    .HasColumnName("ID_EMPRESA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdTrabajador)
                    .IsRequired()
                    .HasColumnName("ID_TRABAJADOR")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasColumnName("PISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Puerta)
                    .HasColumnName("PUERTA")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
