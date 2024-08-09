﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WareHouseDAL;

#nullable disable

namespace WareHouseDAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240809081126_intToString")]
    partial class intToString
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeesWareHouse", b =>
                {
                    b.Property<string>("EmployeesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WareHousesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeesId", "WareHousesId");

                    b.HasIndex("WareHousesId");

                    b.ToTable("EmployeesWareHouse");
                });

            modelBuilder.Entity("WareHouseDAL.Entities.Director", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("WareHouseDAL.Entities.Employees", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WareHouseDAL.Entities.WareHouse", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DirectorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("WareHouses");
                });

            modelBuilder.Entity("EmployeesWareHouse", b =>
                {
                    b.HasOne("WareHouseDAL.Entities.Employees", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WareHouseDAL.Entities.WareHouse", null)
                        .WithMany()
                        .HasForeignKey("WareHousesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WareHouseDAL.Entities.WareHouse", b =>
                {
                    b.HasOne("WareHouseDAL.Entities.Director", "Director")
                        .WithMany("WareHouses")
                        .HasForeignKey("DirectorId");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("WareHouseDAL.Entities.Director", b =>
                {
                    b.Navigation("WareHouses");
                });
#pragma warning restore 612, 618
        }
    }
}