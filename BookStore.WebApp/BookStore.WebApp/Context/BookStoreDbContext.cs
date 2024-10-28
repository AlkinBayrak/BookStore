using BookStore.WebApp.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.WebApp.Context
{
	public class BookStoreDbContext : DbContext
	{
        #region OldCons
        //private static string _connectionString;

        //      public BookStoreDbContext(IConfiguration configuration)
        //      {
        //	_connectionString = configuration.GetConnectionString("BookStoreDbBilkent");
        //	//var test = configuration.GetSection("ConnectionStrings:BookStoreDbBilkent");
        //	//Console.WriteLine("ConStr :" + _connectionString);
        // //         Console.WriteLine("test:" + test);

        //} 
        #endregion
        public BookStoreDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }
        public DbSet<City> Cities { get; set; }
        #region OldConfig
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //	optionsBuilder.UseSqlServer(_connectionString);
        //} 
        #endregion
    }
}
