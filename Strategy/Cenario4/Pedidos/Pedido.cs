using Cenario4.Fretes;

namespace Cenario4.Pedidos
{
    public abstract class Pedido
    {
        public double Valor { get; set; }
        public string? NomeSetor { get; set; }
        public Frete TipoFrete { get; set; }

        public double CalculaFrete()
        {
            return TipoFrete.Calcula(Valor);
        }
    }
}
