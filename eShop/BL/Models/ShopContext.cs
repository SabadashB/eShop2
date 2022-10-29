using Microsoft.EntityFrameworkCore;

namespace eShop.Models
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<Role> Roles { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role() {Id = 1, Name ="admin"});
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 2, Name = "user" });
            modelBuilder.Entity<User>().HasData(new User() {Id = new System.Guid(), Email = "admin@admin.com",Password = "123456", RoleId = 1});
            modelBuilder.Entity<User>().HasData(new User() { Id = new System.Guid(), Email = "user@user.com", Password = "123456", RoleId = 2 });
        }
    }
}