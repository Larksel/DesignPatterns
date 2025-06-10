namespace FactoryMethodProblema.boletobancario;

public abstract class Banco
{
    // Este é o Factory Method
    protected abstract Boleto CriarBoleto(int vencimento, double valor);

    public Boleto GerarBoleto(int vencimento, double valor)
    {
        Boleto boleto = CriarBoleto(vencimento, valor);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R${valor}");
        Console.WriteLine($"Valor Juros R${boleto.CalcularJuros()}");
        Console.WriteLine($"Valor Multa R${boleto.CalcularMulta()}");
        Console.WriteLine($"Valor Desconto R${boleto.CalcularDesconto()}");
        Console.WriteLine("--------------------------------------------------");

        return boleto;
    }

}
