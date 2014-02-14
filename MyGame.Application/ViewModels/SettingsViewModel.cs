using MyGame.Data;
using MyGame.Data.Models;
using ReactiveUI;

namespace MyGame.ViewModels
{
    public interface ISettingsViewModel 
    {
        GameSetting Setting { get; }
    }

    public class SettingsViewModel : ViewModelBase, ISettingsViewModel
    {
        private readonly IService _service;
        private GameSetting _setting;

        public SettingsViewModel(IService service)
        {
            _service = service;
            _service.Start();
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

        public GameSetting Setting
        {
            get { return _setting; }
            set { this.RaiseAndSetIfChanged<SettingsViewModel, GameSetting>(ref _setting, value); }
        }
    }
}