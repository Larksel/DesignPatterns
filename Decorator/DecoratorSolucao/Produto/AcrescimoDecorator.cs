namespace DecoratorSolucao.Produto;

public abstract class AcrescimoDecorator : Pizza
{
    protected Pizza Pizza;
    public abstract override string GetDescricao();
    public abstract override double GetPreco();
}
