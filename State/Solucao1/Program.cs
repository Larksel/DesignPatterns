using Solucao1.domains;

try
{
    Console.WriteLine("---------------- Pedido 01 ----------------");
    Pedido pedido = new();
    pedido.SucessoAoPagar();
    pedido.DespacharPedido();

    Console.WriteLine("---------------- Pedido 02 ----------------");
    Pedido pedido2 = new();
    pedido2.SucessoAoPagar();
    pedido2.DespacharPedido();
    pedido2.CancelarPedido();
} catch (Exception e)
{
    Console.WriteLine(e);
}