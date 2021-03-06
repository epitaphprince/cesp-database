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
    [Migration("20190418155343_Seed-Dictionaries")]
    partial class SeedDictionaries
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A1",
                            Rang = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "A2.1",
                            Rang = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "A2.2",
                            Rang = 4
                        },
                        new
                        {
                            Id = 4,
                            Name = "B1.1",
                            Rang = 5
                        },
                        new
                        {
                            Id = 5,
                            Name = "B1.2",
                            Rang = 6
                        },
                        new
                        {
                            Id = 6,
                            Name = "B2.1",
                            Rang = 7
                        },
                        new
                        {
                            Id = 7,
                            Name = "B2.2",
                            Rang = 8
                        },
                        new
                        {
                            Id = 8,
                            Name = "B2.3",
                            Rang = 9
                        },
                        new
                        {
                            Id = 9,
                            Name = "C1.1",
                            Rang = 10
                        },
                        new
                        {
                            Id = 10,
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "Йосу — преподаватель-носитель испанского языка из Барселоны с большим опытом работы. Имеет международный сертификат ELE для преподавания испанского как иностранного (от International House Barcelona, утвержденным Университетом Барселоны). Кроме того Йосу является дипломированным экзаменатором экзамена DELE, это значит что он может как принимать экзамен, так и подготавливать студентов для сдачи DELE. И конечно, имеет сертификат, подтверждающий квалификацию преподавателя от Института Сервантеса г. Москвы. Работает как со взрослыми, так и с детьми у которых всегда имеет особенный успех. Уроки проходят в дружественной, неформальной обстановке, что способствует эффективному и быстрому усвоению материала. Владеет русским языком.",
                            Name = "Йосу",
                            PhotoId = 1,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 2,
                            Info = "Анхель – опытный преподаватель испанского языка из Малаги. Позитивный, открытый и добрый. На уроках любит разложить все объяснения по полочкам, что облегчает процесс усвоения материала. В Москве преподаёт испанский с 2012 прекрасно ладит как со взрослыми, так и с детьми, готовит свои уроки индивидуально, с учетом потребностей, интересов и особенностей каждой группы, но конечно в рамках Международного стандарта преподавания испанского языка иностранцам. Увлекается классической музыкой. Прекрасно владеет русским языком.",
                            Name = "Анхель",
                            PhotoId = 2,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 3,
                            Info = "Рафаэль - преподаватель-носитель испанского и каталанского языков из Барселоны. В Россию приехал в 2013 году, до этого жил и работал в Англии. Имеет сертификаты Института Сервантеса о специальной подготовке преподавателей которые дают право преподавать язык иностранным студентам. Открытый, жизнерадостный и общительный. Ему нравится путешествовать, познавать новые культуры и обмениваться своим опытом с другими людьми. Творчески подходит к подготовке своих уроков испанского и каталанского и поэтому его занятия всегда динамичные и интересные. На своих уроках он использует коммуникативную методику, соответствующую международным стандартам. На занятиях у Рафаэля при погружении в языковую среду студент с первых уроков начинает говорить на испанском языке. Прекрасно ладит как со взрослыми, так и с детьми и подростками. Владеет русским языком.",
                            Name = "Рафаэль",
                            PhotoId = 3,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 4,
                            Info = "Альберто преподаватель-носитель испанского языка, родился в Гранаде. Имеет обширный опыт преподавания испанского языка для иностранцев, как в Испании так и в России. На занятиях с Альберто всегда интересно и весело. Студенты активно вовлечены в учебный процесс. Альберто знает древние языки, такие как: латинский и греческий, что позволяет ему давать более глубокий материал по испанскому языку. Так же свободно владеет русским языком.",
                            Name = "Альберто",
                            PhotoId = 4,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 5,
                            Info = "Алехо - преподаватель испанского языка с более чем девятилетним опытом работы. Он отлично понимает потребности и трудности своих учеников, так как сам учился русскому, английскому, французскому и португальскому языкам, и знает все \"подводные камни\" при изучении иностранных языков и, несомненно, поможет их избежать своим судентам. Алехо очень позитивный, понимающий и терпеливый человек, что особенно важно в профессии преподавателя. Алехо имеет диплом бакалавра по экономике, также успешно прошел курсы по повышению квалиффикации в Институте Сервантеса. Кроме того, является официальным экзаменатором Dele для уровней A, B и C.",
                            Name = "Алехо",
                            PhotoId = 5,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 6,
                            Info = "Пабло - преподаватель испанского языка из Венесуэлы. Работает как со взрослыми, так и с детскими группами, у которых всегда имеет особенный успех. Веселый, молодой, харизматичный преподаватель. Всегда тщательно подбирает материалы для каждого занятия. Очень ответственно относится к своей работе, и результатам своих студентов.",
                            Name = "Пабло",
                            PhotoId = 6,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 7,
                            Info = @"Джонатан жизнелюбивый и опытный преподаватель из Испании (Барселона). Имеет педагогическое образование (воспитатель в детском саду), что дало ему возможность работать с детьми разных возрастов и преподавать им испанский язык как иностранный. 
                    Уже три года Джонатан обучает испанскому языку как детей, так и взрослых. Программу занятий для каждого ученика подбирает индивидуально и адаптирует методику под его особенности, уровень владения языком, возраст и потребности. Его занятия всегда увлекательны и динамичными, и при всем при этом, эффективные и полезные.Владеет русским языком.",
                            Name = "Джонатан",
                            PhotoId = 7,
                            Post = "преподаватель"
                        },
                        new
                        {
                            Id = 8,
                            Info = "Юлия разносторонний и творческий человек. Закончила с отличием филологический факультет МГУ им М.В. Ломоносова. Прошла стажировку в Университете Барселоны. Три года работает преподавателем испанского и каталанского языков. Владеет коммуникативной методикой преподавания для иностранцев. На своих уроках особое внимание уделяет грамматике и разговорной лексике, а также культуре и литературе стран изучаемого языка.",
                            Name = "Юлия",
                            PhotoId = 8,
                            Post = "преподаватель, лингвист"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "Йосу",
                            Name = "teachers/josu-foto.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Info = "Анхель",
                            Name = "teachers/anhel-photo.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Info = "Рафаэль",
                            Name = "teachers/rafael_200x193.png"
                        },
                        new
                        {
                            Id = 4,
                            Info = "Альберто",
                            Name = "teachers/alberto.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Info = "Алехо",
                            Name = "teachers/alejo.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Info = "Пабло",
                            Name = "teachers/pablo.jpeg"
                        },
                        new
                        {
                            Id = 7,
                            Info = "Джонатан",
                            Name = "teachers/jonatan.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Info = "Юлия",
                            Name = "teachers/julia.png"
                        });
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
