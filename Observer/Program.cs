using Observer.Observers;
using Observer.Subjects;

// Criação da Newsletter (subject)
Newsletter newsletter = new();

// Criação dos observadores
Funcionario funcionario1 = new("Func01", "func01@teste.com");
Funcionario funcionario2 = new("Func02", "func02@teste.com");
newsletter.RegisterObserver(funcionario1);
newsletter.RegisterObserver(funcionario2);

Cliente cliente = new("Cli01", "cli01@teste.com");
newsletter.RegisterObserver(cliente);

Parceiro parceiro = new("Parca01", "parca01@teste.com");
newsletter.RegisterObserver(parceiro);

Fornecedor fornecedor = new("Forn01", "forn01@teste.com");
newsletter.RegisterObserver(fornecedor);

Console.WriteLine("------------------------ TESTE PRIMEIRA MENSAGEM ------------------------");
newsletter.AddMessage("Primeira Mensagem");

newsletter.RemoveObserver(funcionario2);

Console.WriteLine("------------------------ TESTE SEGUNDA MENSAGEM ------------------------");
newsletter.AddMessage("Segunda Mensagem");

newsletter.RegisterObserver(funcionario2);

Console.WriteLine("------------------------ TESTE TERCEIRA MENSAGEM ------------------------");
newsletter.AddMessage("Terceira Mensagem");
