﻿// <auto-generated />
using System;
using CESP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    [DbContext(typeof(CespContext))]
    [Migration("20190505162000_Delete-Press")]
    partial class DeletePress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<int?>("PhotoId")
                        .HasColumnName("photo_id");

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.Property<DateTime>("Start")
                        .HasColumnName("start");

                    b.Property<string>("SysName")
                        .IsRequired()
                        .HasColumnName("sysname")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("SysName")
                        .IsUnique();

                    b.ToTable("activities");
                });

            modelBuilder.Entity("CESP.Database.Context.Activities.Models.ActivityFilesDto", b =>
                {
                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("FileId")
                        .HasColumnName("file_id");

                    b.HasKey("ActivityId", "FileId");

                    b.HasIndex("FileId");

                    b.ToTable("activity_files");
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "Начальный уровень",
                            Name = "A1",
                            Rang = 1
                        },
                        new
                        {
                            Id = 2,
                            Info = "Базовый уровень",
                            Name = "A2.1",
                            Rang = 3
                        },
                        new
                        {
                            Id = 3,
                            Info = "Базовый уровень",
                            Name = "A2.2",
                            Rang = 4
                        },
                        new
                        {
                            Id = 4,
                            Info = "Продвинутый уровень",
                            Name = "B1.1",
                            Rang = 5
                        },
                        new
                        {
                            Id = 5,
                            Info = "Продвинутый уровень",
                            Name = "B1.2",
                            Rang = 6
                        },
                        new
                        {
                            Id = 6,
                            Info = "Продвинутый уровень",
                            Name = "B2.1",
                            Rang = 7
                        },
                        new
                        {
                            Id = 7,
                            Info = "Продвинутый уровень",
                            Name = "B2.2",
                            Rang = 8
                        },
                        new
                        {
                            Id = 8,
                            Info = "Продвинутый уровень",
                            Name = "B2.3",
                            Rang = 9
                        },
                        new
                        {
                            Id = 9,
                            Info = "Продвинутый уровень",
                            Name = "C1.1",
                            Rang = 10
                        },
                        new
                        {
                            Id = 10,
                            Info = "Продвинутый уровень",
                            Name = "C1.2",
                            Rang = 11
                        },
                        new
                        {
                            Id = 11,
                            Name = "C2.1",
                            Rang = 12
                        },
                        new
                        {
                            Id = 12,
                            Name = "C2.2",
                            Rang = 13
                        },
                        new
                        {
                            Id = 13,
                            Name = "C1+",
                            Rang = 14
                        },
                        new
                        {
                            Id = 14,
                            Name = "C2+",
                            Rang = 15
                        });
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
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<int?>("PhotoId")
                        .HasColumnName("photo_id");

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.Property<string>("SysName")
                        .IsRequired()
                        .HasColumnName("sysname")
                        .HasMaxLength(256);

                    b.Property<int?>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.HasKey("Id");

                    b.HasIndex("MaxLanguageLevelId");

                    b.HasIndex("MinLanguageLevelId");

                    b.HasIndex("PhotoId");

                    b.HasIndex("SysName")
                        .IsUnique();

                    b.HasIndex("TeacherId");

                    b.ToTable("speaking_club_meetings");
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
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "руб."
                        });
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

                    b.Property<int?>("CurrencyId")
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

                    b.HasIndex("CurrencyId");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("prices");
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

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.GroupBunchDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("SysName")
                        .IsRequired()
                        .HasColumnName("sysname")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("SysName")
                        .IsUnique();

                    b.ToTable("group_bunches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Взрослые группы",
                            SysName = "adult"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Детские группы",
                            SysName = "children"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Молодежные и подростковые группы",
                            SysName = "teen"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Группы каталонского языка",
                            SysName = "catalan"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Расписание и цены",
                            SysName = "schedules"
                        });
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.GroupDurationDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<double>("Duration")
                        .HasColumnName("duration");

                    b.Property<int>("StudentGroupId")
                        .HasColumnName("student_group_id");

                    b.Property<int>("TimeUnitId")
                        .HasColumnName("time_unit_id");

                    b.HasKey("Id");

                    b.HasIndex("StudentGroupId");

                    b.HasIndex("TimeUnitId");

                    b.ToTable("group_durations");
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.GroupTimeDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("group_times");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Утренний курс"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Дневной курс"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Вечерний курс"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Курс выходного дня"
                        });
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.StudentGroupDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("CountStudentsMax")
                        .HasColumnName("count_students_max");

                    b.Property<int?>("CountStudentsMin")
                        .HasColumnName("count_students_min");

                    b.Property<int?>("CourseId")
                        .HasColumnName("course_id");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int?>("GroupBunchId")
                        .HasColumnName("group_bunch_id");

                    b.Property<int?>("GroupTimeId")
                        .HasColumnName("group_time_id");

                    b.Property<bool>("IsAvailable")
                        .HasColumnName("available");

                    b.Property<bool>("IsWorking")
                        .HasColumnName("working");

                    b.Property<int?>("LanguageLevelId")
                        .HasColumnName("language_level_id");

                    b.Property<DateTime?>("Start")
                        .HasColumnName("date_start");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("GroupBunchId");

                    b.HasIndex("GroupTimeId");

                    b.HasIndex("LanguageLevelId");

                    b.ToTable("student_groups");
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.TimeUnitDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("time_units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ак.ч"
                        },
                        new
                        {
                            Id = 2,
                            Name = "нед"
                        },
                        new
                        {
                            Id = 3,
                            Name = "мес"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "facebook"
                        },
                        new
                        {
                            Id = 2,
                            Name = "vk"
                        },
                        new
                        {
                            Id = 3,
                            Name = "e-mail"
                        },
                        new
                        {
                            Id = 4,
                            Name = "анкета"
                        });
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

            modelBuilder.Entity("CESP.Database.Context.Activities.Models.ActivityDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("course_file_fk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("CESP.Database.Context.Activities.Models.ActivityFilesDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Activities.Models.ActivityDto", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("activity_files_activity_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .HasConstraintName("activity_files_file_fk")
                        .OnDelete(DeleteBehavior.Cascade);
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
                        .HasForeignKey("MaxLanguageLevelId")
                        .HasConstraintName("max_language_meeting_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "MinLanguageLevel")
                        .WithMany()
                        .HasForeignKey("MinLanguageLevelId")
                        .HasConstraintName("min_language_meeting_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Files.Models.FileDto", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("club_file_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Education.Models.TeacherDto", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("teacher_meeting_fk")
                        .OnDelete(DeleteBehavior.SetNull);
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
                    b.HasOne("CESP.Database.Context.Payments.Models.CurrencyDto", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .HasConstraintName("price_currency_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.StudentGroups.Models.StudentGroupDto", "Group")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("price_student_group_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDto", b =>
                {
                    b.HasOne("CESP.Database.Context.StudentGroups.Models.StudentGroupDto", "StudentGroup")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("schedule_student_group_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.GroupDurationDto", b =>
                {
                    b.HasOne("CESP.Database.Context.StudentGroups.Models.StudentGroupDto", "Group")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("group_duration_student_group_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CESP.Database.Context.StudentGroups.Models.TimeUnitDto", "TimeUnit")
                        .WithMany()
                        .HasForeignKey("TimeUnitId")
                        .HasConstraintName("group_duration_time_unit_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.StudentGroups.Models.StudentGroupDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.CourseDto", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("student_group_course_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CESP.Database.Context.StudentGroups.Models.GroupBunchDto", "Bunch")
                        .WithMany()
                        .HasForeignKey("GroupBunchId")
                        .HasConstraintName("group_group_bunch_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.StudentGroups.Models.GroupTimeDto", "GroupTime")
                        .WithMany()
                        .HasForeignKey("GroupTimeId")
                        .HasConstraintName("group_group_time_fk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "LanguageLevel")
                        .WithMany()
                        .HasForeignKey("LanguageLevelId")
                        .HasConstraintName("group_language_level_fk")
                        .OnDelete(DeleteBehavior.SetNull);
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
