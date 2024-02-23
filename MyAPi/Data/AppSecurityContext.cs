using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyAPi.Data;

public class AppSecurityContext : IdentityDbContext<IdentityUser>
{
    public AppSecurityContext(DbContextOptions<AppSecurityContext> options)
        :base(options)
        {}
}