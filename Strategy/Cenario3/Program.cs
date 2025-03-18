using Cenario3.Pedidos;

try
{
    Pedido pedidoEletro = new PedidoEletronicos();
    pedidoEletro.Valor = 100;

    Console.WriteLine($"Frete Comum {pedidoEletro.NomeSetor}: R${pedidoEletro.CalculaFreteComum()}");
    Console.WriteLine($"Frete Expresso {pedidoEletro.NomeSetor}: R${pedidoEletro.CalculaFreteExpresso()}");

    Pedido pedidoMoveis = new PedidoMoveis();
    pedidoMoveis.Valor = 100;

    Console.WriteLine($"Frete Comum {pedidoMoveis.NomeSetor}: R${pedidoMoveis.CalculaFreteComum()}");
    Console.WriteLine($"Frete Expresso {pedidoMoveis.NomeSetor}: R${pedidoMoveis.CalculaFreteExpresso()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}