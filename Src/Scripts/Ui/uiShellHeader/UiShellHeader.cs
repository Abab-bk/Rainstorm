namespace Game.Scripts.Ui.UiShellHeader;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class UiShellHeader : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: UiShellHeader.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((UiShellHeaderPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public UiShellHeader() : base(nameof(UiShellHeader))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.Title
    /// </summary>
    public class Title : UiNode<UiShellHeaderPanel, Godot.Label, Title>
    {
        public Title(UiShellHeaderPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Title Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.ColorRect
    /// </summary>
    public class ColorRect : UiNode<UiShellHeaderPanel, Godot.ColorRect, ColorRect>
    {
        public ColorRect(UiShellHeaderPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.MenuItems
    /// </summary>
    public class MenuItems : UiNode<UiShellHeaderPanel, Godot.HBoxContainer, MenuItems>
    {
        public MenuItems(UiShellHeaderPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override MenuItems Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<UiShellHeaderPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.Title
        /// </summary>
        public Title L_Title
        {
            get
            {
                if (_L_Title == null) _L_Title = new Title(UiPanel, Instance.GetNode<Godot.Label>("Title"));
                return _L_Title;
            }
        }
        private Title _L_Title;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.ColorRect
        /// </summary>
        public ColorRect L_ColorRect
        {
            get
            {
                if (_L_ColorRect == null) _L_ColorRect = new ColorRect(UiPanel, Instance.GetNode<Godot.ColorRect>("ColorRect"));
                return _L_ColorRect;
            }
        }
        private ColorRect _L_ColorRect;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.MenuItems
        /// </summary>
        public MenuItems L_MenuItems
        {
            get
            {
                if (_L_MenuItems == null) _L_MenuItems = new MenuItems(UiPanel, Instance.GetNode<Godot.HBoxContainer>("MenuItems"));
                return _L_MenuItems;
            }
        }
        private MenuItems _L_MenuItems;

        public HBoxContainer(UiShellHeaderPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: UiShellHeader.PanelContainer.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<UiShellHeaderPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: UiShellHeader.PanelContainer.HBoxContainer
        /// </summary>
        public HBoxContainer L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer _L_HBoxContainer;

        public MarginContainer(UiShellHeaderPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: UiShellHeader.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<UiShellHeaderPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: UiShellHeader.MarginContainer
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

        public PanelContainer(UiShellHeaderPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.Title
    /// </summary>
    public Title S_Title => L_PanelContainer.L_MarginContainer.L_HBoxContainer.L_Title;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_PanelContainer.L_MarginContainer.L_HBoxContainer.L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer.MenuItems
    /// </summary>
    public MenuItems S_MenuItems => L_PanelContainer.L_MarginContainer.L_HBoxContainer.L_MenuItems;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_PanelContainer.L_MarginContainer.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: UiShellHeader.PanelContainer.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_PanelContainer.L_MarginContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: UiShellHeader.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
