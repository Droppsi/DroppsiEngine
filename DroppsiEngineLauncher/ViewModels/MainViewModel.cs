using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DroppsiEngineCore.Commands;
using DroppsiEngineCore.Misc;
using DroppsiEngineCore.Infrastructure.Logging;

namespace DroppsiEngineLauncher.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand DefaultMainVMCommand { get; set; }
        public RelayCommand NewProjectVMCommand { get; set; }

        public NewProjectViewModel NewProjectVM { get; set; }
        public DefaultMainViewModel DefaultMainVM { get; set; }

        private object? _currentView;
        public object? CurrentView
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

            NewProjectVMCommand = new RelayCommand(() =>
            {
			 CurrentView = NewProjectVM;
            });
            DefaultMainVMCommand = new RelayCommand(() =>
            {
                CurrentView = DefaultMainVMCommand;
            });
            ExitCommand = new RelayCommand(() =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}
