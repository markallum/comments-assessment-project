﻿// <auto-generated />
using CommentsAssessmentProject.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CommentsAssessmentProject.Migrations
{
    [DbContext(typeof(DbService))]
    [Migration("20180705135528_CommentNesting")]
    partial class CommentNesting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommentsAssessmentProject.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Content")
                        .HasMaxLength(400);

                    b.Property<int?>("ParentCommentId");

                    b.Property<DateTime>("PostedDateTime");

                    b.HasKey("Id");

                    b.HasIndex("ParentCommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CommentsAssessmentProject.Models.Comment", b =>
                {
                    b.HasOne("CommentsAssessmentProject.Models.Comment", "ParentComment")
                        .WithMany()
                        .HasForeignKey("ParentCommentId");
                });
#pragma warning restore 612, 618
        }
    }
}
