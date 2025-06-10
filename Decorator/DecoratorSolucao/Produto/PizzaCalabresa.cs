namespace DecoratorSolucao.Produto;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa()
    {
        Descricao = "Deliciosa pizza de calabresa";
        Preco = 25;
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
