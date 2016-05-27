using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaMVC.Models
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("TentaStoreDB")
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }


        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }


    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>()
            {
                new Store() { Name = "Arkens Zoo", Adress = "Djurvägen 22", Products = new List<Product>()
                {
                    new Product() {Name = "Dragon Lizard", ProductNumber = "P-11", Price = 200, ProductText = "This is a great lizard", ProductsInStock = 4},
                    new Product() {Name = "Pretty Hamster", ProductNumber = "P-22", Price = 15, ProductText = "This is a fluffy hamster", ProductsInStock = 51}
                } },
                new Store() { Name = "Alfo Gross", Adress = "ECvägen 55", Products = new List<Product>()
                {
                    new Product() {Name = "Gurka", ProductNumber = "P-33", Price = 5, ProductText = "Ekologisk Gurka", ProductsInStock = 211},
                    new Product() {Name = "Ice cream", ProductNumber = "P-44", Price = 20, ProductText = "The best ice cream", ProductsInStock = 41}
                } }
            };
            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();
        }
    }
}
