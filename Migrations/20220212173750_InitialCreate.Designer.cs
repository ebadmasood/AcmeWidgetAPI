﻿// <auto-generated />
using AcmeWidgetAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcmeWidgetAPI.Migrations
{
    [DbContext(typeof(ActivityDbContext))]
    [Migration("20220212173750_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("AcmeWidgetAPI.ActivitySignUpForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Activity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ActivitySignUpForms");
                });
#pragma warning restore 612, 618
        }
    }
}