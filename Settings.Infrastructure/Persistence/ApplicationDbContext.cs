﻿using Microsoft.EntityFrameworkCore;
using Settings.Domain.Entities;

namespace Settings.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new ConsumerSeedData());
        modelBuilder.Entity<Applications>().Navigation(e => e.Currency).AutoInclude();
        
    }
    public DbSet<LeadStatus> LeadStatuses { get; set; }
    public DbSet<LeadSource> LeadSources { get; set; }
    public DbSet<LeadAgent> LeadAgents { get; set; }
    public DbSet<LeadCategory> LeadCategories { get; set; }
    //public DbSet<Client> Clients { get; set; }
    public DbSet<Applications> Applications { get; set; }
    public DbSet<Planning> Plannings { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Domain.Entities.Task> Tasks { get; set; }
    public DbSet<Tax> Taxes { get; set; }


}
