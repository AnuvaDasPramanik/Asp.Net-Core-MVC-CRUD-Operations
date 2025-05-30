﻿using BankTransactions.Models;
using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Data
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions <TransactionDbContext> options) : base(options)
        {
                
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
