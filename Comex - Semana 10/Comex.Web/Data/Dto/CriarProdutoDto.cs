using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
namespace Comex.Web.Data.Dto;

public class CriarProdutoDto
{
    [Required(ErrorMessage = "O nome do produto é obrigatório!")]
    [MinLength(6, ErrorMessage = "O nome deve ter mais do que 5 caracteres.")]
    public string Nome { get; set; }
    // Exigência ter mais de 5 caracteres

    [Required(ErrorMessage = "O preço é obrigatório!")]
    [Range(0, double.MaxValue, ErrorMessage = "O preço unitário deve ser maior do que 0.")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O estoque é obrigatório!")]
    [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser maior do que 0.")]
    public int QuantidadeEmEstoque { get; set; }

    [Required(ErrorMessage = " A categoria é obrigatória")]
    public string Categoria { get; set; }
}
