using Observer.DisplayObserver;

namespace Observer.Publisher
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
