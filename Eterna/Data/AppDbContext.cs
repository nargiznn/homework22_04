﻿using System;
using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Feature> Features { get; set; }
    }
}

