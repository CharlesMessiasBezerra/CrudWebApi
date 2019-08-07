using Usuario.Domain.UsuarioContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.UsuarioContext
{
    [Table("Usuario")]
    public partial class UsuarioDB
    {
        public UsuarioDB()
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
