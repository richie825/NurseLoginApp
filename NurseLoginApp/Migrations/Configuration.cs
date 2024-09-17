namespace NurseLoginApp.Migrations
{
    using NurseLoginApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NurseLoginApp.Models.NurseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NurseLoginApp.Models.NurseDbContext context)
        {
            context.Nurses.AddOrUpdate(
        new Nurse { Username = "Nurse1", Password = "password1" },
        new Nurse { Username = "Nurse2", Password = "password2" }
    );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
