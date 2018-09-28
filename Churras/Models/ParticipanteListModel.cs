using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ParticipanteListModel
    {

        public int id { get; set; }
        public DateTime Data { get; set; }
        public string Motivo { get; set; }
        public string Nome { get; set; }
        public int IdChurras { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        [Display(Name = "Com Bebida")]
        public string ComBebida { get; set; }
    }
}