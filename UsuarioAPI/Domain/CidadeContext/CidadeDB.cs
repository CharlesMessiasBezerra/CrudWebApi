using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.CidadeContext
{
    [Table("TAB_CIDADES")]
    public partial class CidadeDB
    {
        public CidadeDB()
        {

        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NOME_CIDADE")]
        [StringLength(300)]
        public string Nome_Cidade { get; set; }

        [Required]
        [Column("IDESTADO")]
        public int IdEstado { get; set; }

    }
}
