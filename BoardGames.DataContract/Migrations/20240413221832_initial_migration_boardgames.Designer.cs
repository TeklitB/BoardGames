﻿// <auto-generated />
using System;
using BoardGames.DataContract.DatabContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoardGames.DataContract.Migrations
{
    [DbContext(typeof(BoardGamesDbContext))]
    [Migration("20240413221832_initial_migration_boardgames")]
    partial class initial_migration_boardgames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGame", b =>
                {
                    b.Property<int>("BoardGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BoardGameId"));

                    b.Property<int>("BGGRank")
                        .HasColumnType("integer");

                    b.Property<decimal>("ComplexityAverage")
                        .HasPrecision(4, 2)
                        .HasColumnType("numeric(4,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("integer");

                    b.Property<int>("MinAge")
                        .HasColumnType("integer");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("OwnedUsers")
                        .HasColumnType("integer");

                    b.Property<int>("PlayTime")
                        .HasColumnType("integer");

                    b.Property<decimal>("RatingAverage")
                        .HasPrecision(4, 2)
                        .HasColumnType("numeric(4,2)");

                    b.Property<int>("UsersRated")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("BoardGameId");

                    b.ToTable("BoardGames");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGames_Domains", b =>
                {
                    b.Property<int>("BoardGameId")
                        .HasColumnType("integer");

                    b.Property<int>("DomainId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("BoardGameId", "DomainId");

                    b.HasIndex("DomainId");

                    b.ToTable("BoardGames_Domains");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGames_Mechanics", b =>
                {
                    b.Property<int>("BoardGameId")
                        .HasColumnType("integer");

                    b.Property<int>("MechanicId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("BoardGameId", "MechanicId");

                    b.HasIndex("MechanicId");

                    b.ToTable("BoardGames_Mechanics");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.Domain", b =>
                {
                    b.Property<int>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DomainId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("DomainId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.Mechanic", b =>
                {
                    b.Property<int>("MechanicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MechanicId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("MechanicId");

                    b.ToTable("Mechanics");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGames_Domains", b =>
                {
                    b.HasOne("BoardGames.DataContract.Models.BoardGame", "BoardGame")
                        .WithMany("BoardGames_Domains")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGames.DataContract.Models.Domain", "Domain")
                        .WithMany("BoardGames_Domains")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardGame");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGames_Mechanics", b =>
                {
                    b.HasOne("BoardGames.DataContract.Models.BoardGame", "BoardGame")
                        .WithMany("BoardGames_Mechanics")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGames.DataContract.Models.Mechanic", "Mechanic")
                        .WithMany("BoardGames_Mechanics")
                        .HasForeignKey("MechanicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardGame");

                    b.Navigation("Mechanic");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.BoardGame", b =>
                {
                    b.Navigation("BoardGames_Domains");

                    b.Navigation("BoardGames_Mechanics");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.Domain", b =>
                {
                    b.Navigation("BoardGames_Domains");
                });

            modelBuilder.Entity("BoardGames.DataContract.Models.Mechanic", b =>
                {
                    b.Navigation("BoardGames_Mechanics");
                });
#pragma warning restore 612, 618
        }
    }
}