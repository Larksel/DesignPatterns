namespace FactoryMethodProblema.boletobancario.BancoDoBrasil;

public class BancoDoBrasilBoleto60Dias: Boleto
{
    public BancoDoBrasilBoleto60Dias(double valor)
    {
        Valor = valor;
        Juros = 0.1;
        Desconto = 0;
        Multa = 0.15;
    }
}
