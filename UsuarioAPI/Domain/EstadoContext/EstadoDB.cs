using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.EstadoContext
{
    [Table("TAB_ESTADOS")]
    public partial class EstadoDB
    {
        public EstadoDB()
        {

        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NOME_ESTADO")]
        [StringLength(300)]
        public string Nome_Estado { get; set; }

        [Required]
        [Column("ABREVIACAO")]
        [StringLength(3)]
        public string Abreviacao { get; set; }

    }
}
