namespace FactoryMethodProblema.boletobancario.BancoCaixa;

public class BancoCaixa : Banco
{
    protected override Boleto CriarBoleto(int vencimento, double valor)
    {
        Boleto boleto = vencimento switch
        {
            10 => new BancoCaixaBoleto10Dias(valor),
            30 => new BancoCaixaBoleto30Dias(valor),
            60 => new BancoCaixaBoleto60Dias(valor),
            _ => throw new Exception("Vencimento indisponível"),
        };
        return boleto;
    }

}
