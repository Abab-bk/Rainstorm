namespace Game.Scripts.Ui.NewProjectPopup;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class NewProjectPopup : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: NewProjectPopup.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((NewProjectPopupPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public NewProjectPopup() : base(nameof(NewProjectPopup))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.ProjectNameEdit
    /// </summary>
    public class ProjectNameEdit : UiNode<NewProjectPopupPanel, Godot.LineEdit, ProjectNameEdit>
    {
        public ProjectNameEdit(NewProjectPopupPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override ProjectNameEdit Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2.ProjectPathEdit
    /// </summary>
    public class ProjectPathEdit : UiNode<NewProjectPopupPanel, Godot.LineEdit, ProjectPathEdit>
    {
        public ProjectPathEdit(NewProjectPopupPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override ProjectPathEdit Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2.SelectProjectPathBtn
    /// </summary>
    public class SelectProjectPathBtn : UiNode<NewProjectPopupPanel, Godot.Button, SelectProjectPathBtn>
    {
        public SelectProjectPathBtn(NewProjectPopupPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override SelectProjectPathBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<NewProjectPopupPanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.ProjectPathEdit
        /// </summary>
        public ProjectPathEdit L_ProjectPathEdit
        {
            get
            {
                if (_L_ProjectPathEdit == null) _L_ProjectPathEdit = new ProjectPathEdit(UiPanel, Instance.GetNode<Godot.LineEdit>("ProjectPathEdit"));
                return _L_ProjectPathEdit;
            }
        }
        private ProjectPathEdit _L_ProjectPathEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.SelectProjectPathBtn
        /// </summary>
        public SelectProjectPathBtn L_SelectProjectPathBtn
        {
            get
            {
                if (_L_SelectProjectPathBtn == null) _L_SelectProjectPathBtn = new SelectProjectPathBtn(UiPanel, Instance.GetNode<Godot.Button>("SelectProjectPathBtn"));
                return _L_SelectProjectPathBtn;
            }
        }
        private SelectProjectPathBtn _L_SelectProjectPathBtn;

        public HBoxContainer2(NewProjectPopupPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content
    /// </summary>
    public class Content : UiNode<NewProjectPopupPanel, Godot.VBoxContainer, Content>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ProjectNameEdit
        /// </summary>
        public ProjectNameEdit L_ProjectNameEdit
        {
            get
            {
                if (_L_ProjectNameEdit == null) _L_ProjectNameEdit = new ProjectNameEdit(UiPanel, Instance.GetNode<Godot.LineEdit>("ProjectNameEdit"));
                return _L_ProjectNameEdit;
            }
        }
        private ProjectNameEdit _L_ProjectNameEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.HBoxContainer2
        /// </summary>
        public HBoxContainer2 L_HBoxContainer2
        {
            get
            {
                if (_L_HBoxContainer2 == null) _L_HBoxContainer2 = new HBoxContainer2(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer2"));
                return _L_HBoxContainer2;
            }
        }
        private HBoxContainer2 _L_HBoxContainer2;

        public Content(NewProjectPopupPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override Content Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons.ConfirmBtn
    /// </summary>
    public class ConfirmBtn : UiNode<NewProjectPopupPanel, Godot.Button, ConfirmBtn>
    {
        public ConfirmBtn(NewProjectPopupPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override ConfirmBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons.CancelBtn
    /// </summary>
    public class CancelBtn : UiNode<NewProjectPopupPanel, Godot.Button, CancelBtn>
    {
        public CancelBtn(NewProjectPopupPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override CancelBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons
    /// </summary>
    public class ActionButtons : UiNode<NewProjectPopupPanel, Godot.HBoxContainer, ActionButtons>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ConfirmBtn
        /// </summary>
        public ConfirmBtn L_ConfirmBtn
        {
            get
            {
                if (_L_ConfirmBtn == null) _L_ConfirmBtn = new ConfirmBtn(UiPanel, Instance.GetNode<Godot.Button>("ConfirmBtn"));
                return _L_ConfirmBtn;
            }
        }
        private ConfirmBtn _L_ConfirmBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.CancelBtn
        /// </summary>
        public CancelBtn L_CancelBtn
        {
            get
            {
                if (_L_CancelBtn == null) _L_CancelBtn = new CancelBtn(UiPanel, Instance.GetNode<Godot.Button>("CancelBtn"));
                return _L_CancelBtn;
            }
        }
        private CancelBtn _L_CancelBtn;

        public ActionButtons(NewProjectPopupPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override ActionButtons Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<NewProjectPopupPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.Content
        /// </summary>
        public Content L_Content
        {
            get
            {
                if (_L_Content == null) _L_Content = new Content(UiPanel, Instance.GetNode<Godot.VBoxContainer>("Content"));
                return _L_Content;
            }
        }
        private Content _L_Content;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.ActionButtons
        /// </summary>
        public ActionButtons L_ActionButtons
        {
            get
            {
                if (_L_ActionButtons == null) _L_ActionButtons = new ActionButtons(UiPanel, Instance.GetNode<Godot.HBoxContainer>("ActionButtons"));
                return _L_ActionButtons;
            }
        }
        private ActionButtons _L_ActionButtons;

        public VBoxContainer(NewProjectPopupPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: NewProjectPopup.PanelContainer.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<NewProjectPopupPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        public MarginContainer(NewProjectPopupPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: NewProjectPopup.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<NewProjectPopupPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: NewProjectPopup.MarginContainer
        /// </summary>
        public MarginContainer L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer _L_MarginContainer;

        public PanelContainer(NewProjectPopupPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.ProjectNameEdit
    /// </summary>
    public ProjectNameEdit S_ProjectNameEdit => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Content.L_ProjectNameEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2.ProjectPathEdit
    /// </summary>
    public ProjectPathEdit S_ProjectPathEdit => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Content.L_HBoxContainer2.L_ProjectPathEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2.SelectProjectPathBtn
    /// </summary>
    public SelectProjectPathBtn S_SelectProjectPathBtn => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Content.L_HBoxContainer2.L_SelectProjectPathBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content.HBoxContainer2
    /// </summary>
    public HBoxContainer2 S_HBoxContainer2 => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Content.L_HBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.Content
    /// </summary>
    public Content S_Content => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Content;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons.ConfirmBtn
    /// </summary>
    public ConfirmBtn S_ConfirmBtn => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_ActionButtons.L_ConfirmBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons.CancelBtn
    /// </summary>
    public CancelBtn S_CancelBtn => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_ActionButtons.L_CancelBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer.ActionButtons
    /// </summary>
    public ActionButtons S_ActionButtons => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_ActionButtons;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_MarginContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: NewProjectPopup.PanelContainer.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_PanelContainer.L_MarginContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: NewProjectPopup.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
