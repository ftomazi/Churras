//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class ControleTemperatura
    {
        public int Id { get; set; }
        public int IdSensor { get; set; }
        public System.DateTime Data { get; set; }
        public Nullable<double> Temperatura { get; set; }
        public Nullable<double> Tensao { get; set; }
        public string Dados { get; set; }
    }
}
