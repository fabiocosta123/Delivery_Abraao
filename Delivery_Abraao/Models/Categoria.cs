using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery_Abraao.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "O nome da Categoria deve ser informada!")]
        [Display(Name = "Nome da Categoria")]
        public string CategoriaNome {  get; set; }

        [StringLength(250, ErrorMessage = "A descrição deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "Informe a descrição da categoria!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //está definindo a tabela de 1 para muitos, uma categoria pode ter varios lanches

        public List<Lanche> Lanches { get; set; }

    }
}
