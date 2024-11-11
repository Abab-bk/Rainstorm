using Godot;

namespace Game.Scripts.Ui.LabelWithToolTipBtn;

public partial class LabelWithToolTipBtnPanel : LabelWithToolTipBtn
{
    [Export] private string _name = "";
    [Export] private string _toolTip = "";
    
    public override void _Ready()
    {
        base._Ready();
        S_Label.Instance.Text = _name;
    }
}
