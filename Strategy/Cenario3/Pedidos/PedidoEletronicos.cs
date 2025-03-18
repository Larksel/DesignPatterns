namespace Cenario3.Pedidos
{
    public class PedidoEletronicos : Pedido
    {
        public PedidoEletronicos()
        {
            NomeSetor = "Eletronicos";
        }

        public override double CalculaFreteComum()
        {
            return Valor * 0.05;
        }

        public override double CalculaFreteExpresso()
        {
            return Valor * 0.1;
        }
    }
}
