namespace TemplateMethod.SemPadrao
{
    public class Gateway
    {
        public bool Cobrar(double valor)
        {
            bool[] respostas = { true, false };
            Console.WriteLine($"Valor cobrado: R${valor}");

            return respostas[new Random().Next(0, 1)];
        }
    }
}
