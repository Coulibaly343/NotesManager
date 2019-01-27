﻿using System;
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

namespace NotesManager.Layouts
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            ValidatePassword();
        }

        private void ValidatePassword()
        {
            if (string.IsNullOrEmpty(loginInput.Text) || string.IsNullOrEmpty(passwordInput.Password))
            {
                MessageBox.Show("Login or passowrd cannot be empty", "NotesManager");
            }

            else
            {
                NavigationService.Navigate(new NoteList());
            }
        }
    }
}
