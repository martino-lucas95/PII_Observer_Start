using System;

namespace Observer
{
    public interface ISubject: IObserver <Temperature>
    {
        void Suscribe (IObserver <Temperature> observer);
        void UnSuscribe (IObserver <Temperature> observer);
    }

}