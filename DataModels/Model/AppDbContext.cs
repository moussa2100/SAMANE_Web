using DataModels.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Views;

namespace WebApplication1.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        //i want to add sql connections string here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=135.148.120.57;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=Aa@12121988;TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Carr> Cars { get; set; }

        public DbSet<CarStatus> CarStatuses { get; set; }

        public DbSet<CarType> CarTypes { get; set; }

        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<CustomerStatus> CustomerStatuses { get; set; }



        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<Customerr> Customers { get; set; }

        public DbSet<Rent> Rents { get; set; }

        public DbSet<ContractType> ContractTypes { get; set; }

        public DbSet<Clor> Clors { get; set; }

        public DbSet<Kmcounter> Kmcounters { get; set; }

        public DbSet<FuelType> FuelTypes { set; get; }

        public DbSet<ContractStatus> ContractStatuses { set; get; }

        public DbSet<Payment_Type> payment_Types { set; get; }

        public DbSet<Payment> Payments{ set; get; }

        public DbSet<PaymentOptions> paymentOptions { get; set; }

        public DbSet<PaymentDescription> PaymentDescriptions { get; set; }

        public DbSet<CarLoc> CarLocs { get; set; }

        public DbSet<AuthorizationType> AuthorizationTypes { get; set; }

        public DbSet<AuthorizationTb> AuthorizationTbs { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Oil> Oils { get; set; }


        public DbSet<WebApplication1.Models.Views.vwPayments> vwPayments { get; set; }

        public DbSet<vwRent> vwRents { get; set; }

        public DbSet<vw_CarStatus> vw_CarStatuses { get; set; }

        public DbSet<vw_DateAmount> vw_DateAmounts { get; set; }

        public DbSet<UsersPermissions> UsersPermissions { get; set; }

        public DbSet<vw_payments_total> vw_Payments_Totals { get; set; }

        public DbSet<WebApplication1.Models.Views.vwLate> vw_Late { get; set; }

    }
}
