using MyGame.ViewModels;
using System.Windows.Controls;

namespace MyGame.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            DataContext = new SettingsViewModel();
            InitializeComponent();
        }
    }
}