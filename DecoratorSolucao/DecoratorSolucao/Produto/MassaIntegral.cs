namespace DecoratorSolucao.Produto;

public class MassaIntegral : AcrescimoDecorator
{
    private double ValorMassaIntegral = 5;
    public MassaIntegral(Pizza pizza)
    {
        Pizza = pizza;
    }

    public override string GetDescricao()
    {
        return Pizza.GetDescricao() + " Massa Integral";
    }

    public override double GetPreco()
    {
        return Pizza.GetPreco() + ValorMassaIntegral;
    }
}
