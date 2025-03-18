using Cenario4.Fretes;
using Cenario4.Pedidos;

try
{
    // Define os tipos de frete
    Frete freteComum = new FreteComum();
    Frete freteExpresso = new FreteExpresso();

    // Define o pedido eletronico
    Pedido pedidoEletro = new PedidoEletronicos();
    pedidoEletro.Valor = 100;

    // Calcula o frete comum
    pedidoEletro.TipoFrete = freteComum;
    Console.WriteLine($"Frete Comum {pedidoEletro.NomeSetor}: R${pedidoEletro.CalculaFrete()}");

    // Calcula o frete expresso
    pedidoEletro.TipoFrete = freteExpresso;
    Console.WriteLine($"Frete Expresso {pedidoEletro.NomeSetor}: R${pedidoEletro.CalculaFrete()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}