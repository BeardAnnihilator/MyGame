using MyGame.Data;
using System.Linq;
using System.Collections.Generic;
using MyGame.Data.Models;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace MyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IService _service;

        public MainWindow()
        {
            InitializeComponent();

            _service = new Service();
            _service.Start();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var items = _service.GetItems();
            MessageBox.Show(items.Count().ToString());
        }
    }
}