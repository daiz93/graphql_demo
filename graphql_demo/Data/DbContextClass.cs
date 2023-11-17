﻿using graphql_demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace graphql_demo.Data
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass>options) : base(options)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
