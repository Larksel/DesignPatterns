using Solucao1.domains.enums;

namespace Solucao1.domains
{
    public class Pedido
    {
        private StatusPedido statusPedido { get; set; }

        public Pedido()
        {
            Console.WriteLine("Pedido aguardando pagamento");
            statusPedido = StatusPedido.AGUARDANDO_PAGAMENTO;
        }

        public void SucessoAoPagar()
        {
            if (statusPedido == StatusPedido.AGUARDANDO_PAGAMENTO)
            {
                Console.WriteLine("Pedido pago");
                statusPedido = StatusPedido.PAGO;
            }
            else
            {
                throw new Exception("O pedido não está aguardando pagamento");
            }
        }

        public void CancelarPedido()
        {
            if (statusPedido == StatusPedido.PAGO || 
                statusPedido == StatusPedido.AGUARDANDO_PAGAMENTO)
            {
                Console.WriteLine("Pedido cancelado");
                statusPedido = StatusPedido.CANCELADO;
            }
            else
            {
                throw new Exception($"O pedido se encontra {statusPedido}");
            }
        }

        public void DespacharPedido()
        {
            if (statusPedido == StatusPedido.PAGO)
            {
                Console.WriteLine("Pedido enviado");
                statusPedido = StatusPedido.ENVIADO;
            }
            else
            {
                throw new Exception("O pedido se encontra cancelado");
            }
        }
    }
}
