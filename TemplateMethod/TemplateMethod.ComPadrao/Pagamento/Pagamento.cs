namespace TemplateMethod.ComPadrao.Pagamento
{
    public abstract class Pagamento
    {
        protected double Valor { get; set; }
        protected Gateway Gateway { get; set; }

        // Hook method - Implementação mínima
        public virtual double CalcularTaxa()
        {
            return 0;
        }

        public abstract double CalcularDesconto();

        public bool RealizarCobranca()
        {
            double valorPago = Valor + CalcularTaxa() - CalcularDesconto();
            return Gateway.Cobrar(valorPago);
        }
    }
}
