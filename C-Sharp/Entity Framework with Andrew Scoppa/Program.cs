public class NorthwindEntities : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public NorthwindEntities () :
        base("name=NorthwindEntities")
    {

    }

}

//...

using (DbConnection cn = new EntityConnection())
 using (DbCommand cmd = cn.CreateCommand())
    {
        cmd.CommandText = "SELECT VALUE c FROM NorthwindEntities.Customers AS c";
        cn.Open();
        DbDataReader reader =
            cmd.ExecuteReader(CommandBehavior.SequentialAccess);
        while (reader.Read())
            { /* access reader */}

using (NorthwindEntities ctx = new NorthwindEntities()) // ctx - context
{
    IQueryable<Product> query =
        from p in ctx.Products
        select p;
    foreach (Product p in query) // query evaluated when iterated
        Console.WriteLine(p.ProductName);
}


using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities ctx = new NorthwindEntities())
            {
                IOrderQueryable<Category> categories = from c in ctx.Categories
                                                       orderby c.CategoryName
                                                       select c;
                //Console.WriteLine(categories.ToString());
                foreach (Category category in categories)
                {
                    Console.WriteLine(category.CategoryName);
                    foreach (Product product in category.Products)
                    {
                        product.UnitPrice++;
                        Console.WriteLine("\t{0} {1:c}", product.ProductName, product.UnitPrice);
                    }
                    ctx.SaveChanges();
                }
            }
        }
    }
}

// delete a product
IQueryable<Product> productsToDelete =
    from p in NWEntities.Products
    where p.ProductName == "new test product"
    select p;

if (productsToDelete.Any())
{
    foreach (var p in productsToDelete)
    {
        NWEntities.Remove(p);
    }
    NWEntities.SaveChanges();
}

using (NorthwindEntities ctx = new NorthwindEntities()){
    Product p = ctx.Products.Find(1); // bring entity into context
        // EntityState set to Unchanged

    ++p.UnitPrice; // modify entity
        // EntityState set to Modified

    ctx.SaveChanges(); // save changes to database
        // EntityState set to Unchanged
}

{
    static void Main(string[] args)
    {
        using (NorthwindEntities ctx = new NorthwindEntities())
        {
            Console.WriteLine("\nGet product...");
            Console.ReadLine();
            // retrieve chai (product id 1)
            Product chai = ctx.Products.Find(1);

            Console.ReadLine();
            // increase price
            ++chai.UnitPrice;
            Display(ctx, chai);

            Console.WriteLine("\nCreate new product...");
            Console.ReadLine();
            // create a new product entity
            Product kahlua = new Product() { ProductName = "Kahula Coffee", UnitPrice };
            Display(ctx, kahlua);
            Console.WriteLine("\nAdd new product to context...");
            Console.ReadLine();
            // add the entity to the context
            ctx.Products.Add(kahlua);
            Display(ctx, kahlua);

            Console.WriteLine("\nSave changes...");
            Console.ReadLine();
            // persist and read context
            ctx.SaveChanges();
            Display(ctx, chai);
            Display(ctx, kahlua);

            Console.WriteLine("\nDelete kahlua...");
            Console.ReadLine();
            // remove from context
            ctx.Products.Remove(kahlua);
            Display(ctx, kahlua);

            Console.WriteLine("\nSave changes...");
            Console.ReadLine();
            ctx.SaveChanges();
            Display(ctx, kahlua);

            Console.WriteLine("Finished");
            Console.ReadLine();            
            
        }

}


string commandText = "Select * from Categories";
DbSqlQuery<Category> result =
ctx.Categories.SqlQuery(commandText);

int rowsAffected = ctx.Database.ExecuteSqlCommand
    ("UPDATE Products SET UnitPrice = UnitPrice - 1 " +
    "WHERE CategoryID = (0)", category.CategoryID);

// use parameters to prevent SQL injection   
    
    
    
    }