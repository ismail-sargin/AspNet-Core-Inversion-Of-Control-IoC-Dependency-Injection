namespace IOC.Console
{
    public class DAL :IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product {Id = 1,Name = "Kalem",Price = 100,Stock=1000},
            new Product {Id = 2,Name = "Kalem2",Price = 200,Stock=2000},
            new Product {Id = 3,Name = "Kalem3",Price = 300,Stock=3000},
            new Product {Id = 4,Name = "Kalem4",Price = 400,Stock=4000}
            };
        }
    }
}
