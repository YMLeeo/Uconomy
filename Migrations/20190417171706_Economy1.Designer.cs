// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fr34kyn01535.Uconomy;

namespace fr34kyn01535.Uconomy.Migrations
{
    [DbContext(typeof(UconomyDbContext))]
    [Migration("20190417171706_Economy1")]
    partial class Economy1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("fr34kyn01535.Uconomy.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(32)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTime>("LastUpdated");

                    b.HasKey("Id");

                    b.ToTable("economy");
                });
#pragma warning restore 612, 618
        }
    }
}
