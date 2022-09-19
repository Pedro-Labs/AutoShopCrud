using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopCrud.Models
{
    [Table("Carros")]
    public class Carros
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo")]
        public string? Modelo { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        [Column("Ano")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Column("Câmbio")]
        [Display(Name = "Câmbio")]
        public string? Cambio  { get; set; }

        [Column("Preço")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
