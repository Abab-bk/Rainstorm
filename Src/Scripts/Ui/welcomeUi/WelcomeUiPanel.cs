using Game.Scripts.Classes;

namespace Game.Scripts.Ui.WelcomeUi;

public partial class WelcomeUiPanel : WelcomeUi
{

    public override void OnCreateUi()
    {
        S_NewProjectBtn.Instance.Pressed += () =>
        {
            AddChild(new NewProjectProcessor());
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
