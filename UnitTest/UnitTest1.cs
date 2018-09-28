using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //prepare
            var db = new ChurrasDB(new ChurrasEntities());
            var part = new ParticipanteDB();
            var listaPart = part.ListarParticipantesChurras(1);

            // executa
            var data = db.TotalArrecadado(1);
            decimal acumulado = 0;
            foreach (var item in listaPart)
            {
                acumulado += item.Valor ?? 0;
            }
            
            //valida
            Assert.AreEqual(data, acumulado);
        }
    }
}
