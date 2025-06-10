namespace DecoratorSolucao.Produto;

public class BordaRequeijao : AcrescimoDecorator
{
    private double ValorBorda = 8.5;
    public BordaRequeijao(Pizza pizza)
    {
        Pizza = pizza;
    }

    public override string GetDescricao()
    {
        return Pizza.GetDescricao() + " Borda recheada de requeijão";
    }

    public override double GetPreco()
    {
        return Pizza.GetPreco() + ValorBorda;
    }
}
