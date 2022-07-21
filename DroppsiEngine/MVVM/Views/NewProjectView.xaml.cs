using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DroppsiEngine.MVVM.ViewModels;


namespace DroppsiEngine.MVVM.Views
{
    /// <summary>
    /// Interaction logic for NewProjectView.xaml
    /// </summary>
    public partial class NewProjectView : UserControl
    {
        public NewProjectView()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SecondaryTextProperty = DependencyProperty.Register("SecondaryText", typeof(string), typeof(NewProjectViewModel), new FrameworkPropertyMetadata("SecondaryTextProperty"));

        public string SecondaryText
	   {
            get { return (string)GetValue(SecondaryTextProperty); }
            set { SetValue(SecondaryTextProperty, value); }
	   }
    }
}
