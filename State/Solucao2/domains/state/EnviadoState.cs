namespace Solucao2.domains.state
{
    internal class EnviadoState : IState
    {
        private Pedido _pedido;

        public EnviadoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        void IState.CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }

        void IState.DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }

        void IState.SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }
    }
}
