using Godot;

namespace Game.Scripts.Ui.TextInputFluid;

public partial class TextInputFluidPanel : TextInputFluid
{
    public bool ReadOnly => _readOnly;
    public string Text => S_LineEdit.Instance.Text;
    
    [Export] private bool _readOnly;
    [Export] private string _label = "";
    [Export] private string _placeholderText = "";
    [Export] private bool _hideLabel;

    public void SetReadOnly(bool readOnly)
    {
        _readOnly = readOnly;
        UpdateUi();
    }
    
    public void SetText(string text)
    {
        S_LineEdit.Instance.Text = text;
        UpdateUi();
    }

    public override void OnCreateUi()
    {
        UpdateUi();
    }

    private void UpdateUi()
    {
        S_LineEdit.Instance.Editable = !_readOnly;
        S_LineEdit.Instance.PlaceholderText = _placeholderText;
        S_Label.Instance.Text = _label;
        S_Label.Instance.Visible = !_hideLabel;
    }

    public override void _Ready()
    {
        base._Ready();
        UpdateUi();
    }
}
