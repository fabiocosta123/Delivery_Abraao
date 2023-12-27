using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Delivery_Abraao.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado!")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O nome deve ter no máximo {0} caracteres e no mínimo {1} caracteres!")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(10, ErrorMessage = " A descrição deve ter no mínimo {1} caracteres!")]
        [MaxLength(300, ErrorMessage = " A descrição deve ter no máximo {1} caracteres!")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = " A descrição do lanche deve ser informada!")]
        [Display(Name = " Descrição do Lanche")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres!")]
        [MaxLength(150, ErrorMessage = "A descrição deve ter no máximo {1} caracteres!")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Preço")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho da imagem tamanho normal")]
        public string ImagemUrl {  get; set; }

        [Display(Name = "Caminho da imagem em miniatura")]
        [StringLength(200, ErrorMessage = "O {0} dever ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido {  get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque {  get; set; }

        // faz referência a tabela categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
