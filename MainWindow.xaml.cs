using System.Windows;
using System.Windows.Input;


namespace TestCalendar
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

        private void LableNote_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtNote.Focus();
        }

        private void TxtNote_MouseDown(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(LableNote.Text) && TxtNote.Text.Length > 0)
            {
                LableNote.Visibility = Visibility.Collapsed;
            }
            else
            {
                LableNote.Visibility = Visibility.Visible;

            }
        }
        private void LableTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextTime.Focus();
        }

        private void TxtTime_MouseDown(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextTime.Text) && TextTime.Text.Length > 0)
            {
                LableTime.Visibility = Visibility.Collapsed;
            }
            else
            {
                LableTime.Visibility = Visibility.Visible;

            }
        }
    }
}