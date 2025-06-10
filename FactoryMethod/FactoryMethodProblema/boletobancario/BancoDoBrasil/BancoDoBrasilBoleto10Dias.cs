namespace FactoryMethodProblema.boletobancario.BancoDoBrasil;

public class BancoDoBrasilBoleto10Dias: Boleto
{
    public BancoDoBrasilBoleto10Dias(double valor)
    {
        Valor = valor;
        Juros = 0.03;
        Desconto = 0.05;
        Multa = 0.02;
    }
}
