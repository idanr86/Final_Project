using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SmartFitnessTrainer.BusinessLayer.Authentication;
namespace SmartFitnessTrainer.GuiLayer
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Authenticator authenticator;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButtom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void createNewUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
