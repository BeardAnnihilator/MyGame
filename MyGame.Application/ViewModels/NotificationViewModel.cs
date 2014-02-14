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
    public class NotificationViewModel : ViewModelBase, INotificationViewModel
    {
        private string _message;
        public NotificationViewModel(IScreen screen)
        {
            HostScreen = screen;

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

        public IScreen HostScreen { get; private set; }

        public string UrlPathSegment
        {
            get { return "notification"; }
        }
    }
}
