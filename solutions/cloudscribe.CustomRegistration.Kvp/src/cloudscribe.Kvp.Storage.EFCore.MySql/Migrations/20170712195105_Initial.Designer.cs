﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using cloudscribe.Kvp.Storage.EFCore.MySql;

namespace cloudscribe.Kvp.Storage.EFCore.MySql.Migrations
{
    [DbContext(typeof(KvpDbContext))]
    [Migration("20170712195105_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("cloudscribe.Kvp.Models.KvpItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("Custom1")
                        .HasMaxLength(255);

                    b.Property<string>("Custom2")
                        .HasMaxLength(255);

                    b.Property<string>("FeatureId")
                        .HasMaxLength(36);

                    b.Property<string>("Key")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ModifiedUtc");

                    b.Property<string>("SetId")
                        .HasMaxLength(36);

                    b.Property<string>("SubSetId")
                        .HasMaxLength(36);

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("Key");

                    b.HasIndex("SetId");

                    b.HasIndex("SubSetId");

                    b.ToTable("KvpItems");
                });
        }
    }
}
