using MeetUp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeetUp.DAL
{
    public class MeetUpContext : IdentityDbContext
    {
        public MeetUpContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Admins { get; set; }
    }
}
