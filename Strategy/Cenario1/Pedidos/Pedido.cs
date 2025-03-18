namespace Cenario1.Pedidos
{
    public class Pedido
    {
        public double Valor { get; set; }

        public double CalculaFreteComum()
        {
            return Valor * 0.05;
        }

        public double CalculaFreteExpresso()
        {
            return Valor * 0.1;
        }
    }
}
