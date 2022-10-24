using Microsoft.EntityFrameworkCore;
using NzWalk.Model.Domain;

namespace NzWalk.Data
{
    public class NZWalkDbCtx : DbContext
    {
        public NZWalkDbCtx(DbContextOptions<NZWalkDbCtx> options) : base(options)
        {
        }
        //Models 
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
