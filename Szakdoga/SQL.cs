using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using Szakdoga.Configurations.Entity;
using Szakdoga.Models;
using Szakdoga.Models.Food;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdoga.Data;

namespace Szakdoga
{
    public class SQL : DbContext
    {
        public static string ConnectionString { get; set; }


        public static SQL InitMSSQL()
        {
            var options = new DbContextOptionsBuilder().UseSqlServer(SQL.ConnectionString).Options;
            return new SQL(options);
        }


        private SQL(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodAllergy> FoodAllergies { get; set; }
        public DbSet<FoodAllergyType> FoodAllergyTypes { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderFood> OrderFoods { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        //public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
