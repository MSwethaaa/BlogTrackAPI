using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogTrackAPI.Models;

namespace BlogTrackAPI.Data
{
    public class BlogerDbContext : DbContext
    {
        public BlogerDbContext (DbContextOptions<BlogerDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTrackAPI.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<BlogTrackAPI.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<BlogTrackAPI.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
