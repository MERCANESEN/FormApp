namespace FormsApp.Models {

    public class Repository {


        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories =new();

        static Repository()
        {

            _categories.Add(new Category {CategoryId=1, Name="Telefon"});
            _categories.Add(new Category { CategoryId=2, Name= "Bilgisayar"});
            _categories.Add(new Category{CategoryId=3, Name="Tablet"});

            _products.Add(new Product{ProductId=1, Name="Iphone 11", Price= 15000, IsActive= true, Image="3.jpg.webp", CategoryId=1});
            _products.Add(new Product{ProductId=2, Name="Iphone 13", Price= 30500, IsActive= true, Image="5.jpg.webp", CategoryId=1});
            _products.Add(new Product{ProductId=3, Name="Iphone 14 Pro Max", Price= 30000, IsActive= true, Image="4.jpg.webp", CategoryId=1});
            _products.Add(new Product{ProductId=4, Name="Samsung S23", Price= 25000, IsActive= true, Image="8.jpg.webp", CategoryId=1});
            _products.Add(new Product{ProductId=5, Name="Samsung Galaxy Z", Price= 23990, IsActive= true, Image="9.jpg.png", CategoryId=1});
            _products.Add(new Product{ProductId=6, Name="Macbook", Price= 45000, IsActive= true, Image="7.jpg.webp", CategoryId=2});
            _products.Add(new Product{ProductId=7, Name="Masaüstü Apple", Price= 18000, IsActive= true, Image="6.jpg.jpg", CategoryId=2});
            _products.Add(new Product{ProductId=8, Name="Samsung Tab", Price= 10000, IsActive= true, Image="10.jpg.webp", CategoryId=3});
            _products.Add(new Product{ProductId=9, Name="Ipad", Price= 19000, IsActive= true, Image="2.jpg.jpeg", CategoryId=3});
            _products.Add(new Product{ProductId=10, Name="Ipad Pro", Price= 25000, IsActive= true, Image="1.jpg.jpeg", CategoryId=3});

        }


        public static List<Product> Products 
        {

            get
            {
                return _products;
            }

        }

         public static List<Category> Categories
        {

            get
            {
                return _categories;
            }

        }
    }
}