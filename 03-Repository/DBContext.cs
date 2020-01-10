using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.Repository
{
    public class DBContext:DbContext {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext>options)
            :base(options)
    {
    }
       public virtual DbSet<AirplaneModel> AirPlane { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuider)
        {
            if (!optionBuider.IsConfigured)
            {
                optionBuider.UseSqlServer("Server =.\\SQLExpress; Database = master; trusted_Connection = True; ");
            }
        }

    }




}
