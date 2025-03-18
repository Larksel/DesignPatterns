namespace Cenario4.Fretes
{
    public class FreteComum : Frete
    {
        public double Calcula(double valorPedido)
        {
            return valorPedido * 0.05;
        }
    }
}
