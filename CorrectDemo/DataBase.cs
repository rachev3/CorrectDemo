using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CorrectDemo
{
    public class DataBase : DbContext
    {
        public DbSet<Account> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public string DbPath { get; }
       
        public DataBase()  
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "CorrectDemo.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
