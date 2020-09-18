using System;
using Microsoft.EntityFrameworkCore;
using Service.Diablo2.Entities.Models;

namespace Service.Diablo2.Database
{
    public class Diablo2Context : DbContext
    {
        public Diablo2Context(DbContextOptions<Diablo2Context> options) : base(options)
        { }

        public DbSet<Diablo2Item> Diablo2Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
    }
}
