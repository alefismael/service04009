using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Service04009;

namespace Service04009;

internal class ServiceContext : DbContext
{
    public DbSet<Shooter> Shooters { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceScale> ServiceScales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source=shooter.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shooter>().HasMany(s => s.CommanderServices).WithOne(s => s.CommanderOfTheGuard).HasForeignKey(s => s.CommanderOfTheGuardId);

        modelBuilder.Entity<Service>().HasMany(s => s.Sentinels).WithMany(s => s.SentinelServices).UsingEntity("ServiceSentinelRelational"); ;

        modelBuilder.Entity<Service>().HasMany(s => s.Permanences).WithMany(s => s.PermanenceServices).UsingEntity("ServicePermanenceRelational"); ;

        modelBuilder.Entity<ServiceScale>().HasMany(s => s.Services).WithOne(s => s.ServiceScale).HasForeignKey(s => s.ServiceScaleId);
    }
}
