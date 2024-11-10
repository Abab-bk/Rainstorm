using System;
using System.IO;
using DsUi;
using Game.Scripts.Configs;
using Game.Scripts.Ui.Modal;
using Game.Scripts.Ui.NewProjectPopup;
using Godot;

namespace Game.Scripts.Classes;

public partial class NewProjectProcessor : Node
{
    private ModalPanel _modal;
    
    public override void _Ready()
    {
        var newProjectPopup = NewProjectPopupPanel.Create();
        _modal = UiManager.Open_Modal().Config(new ModalConfig("New Project")
        {
            Slot = newProjectPopup,
            Action1 = new ActionWithName(
                "Confirm",
                () =>
                {
                    NewProject(newProjectPopup.GetProjectInfo());
                }
            )
        });
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