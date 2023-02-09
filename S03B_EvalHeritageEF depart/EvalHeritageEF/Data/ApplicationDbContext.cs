using EvalHeritageEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalHeritageEF.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        #region Implémentation A: deux tables, propriétés du parent répétées
        // VehiculeA sans DbSet
        // Aucun Fluent API nécessaire SI toutes les tables ENFANTS sont définies DbSet
        // Une des solutions préférables lorsque:
        //  une classe parent Abstract avec peu de propriétés
        //  plusieurs propriétés différentes dans les classes enfants
        public DbSet<VoitureA> VoitureA { get; set; }
        public DbSet<BateauA> BateauA { get; set; }

        #endregion



        #region Implémentation B: Une seule table, propriétés fusionnées avec Discriminator
        // Aucun Fluent API nécessaire SI toutes les tables sont définies DbSet
        // Une des solutions préférables lorsque:
        // peu de propriétés dans chaque classe
        // une classe parent Abstract ou non
        // les accès sont identiques pour les classes enfants
        public DbSet<VehiculeB> VehiculeB { get; set; }
        public DbSet<VoitureB> VoitureB { get; set; }
        public DbSet<BateauB> BateauB { get; set; }

        #endregion

        #region Implémentation B2: Une seule table, propriétés fusionnées avec Discriminator personnalisé
        // Une des solutions préférables lorsque:
        // peu de propriétés dans chaque classe
        // une classe parent Abstract ou non
        // les accès sont identiques pour les classes enfants
        public DbSet<VehiculeB2> VehiculeB2 { get; set; }  // ABSTRACT
        public DbSet<VoitureB2> VoitureB2 { get; set; }
        public DbSet<BateauB2> BateauB2 { get; set; }

        #endregion

        #region Implémentation C: Trois tables
        // Une des solutions préférables lorsque:
        // une classe parent PAS Abstract
        // plusieurs propriétés différentes dans chaque classe
        // les accès sont différents pour les classes enfants
        public DbSet<VehiculeC> VehiculeC { get; set; }
        public DbSet<VoitureC> VoitureC { get; set; }
        public DbSet<BateauC> BateauC { get; set; }

        #endregion

        #region Implémentation C2: Trois tables
        // DbSet seulement pour la classe parent VehiculeC2  
        // Une des solutions préférables lorsque:
        //  plusieurs propriétés différentes dans les classes enfants

        public DbSet<VehiculeC2> VehiculeC2 { get; set; }

        #endregion

        #region Implémentation D: Trois tables (parent abstract donc à ÉVITER)
        // Une solution à ÉVITER avec une classe parent Abstract mais malheureusement possible
        public DbSet<VehiculeD> VehiculeD { get; set; } // ABSTRACT
        public DbSet<VoitureD> VoitureD { get; set; }
        public DbSet<BateauD> BateauD { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //Exemple A: Configuration 2 tables
            // Aucun Fluent API nécessaire SI toutes les tables ENFANTS sont définies DbSet 
            // mais PAS la table PARENT



            //Exemple B: Configuration fluent API pour le Discriminator
            // Aucun Fluent API nécessaire SI toutes les tables sont définies DbSet
            // Classe parent ABSTRACT


            //Exemple B2: Configuration fluent API pour le Discriminator
            // Classe parent ABSTRACT
            // Définir le nom et le contenu du Discriminator
            modelBuilder.Entity<VehiculeB2>()
                .HasDiscriminator<string>("Vehicule_type")
                .HasValue<VehiculeB2>("Vehicule_base")  // -------------------------------------- ABSTRACT
                .HasValue<VoitureB2>("Voiture_spec")
                .HasValue<BateauB2>("Bateau_spec");



            //Exemple C: Forcer la création de 3 tables avec liaisons
            modelBuilder.Entity<VehiculeC>().ToTable("VehiculeC");
            modelBuilder.Entity<VoitureC>().ToTable("VoitureC");
            modelBuilder.Entity<BateauC>().ToTable("BateauC");


            //Exemple C2 : Configuration 2 tables
            // Configuration Fluent API des tables enfants seulement

            modelBuilder.Entity<VoitureC2>().ToTable("VoitureC2");
            modelBuilder.Entity<BateauC2>().ToTable("BateauC2");



            //Exemple D: Forcer la création de 3 tables avec liaisons 
            // Avec une classe parent est abstract À ÉVITER ou ajouter des triggers  ------------ À ÉVITER
            modelBuilder.Entity<VehiculeD>().ToTable("VehiculeD");  // -------------------------- ABSTRACT
            modelBuilder.Entity<VoitureD>().ToTable("VoitureD");
            modelBuilder.Entity<BateauD>().ToTable("BateauD");



        }
    }
}
