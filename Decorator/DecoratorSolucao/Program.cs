using DecoratorSolucao.Produto;

// Criação de uma pizza
Console.WriteLine("Cria uma pizza de queijo");
Pizza pizzaQueijo = new PizzaQueijo();

// Impressão de sua descrição
Console.WriteLine($"Produto--> {pizzaQueijo.GetDescricao()} Valor R$ {pizzaQueijo.GetPreco()}");
Console.WriteLine(" ");

// Adiciona borda de requeijão
Console.WriteLine("Adiciona borda de requeijão");
// Um decorator é criado para englobar a pizza
Pizza pizzaQueijoBorda = new BordaRequeijao(pizzaQueijo);

Console.WriteLine($"Produto--> {pizzaQueijoBorda.GetDescricao()} Valor R$ {pizzaQueijoBorda.GetPreco()}");
Console.WriteLine(" ");

// Adiciona massa integral
Console.WriteLine("Adiciona massa integral");
Pizza pizzaQueijoBordaMassaIntegral = new MassaIntegral(pizzaQueijoBorda);
Console.WriteLine($"Produto--> {pizzaQueijoBordaMassaIntegral.GetDescricao()} Valor R$ {pizzaQueijoBordaMassaIntegral.GetPreco()}");