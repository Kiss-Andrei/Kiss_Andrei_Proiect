﻿// <auto-generated />
using System;
using Kiss_Andrei_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kiss_Andrei_Proiect.Migrations
{
    [DbContext(typeof(Kiss_Andrei_ProiectContext))]
    partial class Kiss_Andrei_ProiectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kiss_Andrei_Proiect.Models.Bikes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BikeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BikeSpeeds")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BiketType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("SellingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Bikes");
                });
#pragma warning restore 612, 618
        }
    }
}
