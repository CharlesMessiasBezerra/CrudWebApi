using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.UsuarioContext
{
    [Table("Tab_Usuarios")]
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

        [Required]
        [Column("IDADE")]        
        public int Idade { get; set; }
                
        [Column("SEXO")]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Column("IDCIDADE")]
        public int IdCidade { get; set; }

    }
}
