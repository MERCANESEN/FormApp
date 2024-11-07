using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{

    public class Product
    {

        [Display(Name ="Urun Id")]

        public int ProductId { get; set; }

        [Display(Name ="Urun Adi")]
        [Required]

        public String Name { get; set; } = string.Empty;

        [Display(Name ="Fiyat")]

        public decimal Price { get; set; }

        [Display(Name ="Resim")]

        public String Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
    }

}