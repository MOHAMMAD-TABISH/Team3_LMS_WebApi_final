﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_LMS_Team3.DataAccessLayer;

namespace Team3_LMS_WebApi.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    partial class DataAccessLayer_LMSModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ApplyLeaveDb", b =>
                {
                    b.Property<int>("LeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppliedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mng_Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mng_Id")
                        .HasColumnType("int");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LeaveId");

                    b.HasIndex("Emp_Id");

                    b.ToTable("ApplyLeave_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.EmployeeDb", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Available_Leave")
                        .HasColumnType("bigint");

                    b.Property<string>("Emp_Dept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Emp_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Emp_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("Employee_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ManagerDb", b =>
                {
                    b.Property<int>("serialno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Mng_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mng_Id")
                        .HasColumnType("int");

                    b.Property<long>("Mng_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Mng_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("serialno");

                    b.HasIndex("Mng_Id");

                    b.ToTable("Manager_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ApplyLeaveDb", b =>
                {
                    b.HasOne("WebApi_LMS_Team3.Model.EmployeeDb", "Employee")
                        .WithMany()
                        .HasForeignKey("Emp_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ManagerDb", b =>
                {
                    b.HasOne("WebApi_LMS_Team3.Model.EmployeeDb", "Employee")
                        .WithMany()
                        .HasForeignKey("Mng_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
