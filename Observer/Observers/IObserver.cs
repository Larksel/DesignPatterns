namespace Observer.Observers;

public interface IObserver
{
    public void Update(string mensagem);
    public string GetNome();
    public string GetEmail();
}
