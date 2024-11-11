using Game.Scripts.Configs;

namespace Game.Scripts.Ui.Hud;

public partial class HudPanel : Hud
{
    private ProjectWriter _writer;
    
    private enum Page
    {
        Editor,
        Settings,
        Graphs,
    }
    
    public override void _Ready()
    {
        base._Ready();

        S_UiShellHeader.Instance.SetButtons(
            [
                new ActionWithName("Editor", () => { ChangePage(Page.Editor); }),
                new ActionWithName("Settings", () => { ChangePage(Page.Settings); }),
                new ActionWithName("Graphs", () => { ChangePage(Page.Graphs); })
            ]
            );
        
        ChangePage(Page.Editor);
    }

    public HudPanel Config(ProjectWriter writer)
    {
        _writer = writer;
        S_UiShellHeader.Instance.SetTitle(_writer.Project.Name);
        return this;
    }

    private void ChangePage(Page page)
    {
        S_Pages.Instance.CurrentTab = (int)page;
    }
}
