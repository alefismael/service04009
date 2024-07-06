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
        modelBuilder.Entity<Shooter>().HasMany(s => s.CommanderServices).WithOne(s => s.CommanderOfTheGuard).HasForeignKey(s => s.CommanderOfTheGuardId);  //Um comandante da guarda pode estar em vários serviços

        modelBuilder.Entity<Service>().HasMany(s => s.Sentinels).WithMany(s => s.SentinelServices).UsingEntity("ServiceSentinelRelational"); // Um atirador pode estar em vários serviços como sentinela e um serviço pode ter mais de um sentinela

        modelBuilder.Entity<Service>().HasMany(s => s.Permanences).WithMany(s => s.PermanenceServices).UsingEntity("ServicePermanenceRelational"); // Um atirador pode estar em vários serviços como permanência e um serviço pode ter mais de um permanência

        modelBuilder.Entity<ServiceScale>().HasMany(s => s.Services).WithOne(s => s.ServiceScale).HasForeignKey(s => s.ServiceScaleId).OnDelete(DeleteBehavior.Cascade);  // Um serviço pode estar em apenas 1 escala de serviço, e essa pode ter vários serviços
    }
}
