using OperaWebSite.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OperaWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage ="Campo Obligatirio")]
        [Column(TypeName ="varchar(50)")]
        [StringLength(50)]
        
        public string Title { get; set;}

        [Required(ErrorMessage = "Campo Obligatirio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Composer { get; set;}

        [CheckValidYear]
        public int Year { get; set;}

    }
}
