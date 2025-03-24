using Observer.Subjects;

namespace Observer.Observers;

public class Cliente : IObserver
{
    private string _nome;
    private string _email;

    public Cliente(string nome, string email)
    {
        _nome = nome;
        _email = email;
    }

    public override bool Equals(object? obj)
    {
        return obj is Cliente cliente &&
            _nome == cliente._nome &&
            _email == cliente._email;
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
