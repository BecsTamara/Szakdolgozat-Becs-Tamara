using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Szakdoga.Configurations.Entity;
using Szakdoga.Models;
using Szakdoga.Models.Food;

namespace Szakdoga.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public static string ConnectionString { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;

        }
        public ApplicationDbContext():base(new DbContextOptionsBuilder().UseSqlServer(ApplicationDbContext.ConnectionString).Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new FoodAllergyTypeSeedConfiguration());
            builder.ApplyConfiguration(new FoodTypeSeedConfiguration());
            builder.ApplyConfiguration(new TableSeedConfiguration());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)// base entity kitöltése
        {
            var userId = httpContextAccessor?.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added
                || q.State == EntityState.Modified))
            {
                entry.Entity.LastModifyDate = DateTime.Now;
                entry.Entity.LastModifyUserId = userId;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedUserId = userId;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Food> Foods { get; set;}
        public DbSet<FoodAllergy> FoodAllergies { get; set;}
        public DbSet<FoodAllergyType> FoodAllergyTypes { get; set; }
        public DbSet<FoodType> FoodTypes { get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderFood> OrderFoods { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        //public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}