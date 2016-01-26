﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Sqlite
{
    using DataAccess.Sqlite.Entities;

    using Microsoft.Data.Entity;
    using Microsoft.Data.Sqlite;

    public class DocumentaniaContext : DbContext
    {
        // This property defines the table
        public DbSet<Document> Document { get; set; }

        // This method connects the context with the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Documentania.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}