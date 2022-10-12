using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WeatherForecast.Model
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
        {
        }

        public DbSet<WeatherDetails.root> WeatherCon { get; set; }
    }
}
