using System.Windows;
using System.Windows.Input;

namespace HRIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private const string STAFF_KEY = "viewableStaff";
        //private StaffController staffController;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
            }
        }

        private void ButtonMinimise_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //private void DisplayLoginScreen()
        //{
        //    LoginWindow frm = new LoginWindow();

        //    frm.Owner = this;
        //    frm.ShowDialog();
        //    if (frm.DialogResult.HasValue && frm.DialogResult.Value)
        //        MessageBox.Show("User Logged In");
        //    else
        //        this.Close();
        //}
    }
}

