// <auto-generated />
using EvalHeritageEF.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EvalHeritageEF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230209220129_modelB2")]
    partial class modelB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EvalHeritageEF.Models.BateauA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicencePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Longueur")
                        .HasColumnType("int");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrMats")
                        .HasColumnType("int");

                    b.Property<int>("NbrVoile")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PiloteAutomatique")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BateauA");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.VehiculeB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicencePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehiculeB");

                    b.HasDiscriminator<string>("Discriminator").HasValue("VehiculeB");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.VehiculeB2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicencePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vehicule_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehiculeB2");

                    b.HasDiscriminator<string>("Vehicule_type").HasValue("Vehicule_base");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.VoitureA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BoiteManuelle")
                        .HasColumnType("bit");

                    b.Property<bool>("CameraRecule")
                        .HasColumnType("bit");

                    b.Property<string>("Couleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicencePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrPassagers")
                        .HasColumnType("int");

                    b.Property<int>("NbrVitesses")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VoitureA");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.BateauB", b =>
                {
                    b.HasBaseType("EvalHeritageEF.Models.VehiculeB");

                    b.Property<int>("NbrVoile")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("BateauB");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.VoitureB", b =>
                {
                    b.HasBaseType("EvalHeritageEF.Models.VehiculeB");

                    b.Property<bool>("BoiteManuelle")
                        .HasColumnType("bit");

                    b.Property<bool>("CameraRecule")
                        .HasColumnType("bit");

                    b.Property<string>("Couleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrPassagers")
                        .HasColumnType("int");

                    b.Property<int>("NbrVitesses")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("VoitureB");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.BateauB2", b =>
                {
                    b.HasBaseType("EvalHeritageEF.Models.VehiculeB2");

                    b.Property<int>("NbrVoile")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Bateau_spec");
                });

            modelBuilder.Entity("EvalHeritageEF.Models.VoitureB2", b =>
                {
                    b.HasBaseType("EvalHeritageEF.Models.VehiculeB2");

                    b.Property<string>("Couleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrPassagers")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Voiture_spec");
                });
#pragma warning restore 612, 618
        }
    }
}
