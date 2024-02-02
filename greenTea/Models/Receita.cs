using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace greenTea.Models
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adicione um nome para a receita!")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string NomeReceita { get; set; }

        [Required(ErrorMessage = "Adicione uma URL de imagem!")]
        [Column("UrlImg")]
        [Display(Name = "URL da Imagem")]
        public string UrlImg { get; set; }

        [Required(ErrorMessage = "Adicione uma descrição curta para a receita!")]
        [Column("DescricaoTopo")]
        [Display(Name = "Descrição simples")]
        public string DescricaoTopo { get; set; }

        [Required(ErrorMessage = "Adicione uma descrição para a receita!")]
        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Favor adicionar os ingredientes.")]
        [MinLength(3, ErrorMessage = "Favor inserir ao menos um ingrediente")]
        [Column("Ingredientes")]
        [Display(Name = "Ingredientes")]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Adicione o modo de preparo.</br>" +
                                 "Cada seção deve começar com '-' seguido por ';' ex(-Massa;)." +
                                 "Cada etapa deve terminar com ';' ex(etapa1; etapa2;)!")]
        [Column("ModoPreparo")]
        [Display(Name = "Modo de Preparo")]
        public string ModoPreparo { get; set; }

        [Column("NumPorcoes")]
        [Display(Name = "Número de Porções")]
        public int NumPorcoes { get; set; }

        [Column("Calorias")]
        [Display(Name = "Calorias")]
        public int Calorias { get; set; }

        [Column("TempoPreparo")]
        [Display(Name = "Tempo de Preparo")]
        public string TempoPreparo { get; set; }

        [Column("Autor")]
        [Display(Name = "Nome do Autor")]
        public string Autor { get; set; }

    }
}
