using IceTask4.Models;
using Microsoft.EntityFrameworkCore;

namespace IceTask4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<HotelBooking> HotelBookings { get; set; }
    }
}
