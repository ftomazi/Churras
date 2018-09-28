using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ChurrasCreateModel
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Tamanho Maximo.")]
        public string Motivo { get; set; }

        public string Observacao { get; set; }

        [Display(Name = "Valor com Bebida")]
        public decimal ValorBebida { get; set; }

        [Display(Name = "Valor sem Bebida")]
        public decimal ValorSemBebida { get; set; }

    }
}