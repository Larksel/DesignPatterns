using AbstractFactorySolucao.Boleto.Familia;

namespace AbstractFactorySolucao.Boleto;

public class Banco
{
    public Boleto GerarBoleto(double valor, ICalculosFactory factory)
    {
        Boleto boleto = new Boleto(valor, factory);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R${valor}");
        Console.WriteLine($"Valor Juros R${boleto.CalcularJuros()}");
        Console.WriteLine($"Valor Multa R${boleto.CalcularMulta()}");
        Console.WriteLine($"Valor Desconto R${boleto.CalcularDesconto()}");
        Console.WriteLine("--------------------------------------------------");

        return boleto;
    }
}
