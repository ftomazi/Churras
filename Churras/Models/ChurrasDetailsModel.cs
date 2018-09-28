using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ChurrasDetailsModel : ChurrasCreateModel
    {
        public int Id { get; set; }

        public int Participantes { get; set; }

        public decimal ValorArrecadado { get; set; }

        public decimal ValorPago { get; set; }

        public int Bebem { get; set; }

        public int NaoBebem { get; set; }
        
    }
}