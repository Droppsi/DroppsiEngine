﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngine.Engine.Commands;
using DroppsiEngine.Engine.Misc;
using DroppsiEngine.Engine.Models;

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
            CreateProjectCommand = new RelayCommand((o) =>
            {
                
                ProjectSettings projectSettings = new()
                {
                    PreviewPicturePath = PreviewPicturePathBind,
                    ProjectDir = ProjectDirBind,
                    ProjectVersion = "0.0.1",
                    Name = ProjectNameBind,
                    Description = ProjectDescriptionBind,
                    LastOpened = DateTime.Now,
                    CreateTime = DateTime.Now
                };
                ProjectFile projectFile = new()
                {
                    ProjectSettings = projectSettings,
                };

                SaveProjectCommand saveProject = new();
                saveProject.Save(projectSettings);
            });

		  ProjectSettings projectSettings = new()
		  {
			 Name = "DefaultName",
			 Description = "New DroppsiEngine Project",
			 PreviewPicturePath = "D:/dev/",
			 ProjectDir = "D:/dev/",
			 ProjectVersion = "0.0.1",
			 CreateTime = DateTime.Now,
			 LastOpened = DateTime.Now,
		  };           
	   }

        public ObservableCollection<string> projectSettingsTest;
    }
}
