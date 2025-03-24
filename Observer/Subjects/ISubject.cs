using Observer.Observers;

namespace Observer.Subjects;

public interface ISubject
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
    public void AddMessage(string message);
}
