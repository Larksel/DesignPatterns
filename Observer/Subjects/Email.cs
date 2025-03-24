using Observer.Observers;

namespace Observer.Subjects;

public class Email
{
    public static void EnviarEmail(IObserver observer, string mensagem)
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------");
        Console.WriteLine($"Email enviado para: {observer.GetNome()} - {observer.GetEmail()}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }
}
