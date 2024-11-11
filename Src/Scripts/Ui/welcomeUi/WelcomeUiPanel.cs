using DsUi;
using Game.Scripts.Classes;
using Game.Scripts.Data;
using Game.Scripts.Ui.ProjectItem;
using NativeFileDialogSharp;

namespace Game.Scripts.Ui.WelcomeUi;

public partial class WelcomeUiPanel : WelcomeUi
{
    public override void OnCreateUi()
    {
        S_NewProjectBtn.Instance.Pressed += () =>
        {
            AddChild(new NewProjectProcessor());
        };

        S_LoadProjectBtn.Instance.Pressed += () =>
        {
            var result = Dialog.FileOpen("rainstorm");
            if (!result.IsOk)
            {
                Logger.LogError($"[File pick ERROR]: {result.ErrorMessage}");
                return;
            }

            EventBus.EnterProject(Project.FromTomlFile(result.Path));
        };

        S_ExitBtn.Instance.Pressed += () =>
        {
            GetTree().Quit();
        };

        EventBus.RecentProjectsChanged += projects =>
        {
            foreach (var child in S_RecentProjects.Instance.GetChildren())
            {
                if (child is not ProjectItemPanel panel) continue;
                panel.Destroy();
            }
            
            foreach (var projectItem in projects)
            {
                S_RecentProjects
                    .OpenNestedUi<ProjectItemPanel>(UiManager.UiName.ProjectItem)
                    .Config(projectItem, path =>
                    {
                        EventBus.EnterProject(Project.FromTomlFile(path));
                    });
            }
        };
    }

    public override void OnDestroyUi()
    {
    }

}
