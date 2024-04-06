using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

//method
// GetAll
//GetProductByName(string name)
//GetProductsByCategoryType(string categoria)

public class ProductService
{
    private readonly Dbcontext _context;

    public ProductService(Dbcontext context)
    {
        _context = context;
    }

    //Method GetAll
    public List<ProductsModel>? GetAllProducts()
    {
        try
        {
            var products = _context.Products.ToList();
            return products;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving products: {ex.Message}");
            return null;
        }
        
    }

    ///GetProductByName(string name)
    public List<ProductsModel>? GetProductsByName(string name)
    {
        try
        {
            var products = _context.Products
                .Where(p => (p.Name ?? "").Contains(name))
                .ToList();

            return products;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving products by name: {ex.Message}");
            return null;
        }
    }

    //GetProductsByCategoryType(string categoria)

    public List<ProductsModel>? GetProductByCategoryType(string categoryType)
    {
        try
        {
            var products = _context.Products
                .Where(p => (p.CategoryType ?? "").Contains(categoryType))
                .ToList();
            return products;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving products by category type: {ex.Message}");
            return null;
        }
    }
}
