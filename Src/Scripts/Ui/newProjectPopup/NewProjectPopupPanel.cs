using Game.Scripts.Data;
using Godot;
using NativeFileDialogSharp;

namespace Game.Scripts.Ui.NewProjectPopup;

public partial class NewProjectPopupPanel : NewProjectPopup
{
    private DialogResult _result;

    public static NewProjectPopupPanel Create()
    {
        return GD
            .Load<PackedScene>("res://Scenes/Ui/NewProjectPopup.tscn")
            .Instantiate<NewProjectPopupPanel>();
    }

    public override void _Ready()
    {
        base._Ready();
        S_SelectProjectPathBtn.Instance.Pressed += () =>
        {
            _result = Dialog.FolderPicker();
            if (!_result.IsOk) return;
            S_ProjectPathEdit.Instance.SetText(_result.Path);
        };
    }

    public Project GetProject() => new ()
    {
        Name = S_ProjectNameEdit.Instance.Text,
        Path = _result.Path
    };

    public override void OnDestroyUi()
    {
        
    }
}
