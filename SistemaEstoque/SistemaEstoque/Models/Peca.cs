using System.ComponentModel.DataAnnotations;

namespace SistemaEstoque.Models
{
    public class Peca
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, 99999, ErrorMessage = "Preço inválido")]
        public decimal Preco { get; set; }
    }
}
