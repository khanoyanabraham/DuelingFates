using UnityEngine;

namespace DuelingFates.ScreenManagement
{
    public interface IScreenManager
    {
        T LoadScreen<T>() where T : IScreen;
        T LoadScreen<T>(Transform parent) where T : IScreen;
        void UnloadScreen(IScreen screenToUnload);
    }
}
