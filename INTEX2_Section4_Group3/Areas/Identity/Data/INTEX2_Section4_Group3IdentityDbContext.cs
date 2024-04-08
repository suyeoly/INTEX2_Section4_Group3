using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace INTEX2_Section4_Group3.Areas.Identity.Data;

public class INTEX2_Section4_Group3IdentityDbContext : IdentityDbContext<IdentityUser>
{
    public INTEX2_Section4_Group3IdentityDbContext(DbContextOptions<INTEX2_Section4_Group3IdentityDbContext> options)
        : base(options)
    {
    }

    public INTEX2_Section4_Group3IdentityDbContext() { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
