using MyGame.Data;
using MyGame.Data.Models;
using ReactiveUI;

namespace MyGame.ViewModels
{
   

    public class SettingsViewModel : ViewModelBase, ISettingsViewModel
    {
        private readonly IService _service;
        private ISetting _setting;

        public SettingsViewModel()
        {
            _service = RxApp.DependencyResolver.GetService<IService>();

            InitData();
        }

        protected override void InitData()
        {
            Setting = _service.GetSetting();
        }

        protected void InitCommands()
        {
            throw new System.NotImplementedException();
        }

        public ISetting Setting
        {
            get { return _setting; }
            set { this.RaiseAndSetIfChanged<SettingsViewModel, ISetting>(ref _setting, value); }
        }
    }
}