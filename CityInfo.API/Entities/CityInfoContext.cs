using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {
        /*
         * To create migrations, run in Package Mgr console
         * Add-Migration CityInfoDBInitialMigration
         * 
         * for subsequent updates to entity classes run
         * Add-Migration CityInfoDBAddPOIDescription
         */

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(Startup.Configuration["connectionStrings:cityInfoDBConnectionString"]);

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
