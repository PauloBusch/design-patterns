namespace ObservablePattern
{
    public interface IObservable<TypeValue>
    {
        void UpdateValue(TypeValue newValue);
    }
}
