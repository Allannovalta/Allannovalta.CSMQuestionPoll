﻿// <auto-generated />
using System;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Allannovalta.CSMQuestionPoll.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models.PollAnswer", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PollChoiceId");

                    b.Property<Guid?>("PollQuestionId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("PollAnswer");
                });

            modelBuilder.Entity("Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models.PollChoice", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PollQuestionId");

                    b.Property<string>("Text");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("PollChoice");
                });

            modelBuilder.Entity("Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models.PollQuestion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("PostExpiry");

                    b.Property<string>("Thumbnail");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("PollQuestions");
                });

            modelBuilder.Entity("Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("LoginStatus");

                    b.Property<int>("LoginTrials");

                    b.Property<string>("Password");

                    b.Property<string>("RegistrationCode");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
