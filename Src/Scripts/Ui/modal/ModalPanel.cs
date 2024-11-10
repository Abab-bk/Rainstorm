using Game.Scripts.Configs;

namespace Game.Scripts.Ui.Modal;

public partial class ModalPanel : Modal
{
    public ModalPanel Config(ModalConfig config)
    {
        S_Action2Btn.Instance.Hide();
        S_Action3Btn.Instance.Hide();
        S_OptionalLabel.Instance.Hide();
        S_ContentText.Instance.Hide();
        
        S_TitleLabel.Instance.Text = config.Title;

        S_CancelBtn.Instance.Pressed += () =>
        {
            if (config.CancelAction != null)
                config.CancelAction.Action();
            Destroy();
        };

        S_Action1Btn.Instance.Pressed += () =>
        {
            if (config.Action1 != null)
                config.Action1.Action();
            Destroy();
        };

        if (config.OptionLabel != "")
        {
            S_OptionalLabel.Instance.Show();
            S_OptionalLabel.Instance.Text = config.OptionLabel;
        }

        if (config.Action1 != null)
            S_Action1Btn.Instance.Text = config.Action1.Name;
        
        if (config.CancelAction != null)
            S_CancelBtn.Instance.Text = config.CancelAction.Name;
        
        if (config.Content != null)
        {
            S_ContentText.Instance.Show();
            S_ContentText.Instance.Text = config.Content;
        }
        
        if (config.Slot != null)
        {
            S_Content.Instance.AddChild(config.Slot);
        }

        if (config.Action2 != null)
        {
            S_Action2Btn.Instance.Show();
            S_Action2Btn.Instance.Pressed += config.Action2.Action;
            S_Action2Btn.Instance.Text = config.Action2.Name;
        }

        if (config.Action3 != null)
        {
            S_Action3Btn.Instance.Show();
            S_Action3Btn.Instance.Pressed += config.Action3.Action;
            S_Action3Btn.Instance.Text = config.Action3.Name;
        }

        return this;
    }


    public override void OnCreateUi()
    {
        S_CloseBtn.Instance.Pressed += Destroy;
    }

    public override void OnDestroyUi()
    {
        
    }

}
