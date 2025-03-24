using Observer.Subjects;

namespace Observer.Observers;

public class Funcionario : IObserver
{
    private string _nome;
    private string _email;

    public Funcionario(string nome, string email)
    {
        _nome = nome;
        _email = email;
    }

    public override bool Equals(object? obj)
    {
        return obj is Funcionario funcionario &&
            _nome == funcionario._nome &&
            _email == funcionario._email;
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
