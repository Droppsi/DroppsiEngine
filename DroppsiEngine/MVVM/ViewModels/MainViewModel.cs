using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DroppsiEngine.Engine.Commands;
using DroppsiEngine.Engine.Misc;


namespace DroppsiEngine.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand DefaultMainVMCommand { get; set; }
        public RelayCommand NewProjectVMCommand { get; set; }

        public NewProjectViewModel NewProjectVM { get; set; }
        public DefaultMainViewModel DefaultMainVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get
            {
                return _currentView; 
            }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            NewProjectVM = new NewProjectViewModel();
            DefaultMainVM = new DefaultMainViewModel();


            CurrentView = DefaultMainVM;

            NewProjectVMCommand = new RelayCommand((o) =>
            {
                CurrentView = NewProjectVM;
            });
            DefaultMainVMCommand = new RelayCommand((o) =>
            {
                CurrentView = DefaultMainVMCommand;
            });
            ExitCommand = new RelayCommand((o) =>
            {
                Application.Current.MainWindow.Close();
            });
        }
    }
}
