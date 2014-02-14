using MyGame.Data.Models;
using MyGame.ViewModels;

namespace MyGame.Design
{
    internal class SettingsViewModelDesign : ISettingsViewModel
    {
        GameSetting ISettingsViewModel.Setting
        {
            get
            {
                return new GameSetting
                {
                    Id = "DesignId",
                    Title = "DesignTitle",
                    GameSpeed = 1,
                    GoogleTrackingCode="DesignTrackingCode"
                };
            }
        }
    }
}