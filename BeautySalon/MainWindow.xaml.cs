﻿using BeautySalon.Events;
using BeautySalon.Views;
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

namespace BeautySalon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public event EventHandler Administrated;

        private bool _isAdmin = false;
        public bool IsAdmin
        {
            get => _isAdmin;
            set
            {
                _isAdmin = value;
                if (value)
                    AdminText.Text = "Выйти из режима администрирования";
                else
                    AdminText.Text = "Войти в режим администрирования";
                AdminModeEventArgs args = new AdminModeEventArgs
                {
                    IsAdmin = value
                };
                if (Administrated is EventHandler)
                {
                    Administrated(this, args);
                }
            }
        }
        public AdminAuthWindow AuthWindow { get; private set; }
        private void AdminLink_Click(object sender, RoutedEventArgs e)
        {
            if (!IsAdmin)
            {
                (new AdminAuthWindow()).ShowDialog();
                return;
            }
            IsAdmin = !IsAdmin;
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (WindowState == WindowState.Normal)
                    WindowState = WindowState.Maximized;
                else
                    WindowState = WindowState.Normal;
            }

        }
    }
}
