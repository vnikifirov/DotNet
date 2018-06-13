﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SwiftCode.Core.Persistence.Contexts;
using System;

namespace SwiftCode.Core.Persistence.Migrations
{
    [DbContext(typeof(BnkseekDbContext))]
    [Migration("20180404222312_InitialModels")]
    partial class InitialModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.BnkseekEntity", b =>
                {
                    b.Property<string>("VKEY")
                        .HasColumnType("char(8)");

                    b.Property<string>("ADR")
                        .HasColumnType("char(30)");

                    b.Property<string>("AT1")
                        .HasColumnType("char(7)");

                    b.Property<string>("AT2")
                        .HasColumnType("char(7)");

                    b.Property<string>("CKS")
                        .HasColumnType("char(6)");

                    b.Property<DateTime>("DATE_CH")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DATE_IN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DT_IZM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DT_IZMR")
                        .HasColumnType("datetime2");

                    b.Property<string>("IND")
                        .HasColumnType("char(6)");

                    b.Property<string>("KSNP")
                        .HasColumnType("char(20)");

                    b.Property<string>("NAMEN")
                        .IsRequired()
                        .HasColumnType("char(30)");

                    b.Property<string>("NAMEP")
                        .IsRequired()
                        .HasColumnType("char(45)");

                    b.Property<string>("NEWKS")
                        .HasColumnType("char(9)");

                    b.Property<string>("NEWNUM")
                        .IsRequired()
                        .HasColumnType("char(9)");

                    b.Property<string>("NNP")
                        .HasColumnType("char(25)");

                    b.Property<string>("OKPO")
                        .HasColumnType("char(8)");

                    b.Property<string>("PERMFO")
                        .HasColumnType("char(6)");

                    b.Property<string>("PZN")
                        .HasColumnType("char(2)");

                    b.Property<string>("REAL")
                        .HasColumnType("char(4)");

                    b.Property<string>("REGN")
                        .HasColumnType("char(9)");

                    b.Property<string>("RGN")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.Property<string>("RKC")
                        .HasColumnType("char(9)");

                    b.Property<string>("SROK")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.Property<string>("TELEF")
                        .HasColumnType("char(25)");

                    b.Property<string>("TNP")
                        .HasColumnType("char(1)");

                    b.Property<string>("UER")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<string>("VKEYDEL")
                        .HasColumnType("char(9)");

                    b.HasKey("VKEY");

                    b.HasIndex("NEWNUM")
                        .IsUnique();

                    b.HasIndex("PZN");

                    b.HasIndex("RGN");

                    b.HasIndex("TNP");

                    b.HasIndex("UER");

                    b.HasIndex("VKEYDEL");

                    b.ToTable("BNKSEEK");
                });

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.PznEntity", b =>
                {
                    b.Property<string>("VKEY")
                        .HasColumnType("char(8)");

                    b.Property<DateTime>("CB_DATE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("IMY");

                    b.Property<string>("NAME");

                    b.Property<string>("PZN")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.HasKey("VKEY");

                    b.HasIndex("PZN")
                        .IsUnique();

                    b.ToTable("PZN");
                });

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.RegEntity", b =>
                {
                    b.Property<string>("VKEY")
                        .HasColumnType("char(8)");

                    b.Property<string>("CENTER")
                        .HasColumnType("char(45)");

                    b.Property<string>("NAME")
                        .HasColumnType("char(45)");

                    b.Property<string>("NAMET")
                        .HasColumnType("char(45)");

                    b.Property<string>("RGN")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.HasKey("VKEY");

                    b.HasIndex("RGN")
                        .IsUnique();

                    b.ToTable("REG");
                });

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.TnpEntity", b =>
                {
                    b.Property<string>("VKEY")
                        .HasColumnType("char(8)");

                    b.Property<string>("FULLNAME")
                        .HasColumnType("char(45)");

                    b.Property<string>("SHORTNAME")
                        .HasColumnType("char(16)");

                    b.Property<string>("TNP")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("VKEY");

                    b.HasIndex("TNP")
                        .IsUnique();

                    b.ToTable("TNP");
                });

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.UerEntity", b =>
                {
                    b.Property<string>("VKEY")
                        .HasColumnType("char(8)");

                    b.Property<string>("UER")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<string>("UERNAME")
                        .HasColumnType("char(80)");

                    b.HasKey("VKEY");

                    b.HasIndex("UER")
                        .IsUnique();

                    b.ToTable("UER");
                });

            modelBuilder.Entity("SwiftCode.Core.Persistence.Entities.BnkseekEntity", b =>
                {
                    b.HasOne("SwiftCode.Core.Persistence.Entities.PznEntity", "PznEntity")
                        .WithMany("BnkseekEntitys")
                        .HasForeignKey("PZN")
                        .HasConstraintName("FK_BNKSEEK_PZN")
                        .HasPrincipalKey("PZN")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SwiftCode.Core.Persistence.Entities.RegEntity", "RegEntity")
                        .WithMany("BnkseekEntitys")
                        .HasForeignKey("RGN")
                        .HasConstraintName("FK_BNKSEEK_REG")
                        .HasPrincipalKey("RGN")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SwiftCode.Core.Persistence.Entities.TnpEntity", "TnpEntity")
                        .WithMany("BnkseekEntitys")
                        .HasForeignKey("TNP")
                        .HasConstraintName("FK_BNKSEEK_TNP")
                        .HasPrincipalKey("TNP")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SwiftCode.Core.Persistence.Entities.UerEntity", "UerEntity")
                        .WithMany("BnkseekEntitys")
                        .HasForeignKey("UER")
                        .HasConstraintName("FK_BNKSEEK_UER")
                        .HasPrincipalKey("UER")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
