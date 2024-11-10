using Game.Scripts.Configs;

namespace Game.Scripts.Ui.Hud;

public partial class HudPanel : Hud
{
    private ProjectWriter _writer;
    
    private enum Page
    {
        Editor,
        Settings
    }
    
    public override void _Ready()
    {
        base._Ready();

        S_UiShellHeader.Instance.SetButtons(
            [
                new ActionWithName("Editor", () => { ChangePage(Page.Editor); }),
                new ActionWithName("Settings", () => { ChangePage(Page.Settings); })
            ]
            );
    }

    public HudPanel Config(ProjectWriter writer)
    {
        _writer = writer;
        S_UiShellHeader.Instance.SetTitle(_writer.Project.Name);
        return this;
    }

    private void ChangePage(Page page)
    {
    }
}
