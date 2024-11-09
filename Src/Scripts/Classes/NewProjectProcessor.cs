using System;
using System.IO;
using DsUi;
using Game.Scripts.Ui.NewProjectPopup;
using Godot;

namespace Game.Scripts.Classes;

public partial class NewProjectProcessor : Node
{
    private NewProjectPopupPanel _popupPanel;
    
    public override void _Ready()
    {
        _popupPanel = UiManager.Open_NewProjectPopup();
        _popupPanel.OnDestroyUiEvent += Destroy;
        _popupPanel.RequestCreateNewProject += NewProject;
    }

    private void NewProject(NewProjectInfo newProjectInfo)
    {
        var projectFilePath = Path.Combine(newProjectInfo.Path, "Project.toml");
        try
        {
            if (!File.Exists(projectFilePath))
            {
                File.Create(projectFilePath).Close();
            }

            var writer = new StreamWriter(projectFilePath);
            writer.Write($"""
                          [ProjectInfo]
                          name = {newProjectInfo.Name}
                          """);
            writer.Close();
            
            _popupPanel.Destroy();
        }
        catch (Exception e)
        {
            Logger.Log($"[Error]: {e}");
            throw;
        }
    }

    private void Destroy()
    {
    }
}