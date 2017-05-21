namespace Sistema_de_Inventario.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sistema_de_Inventario.DAL.InventarioDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Sistema_de_Inventario.DAL.InventarioDB";
        }

        protected override void Seed(Sistema_de_Inventario.DAL.InventarioDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
