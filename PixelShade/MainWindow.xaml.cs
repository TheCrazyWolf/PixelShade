﻿using ModernWpf.Controls;
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

namespace PixelShade
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await dialog_auth.ShowAsync();

            //ContentDialog noWifiDialog = new ContentDialog
            //{
            //    Title = "No wifi connection",
            //    Content = "Check your connection and try again.",
                
            //    CloseButtonText = "Ok"
            //};

            //ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
