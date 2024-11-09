using System;
using Game.Scripts.Classes;
using NativeFileDialogSharp;

namespace Game.Scripts.Ui.NewProjectPopup;

public partial class NewProjectPopupPanel : NewProjectPopup
{
    public event Action<NewProjectInfo> RequestCreateNewProject;
    
    private DialogResult _result;
    
    public override void OnCreateUi()
    {
        S_SelectProjectPathBtn.Instance.Pressed += () =>
        {
            _result = Dialog.FolderPicker();
            if (!_result.IsOk) return;
            S_ProjectPathEdit.Instance.Text = _result.Path;
        };

        S_ConfirmBtn.Instance.Pressed += () =>
        {
            RequestCreateNewProject?.Invoke(
                new NewProjectInfo
                {
                    Name = S_ProjectNameEdit.Instance.Text,
                    Path = _result.Path
                }
            );
        };

        S_CancelBtn.Instance.Pressed += Destroy;
    }

    public override void OnDestroyUi()
    {
        
    }

}
