using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurrasTrinca.Models
{
    public class ControleTemperaturaModel
    {
        public int Id { get; set; }
        public int IdSsensor { get; set; }
        public DateTime Data { get; set; }
        public double Temperatura { get; set; }
        public double Tensao { get; set; }
        public string Dados { get; set; }
    }
}