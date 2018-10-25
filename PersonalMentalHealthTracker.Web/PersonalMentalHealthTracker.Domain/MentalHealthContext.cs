using PersonalMentalHealthTracker.Domain.Entities;
using System.Data.Entity;

namespace PersonalMentalHealthTracker.Domain
{
    public class MentalHealthContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}


