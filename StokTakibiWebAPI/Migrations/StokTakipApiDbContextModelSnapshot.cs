﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StokTakibiWebAPI.ApiDbContext;

namespace StokTakibiWebAPI.Migrations
{
    [DbContext(typeof(StokTakipApiDbContext))]
    partial class StokTakipApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StokTakibiWebAPI.Model.CikisYapilanAracTanimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YedekParcaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YedekParcaId");

                    b.ToTable("CikisYapilanAracTanimi");
                });

            modelBuilder.Entity("StokTakibiWebAPI.Model.YedekParca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CikisDepo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CikisMiktari")
                        .HasColumnType("int");

                    b.Property<string>("CikisTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisBelgeNumarasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisDepo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GirisMiktari")
                        .HasColumnType("int");

                    b.Property<string>("GirisTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatinAlinanFirma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriNumarasi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YedekParca");
                });

            modelBuilder.Entity("StokTakibiWebAPI.Model.YedekParcaTanimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YedekParcaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YedekParcaId");

                    b.ToTable("YedekParcaTanimi");
                });

            modelBuilder.Entity("StokTakibiWebAPI.Model.CikisYapilanAracTanimi", b =>
                {
                    b.HasOne("StokTakibiWebAPI.Model.YedekParca", "YedekParca")
                        .WithMany("CikisYapilanAracTanimis")
                        .HasForeignKey("YedekParcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YedekParca");
                });

            modelBuilder.Entity("StokTakibiWebAPI.Model.YedekParcaTanimi", b =>
                {
                    b.HasOne("StokTakibiWebAPI.Model.YedekParca", "YedekParca")
                        .WithMany("YedekParcaTanimis")
                        .HasForeignKey("YedekParcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YedekParca");
                });

            modelBuilder.Entity("StokTakibiWebAPI.Model.YedekParca", b =>
                {
                    b.Navigation("CikisYapilanAracTanimis");

                    b.Navigation("YedekParcaTanimis");
                });
#pragma warning restore 612, 618
        }
    }
}
