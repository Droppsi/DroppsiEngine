using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DroppsiEngine.Engine.Commands;
using DroppsiEngine.Engine.Misc;
using DroppsiEngine.Engine.Models;
using DroppsiEngine.MVVM.Views;

namespace DroppsiEngine.MVVM.ViewModels
{
    public class NewProjectViewModel : ObservableObject
    {
        public RelayCommand CreateProjectCommand { get; set; }

        public string ProjectNameViewBind {
            get 
            {
                return ProjectNameBind;
            }
            set
            {
                ProjectNameBind = value;
                this.OnPropertyChanged("ProjectNameViewBind");
            }
        }
        public string ProjectDescriptionViewBind
        {
            get
            {
                return ProjectDescriptionBind;
            }
            set
            {
                ProjectDescriptionBind = value;
                this.OnPropertyChanged("ProjectDescriptionViewBind");
            }
        }
        public string PreviewPicturePathViewBind
        {
            get
            {
                return PreviewPicturePathBind;
            }
            set
            {
                PreviewPicturePathBind = value;
                this.OnPropertyChanged("ProjectNameViewBind");
            }
        }
        public string ProjectDirViewBind
        {
            get
            {
                return ProjectDirBind;
            }
            set
            {
                ProjectDirBind = value;
                this.OnPropertyChanged("ProjectNameViewBind");
            }
        }

        private string ProjectNameBind;
        private string ProjectDescriptionBind;
        private string PreviewPicturePathBind;
        private string ProjectDirBind;

        public NewProjectViewModel()
        {
            
            ProjectSettings projectSettings = new()
            {
                Name = "DefaultName",
                Description = "New DroppsiEngine Project",
                PreviewPicturePath = "D:/dev/TESTS/",
                ProjectDir = "D:/dev/TESTS/",
                ProjectVersion = "0.0.1",
                CreateTime = DateTime.Now,
                LastOpened = DateTime.Now,
            };
            
            ProjectNameViewBind = projectSettings.Name;
            ProjectDescriptionViewBind = projectSettings.Description;
            ProjectDirViewBind = projectSettings.ProjectDir;

            CreateProjectCommand = new RelayCommand((o) =>
            {
                projectSettings.Name = ProjectNameBind;
                projectSettings.Description = ProjectDescriptionBind;
                projectSettings.ProjectDir = ProjectDirBind;

                SaveProjectCommand saveProject = new();
                saveProject.Save(projectSettings);
                EditorWindow editor = new();
                editor.Show();
                
            });
        }
    }
}
