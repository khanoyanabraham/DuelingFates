using DuelingFates.ScreenManagement;
using UnityEngine;

namespace DuelingFates.Screens
{
    public class MainScreen : ScreenBase<MainScreenView, MainScreenModel, MainScreenController>
    {
        [SerializeField] private MainScreenView _view;
        protected override void RegisterSignals()
        {
         
        }
    }
}
