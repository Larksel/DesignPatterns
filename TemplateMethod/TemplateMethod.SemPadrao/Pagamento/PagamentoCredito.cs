namespace TemplateMethod.SemPadrao.Pagamento
{
    public class PagamentoCredito
    {
        private double Valor { get; set; }
        private Gateway Gateway { get; set; }

        public PagamentoCredito(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public double CalcularTaxa()
        {
            return Valor * 0.05;
        }

        public double CalcularDesconto()
        {
            if (Valor > 300)
                return Valor * 0.02;
            else return 0;
        }

        public bool RealizarCobranca()
        {
            double valorPago = Valor + CalcularTaxa() - CalcularDesconto();
            return Gateway.Cobrar(valorPago);
        }
    }
}
