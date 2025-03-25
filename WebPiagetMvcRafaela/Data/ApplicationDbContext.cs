using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPiagetMvcRafaela.Models;

namespace WebPiagetMvcRafaela.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebPiagetMvcRafaela.Models.Aluno> Aluno { get; set; } = default!;
}
