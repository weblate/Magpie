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
using System.Windows.Shapes;

namespace NewUI {
    /// <summary>
    /// OptionsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OptionsWindow : Window {
        static readonly string[] OPTIONS_PAGES = new string[] {
            "ApplicationOptionsPage.xaml",
            "ScaleOptionsPage.xaml",
            "AdvancedOptionsPage.xaml",
            "AboutOptionsPage.xaml"
        };

        public OptionsWindow() {
            InitializeComponent();

            lbxOptionsPage.SelectedIndex = 0;
        }

        private void LxbOptionsPage_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            
            int idx = lbxOptionsPage.SelectedIndex;
            if (idx < 0 || idx >= OPTIONS_PAGES.Length) {
                idx = 0;
            }

            _ = contentFrame.Navigate(new Uri(OPTIONS_PAGES[idx], UriKind.Relative));
        }
    }
}
