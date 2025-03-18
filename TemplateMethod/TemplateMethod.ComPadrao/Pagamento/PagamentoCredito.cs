namespace TemplateMethod.ComPadrao.Pagamento
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public override double CalcularTaxa()
        {
            return Valor * 0.05;
        }

        public override double CalcularDesconto()
        {
            if (Valor > 300)
                return Valor * 0.02;
            else return 0;
        }
    }
}
