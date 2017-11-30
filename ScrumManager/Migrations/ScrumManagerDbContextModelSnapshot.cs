using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ScrumManager.Models.DbContexts;

namespace ScrumManager.Migrations
{
    [DbContext(typeof(ScrumManagerDbContext))]
    partial class ScrumManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ScrumManager.Models.People", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<int?>("EventId1");

                    b.HasKey("ID");

                    b.HasIndex("EventId");

                    b.HasIndex("EventId1");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("ScrumManager.Models.People", b =>
                {
                    b.HasOne("ScrumManager.Models.Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId");

                    b.HasOne("ScrumManager.Models.Event")
                        .WithMany("Invitees")
                        .HasForeignKey("EventId1");
                });
        }
    }
}
