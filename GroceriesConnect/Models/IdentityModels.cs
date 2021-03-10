﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using GroceriesConnect.Models.GroceriesConnectModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GroceriesConnect.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public List<Catalog> Catalogs { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Order> Orders { get; set; }
       
        public List<Location> Locations { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Catalog> Catalogs { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<ItemDetail> ItemDetails { get; set; }

        public DbSet<PickupOption> PickupOptions { get; set; }

        public DbSet<PaymentOption> paymentOptions  { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Location> Locations { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}