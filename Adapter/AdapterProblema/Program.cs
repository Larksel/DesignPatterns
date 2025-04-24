using AdapterProblema.Adapter;
using AdapterProblema.Cobranca;

Console.WriteLine("Configura a Cobranca");

Cobranca cobranca = new Cobranca();
cobranca.setValor(100);
cobranca.setNumeroCartao("999999999999");
cobranca.setCVV("163");

// Teste PagFacil
cobranca.setGateway(new PagFacilAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();

// Teste TopPagamentos
cobranca.setGateway(new TopPagamentosAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();