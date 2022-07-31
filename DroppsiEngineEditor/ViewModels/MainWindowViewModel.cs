using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DroppsiEngineCore.Commands;
using DroppsiEngineCore.Models;

namespace DroppsiEngineEditor.ViewModels
{
    public class MainWindowViewModel
    {
	   public RelayCommand OpenProjectCommand { get; set; }
	   public RelayCommand CloseProjectCommand { get; set; }
	   public TreeView ObjectExplorer { get; set; }
	   public MainWindowViewModel()
	   {
		  ObjectExplorer = new TreeView();
		  TreeViewItem item = new()
		  {
			 Header = "Project",
		  };
		  item.Items.Add(new TreeViewItem() { Header = "Camera" });
		  item.Items.Add(new TreeViewItem() { Header = "Objects" });
		  item.Items.Add(new TreeViewItem() { Header = "Lights" });
		  
		  ObjectExplorer.Items.Add(item);
		  
		  OpenProjectCommand = new RelayCommand(() =>
		  {
			 OpenFileDialog openFileDialog = new()
			 {
				Multiselect = false,
				CheckPathExists = true,
				DefaultExt = ".droppsiproject",
				FileName = "Project",
				Filter = "DroppsiEngine Projects (.droppsiproject)|*.droppsiproject",				
			 };
			 if (openFileDialog.ShowDialog() == true)
			 {
				string fileName = File.ReadAllText(openFileDialog.FileName);
				LoadProjectCommand loadProject = new();
				ProjectFile projectFile = loadProject.Load(fileName);
				foreach (var x in projectFile.ProjectEntities)
				{
				    // TODO:
				    // add functionality to add all objects and neasted objects from <ProjectFile> to TreeView and TreeViewItem objects as childItems 
				}
			 }
		  });

		  CloseProjectCommand = new RelayCommand(() =>
		  {
			 // TODO:
			 // add functionality to close projects (saving it) and return to a default view
		  });
	   }
    }
}
