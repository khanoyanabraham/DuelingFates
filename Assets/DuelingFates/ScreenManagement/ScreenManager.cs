using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DuelingFates.ScreenManagement
{
    public class ScreenManager : MonoBehaviour, IScreenManager
    {
        private Dictionary<Type, string> _registrations = new Dictionary<Type, string>();
        private Dictionary<Type, IScreen> _loadedScreens = new Dictionary<Type, IScreen>();
        public ScreenManager()
        {
            Registrations();
        }
        private void Registrations()
        {
        }
        private void RegisterScreen<T>(string resourcePath) where T : IScreen
        {
            _registrations.Add(typeof(T), resourcePath);
        }
        public T LoadScreen<T>() where T : IScreen
        {
            if (!_loadedScreens.TryGetValue(typeof(T), out IScreen screen))
            {
                string resource = _registrations[typeof(T)];
                GameObject screenPrefab = LoadScreenPrefabFromResource(resource);
                GameObject instance = Instantiate(screenPrefab);
                if (instance.TryGetComponent<T>(out T iscreencomponent))
                {
                    _loadedScreens.Add(typeof(T), iscreencomponent);
                    return iscreencomponent;
                }
                else
                {
                    throw new Exception("Screen not found");
                }
            }
            else
            {
                throw new Exception("Screen Already Loaded");
            }
        }
        private GameObject LoadScreenPrefabFromResource(string path)
        {
            return Resources.Load<GameObject>(path);
        }
        public T GetScreen<T>() where T : IScreen
        {
            _loadedScreens.TryGetValue(typeof(T), out IScreen screen1);
            return (T)screen1;
        }
        public T LoadScreen<T>(Transform parent) where T : IScreen
        {
            if (!_loadedScreens.TryGetValue(typeof(T), out IScreen screen))
            {
                string resource = _registrations[typeof(T)];
                GameObject screenPrefab = LoadScreenPrefabFromResource(resource);
                GameObject instance = Instantiate(screenPrefab, parent);
                if (instance.TryGetComponent<T>(out T iscreencomponent))
                {
                    _loadedScreens.Add(typeof(T), iscreencomponent);
                    return iscreencomponent;
                }
                else
                {
                    throw new Exception("Screen not found");
                }
            }
            else
            {
                throw new Exception("Screen Already Loaded");
            }

        }
        public void UnloadScreen(IScreen screenToUnload)
        {
            screenToUnload.UnloadScreen();
            _loadedScreens.Remove(screenToUnload.GetType());
        }
    }
}
