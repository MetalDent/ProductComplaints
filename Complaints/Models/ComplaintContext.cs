using Microsoft.EntityFrameworkCore;

namespace Complaints.Models
{
    public class ComplaintContext: DbContext
    {
        public ComplaintContext(DbContextOptions<ComplaintContext> options): base(options)
        {

        }

        public DbSet<Complaint> Complaints { get; set; } = null;
    }
}
