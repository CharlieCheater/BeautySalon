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
using System.Windows.Shapes;

namespace BeautySalon.Views
{
    /// <summary>
    /// Логика взаимодействия для AdminAuthWindow.xaml
    /// </summary>
    public partial class AdminAuthWindow : Window
    {
        public AdminAuthWindow()
        {
            InitializeComponent();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(PinCodeTB.Text == "0000")
            {
                var t = App.Current.MainWindow as MainWindow;
                t.IsAdmin = true;
                this.Close();
            }
        }
    }
}
