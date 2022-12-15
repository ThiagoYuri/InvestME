using InvestME.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestME.DAL
{
    public class ContextDb: DbContext
    {
        public ContextDb()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbPath = Directory.GetCurrentDirectory() + @"\db\Database.mdf";
                //optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True");
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbInvestME;Data Source=LAPTOP-I9LM3CSP");

            }
        }


        public DbSet<Acoes> Acoes { get; set; }
        public DbSet<Investments> Investments { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
