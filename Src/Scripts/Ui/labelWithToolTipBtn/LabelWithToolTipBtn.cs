namespace Game.Scripts.Ui.LabelWithToolTipBtn;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class LabelWithToolTipBtn : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: LabelWithToolTipBtn.HBoxContainer
    /// </summary>
    public HBoxContainer L_HBoxContainer
    {
        get
        {
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer((LabelWithToolTipBtnPanel)this, GetNode<Godot.HBoxContainer>("HBoxContainer"));
            return _L_HBoxContainer;
        }
    }
    private HBoxContainer _L_HBoxContainer;


    public LabelWithToolTipBtn() : base(nameof(LabelWithToolTipBtn))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: LabelWithToolTipBtn.HBoxContainer.Label
    /// </summary>
    public class Label : UiNode<LabelWithToolTipBtnPanel, Godot.Label, Label>
    {
        public Label(LabelWithToolTipBtnPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: LabelWithToolTipBtn.HBoxContainer.ToolTipIcon
    /// </summary>
    public class ToolTipIcon : UiNode<LabelWithToolTipBtnPanel, Godot.TextureRect, ToolTipIcon>
    {
        public ToolTipIcon(LabelWithToolTipBtnPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override ToolTipIcon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: LabelWithToolTipBtn.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<LabelWithToolTipBtnPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: LabelWithToolTipBtn.Label
        /// </summary>
        public Label L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: LabelWithToolTipBtn.ToolTipIcon
        /// </summary>
        public ToolTipIcon L_ToolTipIcon
        {
            get
            {
                if (_L_ToolTipIcon == null) _L_ToolTipIcon = new ToolTipIcon(UiPanel, Instance.GetNode<Godot.TextureRect>("ToolTipIcon"));
                return _L_ToolTipIcon;
            }
        }
        private ToolTipIcon _L_ToolTipIcon;

        public HBoxContainer(LabelWithToolTipBtnPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: LabelWithToolTipBtn.HBoxContainer.Label
    /// </summary>
    public Label S_Label => L_HBoxContainer.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: LabelWithToolTipBtn.HBoxContainer.ToolTipIcon
    /// </summary>
    public ToolTipIcon S_ToolTipIcon => L_HBoxContainer.L_ToolTipIcon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: LabelWithToolTipBtn.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_HBoxContainer;

}
