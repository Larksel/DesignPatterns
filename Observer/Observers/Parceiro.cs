using Observer.Subjects;

namespace Observer.Observers;

public class Parceiro : IObserver
{
    private string _nome;
    private string _email;

    public Parceiro(string nome, string email)
    {
        _nome = nome;
        _email = email;
    }

    public override bool Equals(object? obj)
    {
        return obj is Parceiro parceiro &&
            _nome == parceiro._nome &&
            _email == parceiro._email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetNome()
    {
        return _nome;
    }

    public void Update(string mensagem)
    {
        Email.EnviarEmail(this, mensagem);
    }
}
