namespace TemplateMethod.ComPadrao.Pagamento
{
    public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public override double CalcularTaxa()
        {
            return 4;
        }

        public override double CalcularDesconto()
        {
            return Valor * 0.05;
        }
    }
}
