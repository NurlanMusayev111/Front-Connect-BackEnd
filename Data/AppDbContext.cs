using FrontEndProject_Connect_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontEndProject_Connect_BackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfo { get; set; }
    }
}
