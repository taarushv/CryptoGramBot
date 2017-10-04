﻿// <auto-generated />
using CryptoGramBot.Data;
using CryptoGramBot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CryptoGramBot.Migrations
{
    [DbContext(typeof(CryptoGramBotDbContext))]
    [Migration("20171004073038_depositstable")]
    partial class depositstable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CryptoGramBot.Models.BalanceHistory", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("DateTime");

                    b.Property<decimal>("DollarAmount");

                    b.Property<string>("Name");

                    b.HasKey("Key");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("BalanceHistories");
                });

            modelBuilder.Entity("CryptoGramBot.Models.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("Amount");

                    b.Property<uint>("Confirmations");

                    b.Property<string>("Currency");

                    b.Property<string>("Exchange");

                    b.Property<string>("Status");

                    b.Property<DateTime>("Time");

                    b.Property<string>("TransactionId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("CryptoGramBot.Models.LastChecked", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Exchange");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("LastCheckeds");
                });

            modelBuilder.Entity("CryptoGramBot.Models.ProfitAndLoss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AverageBuyPrice");

                    b.Property<decimal>("AverageSellPrice");

                    b.Property<string>("Base");

                    b.Property<decimal>("CommissionPaid");

                    b.Property<decimal>("DollarProfit");

                    b.Property<decimal>("Profit");

                    b.Property<decimal>("QuantityBought");

                    b.Property<decimal>("QuantitySold");

                    b.Property<string>("Terms");

                    b.Property<decimal>("UnrealisedProfit");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("ProfitAndLosses");
                });

            modelBuilder.Entity("CryptoGramBot.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CryptoGramBot.Models.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Base");

                    b.Property<decimal>("Commission");

                    b.Property<decimal>("Cost");

                    b.Property<string>("Exchange");

                    b.Property<string>("ExchangeId");

                    b.Property<decimal>("Limit");

                    b.Property<decimal>("Quantity");

                    b.Property<decimal>("QuantityRemaining");

                    b.Property<int>("Side");

                    b.Property<string>("Terms");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("CryptoGramBot.Models.WalletBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Address");

                    b.Property<decimal>("Available");

                    b.Property<decimal>("Balance");

                    b.Property<decimal>("BtcAmount");

                    b.Property<string>("Currency");

                    b.Property<string>("Exchange");

                    b.Property<decimal>("Pending");

                    b.Property<decimal>("PercentageChange");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("Requested");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("WalletBalances");
                });

            modelBuilder.Entity("CryptoGramBot.Models.Withdrawal", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("Amount");

                    b.Property<string>("Currency");

                    b.Property<string>("Exchange");

                    b.Property<string>("IpAddress");

                    b.Property<string>("Status");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Withdrawals");
                });
#pragma warning restore 612, 618
        }
    }
}
