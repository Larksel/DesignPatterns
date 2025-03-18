namespace Cenario4.Fretes
{
    public class FreteExpresso : Frete
    {
        public double Calcula(double valorPedido)
        {
            return valorPedido * 0.1;
        }
    }
}
