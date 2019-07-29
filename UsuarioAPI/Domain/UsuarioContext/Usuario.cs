using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.UsuarioContext
{
    [Table("Usuario")]
    public class Usuario
    {

        public Usuario()
        {

        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NOME")]
        [StringLength(150)]
        public string Nome { get; set; }


    }
}
