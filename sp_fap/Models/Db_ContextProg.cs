using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using sp_fap.Models;

namespace sp_fap.Content
{
    public class Db_ContextProg:DbContext
    {
        public Db_ContextProg(string connection)
        {
            Database.Connection.ConnectionString = connection;
        }
        public DbSet<Analyses> Analyses_m { get; set; }
        public DbSet<AnalysesOfPatients> AnalysesOfPatients_m { get; set; }
        public DbSet<AnalysesOfPatientsValue> AnalysesOfPatientsValue_m { get; set; }
        public DbSet<BloodGroup> BloodGroup_m { get; set; }
        public DbSet<Depatment> Depatment_m { get; set; }
        public DbSet<Doctors> Doctors_m { get; set; }
        public DbSet<Dosage> Dosage_m { get; set; }
        public DbSet<Drugs> Drugs_m { get; set; }
        public DbSet<DrugsOfPatients> DrugsOfPatients_m { get; set; }
        public DbSet<DrugsOfPatientsValue> DrugsOfPatientsValue_m { get; set; }
        public DbSet<DrugsOfWayOfAdministration> DrugsOfWayOfAdministration_m { get; set; }
        public DbSet<FluidBalance> FluidBalance_m { get; set; }
        public DbSet<FluidBalanceOfPatients> FluidBalanceOfPatients_m { get; set; }
        public DbSet<FluidBalanceOfPatientsValue> FluidBalanceOfPatientsValue { get; set; }
        public DbSet<Indicators> Indicators_m { get; set; }
        public DbSet<IndicatorsOfPatients> IndicatorsOfPatients_m { get; set; }
        public DbSet<IndicatorsOfPatientsValue> IndicatorsOfPatientsValue_m { get; set; }
        public DbSet<Patients> Patients_m { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<RhesusAccessory> RhesusAccessory { get; set; }
        public DbSet<Users> Users_m { get; set; }
        public DbSet<UserType> UserType_m { get; set; }
        public DbSet<WayOfAdministration> WayOfAdministration_m { get; set; }
        public DbSet<WayOfReception> WayOfReception { get; set; }

    }
}