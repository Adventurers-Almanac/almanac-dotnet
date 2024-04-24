
namespace AdventurersAlmanac.Domain.Entities
{
    public abstract class Aggregate: Entity
    {
        private readonly List<object> _events = new List<object>();

        protected void AddEvent(object @event)
        {
            _events.Add(@event);
        }

        public IEnumerable<object> GetEvents()
        {
            return _events;
        }

        public void ClearEvents()
        {
            _events.Clear();
        }
    }
}