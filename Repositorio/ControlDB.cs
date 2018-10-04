using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ControlDB
    {
        private readonly ChurrasEntities _db;

        // permite injeção dos dados p teste unitario
        public ControlDB(ChurrasEntities dbEntity)
        {
            _db = dbEntity;
        }

        public IList<ControleTemperatura> ListarTemperaturas(DateTime filtroData)
        {
            var datafim = filtroData.AddDays(1);
            var dados = _db.ControleTemperaturas.Where(p => p.Data >= filtroData && p.Data < datafim).ToList();
            return dados;
        }

  //      select distinct substring(cast(data as varchar(50)),0,20), max(temperatura), min(temperatura), idsensor, tensao, dados from controletemperatura
// group by substring(cast(data as varchar(50)),0,20), idsensor, tensao, dados

    }
}
