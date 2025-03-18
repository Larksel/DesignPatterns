namespace Cenario2.Pedidos
{
    public abstract class Pedido
    {
        public double Valor { get; set; }
        public string? NomeSetor { get; set; }

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
