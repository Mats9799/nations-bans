using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SpigotBans.Models;

namespace SpigotBans.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170920105041_SQL")]
    partial class SQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SpigotBans.Models.Ban", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BanDate");

                    b.Property<DateTime>("PardonDate");

                    b.Property<string>("PlayerName");

                    b.Property<Guid>("PlayerUUID");

                    b.Property<string>("Reason");

                    b.Property<string>("StaffName");

                    b.HasKey("ID");

                    b.ToTable("Bans");
                });
        }
    }
}
