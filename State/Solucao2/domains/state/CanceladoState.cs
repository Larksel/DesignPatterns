namespace Solucao2.domains.state
{
    internal class CanceladoState : IState
    {
        private Pedido _pedido;

        public CanceladoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        void IState.CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }

        void IState.DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }

        void IState.SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }
    }
}
