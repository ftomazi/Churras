using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ParticipanteCreateModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Tamanho Máximo.")]
        public string Nome { get; set; }

        public int IdChurras { get; set; }

        public decimal Valor { get; set; }

        [Display(Name = "Pago")]
        public bool Pago { get; set; }

        [Display(Name = "Com bebida?")]
        public bool ComBebida { get; set; }



    }
}