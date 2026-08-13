using DailyTaskBot.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyTaskBot.Data
{
    public class DailyTaskBotContext : DbContext
    {
        public DbSet<EmployeeDailyReport> Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-IMHDDG2;
                  Database=DailyTaskBotDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True");
        }
    }
}