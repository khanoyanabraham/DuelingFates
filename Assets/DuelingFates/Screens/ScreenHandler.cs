using DuelingFates.ScreenManagement;
using System;
using UnityEngine;

namespace DuelingFates.Screens
{
    public class ScreenHandler : ScreenBase<ScreenHandlerView, ScreenHandlerModel, ScreenHandlerController>
    {
        [SerializeField] ScreenHandlerView _view;
        protected override void RegisterSignals()
        {
            
        }
    }
}
