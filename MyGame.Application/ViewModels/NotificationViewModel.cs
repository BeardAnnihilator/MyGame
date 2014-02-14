using MyGame.Infrastructure;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.ViewModels
{
    public interface INotificationViewModel
    {
        string Message { get; set; }
        ReactiveCommand Hide { get; }
        ReactiveCommand Show { get; }
    }

    public class NotificationViewModel : ViewModelBase, INotificationViewModel
    {
        private string _message;
        public NotificationViewModel(IScreen screen)
        {
            InitData();

            InitCommands();
        }

        public ReactiveCommand Hide { get; protected set; }

        public ReactiveCommand Show { get; protected set; }

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
