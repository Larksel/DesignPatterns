namespace Solucao3.domains.state
{
    public interface IState
    {
        public void SucessoAoPagar();
        public void CancelarPedido();
        public void DespacharPedido();
    }
}
