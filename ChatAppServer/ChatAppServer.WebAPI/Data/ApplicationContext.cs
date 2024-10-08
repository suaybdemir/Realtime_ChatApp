﻿using ChatAppServer.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAppServer.WebAPI.Data
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<UserConnection> UserConnections { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .HasKey(e => e.Id);
        }
    }
}
