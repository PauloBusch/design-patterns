namespace ObservablePattern
{
    public interface IObserved<TypeValue>
    {
        void Subscribe(IObservable<TypeValue> observable);
        void Unsubscribe(IObservable<TypeValue> observable);
        void NotifyObservable(TypeValue newValue);
    }
}
