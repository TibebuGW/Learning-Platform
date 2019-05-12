using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teaching.Models;
namespace Teaching.Data
{
    public class ApplicationDbContext: DbContext
    {
        public virtual DbSet<Grade> Grades { get; set; }

        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<Chapter> Chapters { get; set; }

        public virtual DbSet<Quiz> Quizes{ get; set; }

        public virtual DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=6UvPhZr1w9RxhYkX;database=TeachingDb", 
                    new MySqlServerVersion(new Version(8, 0, 11)))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
