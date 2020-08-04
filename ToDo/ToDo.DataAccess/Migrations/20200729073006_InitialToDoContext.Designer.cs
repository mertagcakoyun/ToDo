﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;

namespace ToDo.DataAccess.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20200729073006_InitialToDoContext")]
    partial class InitialToDoContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDo.Entities.Concrete.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("ToDo.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserObjId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserObjId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToDo.Entities.Concrete.Business", b =>
                {
                    b.HasOne("ToDo.Entities.Concrete.User", null)
                        .WithMany("BusinessList")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ToDo.Entities.Concrete.User", b =>
                {
                    b.HasOne("ToDo.Entities.Concrete.User", "UserObj")
                        .WithMany()
                        .HasForeignKey("UserObjId");
                });
#pragma warning restore 612, 618
        }
    }
}