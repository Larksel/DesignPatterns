namespace DecoratorSolucao.Produto;

public class PizzaFrango : Pizza
{
    public PizzaFrango()
    {
        Descricao = "Deliciosa pizza de frango";
        Preco = 19;
    }

    public override string GetDescricao()
    {
        return Descricao;
    }

    public override double GetPreco()
    {
        return Preco;
    }
}
