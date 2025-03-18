namespace TemplateMethod.SemPadrao.Pagamento
{
    public class PagamentoDinheiro
    {
        private double Valor { get; set; }
        private Gateway Gateway { get; set; }

        public PagamentoDinheiro(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public double CalcularTaxa()
        {
            return 0;
        }

        public double CalcularDesconto()
        {
            return Valor * 0.1;
        }

        public bool RealizarCobranca()
        {
            double valorPago = Valor + CalcularTaxa() - CalcularDesconto();
            return Gateway.Cobrar(valorPago);
        }
    }
}
