using ConsoleApp1_linq1.Modals;
using static ConsoleApp1_linq1.DataSource.Source;
namespace ConsoleApp1_linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result= ProductList.Where(p => p.Category == "Seafood");
            // foreach(var item in result)
            // {
            //   Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            // }

            //Q2
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item}");

            //}

            //Q3
            //var result = ProductList.OrderBy(p => p.UnitPrice)

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            //Q4
            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitsInStock <= 30);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            //Q5
            //var result = ProductList.Where(p => p.Category == "Condiments" && p.UnitsInStock > 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            //Q6
            //var resutlt = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitPrice,
            //    Instock = p.UnitsInStock > 0 ? "available" : "out of stock"
            //});
            //foreach (var item in resutlt)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}, Stock Status: {item.Instock}");
            //}

            //Q7
            //var result = ProductList.Select((p, i) => new
            //{
            //   Index = i+1 ,
            //   Name = p.ProductName
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Index}. {item.Name}");
            //}
        }
    }
}
