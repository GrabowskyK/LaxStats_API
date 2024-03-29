﻿// <auto-generated />
using System;
using LaxStats_API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaxStatsAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240221001348_FixMigrations")]
    partial class FixMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LaxStats.Models.EventGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AssistId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeGoal")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("AssistId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("EventGoals");
                });

            modelBuilder.Entity("LaxStats.Models.EventPenalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PenaltyType")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeEvent")
                        .HasColumnType("time");

                    b.Property<int>("TimePenalty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("EventPenalties");
                });

            modelBuilder.Entity("LaxStats.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScoreAwayTeam")
                        .HasColumnType("int");

                    b.Property<int>("ScoreHomeTeam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.FaceOff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OverTime")
                        .HasColumnType("int");

                    b.Property<int>("Q1")
                        .HasColumnType("int");

                    b.Property<int>("Q2")
                        .HasColumnType("int");

                    b.Property<int>("Q3")
                        .HasColumnType("int");

                    b.Property<int>("Q4")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("FaceOffs");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Groundballs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OverTime")
                        .HasColumnType("int");

                    b.Property<int>("Q1")
                        .HasColumnType("int");

                    b.Property<int>("Q2")
                        .HasColumnType("int");

                    b.Property<int>("Q3")
                        .HasColumnType("int");

                    b.Property<int>("Q4")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Groundballs");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Shots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OverTime")
                        .HasColumnType("int");

                    b.Property<int>("Q1")
                        .HasColumnType("int");

                    b.Property<int>("Q2")
                        .HasColumnType("int");

                    b.Property<int>("Q3")
                        .HasColumnType("int");

                    b.Property<int>("Q4")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Shots");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.ShotsWide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OverTime")
                        .HasColumnType("int");

                    b.Property<int>("Q1")
                        .HasColumnType("int");

                    b.Property<int>("Q2")
                        .HasColumnType("int");

                    b.Property<int>("Q3")
                        .HasColumnType("int");

                    b.Property<int>("Q4")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("ShotsWides");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Timeouts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("TookTimeout")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Timeouts");
                });

            modelBuilder.Entity("LaxStats.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Assist")
                        .HasColumnType("int");

                    b.Property<DateTime>("Born")
                        .HasColumnType("datetime2");

                    b.Property<int>("GamePlayed")
                        .HasColumnType("int");

                    b.Property<int>("Goal")
                        .HasColumnType("int");

                    b.Property<int>("MinutesPenalties")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Penalties")
                        .HasColumnType("int");

                    b.Property<int>("ShirtNumber")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("LaxStats.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("draw")
                        .HasColumnType("int");

                    b.Property<int>("lose")
                        .HasColumnType("int");

                    b.Property<int>("points")
                        .HasColumnType("int");

                    b.Property<int>("win")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("LaxStats_API.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("LaxStats_API.Models.PlayerGoalie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Born")
                        .HasColumnType("datetime2");

                    b.Property<int>("GamePlayed")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Saves")
                        .HasColumnType("int");

                    b.Property<int>("ShirtNumber")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerGoalie");
                });

            modelBuilder.Entity("LaxStats.Models.EventGoal", b =>
                {
                    b.HasOne("LaxStats.Models.Player", "Assist")
                        .WithMany()
                        .HasForeignKey("AssistId");

                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("Goals")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaxStats.Models.Player", "Player")
                        .WithMany("Goals")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Assist");

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("LaxStats.Models.EventPenalty", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("Penalty")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaxStats.Models.Player", "Player")
                        .WithMany("Penalty")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("LaxStats.Models.Game", b =>
                {
                    b.HasOne("LaxStats.Models.Team", "AwayTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LaxStats.Models.Team", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LaxStats_API.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("League");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.FaceOff", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("FaceOffs")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Groundballs", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("Groundballs")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Shots", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("Shots")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.ShotsWide", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("ShotsWides")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LaxStats.Models.MatchStats.Timeouts", b =>
                {
                    b.HasOne("LaxStats.Models.Game", "Game")
                        .WithMany("Timeouts")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LaxStats.Models.Player", b =>
                {
                    b.HasOne("LaxStats.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("LaxStats.Models.Team", b =>
                {
                    b.HasOne("LaxStats_API.Models.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("LaxStats_API.Models.PlayerGoalie", b =>
                {
                    b.HasOne("LaxStats.Models.Team", "Team")
                        .WithMany("PlayerGoalies")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("LaxStats.Models.Game", b =>
                {
                    b.Navigation("FaceOffs");

                    b.Navigation("Goals");

                    b.Navigation("Groundballs");

                    b.Navigation("Penalty");

                    b.Navigation("Shots");

                    b.Navigation("ShotsWides");

                    b.Navigation("Timeouts");
                });

            modelBuilder.Entity("LaxStats.Models.Player", b =>
                {
                    b.Navigation("Goals");

                    b.Navigation("Penalty");
                });

            modelBuilder.Entity("LaxStats.Models.Team", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");

                    b.Navigation("PlayerGoalies");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("LaxStats_API.Models.League", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
