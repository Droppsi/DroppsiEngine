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

namespace DroppsiEngine.MVVM.Views
{
    /// <summary>
    /// Interaktionslogik für EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
	   public EditorWindow()
	   {
		  InitializeComponent();
	   }

	   private void Window_MouseDown(object sender, MouseButtonEventArgs e)
	   {
		  DragMove();
	   }

	   private void MaximizeButton_Click(object sender, RoutedEventArgs e)
	   {
		  Application.Current.MainWindow.WindowState = WindowState.Maximized;
	   }

	   private void MinimizeButton_Click(object sender, RoutedEventArgs e)
	   {
		  Application.Current.MainWindow.WindowState = WindowState.Minimized;
	   }

	   private void CloseButton_Click(object sender, RoutedEventArgs e)
	   {
		  Application.Current.MainWindow.Close();
	   }
    }
}
