namespace FactoryMethodProblema.boletobancario.BancoDoBrasil;

public class BancoDoBrasilBoleto30Dias : Boleto
{
    public BancoDoBrasilBoleto30Dias(double valor)
    {
        Valor = valor;
        Juros = 0.05;
        Desconto = 0.02;
        Multa = 0.05;
    }
}
