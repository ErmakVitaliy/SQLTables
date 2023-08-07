﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLTables.DBContext;

#nullable disable

namespace SQLTables.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("SQLTables.Domain.Entity.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("author_id");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name_author");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Булгаков М.А."
                        },
                        new
                        {
                            Id = 2,
                            Name = "Достоевский Ф.М."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Есенин С.А"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Пастернак Б.Л"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Лермонтов М.Ю."
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("book_id");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("author_id");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("genre_id");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 3,
                            AuthorId = 1,
                            GenreId = 1,
                            Price = 670.99m,
                            Title = "Мастер и Маргарита"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 5,
                            AuthorId = 1,
                            GenreId = 1,
                            Price = 540.50m,
                            Title = "Белая гвардия"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 10,
                            AuthorId = 2,
                            GenreId = 1,
                            Price = 460.00m,
                            Title = "Идиот"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 2,
                            AuthorId = 2,
                            GenreId = 1,
                            Price = 799.01m,
                            Title = "Братья Карамазовы"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 10,
                            AuthorId = 2,
                            GenreId = 1,
                            Price = 480.50m,
                            Title = "Игрок"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 15,
                            AuthorId = 3,
                            GenreId = 2,
                            Price = 650.00m,
                            Title = "Стихотворения и поэмы"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 6,
                            AuthorId = 3,
                            GenreId = 2,
                            Price = 570.20m,
                            Title = "Черный человек"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 2,
                            AuthorId = 4,
                            GenreId = 2,
                            Price = 518.99m,
                            Title = "Лирика"
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Buy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("buy_id");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("client_id");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("buy_description");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Buys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Description = "Доставка только вечером"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 3,
                            Description = ""
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            Description = "Упаковать каждую книгу по отдельности"
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 1,
                            Description = ""
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.BuyBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("buy_book_id");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("book_id");

                    b.Property<int>("BuyId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("buy_id");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BuyId");

                    b.ToTable("BuyBooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1,
                            BookId = 1,
                            BuyId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 2,
                            BookId = 7,
                            BuyId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            BookId = 3,
                            BuyId = 1
                        },
                        new
                        {
                            Id = 4,
                            Amount = 2,
                            BookId = 8,
                            BuyId = 2
                        },
                        new
                        {
                            Id = 5,
                            Amount = 2,
                            BookId = 3,
                            BuyId = 3
                        },
                        new
                        {
                            Id = 6,
                            Amount = 1,
                            BookId = 2,
                            BuyId = 3
                        },
                        new
                        {
                            Id = 7,
                            Amount = 1,
                            BookId = 1,
                            BuyId = 3
                        },
                        new
                        {
                            Id = 8,
                            Amount = 1,
                            BookId = 5,
                            BuyId = 4
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.BuyStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("buy_step_id");

                    b.Property<int>("BuyId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("buy_id");

                    b.Property<DateTime?>("DateStepBeg")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_step_beg");

                    b.Property<DateTime?>("DateStepEnd")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_step_end");

                    b.Property<int>("StepId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("step_id");

                    b.HasKey("Id");

                    b.HasIndex("BuyId");

                    b.HasIndex("StepId")
                        .IsUnique();

                    b.ToTable("BuySteps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyId = 1,
                            DateStepBeg = new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 1
                        },
                        new
                        {
                            Id = 2,
                            BuyId = 1,
                            DateStepBeg = new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 2
                        },
                        new
                        {
                            Id = 3,
                            BuyId = 1,
                            DateStepBeg = new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 3
                        },
                        new
                        {
                            Id = 4,
                            BuyId = 1,
                            DateStepBeg = new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 3
                        },
                        new
                        {
                            Id = 5,
                            BuyId = 2,
                            DateStepBeg = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 1
                        },
                        new
                        {
                            Id = 6,
                            BuyId = 2,
                            DateStepBeg = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 2
                        },
                        new
                        {
                            Id = 7,
                            BuyId = 2,
                            DateStepBeg = new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 3
                        },
                        new
                        {
                            Id = 8,
                            BuyId = 2,
                            StepId = 4
                        },
                        new
                        {
                            Id = 9,
                            BuyId = 3,
                            DateStepBeg = new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 1
                        },
                        new
                        {
                            Id = 10,
                            BuyId = 3,
                            DateStepBeg = new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 2
                        },
                        new
                        {
                            Id = 11,
                            BuyId = 3,
                            DateStepBeg = new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStepEnd = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 3
                        },
                        new
                        {
                            Id = 12,
                            BuyId = 3,
                            DateStepBeg = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 4
                        },
                        new
                        {
                            Id = 13,
                            BuyId = 4,
                            DateStepBeg = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StepId = 1
                        },
                        new
                        {
                            Id = 14,
                            BuyId = 4,
                            StepId = 2
                        },
                        new
                        {
                            Id = 15,
                            BuyId = 4,
                            StepId = 3
                        },
                        new
                        {
                            Id = 16,
                            BuyId = 4,
                            StepId = 4
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("city_id");

                    b.Property<int>("DaysDelivery")
                        .HasColumnType("INTEGER")
                        .HasColumnName("days_delivery");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name_city");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DaysDelivery = 5,
                            Name = "Москва"
                        },
                        new
                        {
                            Id = 2,
                            DaysDelivery = 3,
                            Name = "Санкт-Петербург"
                        },
                        new
                        {
                            Id = 3,
                            DaysDelivery = 12,
                            Name = "Владивосток"
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("client_id");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("city_id");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameClient")
                        .HasColumnType("TEXT")
                        .HasColumnName("name_client");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 3,
                            Email = "baranov@test",
                            NameClient = "Баранов Павел"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Email = "abramova@test",
                            NameClient = "Абрамова Катя"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Email = "semenov@test",
                            NameClient = "Семенонов Иван"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            Email = "yakovleva@test",
                            NameClient = "Яковлева Галина"
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("genre_id");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name_genre");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Роман"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Поэзия"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Приключения"
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameStep")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Steps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameStep = "Оплата"
                        },
                        new
                        {
                            Id = 2,
                            NameStep = "Упаковка"
                        },
                        new
                        {
                            Id = 3,
                            NameStep = "Транспортировка"
                        },
                        new
                        {
                            Id = 4,
                            NameStep = "Доставка"
                        });
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Book", b =>
                {
                    b.HasOne("SQLTables.Domain.Entity.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQLTables.Domain.Entity.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Buy", b =>
                {
                    b.HasOne("SQLTables.Domain.Entity.Client", "Client")
                        .WithMany("Buys")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.BuyBook", b =>
                {
                    b.HasOne("SQLTables.Domain.Entity.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQLTables.Domain.Entity.Buy", "Buy")
                        .WithMany()
                        .HasForeignKey("BuyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Buy");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.BuyStep", b =>
                {
                    b.HasOne("SQLTables.Domain.Entity.Buy", "Buy")
                        .WithMany()
                        .HasForeignKey("BuyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQLTables.Domain.Entity.Step", "Step")
                        .WithOne("BuyStep")
                        .HasForeignKey("SQLTables.Domain.Entity.BuyStep", "StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buy");

                    b.Navigation("Step");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Client", b =>
                {
                    b.HasOne("SQLTables.Domain.Entity.City", "City")
                        .WithMany("Clients")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.City", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Client", b =>
                {
                    b.Navigation("Buys");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("SQLTables.Domain.Entity.Step", b =>
                {
                    b.Navigation("BuyStep");
                });
#pragma warning restore 612, 618
        }
    }
}