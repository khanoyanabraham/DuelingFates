using Assets.DuelingFates.ScreenManagement.MvcSignals;
using DuelingFates.ScreenManagement.MvcSignals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelingFates.ScreenManagement
{
    public class SignalRegistrator
    {
        public void RegisterSignal(SignalAction signal, Action action)
        {
            signal.AddAction(action);
        }
        public void RegisterSignal<T>(SignalActionT<T> signal, Action<T> action)
        {
            signal.AddAction(action);
        }
    }
}
