using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialProject.WebUI.Entities
{
    public class CustomIdentityDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options)
            : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FriendShip> FriendShips { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<FriendShip>()
                .HasOne(fs => fs.Sender)
                .WithMany(u => u.SenderUsers)
                .HasForeignKey(fs => fs.SenderId);

            builder.Entity<FriendShip>()
                .HasOne(fs => fs.Friend)
                .WithMany(u => u.FriendUsers)
                .HasForeignKey(fs => fs.FriendId);



        }


    }

}

