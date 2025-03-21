using Solucao2.domains.state;

namespace Solucao2.domains
{
    public class Pedido
    {
        public IState AguardandoPagamento { get; set; }
        public IState Pago {  get; set; }
        public IState Cancelado { get; set; }
        public IState Enviado { get; set; }
        public IState EstadoAtual {  get; set; }

        public Pedido()
        {
            Console.WriteLine("Pedido aguardando pagamento");

            // Define as classes concretas
            AguardandoPagamento = new AguardandoPagamentoState(this);
            Pago = new PagoState(this);
            Cancelado = new CanceladoState(this);

            // Define estado atual
            EstadoAtual = AguardandoPagamento;
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
