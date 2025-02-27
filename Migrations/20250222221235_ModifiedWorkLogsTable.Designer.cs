﻿// <auto-generated />
using System;
using Managemate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Managemate.Migrations
{
    [DbContext(typeof(ManageMateDBConetxt))]
    [Migration("20250222221235_ModifiedWorkLogsTable")]
    partial class ModifiedWorkLogsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Managemate.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Managemate.Models.DepartmentMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("DepartmentMembers");
                });

            modelBuilder.Entity("Managemate.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agenda")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Managemate.Models.MeetingParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<bool>("NotificationSent")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ParticipantId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("MeetingParticipants");
                });

            modelBuilder.Entity("Managemate.Models.TaskToDo", b =>
                {
                    b.Property<string>("TaskId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.Property<string>("SkillsNeeded")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DepartmentId");

                    b.ToTable("TasksToDo");
                });

            modelBuilder.Entity("Managemate.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("JoinedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MinWorkingHours")
                        .HasColumnType("int");

                    b.Property<int?>("Otp")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Skills")
                        .HasColumnType("longtext");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Managemate.Models.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssignedEmployeeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TaskId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedEmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("Managemate.Models.WorkLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TotalMinutesWorked")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkLogs");
                });

            modelBuilder.Entity("Managemate.Models.WorkSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("CheckoutTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WorkLogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkLogId");

                    b.ToTable("WorkSessions");
                });

            modelBuilder.Entity("Managemate.Models.DepartmentMember", b =>
                {
                    b.HasOne("Managemate.Models.Department", "Department")
                        .WithMany("Members")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Managemate.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Managemate.Models.Meeting", b =>
                {
                    b.HasOne("Managemate.Models.User", "Owner")
                        .WithMany("MeetingsCreated")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Managemate.Models.MeetingParticipant", b =>
                {
                    b.HasOne("Managemate.Models.Meeting", "Meeting")
                        .WithMany("Participants")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Managemate.Models.User", "Participant")
                        .WithMany("Meetings")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Managemate.Models.TaskToDo", b =>
                {
                    b.HasOne("Managemate.Models.User", "Creator")
                        .WithMany("CreatedTasks")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Managemate.Models.Department", null)
                        .WithMany("TasksToDo")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Managemate.Models.UserTask", b =>
                {
                    b.HasOne("Managemate.Models.User", "AssignedEmployee")
                        .WithMany("AssignedTasks")
                        .HasForeignKey("AssignedEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Managemate.Models.TaskToDo", "TasksToDo")
                        .WithMany("AssignedUsers")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedEmployee");

                    b.Navigation("TasksToDo");
                });

            modelBuilder.Entity("Managemate.Models.WorkLog", b =>
                {
                    b.HasOne("Managemate.Models.User", "Employee")
                        .WithMany("WorkLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Managemate.Models.WorkSession", b =>
                {
                    b.HasOne("Managemate.Models.WorkLog", "WorkLog")
                        .WithMany("Sessions")
                        .HasForeignKey("WorkLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkLog");
                });

            modelBuilder.Entity("Managemate.Models.Department", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("TasksToDo");
                });

            modelBuilder.Entity("Managemate.Models.Meeting", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("Managemate.Models.TaskToDo", b =>
                {
                    b.Navigation("AssignedUsers");
                });

            modelBuilder.Entity("Managemate.Models.User", b =>
                {
                    b.Navigation("AssignedTasks");

                    b.Navigation("CreatedTasks");

                    b.Navigation("Meetings");

                    b.Navigation("MeetingsCreated");

                    b.Navigation("WorkLogs");
                });

            modelBuilder.Entity("Managemate.Models.WorkLog", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
