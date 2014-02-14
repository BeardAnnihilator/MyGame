using MyGame.ViewModels;
using ReactiveUI;
using ReactiveUI.Xaml;
using System.Windows;

namespace MyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow()
        //{
        //    InitializeComponent();
        //}
        public MainWindowViewModel ViewModel { get; protected set; }

        public MainWindow()
        {
            InitializeComponent();

            var viewHost = new RoutedViewHost();
            this.Presenter.Content = viewHost;

            var screen = RxApp.DependencyResolver.GetService<IScreen>();
            viewHost.Router = screen.Router;

            DataContext = RxApp.DependencyResolver.GetService<IMainWindowViewModel>();
            
            
        }
    }
}