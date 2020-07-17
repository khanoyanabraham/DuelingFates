using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelingFates.ScreenManagement
{
    public interface IScreen
    {
        void InitScreen();
        void ShowScreen();
        void HideScreen();
        void UnloadScreen();

    }
}
