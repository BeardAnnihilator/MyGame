using MyGame.ViewModels;
using MyGame.Extensions;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MyGame.Views
{
    /// <summary>
    /// Interaction logic for WelcomeView.xaml
    /// </summary>
    //public partial class WelcomeView : UserControl
    //{
    //    public WelcomeView()
    //    {
    //        InitializeComponent();
    //    }
    //}

    public partial class WelcomeView : UserControl, IViewFor<IWelcomeViewModel>
    {
        public WelcomeView()
        {
            InitializeComponent();

            this.WhenNavigatedTo(ViewModel, () =>
            {
                /* COOLSTUFF: Setting up the View
                 *
                 * Whenever we're Navigated to, we want to set up some bindings.
                 * In particular, we want to Subscribe to the HelloWorld command
                 * and whenever the ViewModel invokes it, we will pop up a
                 * Message Box.
                 */

                // Make XAML Bindings be relative to our ViewModel
                DataContext = ViewModel;

                return ViewModel.HelloWorld.Subscribe(param =>
                    MessageBox.Show("It worked!"));
            });


        }

        public IWelcomeViewModel ViewModel
        {
            get { return (IWelcomeViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(IWelcomeViewModel), typeof(WelcomeView), new PropertyMetadata(null));

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IWelcomeViewModel)value; }
        }
    }

    
}

