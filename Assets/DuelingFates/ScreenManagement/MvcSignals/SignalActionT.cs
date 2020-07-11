﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.DuelingFates.ScreenManagement.MvcSignals
{
    public class SignalActionT<T>
    {
        private List<Action<T>> _actions = new List<Action<T>>();
        public void Dispatch(T data)
        {
            _actions.ForEach(action => action?.Invoke(data));
        }

        public void AddAction(Action<T> action)
        {
            _actions.Add(action);
        }

        public void RemoveAllActions()
        {
            _actions.Clear();
        }
    }
}
