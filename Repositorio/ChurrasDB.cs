using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ChurrasDB
    {
        private readonly ChurrasEntities _churras;

        // permite injeção dos dados p teste unitario
        public ChurrasDB(ChurrasEntities churras)
        {
            _churras = churras;
        }

        public void IncluirChurras(DateTime data, string motivo, string obs, decimal vlrBebida, decimal vlrSemBebida)
        {
            _churras.Churras.Add(
                new Churra(){
                    Data = data,
                    Motivo = motivo,
                    Observacao = obs,
                    ValorComBebida = vlrBebida,
                    ValorSemBebida = vlrSemBebida
                }
                );
            _churras.SaveChanges();
        }

         public IList<Churra> ListarChurras()
        {
            var dados = _churras.Churras.ToList();
            return dados;
        }

        public Churra BuscarChurras(int id)
         {
             return _churras.Churras.FirstOrDefault(p => p.Id == id);
         }

        public decimal TotalArrecadado(int idChurras)
        {
            var dados = _churras.Participantes.Where(p => p.IdChurras == idChurras);
            return dados.Any() ? dados.Sum(p => p.Valor ?? 0) : 0;
        }
        public int Participantes(int idChurras)
        {
            var dados = _churras.Participantes.Count(p => p.IdChurras == idChurras);
            return dados;
        }

        public decimal ValorArrecadacao(int idChurras)
        {
            var dados = _churras.Participantes.Where(p => p.IdChurras == idChurras && p.Pago == false);
            return dados.Any() ? dados.Sum(o => o.Valor ?? 0) : 0;
        }

        public decimal ValorPago(int id)
        {
            var dados = _churras.Participantes.Where(p => p.IdChurras == id && p.Pago == true).ToList();
            return dados.Any() ? dados.Sum(o => o.Valor ?? 0) : 0;
        }

        public int Bebuns(int id)
        {
            return _churras.Participantes.Count(p => p.IdChurras == id && p.ComBebida == true);
        }

        public int NaoBebuns(int id)
        {
            return _churras.Participantes.Count(p => p.IdChurras == id && p.ComBebida == false);
        }
    }
}
