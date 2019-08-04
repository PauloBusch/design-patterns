using System.Collections.Generic;

namespace ObservablePattern
{
    public class Observer : IObserver<string>
    {
        private IList<IObservable<string>> _observables;
        public Observer() { 
            _observables = new List<IObservable<string>>();    
        }
        public void NotifyObservable(string newValue)
        {
            foreach(var observable in _observables)
                observable.UpdateValue(newValue);
        }

        public void Subscribe(IObservable<string> observable)
        {
            _observables.Add(observable);
        }

        public void Unsubscribe(IObservable<string> observable)
        {
            _observables.Remove(observable);
        }
    }
}
