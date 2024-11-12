using Game.Scripts.Configs;
using Game.Scripts.Data;

namespace Game.Scripts.Ui.Hud;

public partial class HudPanel : Hud
{
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
        
        S_UiShellHeader.Instance.SetTitle(Global.ProjectWriter.Project.Name);
        
        ChangePage(Page.Editor);
    }

    private void ChangePage(Page page)
    {
        S_Pages.Instance.CurrentTab = (int)page;
    }
}
