using ReactiveUI;
using ReactiveUI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
         private readonly IScreen screen;

        public MainWindowViewModel(IScreen screen)
        {
            this.screen = screen;
        }

        public MainWindowViewModel()
        {
        }
    }

    
}