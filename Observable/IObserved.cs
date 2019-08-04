using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public interface IObserved<TypeValue>
    {
        void Subscribe(IObservable<TypeValue> observable);
        void Unsubscribe(IObservable<TypeValue> observable);
        void NotifyObservable(TypeValue newValue);
    }
}
