using Godot;

namespace Game.Scripts.Ui.ImageCutterUi;

public partial class ImageCutterUiPanel : ImageCutterUi
{
    public override void _Ready()
    {
        // TODO: For test, delete later
        S_Sprite2D.Instance.Texture = ImageTexture
            .CreateFromImage(
                Image
                    .LoadFromFile("D:\\Dev\\Test\\DungeonGate.png")
                );
        
        S_AutoSliceBtn.Instance.Pressed += () =>
        {
            
        };
    }
}
