namespace ObservablePattern
{
    public interface IObserver<TypeValue>
    {
        void Subscribe(IObservable<TypeValue> observable);
        void Unsubscribe(IObservable<TypeValue> observable);
        void NotifyObservable(TypeValue newValue);
    }
}
