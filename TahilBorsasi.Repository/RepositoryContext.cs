
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
    
    public DbSet<ProductName>? ProductNames {  get; set; }
    public DbSet<Farmer> Farmers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Citys { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<EntryProduct> EntryProducts { get; set; }
    public DbSet<LabData> LabDatas { get; set; }
    public DbSet<Tradesman> Tradesmans { get; set; }
    public DbSet<LastProduct> LastProducts { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleTrades> SaleTrade { get; set; }
}
}
