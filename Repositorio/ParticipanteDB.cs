using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ParticipanteDB
    {
        private readonly ChurrasEntities _churras;

        public ParticipanteDB()
        {
            _churras = new ChurrasEntities();
        }

        public void IncluirParticipante(int idChurras, string nome, decimal valor, bool pago, bool comBebida)
        {
            _churras.Participantes.Add(
                new Participante()
                {
                    IdChurras = idChurras,
                    Nome = nome,
                    Valor = valor,
                    Pago = pago,
                    ComBebida = comBebida
                });
            _churras.SaveChanges();
        }

        public IList<Participante> ListarParticipantesChurras(int idChurras)
        {
            var dados = _churras.Participantes.Where(p => p.IdChurras == idChurras).ToList();
            return dados;
        }



    }
}
