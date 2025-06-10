namespace FactoryMethodProblema.boletobancario.BancoDoBrasil;

public class BancoDoBrasil : Banco
{
    protected override Boleto CriarBoleto(int vencimento, double valor)
    {
        Boleto boleto = vencimento switch
        {
            10 => new BancoDoBrasilBoleto10Dias(valor),
            30 => new BancoDoBrasilBoleto30Dias(valor),
            60 => new BancoDoBrasilBoleto60Dias(valor),
            _ => throw new Exception("Vencimento indisponível"),
        };
        return boleto;
    }

}
