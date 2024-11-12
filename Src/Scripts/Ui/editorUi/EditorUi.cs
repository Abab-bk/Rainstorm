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
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer.ScrollContainer.Layers
    /// </summary>
    public class Layers : UiNode<EditorUiPanel, Godot.VBoxContainer, Layers>
    {
        public Layers(EditorUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override Layers Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<EditorUiPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer.Layers
        /// </summary>
        public Layers L_Layers
        {
            get
            {
                if (_L_Layers == null) _L_Layers = new Layers(UiPanel, Instance.GetNode<Godot.VBoxContainer>("Layers"));
                return _L_Layers;
            }
        }
        private Layers _L_Layers;

        public ScrollContainer(EditorUiPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<EditorUiPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.ScrollContainer
        /// </summary>
        public ScrollContainer L_ScrollContainer
        {
            get
            {
                if (_L_ScrollContainer == null) _L_ScrollContainer = new ScrollContainer(UiPanel, Instance.GetNode<Godot.ScrollContainer>("ScrollContainer"));
                return _L_ScrollContainer;
            }
        }
        private ScrollContainer _L_ScrollContainer;

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
    /// 类型: <see cref="Godot.Control"/>, 路径: EditorUi.HSplitContainer.ActiveArea
    /// </summary>
    public class ActiveArea : UiNode<EditorUiPanel, Godot.Control, ActiveArea>
    {
        public ActiveArea(EditorUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override ActiveArea Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorUi.ActiveArea
        /// </summary>
        public ActiveArea L_ActiveArea
        {
            get
            {
                if (_L_ActiveArea == null) _L_ActiveArea = new ActiveArea(UiPanel, Instance.GetNode<Godot.Control>("ActiveArea"));
                return _L_ActiveArea;
            }
        }
        private ActiveArea _L_ActiveArea;

        public HSplitContainer(EditorUiPanel uiPanel, Godot.HSplitContainer node) : base(uiPanel, node) {  }
        public override HSplitContainer Clone() => new (UiPanel, (Godot.HSplitContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer.ScrollContainer.Layers
    /// </summary>
    public Layers S_Layers => L_HSplitContainer.L_VSplitContainer.L_PanelContainer.L_ScrollContainer.L_Layers;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: EditorUi.HSplitContainer.VSplitContainer.PanelContainer.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_HSplitContainer.L_VSplitContainer.L_PanelContainer.L_ScrollContainer;

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
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorUi.HSplitContainer.ActiveArea
    /// </summary>
    public ActiveArea S_ActiveArea => L_HSplitContainer.L_ActiveArea;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: EditorUi.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_HSplitContainer;

}
