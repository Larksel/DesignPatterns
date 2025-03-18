namespace Cenario3.Pedidos
{
    public class PedidoMoveis : Pedido
    {
        public PedidoMoveis()
        {
            NomeSetor = "Móveis";
        }

        public override double CalculaFreteComum()
        {
            return Valor * 0.05;
        }

        public override double CalculaFreteExpresso()
        {
            throw new Exception("Não é permitido frete expresso");
        }
    }
}
