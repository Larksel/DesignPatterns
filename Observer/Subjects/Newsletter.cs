using Observer.Observers;

namespace Observer.Subjects;

public class Newsletter : ISubject
{
    private List<IObserver> _observers;
    private List<string> _emails;

    public Newsletter()
    {
        _observers = [];
        _emails = [];
    }

    public void AddMessage(string message)
    {
        _emails.Add(message);
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_emails.Last());
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        for (int i = 0; i < _observers.Count; i++)
        {
            IObserver observerReg = _observers[i];
            if (observerReg.Equals(observer))
                _observers.Remove(observerReg);
        }
    }
}
