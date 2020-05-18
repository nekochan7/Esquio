﻿// <auto-generated />
using System;
using Esquio.UI.Api.Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunctionalTests.Esquio.UI.Api.Seedwork.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ApiKeyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.DeploymentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ByDefault")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductEntityId");

                    b.ToTable("Deployments");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Archived")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductEntityId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureStateEntity", b =>
                {
                    b.Property<int>("FeatureEntityId")
                        .HasColumnType("int");

                    b.Property<int>("DeploymentEntityId")
                        .HasColumnType("int");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.HasKey("FeatureEntityId", "DeploymentEntityId");

                    b.HasIndex("DeploymentEntityId");

                    b.ToTable("FeatureStates");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureTagEntity", b =>
                {
                    b.Property<int>("FeatureEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TagEntityId")
                        .HasColumnType("int");

                    b.HasKey("FeatureEntityId", "TagEntityId");

                    b.HasIndex("TagEntityId");

                    b.ToTable("FeatureTags");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.HistoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.MetricEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeploymentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DateTime");

                    b.ToTable("Metrics");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ParameterEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeploymentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ToggleEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.HasAlternateKey("Name", "DeploymentName", "ToggleEntityId");

                    b.HasIndex("ToggleEntityId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationRole")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Reader");

                    b.Property<string>("Kind")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("User");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("SubjectId")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HexColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7)
                        .HasDefaultValue("#FF0000");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ToggleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeatureEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasAlternateKey("Type", "FeatureEntityId")
                        .HasName("IX_ToggeFeature");

                    b.HasIndex("FeatureEntityId");

                    b.ToTable("Toggles");
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.DeploymentEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.ProductEntity", "ProductEntity")
                        .WithMany("Deployments")
                        .HasForeignKey("ProductEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.ProductEntity", "ProductEntity")
                        .WithMany("Features")
                        .HasForeignKey("ProductEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureStateEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.DeploymentEntity", "DeploymentEntity")
                        .WithMany()
                        .HasForeignKey("DeploymentEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureEntity", "FeatureEntity")
                        .WithMany("FeatureStates")
                        .HasForeignKey("FeatureEntityId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureTagEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureEntity", "FeatureEntity")
                        .WithMany("FeatureTags")
                        .HasForeignKey("FeatureEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.TagEntity", "TagEntity")
                        .WithMany()
                        .HasForeignKey("TagEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ParameterEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.ToggleEntity", "ToggleEntity")
                        .WithMany("Parameters")
                        .HasForeignKey("ToggleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.UI.Api.Infrastructure.Data.Entities.ToggleEntity", b =>
                {
                    b.HasOne("Esquio.UI.Api.Infrastructure.Data.Entities.FeatureEntity", "FeatureEntity")
                        .WithMany("Toggles")
                        .HasForeignKey("FeatureEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
