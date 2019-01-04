﻿// <auto-generated />
using System;
using CitySpeaks.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CitySpeaks.Infrastructure.Migrations
{
    [DbContext(typeof(CitySpeaksContext))]
    [Migration("20190104085859_user-and-role")]
    partial class userandrole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CitySpeaks.Domain.Models.CustomPages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BigImageData");

                    b.Property<string>("BigImageMimeType");

                    b.Property<bool>("IsShow");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Page")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CustomPages");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.MainPages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("LogoImageMimeType");

                    b.Property<byte[]>("LogolImageData");

                    b.Property<byte[]>("MainImageData");

                    b.Property<string>("MainImageMimeType");

                    b.Property<string>("Subtitle")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MainPages");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150);

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300);

                    b.Property<byte[]>("Model")
                        .IsRequired();

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BigImageData");

                    b.Property<string>("BigImageMimeType");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("FullDescription")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.Property<byte[]>("SmallImageData");

                    b.Property<string>("SmallImageMimeType");

                    b.HasKey("NewsId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.ProgramCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CategoryId")
                        .HasName("PK_dbo.ProgramCategories");

                    b.ToTable("ProgramCategories");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.Programs", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BigImageData");

                    b.Property<string>("BigImageMimeType");

                    b.Property<int>("CategoryId");

                    b.Property<string>("FullDescription")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.Property<byte[]>("SmallImageData");

                    b.Property<string>("SmallImageMimeType");

                    b.HasKey("ProgramId")
                        .HasName("PK_dbo.Programs");

                    b.HasIndex("CategoryId")
                        .HasName("IX_CategoryId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("ImageMimeType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("RoleId");

                    b.HasKey("UserName");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.Workers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BigImageData");

                    b.Property<string>("BigImageMimeType");

                    b.Property<string>("FullDescription");

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("ImageMimeType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.Programs", b =>
                {
                    b.HasOne("CitySpeaks.Domain.Models.ProgramCategories", "Category")
                        .WithMany("Programs")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_dbo.Programs_dbo.ProgramCategories_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CitySpeaks.Domain.Models.User", b =>
                {
                    b.HasOne("CitySpeaks.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
