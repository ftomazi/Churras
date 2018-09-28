using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ChurrasListModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao  { get; set; }
        public int NumeroParticipantes { get; set; }
        public decimal TotalArrecadado { get; set; }

    }
}