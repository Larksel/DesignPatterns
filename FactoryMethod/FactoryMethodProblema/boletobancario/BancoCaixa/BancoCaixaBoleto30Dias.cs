namespace FactoryMethodProblema.boletobancario.BancoCaixa;

public class BancoCaixaBoleto30Dias : Boleto
{
    public BancoCaixaBoleto30Dias(double valor)
    {
        Valor = valor;
        Juros = 0.05;
        Desconto = 0.05;
        Multa = 0.1;
    }
}
