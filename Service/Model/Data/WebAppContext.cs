using Microsoft.EntityFrameworkCore;

namespace WebApp.Service.Model.Data
{
   public class WebAppContext : DbContext
   {
        public WebAppContext()
        {
        }
        public WebAppContext( DbContextOptions<WebAppContext> options )
        :  base (options: options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                using StreamReader sr1 = File.OpenText(Path.GetFullPath(@"C:\Users\wallison-santos\Documents\GitHub\csharp\dados.csv"));
                while (!sr1.EndOfStream)
                {
                    string[] vetor = sr1.ReadLine().Split(';');

                    modelBuilder.Entity<Product>().HasData( new Product
                    {
                        Id           = long.Parse(vetor[0]),
                        Name         = vetor[1],
                        Price        = double.Parse(vetor[2]),
                        Description  = vetor[3],
                        ImageUrl     = vetor[4],
                        CategoryName = vetor[5]
                    });
                }

            } catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
    }
}