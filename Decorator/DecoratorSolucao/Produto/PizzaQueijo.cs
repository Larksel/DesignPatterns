namespace DecoratorSolucao.Produto;

public class PizzaQueijo : Pizza
{
    public PizzaQueijo()
    {
        Descricao = "Deliciosa pizza de queijo";
        Preco = 22;
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
