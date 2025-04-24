using AdapterProblema.Pagamento;

namespace AdapterProblema.Adapter;

public class TopPagamentosAdapter : Gateway
{
    public TopPagamentos topPagamentos;
    public string numeroCartao { get; set; }
    public string cvv { get; set; }
    public double valor { get; set; }
    public int parcelas { get; set; }

    public TopPagamentosAdapter()
    {
        topPagamentos = new TopPagamentos();
    }

    public void setCVV(string cvv)
    {
        this.cvv = cvv;
    }

    public void setNumeroCartao(string numeroCartao)
    {
        this.numeroCartao = numeroCartao;
    }

    public void setParcelas(int parcelas)
    {
        this.parcelas = parcelas;
    }

    public void setValor(double valor)
    {
        this.valor = valor;
    }

    public bool validarCartao()
    {
        return true;
    }

    public bool realizarPagamento()
    {
        topPagamentos.setValorTotal(valor);
        topPagamentos.setCartao(numeroCartao, cvv);
        topPagamentos.setQuantidadeParcelas(parcelas);

        return topPagamentos.realizarPagamento();
    }
}
