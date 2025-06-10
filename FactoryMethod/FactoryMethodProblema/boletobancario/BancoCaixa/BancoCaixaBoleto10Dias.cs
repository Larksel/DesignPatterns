namespace FactoryMethodProblema.boletobancario.BancoCaixa;

public class BancoCaixaBoleto10Dias: Boleto
{
    public BancoCaixaBoleto10Dias(double valor)
    {
        Valor = valor;
        Juros = 0.02;
        Desconto = 0.1;
        Multa = 0.05;
    }
}
