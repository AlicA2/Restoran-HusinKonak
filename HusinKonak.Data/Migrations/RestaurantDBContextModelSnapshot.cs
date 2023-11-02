﻿// <auto-generated />
using System;
using HusinKonak.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    [DbContext(typeof(RestaurantDBContext))]
    partial class RestaurantDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.AboutMe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutMe");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Dostava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresaDostave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("TelefonDostave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("kartica_id")
                        .HasColumnType("int");

                    b.Property<int?>("korisnik_id")
                        .HasColumnType("int");

                    b.Property<int?>("meni_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("kartica_id");

                    b.HasIndex("korisnik_id");

                    b.ToTable("Dostava");
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

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.ForumOdgovor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AutorIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Odgovor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("forumTema_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("forumTema_id");

                    b.ToTable("ForumOdgovor");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.ForumTema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pitanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnickiNalogID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("korisnickiNalogID");

                    b.ToTable("ForumTema");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Galerija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<byte[]>("slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("Galerija");
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

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Kartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresaRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumIsteka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drzava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SigurnosniKod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kartica");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Korpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("korisnik_id")
                        .HasColumnType("int");

                    b.Property<int?>("meni_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("korisnik_id");

                    b.HasIndex("meni_id");

                    b.ToTable("Korpa");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Meni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("kategorija_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("kategorija_id");

                    b.ToTable("Meni");
                });

            modelBuilder.Entity("Kontakt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poruka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("korisnikID");

                    b.ToTable("Kontakt");
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
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

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Dostava", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.Kartica", "kartica")
                        .WithMany()
                        .HasForeignKey("kartica_id");

                    b.HasOne("HusinKonak.Data.Modul2.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnik_id");

                    b.Navigation("kartica");

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.ForumOdgovor", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.ForumTema", "forumTema")
                        .WithMany()
                        .HasForeignKey("forumTema_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("forumTema");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.ForumTema", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("korisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
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

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Korpa", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnik_id");

                    b.HasOne("HusinKonak.Data.Modul2.Models.Meni", "Meni")
                        .WithMany()
                        .HasForeignKey("meni_id");

                    b.Navigation("Meni");

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("HusinKonak.Data.Modul2.Models.Meni", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.Kategorija", "kategorija")
                        .WithMany()
                        .HasForeignKey("kategorija_id");

                    b.Navigation("kategorija");
                });

            modelBuilder.Entity("Kontakt", b =>
                {
                    b.HasOne("HusinKonak.Data.Modul2.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
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
