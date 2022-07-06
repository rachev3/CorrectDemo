﻿// <auto-generated />
using System;
using CorrectDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CorrectDemo.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20220706114728_Songs")]
    partial class Songs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("CorrectDemo.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CorrectDemo.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlaylistId");

                    b.HasIndex("AccountId");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("CorrectDemo.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.Property<int>("PlaylistsPlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SongsSongId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaylistsPlaylistId", "SongsSongId");

                    b.HasIndex("SongsSongId");

                    b.ToTable("PlaylistSong");
                });

            modelBuilder.Entity("CorrectDemo.Playlist", b =>
                {
                    b.HasOne("CorrectDemo.Account", null)
                        .WithMany("Playlists")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.HasOne("CorrectDemo.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsPlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorrectDemo.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsSongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CorrectDemo.Account", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}