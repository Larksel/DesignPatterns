namespace AdapterProblema.Adapter;

public interface Gateway
{
    public void setValor(double valor);
    public void setParcelas(int parcelas);
    public void setNumeroCartao(string numeroCartao);
    public void setCVV(string cvv);
    public bool validarCartao();
    public bool realizarPagamento();
}
