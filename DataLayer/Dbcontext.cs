using Microsoft.EntityFrameworkCore;

public class Dbcontext : DbContext
{
    public DbSet<ProductsModel> Products { get; set; }

    public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    
        modelBuilder.Entity<ProductsModel>().ToTable("Products");
    }
}