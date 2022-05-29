using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_postgres_example.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_postgres_example.Database
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users{get; set;}


        /*
        * Customização no nome da tabela e seus campos ao inves de deixar o padrao gerado pelo EF core
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var UserDefinition = modelBuilder.Entity<User>();
            UserDefinition.ToTable("TUser");
            UserDefinition.HasKey(field =>field.Id);
            UserDefinition.Property(field => field.Id).HasColumnName("Val_ID").ValueGeneratedOnAdd();
        }
    }
}