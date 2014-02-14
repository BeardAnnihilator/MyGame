using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyGame.ViewModels
{
    public interface INotificationViewModel : IRoutableViewModel
    {
        string Message { get; set; }
        ReactiveCommand Hide { get; }
        ReactiveCommand Show { get; }
    }

}
