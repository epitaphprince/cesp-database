﻿// <auto-generated />
using System;
using CESP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    [DbContext(typeof(CespContext))]
    partial class CespContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CESP.Database.Context.Activities.Models.ActivityDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("End")
                        .HasColumnName("end");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.Property<DateTime>("Start")
                        .HasColumnName("start");

                    b.HasKey("Id");

                    b.ToTable("activities");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.CourseDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasColumnName("short_info");

                    b.Property<string>("DurationInfo")
                        .HasColumnName("duration_info");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<int?>("PhotoId")
                        .HasColumnName("photo_id");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("cources");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.LanguageLevelDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NativeName")
                        .HasColumnName("native_name")
                        .HasMaxLength(256);

                    b.Property<int?>("Rang")
                        .HasColumnName("rang");

                    b.HasKey("Id");

                    b.ToTable("language_levels");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.SpeakingClubMeetingDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<int?>("MaxLanguageLevelId")
                        .HasColumnName("max_language_level_id");

                    b.Property<int?>("MinLanguageLevelId")
                        .HasColumnName("min_language_level_id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int?>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.Property<int?>("max_language_meeting_fk");

                    b.Property<int?>("min_language_meeting_fk");

                    b.Property<int?>("teacher_meeting_fk");

                    b.HasKey("Id");

                    b.HasIndex("max_language_meeting_fk");

                    b.HasIndex("min_language_meeting_fk");

                    b.HasIndex("teacher_meeting_fk");

                    b.ToTable("speaking_club_meetings");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("CountStudentsMax")
                        .HasColumnName("count_students_max");

                    b.Property<int?>("CountStudentsMin")
                        .HasColumnName("count_students_min");

                    b.Property<int>("CourseId")
                        .HasColumnName("course_id");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<bool>("IsAvailable")
                        .HasColumnName("available");

                    b.Property<bool>("IsWorking")
                        .HasColumnName("working");

                    b.Property<DateTime?>("Start")
                        .HasColumnName("date_start");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("student_groups");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.TeacherDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<int?>("PhotoId")
                        .HasColumnName("photo_id");

                    b.Property<string>("Post")
                        .HasColumnName("post")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("CESP.Database.Context.Files.Models.FileDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("files");
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.CurrencyDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("currencies");
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.PriceDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<decimal>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("CostInfo")
                        .HasColumnName("cost_info")
                        .HasMaxLength(256);

                    b.Property<int?>("CourseDtoId");

                    b.Property<int>("CurrencyId")
                        .HasColumnName("currency_id");

                    b.Property<string>("DiscountInfo")
                        .HasColumnName("discount_info")
                        .HasMaxLength(256);

                    b.Property<int?>("DiscountPer")
                        .HasColumnName("discounter");

                    b.Property<string>("PaymentPeriod")
                        .HasColumnName("payment_period")
                        .HasMaxLength(256);

                    b.Property<int>("StudentGroupId")
                        .HasColumnName("group_id");

                    b.HasKey("Id");

                    b.HasIndex("CourseDtoId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("prices");
                });

            modelBuilder.Entity("CESP.Database.Context.Press.Models.PressDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("BlogUrl")
                        .HasColumnName("blog_url");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("Source")
                        .HasColumnName("source")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("presses");
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnName("day")
                        .HasMaxLength(256);

                    b.Property<TimeSpan>("EndLessonTime")
                        .HasColumnName("lesson_end");

                    b.Property<TimeSpan>("StartLessonTime")
                        .HasColumnName("lesson_start");

                    b.Property<int>("StudentGroupId")
                        .HasColumnName("student_group_id");

                    b.HasKey("Id");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("CESP.Database.Context.Schools.Models.SchoolDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Location")
                        .HasColumnName("location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.HasKey("Id");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.FeedbackDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message");

                    b.Property<int?>("PhotoId")
                        .HasColumnName("photo_id");

                    b.Property<string>("Signature")
                        .HasColumnName("signature");

                    b.Property<int?>("SourceId")
                        .HasColumnName("source_id");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("SourceId");

                    b.HasIndex("UserId");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.FeedbackSourceDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("feedback_sources");
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.CourseDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("course_file_fk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.SpeakingClubMeetingDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "MaxLanguageLevel")
                        .WithMany()
                        .HasForeignKey("max_language_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "MinLanguageLevel")
                        .WithMany()
                        .HasForeignKey("min_language_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.TeacherDto", "Teacher")
                        .WithMany()
                        .HasForeignKey("teacher_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.CourseDto", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("student_group_course_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.TeacherDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("teacher_file_fk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.PriceDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.CourseDto")
                        .WithMany("Prices")
                        .HasForeignKey("CourseDtoId");

                    b.HasOne("CESP.Database.Context.Payments.Models.CurrencyDto", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .HasConstraintName("price_currency_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.StudentGroupDto", "Group")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("price_student_group_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.StudentGroupDto", "StudentGroup")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("schedule_student_group_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.FeedbackDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("feedback_photo_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Users.Models.FeedbackSourceDto", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .HasConstraintName("feedback_source_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Users.Models.UserDto", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("feedback_user_fk")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}