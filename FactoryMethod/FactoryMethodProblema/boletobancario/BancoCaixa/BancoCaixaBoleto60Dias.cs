namespace FactoryMethodProblema.boletobancario.BancoCaixa;

public class BancoCaixaBoleto60Dias: Boleto
{
    public BancoCaixaBoleto60Dias(double valor)
    {
        Valor = valor;
        Juros = 0.1;
        Desconto = 0;
        Multa = 0.2;
    }
}
