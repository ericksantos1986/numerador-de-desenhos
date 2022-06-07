using System;

namespace Numerador.Entities
{
    public class Numero
    {
        public string NumeroDoDesenho { get; private set; }
        public int TipoDeDesenho { get; set; }
        public int Sequencial { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        
        public void GerarNumero(Ordem Ordem)
        {
            NumeroDoDesenho = "DT-" + Ordem.OrdemDeServico + "-" + TipoDeDesenho.ToString("000") + "-" + Sequencial.ToString("000");
        }
    }
}
