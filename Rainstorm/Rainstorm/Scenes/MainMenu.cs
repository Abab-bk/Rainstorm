using Rainstorm.Core;
using Rainstorm.Utils;
using Raylib_CsLo;

namespace Rainstorm.Scenes;

public class MainMenu : Scene
{
    private bool _showNewProjectPopup;
    
    public override void Draw()
    {
        base.Draw();

        if (_showNewProjectPopup)
        {
            var result = RayGui.GuiMessageBox(
                RectangleUtils.GetCenteredRectangle(300f, 200f),
                "New Project",
                "Are you sure you want to create a new project?",
                "Yes;No"
            );
            
            if (result >= 0) _showNewProjectPopup = false;
            if (result > 0)
            {
                
            }
        }

        if (RayGui.GuiButton(
                new Rectangle(100f, 100f, 200f, 100f),
                "New Project"))
        {
            _showNewProjectPopup = true;
        }

        if (RayGui.GuiButton(
                new Rectangle(100f, 200f, 200f, 100f),
                "Load Project"))
        {
        }

        if (RayGui.GuiButton(
                new Rectangle(100f, 300f, 200f, 100f),
                "Settings"))
        {
        }

        if (RayGui.GuiButton(
                new Rectangle(100f, 400f, 200f, 100f),
                "Exit"))
        {
            Program.Exit();
        }
    }
}