﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShop.Models;

namespace eShop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20220531102906_InitialCreates")]
    partial class InitialCreates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("eShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 100000001,
                            Image = "images/books/godfather.jpg",
                            LongDesc = "Tyrant, blackmailer, racketeer, murderer - his influence reaches every level of American society. Meet Don Corleone, a friendly man, a just man, a reasonable man. The deadliest lord of the Cosa Nostra. The Godfather. But no man can stay on top forever, not when he has enemies on both sides of the law. As the ageing Vito Corleone nears the end of a long life of crime, his sons must step up to manage the family business. Sonny Corleone is an old hand, while World War II veteran Michael Corleone is unused to the world of crime and reluctant to plunge into the business. Both the police and ruthless rival crime lords scent blood in the water. If the Corleone family is to survive, it needs a ruthless new don. But the price of success in a violent life may be too high to bear...",
                            Name = "The Godfather, Маріо Пьюзо",
                            Price = 500m,
                            ShortDesc = "«Хрещений батько» - роман Маріо Пьюзо, виданий в 1969 році і розповідає про життя одного з могутніх мафіозних кланів Америки - сім'ї дона Корлеоне. Російською мовою вперше опубліковано у журналі «Прапор». У 1972 році твір екранізований Френсісом Фордом Копполою."
                        },
                        new
                        {
                            Id = 100000002,
                            Image = "images/books/graf.jpg",
                            LongDesc = "«Граф Монте-Крісто» Александра Дюма — один із улюблених романів багатьох поколінь читачів. Це розповідь про несправедливо засудженого й ув’язненого в замку Іф юнака Едмона Дантеса. Зумівши утекти з в’язниці й відшукавши скарб, він прагне справедливості та відплати... Що чекає на його кривдників? Чи принесе ця помста задоволення самому Дантесові? Історія добра і зла, кривди й помсти, змальована у книзі, сповнена неабиякої інтриги... До уваги читачів перший том цього захоплюючого роману. Поділ на розділи та томи здійснено на основі прижиттєвого видання твору; такого ж принципу дотримуються і європейські видавці (на ньому, зокрема, заснований і єдиний відомий на сьогодні друкований переклад роману українською мовою, що побачив світ 1924 року у Вінніпеґу).",
                            Name = "Граф Монте-Кристо, Александр Дюма",
                            Price = 200m,
                            ShortDesc = "«Граф Монте-Крісто» - пригодницький роман Олександра Дюма, класика французької літератури, написаний в 1844-1846 роках."
                        },
                        new
                        {
                            Id = 100000003,
                            Image = "images/books/green.jpg",
                            LongDesc = "Пол Еджкомб — колишній наглядач федеральної в’язниці штату Луїзіана «Холодна гора», а нині — мешканець будинку для літніх людей. Більш ніж півстоліття тому він скоїв те, чого досі не може собі вибачити. І тягар минулого знову й знову повертає його до 1932 року. Тоді до блоку Е, в якому утримували засуджених до смертної кари злочинців, прибули «новенькі». Серед тих, на кого чекала сумнозвісна Зелена миля — останній шлях, що проходить засуджений до місця страти, — був Джон Коффі. Його визнали винним у зґвалтуванні та вбивстві двох сестер-близнючок Кори й Кеті Деттерик. Поволі Пол усвідомлює, що цей незграбний велетень, який скидався на сумирну дитину, не може бути монстром-убивцею. Але як врятувати того, хто вже ступив на Зелену милю?",
                            Name = "Зелена миля, Стівен Кінг",
                            Price = 250m,
                            ShortDesc = "«Зелена миля» - роман Стівена Кінга. У 1999 році за цим романом було знято однойменний фільм."
                        },
                        new
                        {
                            Id = 100000004,
                            Image = "images/books/harry.jpg",
                            LongDesc = "У Гоґвортсі пробрався вбивця, на рахунку якого безліч життів і людей, і чарівників. Для охорони школи запрошено зловісні варти в'язниці Азкабан – дементори. Гаррі та його друзі незабаром з'ясовують, чому всі чарівники бояться дементорів, а сам Гаррі вирішує знайти вбивцю.",
                            Name = "Гаррі Поттер і в'язень Азкабана, Джоан Роулінг",
                            Price = 250m,
                            ShortDesc = "Гаррі Поттер і в'язень Азкабана - третя книга Джоан Роулінг із серії романів про Гаррі Поттера."
                        },
                        new
                        {
                            Id = 100000005,
                            Image = "images/books/servant.jpg",
                            LongDesc = "1960-і роки, штат Міссісіпі, США. Ейбілін все своє життя пропрацювала служницею у білих людей, виростила сімнадцять їхніх дітей, але втратила свого єдиного сина. Мінні — невгамовна й нестримна жінка, з якою не варто сперечатися. Через свій непростий характер вона змушена часто змінювати господарів, але роботу таки може знайти: її торти і пироги незрівнянні. Скітер, біла дівчина, після закінчення університету повертається у рідний Джексон. Вона мріє про письменницьку кар’єру і хоче розповісти світові про те, що коїться тут, на Півдні Америки.",
                            Name = "Прислуга, Кетрін Стокетт",
                            Price = 150m,
                            ShortDesc = "«Прислуга» - роман 2009 року американської письменниці Кетрін Стокетт. Він розповідає про афроамериканців,що працюють на білих людей у місті Джексон, штат Міссісіпі, на початку 1960 - х років."
                        },
                        new
                        {
                            Id = 100000006,
                            Image = "images/books/sherlok.jpg",
                            LongDesc = "Це – класика, це – детектив, це література Великобританії XIV-XIX ст., ще прекрасна і у розквіті сил. Сам Конан Дойл, який вигадав індивідуальну особистість, фаната своєї справи, Шерлока Холмса, того, хто став ідеалом для любителів подібної прози, народився в Единбурзі, здобув там медичну освіту та об'їздив чи не весь світ. Він захистив докторську дисертацію та плавав до Арктики, Західної та Південної Африки, служив хірургом на полі бою, під час війни. Незважаючи на фурор, який зробили розповіді про пригоди Холмса та Ватсона, найкращим своїм твором Конан Дойл вважав історичний роман «Білий загін» про Столітню війну. Він отримав титул пера за літературну діяльність, а останні роки життя захоплювався спіритизмом і випустив книгу власним коштом, присвячену цьому. Книга - ціла збірка розповідей про великого лондонського детективу, його пригоди та винахідливості.",
                            Name = "Пригоди Шерлока Холмса, Артур Конан Дойл",
                            Price = 200m,
                            ShortDesc = "«Пригоди Шерлока Холмса» - збірка з 12 детективних оповідань, створених Артуром Конаном Дойлом"
                        });
                });

            modelBuilder.Entity("eShop.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        });
                });

            modelBuilder.Entity("eShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 100000000,
                            Email = "admin@admin.com",
                            Password = "123456",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 100000001,
                            Email = "user@user.com",
                            Password = "123456",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("eShop.Models.Order", b =>
                {
                    b.HasOne("eShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eShop.Models.User", b =>
                {
                    b.HasOne("eShop.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("eShop.Models.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
