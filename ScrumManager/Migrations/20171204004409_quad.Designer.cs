using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ScrumManager.Models.DbContexts;

namespace ScrumManager.Migrations
{
    [DbContext(typeof(ScrumManagerDbContext))]
    [Migration("20171204004409_quad")]
    partial class quad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScrumManager.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("EventLocation");

                    b.Property<string>("EventName");

                    b.Property<string>("EventType");

                    b.Property<string>("Notes");

                    b.Property<string>("RoleName");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ScrumManager.Models.People", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Peoples");
                });
        }
    }
}
