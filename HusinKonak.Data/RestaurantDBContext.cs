using HusinKonak.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HusinKonak.Data
{
    public class RestaurantDBContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contact> SecondReservations { get; set; }

        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Admin>()
            //.HasMany(e => e.Employees)
            //.WithOne(e => e.Admin)
            //.HasForeignKey(e => e.AdminId);

           // modelBuilder.Entity<Customer>()
           //.HasMany(e => e.Orders)
           //.WithMany(e => e.Customers);

            modelBuilder.Entity<Delivery>()
            .HasOne(e => e.Order)
            .WithOne(e => e.Delivery)
            .HasForeignKey<Order>(e => e.OrderId);



            modelBuilder.Entity<DiscountMenuItem>()
        .HasKey(dm => new { dm.DiscountID, dm.MenuItemID });

            modelBuilder.Entity<Discount>()
                .HasMany(d => d.DiscountMenuItems)
                .WithOne(dm => dm.Discount)
                .HasForeignKey(dm => dm.DiscountID);

            modelBuilder.Entity<MenuItem>()
                .HasMany(mi => mi.DiscountMenuItems)
                .WithOne(dm => dm.MenuItem)
                .HasForeignKey(dm => dm.MenuItemID);


            modelBuilder.Entity<EmployeeEvent>()
        .HasKey(ee => new { ee.EmployeeId, ee.EventId });

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeEvents)
                .WithOne(ee => ee.Employee)
                .HasForeignKey(ee => ee.EmployeeId);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EmployeeEvents)
                .WithOne(ee => ee.Event)
                .HasForeignKey(ee => ee.EventId); modelBuilder.Entity<Employee>()
            .HasMany<EmployeeEvent>(e => e.EmployeeEvents)
            .WithOne(ee => ee.Employee)
            .HasForeignKey(ee => ee.EmployeeId);
            modelBuilder.Entity<Event>()
                .HasMany<EmployeeEvent>(e => e.EmployeeEvents)
                .WithOne(ee => ee.Event)
                .HasForeignKey(ee => ee.EventId);

            modelBuilder.Entity<Inventory>()
            .HasMany(e => e.MenuItems)
            .WithOne(e => e.Inventory)
            .HasForeignKey(e => e.InventoryId);

            modelBuilder.Entity<OrderItemMenuItem>()
        .HasKey(oi => new { oi.MenuItemId, oi.OrderItemId });

            modelBuilder.Entity<Order>()
            .HasMany(e => e.Payments)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Order>()
           .HasOne(e => e.Table)
           .WithOne(e => e.Order)
           .HasForeignKey<Order>(e => e.TableId);

            modelBuilder.Entity<OrderItemReview>()
        .HasKey(oir => new { oir.OrderItemId, oir.ReviewId });

            modelBuilder.Entity<OrderItem>()
                .HasMany(oi => oi.OrderItemReviews)
                .WithOne(oir => oir.OrderItem)
                .HasForeignKey(oir => oir.OrderItemId);

            modelBuilder.Entity<Review>()
                .HasMany(r => r.OrderItemReviews)
                .WithOne(oir => oir.Review)
                .HasForeignKey(oir => oir.ReviewId);

            modelBuilder.Entity<CustomerReward>()
            .HasKey(cr => new { cr.CustomerId, cr.RewardId });

            modelBuilder.Entity<Reward>()
                .HasMany(r => r.CustomerRewards)
                .WithOne(cr => cr.Reward)
                .HasForeignKey(cr => cr.RewardId);

            //modelBuilder.Entity<Customer>()
            //    .HasMany(c => c.CustomerRewards)
            //    .WithOne(cr => cr.Customer)
            //    .HasForeignKey(cr => cr.CustomerId);


            modelBuilder.Entity<Table>()
    .HasMany(e => e.TableReservations)
    .WithOne(e => e.Table)
    .HasForeignKey(e => e.TableId);
            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.TableReservations)
                .WithOne(e => e.Reservation)
                .HasForeignKey(e => e.ReservationId);

            modelBuilder.Entity<TableReservation>()
                .HasKey(tr => new { tr.TableId, tr.ReservationId });


            modelBuilder.Entity<Transaction>()
            .HasMany(e => e.Payments)
            .WithOne(e => e.Transaction)
            .HasForeignKey(e => e.TransactionId);

            modelBuilder.Entity<Discount>()
       .Property(d => d.Amount)
       .HasConversion(
           a => a.ToString(),
           s => decimal.Parse(s));

            modelBuilder.Entity<Reward>()
        .Property(r => r.Amount)
        .HasColumnType("decimal(18, 2)");
        }
    }
}
