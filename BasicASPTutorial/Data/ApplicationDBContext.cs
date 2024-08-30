using BasicASPTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BasicASPTutorial.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> optoins) : base(optoins)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
