using System;


namespace Observer
{
    public interface IObserver <Temperature>
    {
        void Update(IObserver<Temperature> Temperature);
    }
}