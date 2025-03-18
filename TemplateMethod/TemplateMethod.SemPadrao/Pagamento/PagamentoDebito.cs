namespace TemplateMethod.SemPadrao.Pagamento
{
    public class PagamentoDebito
    {
        private double Valor { get; set; }
        private Gateway Gateway { get; set; }

        public PagamentoDebito(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public double CalcularTaxa()
        {
            return 4;
        }

        public double CalcularDesconto()
        {
            return Valor * 0.05;
        }

        public bool RealizarCobranca()
        {
            double valorPago = Valor + CalcularTaxa() - CalcularDesconto();
            return Gateway.Cobrar(valorPago);
        }
    }
}
