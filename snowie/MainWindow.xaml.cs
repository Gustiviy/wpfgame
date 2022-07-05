using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace snowie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Open(new Uri("C:\\Users\\frank\\source\\repos\\snowie\\snowie\\click.wav"));
            mediaPlayer.Play();
            MessageBoxResult result;
            result = MessageBox.Show("Continue?", "Snowie Game v0.0.1", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch(result)
            {
                case MessageBoxResult.OK:
                    nameEntry page = new nameEntry();
                    this.Content = page;
                    mediaPlayer.Open(new Uri("C:\\Users\\frank\\source\\repos\\snowie\\snowie\\click.wav"));
                    mediaPlayer.Play();
                    break;
                case MessageBoxResult.Cancel:
                    mediaPlayer.Open(new Uri("C:\\Users\\frank\\source\\repos\\snowie\\snowie\\click.wav"));
                    mediaPlayer.Play();
                    break;
            }
        }
    }
}
