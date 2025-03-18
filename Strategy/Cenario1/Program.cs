using Cenario1.Pedidos;

// Criação do pedido
Pedido pedido = new Pedido();

// Atribuição do valor
pedido.Valor = 100;

// Cálculo para frete comum
Console.WriteLine("Frete Comum: R$" + pedido.CalculaFreteComum());
// Cálculo para frete expresso
Console.WriteLine("Frete Expresso: R$" + pedido.CalculaFreteExpresso());
