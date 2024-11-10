using Game.Scripts.Classes;
using Game.Scripts.Data;
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
    }

    public override void OnDestroyUi()
    {
    }

}
