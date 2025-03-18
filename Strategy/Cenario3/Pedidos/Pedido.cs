namespace Cenario3.Pedidos
{
    public abstract class Pedido
    {
        public double Valor { get; set; }
        public string? NomeSetor { get; set; }

        public abstract double CalculaFreteComum();
        public abstract double CalculaFreteExpresso();
    }
}
