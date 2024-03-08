using FaceProductAPI.Models.SearchApp;
using FakeFICOAPI.Models.UpdateApplication;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FaceProductAPI.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<AA_LoanHistory> AA_LoanHistory { get; set; }
        public DbSet<AA_FicoLoanHistory> AA_FicoLoanHistory { get; set; }
    }
}
