namespace Game.Scripts.Ui.NewProjectPopup;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class NewProjectPopup : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.Content
    /// </summary>
    public Content L_Content
    {
        get
        {
            if (_L_Content == null) _L_Content = new Content((NewProjectPopupPanel)this, GetNode<Godot.VBoxContainer>("Content"));
            return _L_Content;
        }
    }
    private Content _L_Content;


    public NewProjectPopup() : base(nameof(NewProjectPopup))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_Content;
        RecordNestedUi(inst1.L_ProjectNameEdit.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_ProjectNameEdit.Instance.OnCreateUi();
        inst1.L_ProjectNameEdit.Instance.OnInitNestedUi();

        var inst2 = L_Content.L_HBoxContainer2;
        RecordNestedUi(inst2.L_ProjectPathEdit.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_ProjectPathEdit.Instance.OnCreateUi();
        inst2.L_ProjectPathEdit.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 路径: NewProjectPopup.Content.ProjectNameEdit
    /// </summary>
    public class ProjectNameEdit : UiNode<NewProjectPopupPanel, Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel, ProjectNameEdit>
    {
        public ProjectNameEdit(NewProjectPopupPanel uiPanel, Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel node) : base(uiPanel, node) {  }
        public override ProjectNameEdit Clone()
        {
            var uiNode = new ProjectNameEdit(UiPanel, (Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 路径: NewProjectPopup.Content.HBoxContainer2.ProjectPathEdit
    /// </summary>
    public class ProjectPathEdit : UiNode<NewProjectPopupPanel, Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel, ProjectPathEdit>
    {
        public ProjectPathEdit(NewProjectPopupPanel uiPanel, Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel node) : base(uiPanel, node) {  }
        public override ProjectPathEdit Clone()
        {
            var uiNode = new ProjectPathEdit(UiPanel, (Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: NewProjectPopup.Content.HBoxContainer2.SelectProjectPathBtn
    /// </summary>
    public class SelectProjectPathBtn : UiNode<NewProjectPopupPanel, Godot.Button, SelectProjectPathBtn>
    {
        public SelectProjectPathBtn(NewProjectPopupPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override SelectProjectPathBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: NewProjectPopup.Content.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<NewProjectPopupPanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 节点路径: NewProjectPopup.Content.ProjectPathEdit
        /// </summary>
        public ProjectPathEdit L_ProjectPathEdit
        {
            get
            {
                if (_L_ProjectPathEdit == null) _L_ProjectPathEdit = new ProjectPathEdit(UiPanel, Instance.GetNode<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>("ProjectPathEdit"));
                return _L_ProjectPathEdit;
            }
        }
        private ProjectPathEdit _L_ProjectPathEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.Content.SelectProjectPathBtn
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
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: NewProjectPopup.Content
    /// </summary>
    public class Content : UiNode<NewProjectPopupPanel, Godot.VBoxContainer, Content>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 节点路径: NewProjectPopup.ProjectNameEdit
        /// </summary>
        public ProjectNameEdit L_ProjectNameEdit
        {
            get
            {
                if (_L_ProjectNameEdit == null) _L_ProjectNameEdit = new ProjectNameEdit(UiPanel, Instance.GetNode<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>("ProjectNameEdit"));
                return _L_ProjectNameEdit;
            }
        }
        private ProjectNameEdit _L_ProjectNameEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.HBoxContainer2
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
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 节点路径: NewProjectPopup.Content.ProjectNameEdit
    /// </summary>
    public ProjectNameEdit S_ProjectNameEdit => L_Content.L_ProjectNameEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel"/>, 节点路径: NewProjectPopup.Content.HBoxContainer2.ProjectPathEdit
    /// </summary>
    public ProjectPathEdit S_ProjectPathEdit => L_Content.L_HBoxContainer2.L_ProjectPathEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: NewProjectPopup.Content.HBoxContainer2.SelectProjectPathBtn
    /// </summary>
    public SelectProjectPathBtn S_SelectProjectPathBtn => L_Content.L_HBoxContainer2.L_SelectProjectPathBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: NewProjectPopup.Content.HBoxContainer2
    /// </summary>
    public HBoxContainer2 S_HBoxContainer2 => L_Content.L_HBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: NewProjectPopup.Content
    /// </summary>
    public Content S_Content => L_Content;

}
