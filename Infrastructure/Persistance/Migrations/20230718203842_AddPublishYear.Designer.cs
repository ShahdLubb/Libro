﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(LibroDbContext))]
    [Migration("20230718203842_AddPublishYear")]
    partial class AddPublishYear
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("BookKeyword", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("KeywordsKeywordId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "KeywordsKeywordId");

                    b.HasIndex("KeywordsKeywordId");

                    b.ToTable("BookKeyword");
                });

            modelBuilder.Entity("BookReadingList", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("ReadingListsReadingListId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "ReadingListsReadingListId");

                    b.HasIndex("ReadingListsReadingListId");

                    b.ToTable("BookReadingList");
                });

            modelBuilder.Entity("Persistance.DBEntities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Persistance.DBEntities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("CallNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Collation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edition")
                        .HasColumnType("int");

                    b.Property<string>("GenreCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreCode1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("GenreCode1");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Persistance.DBEntities.Borrow", b =>
                {
                    b.Property<int>("BorrowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowId"), 1L, 1);

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("LibrarianId")
                        .HasColumnType("int");

                    b.Property<int>("PatronId")
                        .HasColumnType("int");

                    b.HasKey("BorrowId");

                    b.HasIndex("ItemId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("PatronId");

                    b.ToTable("Borrowings");
                });

            modelBuilder.Entity("Persistance.DBEntities.CheckIn", b =>
                {
                    b.Property<int>("CheckInId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CheckInId"), 1L, 1);

                    b.Property<int>("BorrowingId")
                        .HasColumnType("int");

                    b.Property<int>("LibrarianId")
                        .HasColumnType("int");

                    b.Property<int>("OverdueCharge")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CheckInId");

                    b.HasIndex("BorrowingId");

                    b.HasIndex("LibrarianId");

                    b.ToTable("CheckIns");
                });

            modelBuilder.Entity("Persistance.DBEntities.Genre", b =>
                {
                    b.Property<string>("GenreCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreCode");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Persistance.DBEntities.Guardian", b =>
                {
                    b.Property<int>("GuardianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuardianId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuardianId");

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("Persistance.DBEntities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("BookId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Persistance.DBEntities.Keyword", b =>
                {
                    b.Property<int>("KeywordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeywordId"), 1L, 1);

                    b.Property<string>("KeywordName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeywordId");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("Persistance.DBEntities.Librarian", b =>
                {
                    b.Property<int>("LibrarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibrarianId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibrarianId");

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("Persistance.DBEntities.Patron", b =>
                {
                    b.Property<int>("PatronId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatronId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ChildGuardianGuardianId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatronId");

                    b.HasIndex("ChildGuardianGuardianId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("Persistance.DBEntities.ReadingList", b =>
                {
                    b.Property<int>("ReadingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReadingListId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatronId")
                        .HasColumnType("int");

                    b.Property<string>("Privacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReadingListId");

                    b.HasIndex("PatronId");

                    b.ToTable("ReadingLists");
                });

            modelBuilder.Entity("Persistance.DBEntities.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("PatronId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationId");

                    b.HasIndex("BookId");

                    b.HasIndex("PatronId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Persistance.DBEntities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatronId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(3,2)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("PatronId");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Persistance.DBEntities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookKeyword", b =>
                {
                    b.HasOne("Persistance.DBEntities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Keyword", null)
                        .WithMany()
                        .HasForeignKey("KeywordsKeywordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookReadingList", b =>
                {
                    b.HasOne("Persistance.DBEntities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.ReadingList", null)
                        .WithMany()
                        .HasForeignKey("ReadingListsReadingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Persistance.DBEntities.Book", b =>
                {
                    b.HasOne("Persistance.DBEntities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreCode1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Persistance.DBEntities.Borrow", b =>
                {
                    b.HasOne("Persistance.DBEntities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Librarian", "Librarian")
                        .WithMany("Checkouts")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Patron", "Patron")
                        .WithMany("Borrowings")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Librarian");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("Persistance.DBEntities.CheckIn", b =>
                {
                    b.HasOne("Persistance.DBEntities.Borrow", "Borrowing")
                        .WithMany()
                        .HasForeignKey("BorrowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Librarian", "Librarian")
                        .WithMany("CheckIns")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrowing");

                    b.Navigation("Librarian");
                });

            modelBuilder.Entity("Persistance.DBEntities.Item", b =>
                {
                    b.HasOne("Persistance.DBEntities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Persistance.DBEntities.Patron", b =>
                {
                    b.HasOne("Persistance.DBEntities.Guardian", "ChildGuardian")
                        .WithMany("Childs")
                        .HasForeignKey("ChildGuardianGuardianId");

                    b.Navigation("ChildGuardian");
                });

            modelBuilder.Entity("Persistance.DBEntities.ReadingList", b =>
                {
                    b.HasOne("Persistance.DBEntities.Patron", "Patron")
                        .WithMany("ReadingLists")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("Persistance.DBEntities.Reservation", b =>
                {
                    b.HasOne("Persistance.DBEntities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Patron", "Patron")
                        .WithMany("Reservations")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("Persistance.DBEntities.Review", b =>
                {
                    b.HasOne("Persistance.DBEntities.Book", "Book")
                        .WithMany("BookReviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistance.DBEntities.Patron", "Patron")
                        .WithMany("BookReviews")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("Persistance.DBEntities.Book", b =>
                {
                    b.Navigation("BookReviews");
                });

            modelBuilder.Entity("Persistance.DBEntities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Persistance.DBEntities.Guardian", b =>
                {
                    b.Navigation("Childs");
                });

            modelBuilder.Entity("Persistance.DBEntities.Librarian", b =>
                {
                    b.Navigation("CheckIns");

                    b.Navigation("Checkouts");
                });

            modelBuilder.Entity("Persistance.DBEntities.Patron", b =>
                {
                    b.Navigation("BookReviews");

                    b.Navigation("Borrowings");

                    b.Navigation("ReadingLists");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}