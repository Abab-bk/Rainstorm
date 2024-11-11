namespace Game.Scripts.Ui.EditorUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class EditorUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: EditorUi.HSplitContainer
    /// </summary>
    public HSplitContainer L_HSplitContainer
    {
        get
        {
            if (_L_HSplitContainer == null) _L_HSplitContainer = new HSplitContainer((EditorUiPanel)this, GetNode<Godot.HSplitContainer>("HSplitContainer"));
            return _L_HSplitContainer;
        }
    }
    private HSplitContainer _L_HSplitContainer;


    public EditorUi() : base(nameof(EditorUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<EditorUiPanel, Godot.PanelContainer, PanelContainer>
    {
        public PanelContainer(EditorUiPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer2
    /// </summary>
    public class PanelContainer2 : UiNode<EditorUiPanel, Godot.PanelContainer, PanelContainer2>
    {
        public PanelContainer2(EditorUiPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer2 Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VSplitContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer
    /// </summary>
    public class VSplitContainer : UiNode<EditorUiPanel, Godot.VSplitContainer, VSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: EditorUi.HSplitContainer.PanelContainer
        /// </summary>
        public PanelContainer L_PanelContainer
        {
            get
            {
                if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer(UiPanel, Instance.GetNode<Godot.PanelContainer>("PanelContainer"));
                return _L_PanelContainer;
            }
        }
        private PanelContainer _L_PanelContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: EditorUi.HSplitContainer.PanelContainer2
        /// </summary>
        public PanelContainer2 L_PanelContainer2
        {
            get
            {
                if (_L_PanelContainer2 == null) _L_PanelContainer2 = new PanelContainer2(UiPanel, Instance.GetNode<Godot.PanelContainer>("PanelContainer2"));
                return _L_PanelContainer2;
            }
        }
        private PanelContainer2 _L_PanelContainer2;

        public VSplitContainer(EditorUiPanel uiPanel, Godot.VSplitContainer node) : base(uiPanel, node) {  }
        public override VSplitContainer Clone() => new (UiPanel, (Godot.VSplitContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: EditorUi.HSplitContainer.Control
    /// </summary>
    public class Control : UiNode<EditorUiPanel, Godot.Control, Control>
    {
        public Control(EditorUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HSplitContainer"/>, 路径: EditorUi.HSplitContainer
    /// </summary>
    public class HSplitContainer : UiNode<EditorUiPanel, Godot.HSplitContainer, HSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: EditorUi.VSplitContainer
        /// </summary>
        public VSplitContainer L_VSplitContainer
        {
            get
            {
                if (_L_VSplitContainer == null) _L_VSplitContainer = new VSplitContainer(UiPanel, Instance.GetNode<Godot.VSplitContainer>("VSplitContainer"));
                return _L_VSplitContainer;
            }
        }
        private VSplitContainer _L_VSplitContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorUi.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        public HSplitContainer(EditorUiPanel uiPanel, Godot.HSplitContainer node) : base(uiPanel, node) {  }
        public override HSplitContainer Clone() => new (UiPanel, (Godot.HSplitContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_HSplitContainer.L_VSplitContainer.L_PanelContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer2
    /// </summary>
    public PanelContainer2 S_PanelContainer2 => L_HSplitContainer.L_VSplitContainer.L_PanelContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer
    /// </summary>
    public VSplitContainer S_VSplitContainer => L_HSplitContainer.L_VSplitContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorUi.HSplitContainer.Control
    /// </summary>
    public Control S_Control => L_HSplitContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: EditorUi.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_HSplitContainer;

}
