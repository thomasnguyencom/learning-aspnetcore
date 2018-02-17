using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Omgtitb.Learning.AspNetCore.AppModel;

namespace Omgtitb.Learning.AspNetCore.AppCore
{
    public class PoseContext : DbContext
    {
        public PoseContext(DbContextOptions<PoseContext> options)
            : base(options)
        {
        }

        public DbSet<Pose> PoseItems { get; set; }
    }
}
