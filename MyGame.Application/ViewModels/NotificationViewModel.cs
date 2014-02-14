using MyGame.Infrastructure;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyGame.ViewModels
{
    public interface INotificationViewModel
    {
        string Message { get; set; }
        ICommand Hide { get; }
        ICommand Show { get; }
    }

    public class NotificationViewModel : ViewModelBase, INotificationViewModel
    {
        private string _message;
        public NotificationViewModel()
        {
            InitData();

            InitCommands();
        }

        public ICommand Hide { get; protected set; }

        public ICommand Show { get; protected set; }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                this.RaiseAndSetIfChanged<NotificationViewModel, string>(ref _message, value);
            }
        }


        protected override void InitData()
        {
            Message = "Welcome";
        }

        protected void InitCommands()
        {
            Hide = new ReactiveCommand();
            Show = new ReactiveCommand();
        }
    }
}
