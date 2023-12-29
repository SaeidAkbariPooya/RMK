using RMK.Domain.Models;
using RMK.Domain.Models.Account;
using Microsoft.EntityFrameworkCore;


namespace RMK.Infra.Data.Context
{
    public class RMKContext : DbContext
    {
        public RMKContext(DbContextOptions<RMKContext> options) : base(options)
        {

        }

        #region account
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        #endregion

        #region on model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();


            modelBuilder.Entity<Person>()
               .Property(s => s.FullName)
               .HasColumnName("FullName")
               .HasMaxLength(300)
               .IsRequired();

            modelBuilder.Entity<User>()
            .HasOne(s => s.Role)
            .WithMany(g => g.Users)
            .HasForeignKey(s => s.RoleId);


            modelBuilder.Entity<Address>()
            .HasOne(s => s.Person)
            .WithMany(g => g.Addresses)
            .HasForeignKey(s => s.PersonId);

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
