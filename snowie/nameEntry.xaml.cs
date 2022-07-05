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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class nameEntry : Page
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public nameEntry()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           GLOBAL.PlayerName = nameTextBox.Text;
            mediaPlayer.Open(new Uri("C:\\Users\\frank\\source\\repos\\snowie\\snowie\\tap.wav"));
            mediaPlayer.Play();
           
           
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            if (GLOBAL.PlayerName == null)
            {
                MessageBox.Show("Name cannot be null.");
            }
            else if (GLOBAL.PlayerName.ToLower() == "mytime")
            {
                mytime mytime = new mytime();
                mytime.Show();
                MainWindow.GetWindow(this).Close();
                mytime.WindowState = WindowState.Maximized;
                mytime.WindowStyle = WindowStyle.None;
            } else

            {
                mytime mytime = new mytime();
                mytime.Show();
                MainWindow.GetWindow(this).Close();
            }
            
        }


    }
}
