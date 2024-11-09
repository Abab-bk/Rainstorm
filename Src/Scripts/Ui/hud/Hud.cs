namespace Game.Scripts.Ui.Hud;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Hud : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: Hud.VSplitContainer
    /// </summary>
    public VSplitContainer L_VSplitContainer
    {
        get
        {
            if (_L_VSplitContainer == null) _L_VSplitContainer = new VSplitContainer((HudPanel)this, GetNode<Godot.VSplitContainer>("VSplitContainer"));
            return _L_VSplitContainer;
        }
    }
    private VSplitContainer _L_VSplitContainer;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Hud.VBoxContainer
    /// </summary>
    public VBoxContainer L_VBoxContainer
    {
        get
        {
            if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer((HudPanel)this, GetNode<Godot.VBoxContainer>("VBoxContainer"));
            return _L_VBoxContainer;
        }
    }
    private VBoxContainer _L_VBoxContainer;


    public Hud() : base(nameof(Hud))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Hud.VSplitContainer.Layers
    /// </summary>
    public class Layers : UiNode<HudPanel, Godot.PanelContainer, Layers>
    {
        public Layers(HudPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override Layers Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Hud.VSplitContainer.Entities
    /// </summary>
    public class Entities : UiNode<HudPanel, Godot.PanelContainer, Entities>
    {
        public Entities(HudPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override Entities Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VSplitContainer"/>, 路径: Hud.VSplitContainer
    /// </summary>
    public class VSplitContainer : UiNode<HudPanel, Godot.VSplitContainer, VSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.Layers
        /// </summary>
        public Layers L_Layers
        {
            get
            {
                if (_L_Layers == null) _L_Layers = new Layers(UiPanel, Instance.GetNode<Godot.PanelContainer>("Layers"));
                return _L_Layers;
            }
        }
        private Layers _L_Layers;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.Entities
        /// </summary>
        public Entities L_Entities
        {
            get
            {
                if (_L_Entities == null) _L_Entities = new Entities(UiPanel, Instance.GetNode<Godot.PanelContainer>("Entities"));
                return _L_Entities;
            }
        }
        private Entities _L_Entities;

        public VSplitContainer(HudPanel uiPanel, Godot.VSplitContainer node) : base(uiPanel, node) {  }
        public override VSplitContainer Clone() => new (UiPanel, (Godot.VSplitContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Hud.VBoxContainer.Topbar
    /// </summary>
    public class Topbar : UiNode<HudPanel, Godot.PanelContainer, Topbar>
    {
        public Topbar(HudPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override Topbar Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: Hud.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<HudPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.Topbar
        /// </summary>
        public Topbar L_Topbar
        {
            get
            {
                if (_L_Topbar == null) _L_Topbar = new Topbar(UiPanel, Instance.GetNode<Godot.PanelContainer>("Topbar"));
                return _L_Topbar;
            }
        }
        private Topbar _L_Topbar;

        public VBoxContainer(HudPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VSplitContainer.Layers
    /// </summary>
    public Layers S_Layers => L_VSplitContainer.L_Layers;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VSplitContainer.Entities
    /// </summary>
    public Entities S_Entities => L_VSplitContainer.L_Entities;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: Hud.VSplitContainer
    /// </summary>
    public VSplitContainer S_VSplitContainer => L_VSplitContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VBoxContainer.Topbar
    /// </summary>
    public Topbar S_Topbar => L_VBoxContainer.L_Topbar;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Hud.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_VBoxContainer;

}
