using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição do produto é obrigatória")]
    [StringLength(300, ErrorMessage = "A descrição do produto deve ter no máximo 300 caracteres")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque do produto é obrigatória")]
    public float Estoque { get; set; }

    [Required]
    public DateTime DataCadastro { get; set; }

    [ForeignKey("Categoria")]
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}
