using Microsoft.EntityFrameworkCore;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.DataAccess.Concrete
{
    public  class SocialDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = @"Data Source=(localdb)\ProjectModels;Initial Catalog=SocialDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);
        }

        public DbSet<User> Users { get; set; }

        // public DbSet<Post> Posts { get; set; }

        // public DbSet<Comment> Comments { get; set; }

        // public DbSet<Notification> Notifications { get; set; }

        // public DbSet<Chat> Chats { get; set; }

        //  public DbSet<Group> Groups { get; set; }

        //  public DbSet<Storie> Stories { get; set; }


    }
}
