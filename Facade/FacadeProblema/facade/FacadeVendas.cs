using FacadeProblema.cadastros;
using FacadeProblema.vendas;

namespace FacadeProblema.facade;

public class FacadeVendas
{
    private Pedido pedido;
    private Pagamento pagamento;
    private EmailPedido email;

    public FacadeVendas(Consumidor consumidor)
    {
        pedido = new Pedido();
        pedido.consumidor = consumidor;

        email = new EmailPedido(pedido);
    }

    public void addProduto(Produto produto)
    {
        pedido.addProduto(produto);
    }

    public void pedidoCredito()
    {
        pagamento = new PagamentoCredito(pedido);
        if (pagamento.realizarPagamento())
        {
            email.enviarEmail("Pagamento realizado com sucesso (crédito)");
        } 
        else
        {
            email.enviarEmail("Falha no pagamento do pedido");
        }
    }

    public void pedidoBoleto()
    {
        pagamento = new PagamentoBoleto(pedido);
        if (pagamento.realizarPagamento())
        {
            email.enviarEmail("Pagamento realizado com sucesso (boleto)");
        } 
        else
        {
            email.enviarEmail("Falha no pagamento do pedido");
        }
    }
}
