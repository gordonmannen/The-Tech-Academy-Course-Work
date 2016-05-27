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