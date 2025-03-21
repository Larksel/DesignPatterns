namespace Solucao3.domains.state
{
    internal class PagoState : IState
    {
        private Pedido _pedido;

        public PagoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        void IState.CancelarPedido()
        {
            _pedido.EstadoAtual = new CanceladoState(_pedido);
        }

        void IState.DespacharPedido()
        {
            _pedido.EstadoAtual = new EnviadoState(_pedido);
        }

        void IState.SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }
    }
}
