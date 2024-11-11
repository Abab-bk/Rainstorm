using System;

namespace Game.Scripts.Ui.SearchBarUi;

public partial class SearchBarUiPanel : SearchBarUi
{
    public event Action<string> OnQueryChanged;
    
    public override void _Ready()
    {
        base._Ready();
        S_LineEdit.Instance.TextChanged += text =>
        {
            OnQueryChanged?.Invoke(text);
        };
    }
}
