using Learn_BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn_BulkyWeb.Data; 

public class ApplicationDbContext : DbContext{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        
    }

    public DbSet<Category> Category { get; set; }
}