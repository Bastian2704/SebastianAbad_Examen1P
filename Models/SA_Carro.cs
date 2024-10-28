using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SebastianAbad_Examen1P.Models
{
    [Table("SA_Tabla1")]
    public class SA_Carro
    {
        [KeyAttribute]
        public int SA_CARROID { get; set; }
        [StringLength(1)]
        public int SA_MecanicosAcargo { get; set; }
        [MaxLength(30)]
        [Required]
        public string SA_Modelo { get; set; }
        [MaxLength(20)]
        [Required]
        public string SA_Marca{ get; set; }
        [Range(0, 5000)]
        public decimal SA_Precio { get; set; }
        public bool SA_Gasolina { get; set; }
        public DateTime SA_FechaEntrega { get; set; }



    }
}
