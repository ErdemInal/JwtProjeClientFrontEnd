using System.ComponentModel.DataAnnotations;

namespace JwtProjeClient.Models{
    public class ProductAdd{
        [Required(ErrorMessage="Ad alanı boş geçilemez")]
        public string Name { get; set; }
    }
}