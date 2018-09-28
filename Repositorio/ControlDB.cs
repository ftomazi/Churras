using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ControlDB
    {
        private readonly ChurrasEntities _churras;

        // permite injeção dos dados p teste unitario
        public ControlDB(ChurrasEntities churras)
        {
            _churras = churras;
        }

        public IList<ControleTemperatura> ListarTemperaturas()
        {
            var dados = _churras.ControleTemperaturas.Where(p => p.Data >= DateTime.Today).ToList();
            return dados;
        }

  //      select distinct substring(cast(data as varchar(50)),0,20), max(temperatura), min(temperatura), idsensor, tensao, dados from controletemperatura
// group by substring(cast(data as varchar(50)),0,20), idsensor, tensao, dados

    }
}
