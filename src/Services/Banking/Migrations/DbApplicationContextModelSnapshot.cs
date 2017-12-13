﻿// <auto-generated />
using Banking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Banking.Migrations
{
    [DbContext(typeof(DbApplicationContext))]
    partial class DbApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Banking.Data.Entitites.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnp");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Banking.Data.Entitites.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId");

                    b.Property<DateTime>("Due");

                    b.Property<DateTime>("From");

                    b.Property<Guid?>("TransactionId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Banking.Data.Entitites.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("TaxRate");

                    b.Property<DateTime>("TransactionTime");

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Banking.Data.Entitites.Payment", b =>
                {
                    b.HasOne("Banking.Data.Entitites.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId");

                    b.HasOne("Banking.Data.Entitites.Transaction", "Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionId");
                });
#pragma warning restore 612, 618
        }
    }
}
