using Microsoft.EntityFrameworkCore;
using Ticketly.Domain.Entities;

namespace Ticketly.Repository
{
    public class TicketlyDbContext : DbContext
    {
        public TicketlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategorieTypes { get; set; }
        public DbSet<CategoryTypeAssociation> CategoryTypeAssociations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<LookupPaymentMethod> LookupPaymentMethods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBooking> UserBookings { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.ArtistId);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArtistEvent>(entity =>
            {
                entity.HasOne(e => e.Artist)
                    .WithMany(e=>e.ArtistEvents)
                    .HasForeignKey(e => e.ArtistId)
                    .HasConstraintName("FK_ArtistEvents_Artists");

                entity.HasOne(e => e.Event)
                    .WithMany(e => e.ArtistEvents)
                    .HasForeignKey(e => e.EventId)
                    .HasConstraintName("FK_ArtistEvents_Events");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.HasOne(e => e.Event)
                      .WithMany(e => e.Booking)
                      .HasForeignKey(e => e.EventId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
            });

            modelBuilder.Entity<CategoryType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CategoryTypeAssociation>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.TypeId });

                entity.HasOne(e => e.Category)
                    .WithMany(e => e.CategoryTypeAssociations)
                    .HasForeignKey(e => e.CategoryId);
            
                entity.HasOne(e => e.CategoryType)
                .WithMany(e => e.CategoryTypeAssociations)
                .HasForeignKey(e => e.TypeId);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.HasOne(e => e.Venue)
                    .WithMany(e => e.Events)
                    .HasForeignKey(e => e.VenueId);

                entity.HasOne(e => e.Category)
                    .WithOne(e => e.Event)
                    .HasForeignKey<Category>(e => e.CategoryId);

            });

            modelBuilder.Entity<LookupPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);
            }); 
            
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(e => e.User)
                    .WithMany(e => e.Orders)
                    .HasForeignKey(e => e.UserId);
            });
            
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.HasOne(e => e.PaymentMethod)
                    .WithOne(e => e.Payment)
                    .HasForeignKey<LookupPaymentMethod>(e => e.PaymentMethodId);
            });
            
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.HasOne(e => e.Booking)
                    .WithMany(e => e.Tickets)
                    .HasForeignKey(e => e.BookingId);

                entity.HasOne(e => e.Event)
                    .WithMany(e => e.Tickets)
                    .HasForeignKey(e => e.EventId);

                entity.HasOne(e => e.Order)
                    .WithMany(e => e.Tickets)
                    .HasForeignKey(e => e.OrderId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserName)
                     .IsRequired()
                     .HasMaxLength(25);

                entity.Property(e => e.FirstName)
                     .IsRequired()
                     .HasMaxLength(50);

                entity.Property(e => e.LastName)
                     .IsRequired()
                     .HasMaxLength(50);

                entity.Property(e => e.Email)
                     .IsRequired()
                     .HasMaxLength(50);
            });
            
            modelBuilder.Entity<UserBooking>(entity =>
            {
                entity.HasOne(e => e.Booking)
                      .WithMany(e => e.UserBookings)
                      .HasForeignKey(e => e.BookingId)
                      .HasConstraintName("FK_UserBooking_Bookings");

                entity.HasOne(e => e.User)
                     .WithMany(e => e.UserBookings)
                     .HasForeignKey(e => e.UserId)
                     .HasConstraintName("FK_UserBooking_Users");
            });

            modelBuilder.Entity<UserEvent>(entity =>
            {
                entity.HasOne(e => e.User)
                      .WithMany(e => e.UserEvents)
                      .HasForeignKey(e => e.UserId)
                      .HasConstraintName("FK_UserBooking_Bookings");

                entity.HasOne(e => e.Event)
                     .WithMany(e => e.UserEvents)
                     .HasForeignKey(e => e.EventId)
                     .HasConstraintName("FK_UserBooking_Users");
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.HasKey(e => e.VenueId);

                entity.Property(e => e.VenueName)
                     .IsRequired()
                     .HasMaxLength(50);

                entity.Property(e => e.VenueAddress)
                     .IsRequired()
                     .HasMaxLength(100);
            });
        }
    }
}
