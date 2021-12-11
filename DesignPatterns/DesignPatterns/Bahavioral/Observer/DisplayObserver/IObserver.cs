using Observer.Models;

namespace Observer.DisplayObserver
{
    interface IObserver
    {
        void Update(MeasurementsData data);
    }
}
