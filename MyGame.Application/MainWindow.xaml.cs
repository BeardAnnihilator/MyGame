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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GameEngine));
            using (TextReader reader = new StreamReader("GameEngine.xml"))
            {
                var result = serializer.Deserialize(reader) as GameEngine;
                if (result != null)
                {
                    MessageBox.Show(result.ToString());
                }
                else
                {
                    MessageBox.Show("fail!");
                }
            }
        }
    }
}