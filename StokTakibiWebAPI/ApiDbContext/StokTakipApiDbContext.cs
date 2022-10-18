using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StokTakibiWebAPI.Model;
using System.Net;

namespace StokTakibiWebAPI.ApiDbContext
{
    public class StokTakipApiDbContext : DbContext
    {
        public DbSet<YedekParca>? YedekParca { get; set; }
        public DbSet<CikisYapilanAracTanimi>? CikisYapilanAracTanimi { get; set; }
        public DbSet<YedekParcaTanimi>? YedekParcaTanimi { get; set; }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddDebug().AddConsole());
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=StokTakibiApiDB;Trusted_Connection=True;MultipleActiveResultSets=True;")
                 .UseLoggerFactory(loggerFactory);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YedekParca>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.GirisMiktari);
                entity.Property(e => e.GirisTarihi);
                entity.Property(e => e.GirisBelgeNumarasi);
                entity.Property(e => e.SatinAlinanFirma);
                entity.Property(e => e.SeriNumarasi);
                entity.Property(e => e.GirisMiktari);
                entity.Property(e => e.Birimi);
                entity.Property(e => e.CikisDepo);
                entity.Property(e => e.CikisTarihi);
                entity.Property(e => e.CikisMiktari);
                //entity.HasMany
            });
            modelBuilder.Entity<YedekParcaTanimi>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Kodu);
                entity.Property(e => e.Adi);
                entity.HasOne(e => e.YedekParca).WithMany(e => e.YedekParcaTanimis).HasForeignKey(e => e.YedekParcaId);
            });

            modelBuilder.Entity<CikisYapilanAracTanimi>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Marka);
                entity.Property(e => e.Plaka);
                entity.HasOne(e => e.YedekParca).WithMany(e => e.CikisYapilanAracTanimis).HasForeignKey(e => e.YedekParcaId);
            });

            //modelBuilder.Entity<YedekParcaGirisKaydi>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.GirisMiktari);
            //    entity.Property(e => e.GirisTarihi);
            //    entity.Property(e => e.GirisBelgeNumarasi);
            //    entity.Property(e => e.SatinAlinanFirma);
            //    entity.Property(e => e.SeriNumarasi);
            //    entity.Property(e => e.GirisMiktari);
            //    entity.Property(e => e.Birimi);
            //    entity.HasMany(e => e.Addresses).WithOne(e => e.user).OnDelete(DeleteBehavior.Cascade);
            //    entity.HasMany(e => e.Addresses).WithOne(e => e.user).HasForeignKey(e => e.UserId);
            //});

            //modelBuilder.Entity<YedekParcaCikisKaydi>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.CikisDepo);
            //    entity.Property(e => e.CikisTarihi);
            //    entity.Property(e => e.SeriNumarasi);
            //    entity.Property(e => e.CikisMiktari);
            //    entity.Property(e => e.Birimi);
            //    entity.HasOne(e => e.user).WithMany(e => e.Addresses).OnDelete(DeleteBehavior.ClientCascade);
            //    entity.HasOne(e => e.user).WithMany(e => e.Addresses).HasForeignKey(e => e.UserId);
            //});
        }
    }
}
