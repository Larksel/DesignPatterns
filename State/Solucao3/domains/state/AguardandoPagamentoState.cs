namespace Solucao3.domains.state
{
    internal class AguardandoPagamentoState : IState
    {
        private Pedido _pedido;

        public AguardandoPagamentoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        void IState.CancelarPedido()
        {
            _pedido.EstadoAtual = new CanceladoState(_pedido);
        }

        void IState.DespacharPedido()
        {
            throw new Exception("Operação não suportada, " +
                "o pedido ainda não foi pago");
        }

        void IState.SucessoAoPagar()
        {
            _pedido.EstadoAtual = new PagoState(_pedido);
        }
    }
}
