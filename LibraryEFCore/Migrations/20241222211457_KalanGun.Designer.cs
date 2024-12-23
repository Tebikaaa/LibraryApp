﻿// <auto-generated />
using System;
using LibraryEFCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryEFCore.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241222211457_KalanGun")]
    partial class KalanGun
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("LibraryEFCore.Models.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("LibraryEFCore.Models.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<int>("KategoriID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SeriNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("StokAdedi")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("YayınYılı")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Yazar")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("LibraryEFCore.Models.OduncIslem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("IadeTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KalanGun")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KitapID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OduncDurumu")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OduncTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("UyeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("KitapID");

                    b.HasIndex("UyeID");

                    b.ToTable("OduncIslemleri");
                });

            modelBuilder.Entity("LibraryEFCore.Models.Uye", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("LibraryEFCore.Models.Kitap", b =>
                {
                    b.HasOne("LibraryEFCore.Models.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("LibraryEFCore.Models.OduncIslem", b =>
                {
                    b.HasOne("LibraryEFCore.Models.Kitap", "Kitap")
                        .WithMany()
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEFCore.Models.Uye", "Uye")
                        .WithMany("OduncIslemler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("LibraryEFCore.Models.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("LibraryEFCore.Models.Uye", b =>
                {
                    b.Navigation("OduncIslemler");
                });
#pragma warning restore 612, 618
        }
    }
}
