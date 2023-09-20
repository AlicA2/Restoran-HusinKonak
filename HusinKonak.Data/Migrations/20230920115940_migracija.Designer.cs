﻿// <auto-generated />
using System;
using HusinKonak.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    [DbContext(typeof(RestaurantDBContext))]
    [Migration("20230920115940_migracija")]
    partial class migracija
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HusinKonak.Data.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twoFCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("twoFJelOtkljucano")
                        .HasColumnType("bit");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aktivacijaGUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAktiviran")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("KorisnickiNalog");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("HusinKonak.Data.Modul0_Autentifikacija.Models.LogKretanjePoSistemu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("exceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isException")
                        .HasColumnType("bit");

                    b.Property<int?>("korisnikID")
                        .HasColumnType("int");

                    b.Property<string>("postData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("queryPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("korisnikID");

                    b.ToTable("LogKretanjePoSistemu");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.Property<int>("drzavaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("drzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Admin", b =>
                {
                    b.HasBaseType("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrucnaSprema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradid")
                        .HasColumnType("int");

                    b.HasIndex("gradid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Korisnik", b =>
                {
                    b.HasBaseType("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumPolasaka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tezina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradid")
                        .HasColumnType("int");

                    b.HasIndex("gradid");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul0_Autentifikacija.Models.LogKretanjePoSistemu", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID");

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Grad", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Admin", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("HusinKonak.Data.Modul2.Models.Admin", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Data.Modul2.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grad");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Korisnik", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("HusinKonak.Data.Modul2.Models.Korisnik", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Data.Modul2.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grad");
                });
#pragma warning restore 612, 618
        }
    }
}
