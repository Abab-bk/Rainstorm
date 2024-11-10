using System;
using System.IO;
using DsUi;
using Game.Scripts.Configs;
using Game.Scripts.Data;
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
                    NewProject(newProjectPopup.GetProject());
                }
            )
        });
    }

    private void NewProject(Project project)
    {
        var projectFilePath = Path.Combine(project.Path, $"{project.Name}.rainstorm");
        try
        {
            if (!File.Exists(projectFilePath))
            {
                File.Create(projectFilePath).Close();
            }

            var writer = new StreamWriter(projectFilePath);
            writer.Write(project.ToToml());
            writer.Close();
            
            EventBus.EnterProject(Project.FromTomlFile(projectFilePath));
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