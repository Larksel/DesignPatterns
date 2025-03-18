using Cenario2.Pedidos;

// Criação do pedido
Pedido pedidoEletronico = new PedidoEletronicos();

// Atribuição do valor
pedidoEletronico.Valor = 100;

// Cálculo para frete comum
Console.WriteLine($"Frete Comum {pedidoEletronico.NomeSetor}: R${pedidoEletronico.CalculaFreteComum()}");
// Cálculo para frete expresso
Console.WriteLine($"Frete Expresso {pedidoEletronico.NomeSetor}: R${pedidoEletronico.CalculaFreteExpresso()}");
