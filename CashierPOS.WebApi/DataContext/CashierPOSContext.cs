using Microsoft.EntityFrameworkCore;
using CashierPOS.WebApi.Models.EntityModel;
using System.Reflection;

namespace CashierPOS.WebApi.DataContext
{
    public class CashierPOSContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SystemType> SystemTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<ChangeShift> ChangeShifts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<ChangeShiftDetail> ChangeShiftDetails { get; set; }
        public DbSet<ReasonType> ReasonTypes { get; set; }
        public DbSet<ReasonRefundType> ReasonRefundTypes { get; set; }
        public DbSet<SellInvoice> SellInvoices { get; set; }
        public DbSet<ReturnOrder> ReturnOrders { get; set; }
        public DbSet<ReturnOrderDetail> ReturnOrderDetails { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<SellInvoiceDetail> SellInvoiceDetails { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }  
        public DbSet<Division> Divisions { get; set; }  


        public CashierPOSContext(DbContextOptions options) : base(options)
        {
        }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
