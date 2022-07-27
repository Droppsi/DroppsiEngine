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
using DroppsiEngineCore.Commands;
using DroppsiEngineCore.Infrastructure.Logging;
using OpenTK.Wpf;

namespace DroppsiEngineEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
	   public RelayCommand OpenFileMenu { get; set; }
	   public MainWindow()
	   {
		  InitializeComponent();

		  OpenFileMenu = new RelayCommand(() =>
		  {

		  });
	   }

	   private void Window_MouseDown(object sender, MouseButtonEventArgs e)
	   {
		  DragMove();
	   }
    }
}
