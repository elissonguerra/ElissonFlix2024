using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElissonFlix.Models;

[Table("Movie")]

    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte Id { get; set; }

        [Display(Name = "Título Original")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(100, ErrorMessage = "O título original deve possuir no máximo 100 caracteres")]
        public string OriginalTile { get; set; }   
    }
