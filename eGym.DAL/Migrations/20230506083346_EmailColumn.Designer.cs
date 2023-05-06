﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eGym.DAL;

#nullable disable

namespace eGym.DAL.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230506083346_EmailColumn")]
    partial class EmailColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eGym.Domain.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            BirthDate = new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9500),
                            FirstName = "user",
                            Gender = 1,
                            LastName = "user",
                            Password = "test",
                            Role = 2,
                            Username = "user"
                        });
                });

            modelBuilder.Entity("eGym.Domain.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<string>("CVC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("eGym.Domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StripeCustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CardId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("eGym.Domain.Diet", b =>
                {
                    b.Property<int>("DietId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DietId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Meal")
                        .HasColumnType("int");

                    b.HasKey("DietId");

                    b.HasIndex("AccountId");

                    b.ToTable("Diet");
                });

            modelBuilder.Entity("eGym.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9640),
                            FirstName = "desktop",
                            Gender = 1,
                            LastName = "desktop",
                            Password = "test",
                            Role = 0,
                            Username = "desktop"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9650),
                            FirstName = "mobile",
                            Gender = 1,
                            LastName = "mobile",
                            Password = "test",
                            Role = 0,
                            Username = "mobile"
                        },
                        new
                        {
                            EmployeeId = 3,
                            BirthDate = new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9650),
                            FirstName = "employee",
                            Gender = 1,
                            LastName = "employee",
                            Password = "test",
                            Role = 1,
                            Username = "employee"
                        });
                });

            modelBuilder.Entity("eGym.Domain.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Employees")
                        .HasColumnType("int");

                    b.Property<int>("Equipment")
                        .HasColumnType("int");

                    b.Property<int>("ServiceQuality")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.HasIndex("AccountId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("eGym.Domain.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<int>("CCV")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiptEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("eGym.Domain.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservationId");

                    b.HasIndex("AccountId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("eGym.Domain.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Descritption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("eGym.Domain.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Meal")
                        .HasColumnType("int");

                    b.HasKey("TrainingId");

                    b.HasIndex("AccountId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("eGym.Domain.Customer", b =>
                {
                    b.HasOne("eGym.Domain.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGym.Domain.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("eGym.Domain.Diet", b =>
                {
                    b.HasOne("eGym.Domain.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("eGym.Domain.Feedback", b =>
                {
                    b.HasOne("eGym.Domain.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("eGym.Domain.Payment", b =>
                {
                    b.HasOne("eGym.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGym.Domain.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId");

                    b.Navigation("Customer");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("eGym.Domain.Reservation", b =>
                {
                    b.HasOne("eGym.Domain.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGym.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("eGym.Domain.Training", b =>
                {
                    b.HasOne("eGym.Domain.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}