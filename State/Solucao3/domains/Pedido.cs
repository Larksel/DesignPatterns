using Solucao3.domains.state;

namespace Solucao3.domains
{
    public class Pedido
    {
        public IState EstadoAtual {  get; set; }

        public Pedido()
        {
            Console.WriteLine("Pedido aguardando pagamento");

            // Define estado atual
            EstadoAtual = new AguardandoPagamentoState(this);
        }

        public void SucessoAoPagar()
        {
            try
            {
                Console.WriteLine("Pedido pago");
                EstadoAtual.SucessoAoPagar();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CancelarPedido()
        {
            try
            {
                Console.WriteLine("Pedido cancelado");
                EstadoAtual.CancelarPedido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DespacharPedido()
        {
            try
            {
                Console.WriteLine("Pedido enviado");
                EstadoAtual.DespacharPedido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
