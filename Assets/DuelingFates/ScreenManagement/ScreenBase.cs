using UnityEngine;

namespace DuelingFates.ScreenManagement
{
    public abstract class ScreenBase<TScreenView, TScreenModel, TScreenController> : MonoBehaviour, IScreen
        where TScreenView : IScreenView
        where TScreenModel : IScreenModel
        where TScreenController : IScreenController
    {

        protected TScreenView View;
        protected TScreenModel Model;
        protected IScreenController Controller;

        protected SignalRegistrator SignalRegistrator = new SignalRegistrator();

        private void Start()
        {
            InitScreen();
        }
        public void HideScreen()
        {
            gameObject.SetActive(false);
        }

        public virtual void InitScreen()
        {
            RegisterSignals();
            View.Init();
            Model.Init();
            Controller.Init();
        }
        protected void InitializeMVC(TScreenView view, TScreenModel model, TScreenController controller)
        {
            this.View = view;
            this.Model = model;
            this.Controller = controller;
        }

        public void ShowScreen()
        {
            gameObject.SetActive(true);
        }
     

        protected abstract void RegisterSignals();
        public void UnloadScreen()
        {
            Destroy(gameObject);
        }
    }

}
