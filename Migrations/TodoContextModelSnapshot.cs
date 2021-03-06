﻿// <auto-generated />
using EF_todo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_todo.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("EF_todo.Models.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TodoItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "to clean the house",
                            IsComplete = true,
                            Title = "Cleaning"
                        },
                        new
                        {
                            Id = 2,
                            Description = "to buy healthy food",
                            IsComplete = false,
                            Title = "Groceries"
                        },
                        new
                        {
                            Id = 3,
                            Description = "to do 100 push-ups",
                            IsComplete = false,
                            Title = "Excercise"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
