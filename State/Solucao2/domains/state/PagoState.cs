namespace Solucao2.domains.state
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
            _pedido.EstadoAtual = _pedido.Cancelado;
        }

        void IState.DespacharPedido()
        {
            _pedido.EstadoAtual = _pedido.Enviado;
        }

        void IState.SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }
    }
}
