﻿using KIDEControls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KIDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadLayout();
        }

        private void LoadLayout()
        {
            
            BaseVH.AddControl(new CodeEditor());
        }

        private void CmdCut(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CmdCopy(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CmdPaste(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CmdNew(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}