using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Filler.Filling
{
    public static class TeachersSeed
    {
        public static void SeedTeachers(this CespContext context)
        {
            if (context.Teachers.FirstOrDefault(c => c.Name == "Йосу") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/josu-foto.jpg",
                    Info = "Йосу",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Йосу",
                    Post = "преподаватель",
                    Info =
                        "Йосу — преподаватель-носитель испанского языка из Барселоны с большим опытом работы. Имеет международный сертификат ELE для преподавания испанского как иностранного (от International House Barcelona, утвержденным Университетом Барселоны). Кроме того Йосу является дипломированным экзаменатором экзамена DELE, это значит что он может как принимать экзамен, так и подготавливать студентов для сдачи DELE. И конечно, имеет сертификат, подтверждающий квалификацию преподавателя от Института Сервантеса г. Москвы. Работает как со взрослыми, так и с детьми у которых всегда имеет особенный успех. Уроки проходят в дружественной, неформальной обстановке, что способствует эффективному и быстрому усвоению материала. Владеет русским языком.",
                    PhotoId = photo.Id
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Анхель") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/anhel-photo.jpeg",
                    Info = "Анхель",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Анхель",
                    Post = "преподаватель",
                    Info =
                        "Анхель – опытный преподаватель испанского языка из Малаги. Позитивный, открытый и добрый. На уроках любит разложить все объяснения по полочкам, что облегчает процесс усвоения материала. В Москве преподаёт испанский с 2012 прекрасно ладит как со взрослыми, так и с детьми, готовит свои уроки индивидуально, с учетом потребностей, интересов и особенностей каждой группы, но конечно в рамках Международного стандарта преподавания испанского языка иностранцам. Увлекается классической музыкой. Прекрасно владеет русским языком.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Рафаэль") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/rafael_200x193.png",
                    Info = "Рафаэль",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Рафаэль",
                    Post = "преподаватель",
                    Info =
                        "Рафаэль - преподаватель-носитель испанского и каталанского языков из Барселоны. В Россию приехал в 2013 году, до этого жил и работал в Англии. Имеет сертификаты Института Сервантеса о специальной подготовке преподавателей которые дают право преподавать язык иностранным студентам. Открытый, жизнерадостный и общительный. Ему нравится путешествовать, познавать новые культуры и обмениваться своим опытом с другими людьми. Творчески подходит к подготовке своих уроков испанского и каталанского и поэтому его занятия всегда динамичные и интересные. На своих уроках он использует коммуникативную методику, соответствующую международным стандартам. На занятиях у Рафаэля при погружении в языковую среду студент с первых уроков начинает говорить на испанском языке. Прекрасно ладит как со взрослыми, так и с детьми и подростками. Владеет русским языком.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Альберто") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/alberto.jpg",
                    Info = "Альберто",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Альберто",
                    Post = "преподаватель",
                    Info =
                        "Альберто преподаватель-носитель испанского языка, родился в Гранаде. Имеет обширный опыт преподавания испанского языка для иностранцев, как в Испании так и в России. На занятиях с Альберто всегда интересно и весело. Студенты активно вовлечены в учебный процесс. Альберто знает древние языки, такие как: латинский и греческий, что позволяет ему давать более глубокий материал по испанскому языку. Так же свободно владеет русским языком.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Алехо") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/alejo.jpg",
                    Info = "Алехо",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Алехо",
                    Post = "преподаватель",
                    Info =
                        "Алехо - преподаватель испанского языка с более чем девятилетним опытом работы. Он отлично понимает потребности и трудности своих учеников, так как сам учился русскому, английскому, французскому и португальскому языкам, и знает все \"подводные камни\" при изучении иностранных языков и, несомненно, поможет их избежать своим судентам. Алехо очень позитивный, понимающий и терпеливый человек, что особенно важно в профессии преподавателя. Алехо имеет диплом бакалавра по экономике, также успешно прошел курсы по повышению квалиффикации в Институте Сервантеса. Кроме того, является официальным экзаменатором Dele для уровней A, B и C.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Пабло") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/pablo.jpeg",
                    Info = "Пабло",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Пабло",
                    Post = "преподаватель",
                    Info =
                        "Пабло - преподаватель испанского языка из Венесуэлы. Работает как со взрослыми, так и с детскими группами, у которых всегда имеет особенный успех. Веселый, молодой, харизматичный преподаватель. Всегда тщательно подбирает материалы для каждого занятия. Очень ответственно относится к своей работе, и результатам своих студентов.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Джонатан") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/jonatan.jpg",
                    Info = "Джонатан",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Джонатан",
                    Post = "преподаватель",
                    Info =
                        @"Джонатан жизнелюбивый и опытный преподаватель из Испании (Барселона). Имеет педагогическое образование (воспитатель в детском саду), что дало ему возможность работать с детьми разных возрастов и преподавать им испанский язык как иностранный. 
                    Уже три года Джонатан обучает испанскому языку как детей, так и взрослых. Программу занятий для каждого ученика подбирает индивидуально и адаптирует методику под его особенности, уровень владения языком, возраст и потребности. Его занятия всегда увлекательны и динамичными, и при всем при этом, эффективные и полезные.Владеет русским языком.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            
            if (context.Teachers.FirstOrDefault(c => c.Name == "Юлия") == null)
            {
                var photo = new FileDto
                {
                    Name = "teachers/julia.png",
                    Info = "Юлия",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var teacher = new TeacherDto
                {
                    Name = "Юлия",
                    Post = "преподаватель, лингвист",
                    Info =
                        "Юлия разносторонний и творческий человек. Закончила с отличием филологический факультет МГУ им М.В. Ломоносова. Прошла стажировку в Университете Барселоны. Три года работает преподавателем испанского и каталанского языков. Владеет коммуникативной методикой преподавания для иностранцев. На своих уроках особое внимание уделяет грамматике и разговорной лексике, а также культуре и литературе стран изучаемого языка.",
                    PhotoId = photo.Id,
                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }
    }
}