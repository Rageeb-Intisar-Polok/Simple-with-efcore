// <auto-generated />
using System;
using AdminDBHandler.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseHandler.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221230145322_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdminDBHandler.Models.Dept_Level_Term.Department", b =>
                {
                    b.Property<int?>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("DeptId"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("AdminDBHandler.Models.Dept_Level_Term.Level", b =>
                {
                    b.Property<int?>("lvl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("lvl"));

                    b.HasKey("lvl");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("AdminDBHandler.Models.Dept_Level_Term.Term", b =>
                {
                    b.Property<int?>("trm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("trm"));

                    b.HasKey("trm");

                    b.ToTable("Term");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User", b =>
                {
                    b.Property<string>("UUId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Number_of_connections")
                        .HasColumnType("int");

                    b.HasKey("UUId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Officials", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndividualUUId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IndividualUUId");

                    b.ToTable("Officials");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Students", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndividualUUId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("lvl")
                        .HasColumnType("int");

                    b.Property<int?>("trm")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DeptId");

                    b.HasIndex("IndividualUUId");

                    b.HasIndex("lvl");

                    b.HasIndex("trm");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Teachers", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndividualUUId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DeptId");

                    b.HasIndex("IndividualUUId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Officials", b =>
                {
                    b.HasOne("AdminDBHandler.Models.User.User", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualUUId");

                    b.Navigation("Individual");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Students", b =>
                {
                    b.HasOne("AdminDBHandler.Models.Dept_Level_Term.Department", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId");

                    b.HasOne("AdminDBHandler.Models.User.User", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualUUId");

                    b.HasOne("AdminDBHandler.Models.Dept_Level_Term.Level", "L")
                        .WithMany()
                        .HasForeignKey("lvl");

                    b.HasOne("AdminDBHandler.Models.Dept_Level_Term.Term", "T")
                        .WithMany()
                        .HasForeignKey("trm");

                    b.Navigation("Dept");

                    b.Navigation("Individual");

                    b.Navigation("L");

                    b.Navigation("T");
                });

            modelBuilder.Entity("AdminDBHandler.Models.User.User_Types.Teachers", b =>
                {
                    b.HasOne("AdminDBHandler.Models.Dept_Level_Term.Department", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId");

                    b.HasOne("AdminDBHandler.Models.User.User", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualUUId");

                    b.Navigation("Dept");

                    b.Navigation("Individual");
                });
#pragma warning restore 612, 618
        }
    }
}
