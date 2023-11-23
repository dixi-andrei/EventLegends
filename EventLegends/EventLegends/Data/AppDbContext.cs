using EventLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace EventLegends.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategories> EventsCategories { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }

        public DbSet<Notification> Notification { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<EventTickets> EventTickets {get; set; }
        public DbSet<EventParticipants> EParticipants {  get; set; }  
        public object UpdateBehavior { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventCategories>().HasKey(mr => new { mr.EventId, mr.CategoryId });

            modelBuilder.Entity<EventCategories>()
                        .HasOne(mr => mr.Event)
                        .WithMany(m3 => m3.EventCategories)
                        .HasForeignKey(mr => mr.CategoryId);

            modelBuilder.Entity<EventCategories>()
                        .HasOne(mr => mr.Category)
                        .WithMany(m4 => m4.EventCategories)
                        .HasForeignKey(mr => mr.EventId);

            modelBuilder.Entity<Organizer>()
                        .HasMany(m1 => m1.Events)
                        .WithOne(m2 => m2.Organizer);

            modelBuilder.Entity<Event>()
                       .HasMany(m1 => m1.Reviews)
                       .WithOne(m2 => m2.Event);

            modelBuilder.Entity<EventParticipants>().HasKey(mr => new { mr.EventId, mr.EventParticipantId });

            modelBuilder.Entity<EventParticipants>()
                        .HasOne(mr => mr.Event)
                        .WithMany(m3 => m3.EventParticipants)
                        .HasForeignKey(mr => mr.EventParticipantId);

            modelBuilder.Entity<EventParticipants>()
                        .HasOne(mr => mr.EventParticipant)
                        .WithMany(m4 => m4.EventParticipants)
                        .HasForeignKey(mr => mr.EventId);


            modelBuilder.Entity<EventTickets>().HasKey(mr => new { mr.EventId, mr.TicketId });

            modelBuilder.Entity<EventTickets>()
                        .HasOne(mr => mr.Event)
                        .WithMany(m3 => m3.EventTickets)
                        .HasForeignKey(mr => mr.TicketId);

            modelBuilder.Entity<EventTickets>()
                        .HasOne(mr => mr.Ticket)
                        .WithMany(m4 => m4.EventTickets)
                        .HasForeignKey(mr => mr.EventId);

            modelBuilder.Entity<Event>()
                .HasOne(m5 => m5.Venue)
                .WithOne(m6 => m6.Event)
                .HasForeignKey<Venue>(m6 => m6.EventId);

            modelBuilder.Entity<EventParticipant>()
                       .HasMany(m1 => m1.Tickets)
                       .WithOne(m2 => m2.EventParticipant);

            modelBuilder.Entity<Ticket>()
                       .HasMany(m1 => m1.Orders)
                       .WithOne(m2 => m2.Ticket);

            modelBuilder.Entity<User>()
                       .HasMany(m1 => m1.EventParticipants)
                       .WithOne(m2 => m2.User);

            modelBuilder.Entity<User>()
                       .HasMany(m1 => m1.Notifications)
                       .WithOne(m2 => m2.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}
