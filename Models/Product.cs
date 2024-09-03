namespace FormsApp.Models{

    public class Product{


        public int ProductId { get; set; }

        public String Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public String Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
    }

}