namespace ObservablePattern
{
    public class Observable : IObservable<string>
    {
        private string _value;
        public void UpdateValue(string newValue)
        {
            _value = newValue;
        }
    }
}
