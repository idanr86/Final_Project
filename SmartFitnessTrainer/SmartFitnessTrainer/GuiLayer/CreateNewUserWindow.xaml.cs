﻿using System;
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
using SmartFitnessTrainer.BusinessLayer.DataAccessObject;

namespace SmartFitnessTrainer.GuiLayer
{
    /// <summary>
    /// Interaction logic for CreateNewUserWindow.xaml
    /// </summary>
    public partial class CreateNewUserWindow : Window
    {
        SqlDao dao;
        public CreateNewUserWindow()
        {
            InitializeComponent();
        }

        private void createNewUserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private Boolean validateInput()
        {
            return false;
        }
    }
}
