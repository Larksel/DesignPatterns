namespace TemplateMethod.ComPadrao.Pagamento
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(double valor, Gateway gateway)
        {
            Valor = valor;
            Gateway = gateway;
        }

        public override double CalcularDesconto()
        {
            return Valor * 0.1;
        }
    }
}
