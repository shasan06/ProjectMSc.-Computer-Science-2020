﻿// <auto-generated />
using Metrics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Metrics.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200706212959_Modified Response, Registration")]
    partial class ModifiedResponseRegistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Metrics.Models.Complexity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Complexities");
                });

            modelBuilder.Entity("Metrics.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Metrics.Models.Question", b =>
                {
                    b.Property<int>("questionid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("firstoperand")
                        .HasColumnType("int");

                    b.Property<int>("levelid")
                        .HasColumnType("int");

                    b.Property<int>("secondoperand")
                        .HasColumnType("int");

                    b.HasKey("questionid");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Metrics.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("RegistrationId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Metrics.Models.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Answer")
                        .HasColumnType("bit");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<double>("MarksObtained")
                        .HasColumnType("float");

                    b.Property<string>("QuestionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.Property<string>("Test")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}