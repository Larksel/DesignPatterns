using TemplateMethod.ComPadrao;
using TemplateMethod.ComPadrao.Pagamento;

double valor = 1000;
Gateway gateway = new Gateway();

Console.WriteLine("Crédito");
PagamentoCredito pgCred = new PagamentoCredito(valor, gateway);
pgCred.RealizarCobranca();

Console.WriteLine("Débito");
PagamentoDebito pgDeb = new PagamentoDebito(valor, gateway);
pgDeb.RealizarCobranca();

Console.WriteLine("Dinheiro");
PagamentoDinheiro pgDin = new PagamentoDinheiro(valor, gateway);
pgDin.RealizarCobranca();