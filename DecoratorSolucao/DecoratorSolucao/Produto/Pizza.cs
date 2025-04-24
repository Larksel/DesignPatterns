namespace DecoratorSolucao.Produto;

public abstract class Pizza
{
    protected string Descricao { get; set; }
    protected double Preco { get; set; }
    public abstract string GetDescricao();
    public abstract double GetPreco();
}
