using Observer.Subjects;

namespace Observer.Observers;

public class Fornecedor : IObserver
{
    private string _nome;
    private string _email;

    public Fornecedor(string nome, string email)
    {
        _nome = nome;
        _email = email;
    }

    public override bool Equals(object? obj)
    {
        return obj is Fornecedor fornecedor &&
            _nome == fornecedor._nome &&
            _email == fornecedor._email;
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
