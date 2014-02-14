using MyGame.Extensions;
using MyGame.ViewModels;
using ReactiveUI;
using System;
using System.Windows.Controls;

namespace MyGame.Views
{
    /// <summary>
    /// Interaction logic for NotificationView.xaml
    /// </summary>
    public partial class NotificationView : UserControl, INotificationView
    {
        public NotificationView()
        {
            InitializeComponent();

            this.WhenNavigatedTo(ViewModel, () =>
            {
                // Make XAML Bindings be relative to our ViewModel
                DataContext = ViewModel;

                return ViewModel.Hide.Subscribe(param => this.Visibility = System.Windows.Visibility.Collapsed);
            });
        }

        public INotificationViewModel ViewModel
        {
            get { return (INotificationViewModel)DataContext; }
            set { DataContext = value; }
        }

        object IViewFor.ViewModel
        {
            get
            {
                return ViewModel;
            }
            set
            {
                this.ViewModel = (INotificationViewModel)value;
            }
        }
    }
}