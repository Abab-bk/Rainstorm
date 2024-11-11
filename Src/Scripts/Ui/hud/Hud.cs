namespace Game.Scripts.Ui.Hud;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Hud : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Hud.ColorRect
    /// </summary>
    public ColorRect L_ColorRect
    {
        get
        {
            if (_L_ColorRect == null) _L_ColorRect = new ColorRect((HudPanel)this, GetNode<Godot.ColorRect>("ColorRect"));
            return _L_ColorRect;
        }
    }
    private ColorRect _L_ColorRect;

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

        var inst1 = L_VBoxContainer;
        RecordNestedUi(inst1.L_UiShellHeader.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_UiShellHeader.Instance.OnCreateUi();
        inst1.L_UiShellHeader.Instance.OnInitNestedUi();

        var inst2 = L_VBoxContainer.L_Pages;
        RecordNestedUi(inst2.L_EditorUi.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_EditorUi.Instance.OnCreateUi();
        inst2.L_EditorUi.Instance.OnInitNestedUi();

        var inst3 = L_VBoxContainer.L_Pages;
        RecordNestedUi(inst3.L_SettingsUi.Instance, inst3, UiManager.RecordType.Open);
        inst3.L_SettingsUi.Instance.OnCreateUi();
        inst3.L_SettingsUi.Instance.OnInitNestedUi();

        var inst4 = L_VBoxContainer.L_Pages;
        RecordNestedUi(inst4.L_GraphsUi.Instance, inst4, UiManager.RecordType.Open);
        inst4.L_GraphsUi.Instance.OnCreateUi();
        inst4.L_GraphsUi.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Hud.ColorRect
    /// </summary>
    public class ColorRect : UiNode<HudPanel, Godot.ColorRect, ColorRect>
    {
        public ColorRect(HudPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 路径: Hud.VBoxContainer.UiShellHeader
    /// </summary>
    public class UiShellHeader : UiNode<HudPanel, Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel, UiShellHeader>
    {
        public UiShellHeader(HudPanel uiPanel, Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel node) : base(uiPanel, node) {  }
        public override UiShellHeader Clone()
        {
            var uiNode = new UiShellHeader(UiPanel, (Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Hud.VBoxContainer.ColorRect
    /// </summary>
    public class ColorRect_1 : UiNode<HudPanel, Godot.ColorRect, ColorRect_1>
    {
        public ColorRect_1(HudPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect_1 Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.EditorUi.EditorUiPanel"/>, 路径: Hud.VBoxContainer.Pages.EditorUi
    /// </summary>
    public class EditorUi : UiNode<HudPanel, Game.Scripts.Ui.EditorUi.EditorUiPanel, EditorUi>
    {
        public EditorUi(HudPanel uiPanel, Game.Scripts.Ui.EditorUi.EditorUiPanel node) : base(uiPanel, node) {  }
        public override EditorUi Clone()
        {
            var uiNode = new EditorUi(UiPanel, (Game.Scripts.Ui.EditorUi.EditorUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.SettingsUi.SettingsUiPanel"/>, 路径: Hud.VBoxContainer.Pages.SettingsUi
    /// </summary>
    public class SettingsUi : UiNode<HudPanel, Game.Scripts.Ui.SettingsUi.SettingsUiPanel, SettingsUi>
    {
        public SettingsUi(HudPanel uiPanel, Game.Scripts.Ui.SettingsUi.SettingsUiPanel node) : base(uiPanel, node) {  }
        public override SettingsUi Clone()
        {
            var uiNode = new SettingsUi(UiPanel, (Game.Scripts.Ui.SettingsUi.SettingsUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.GraphsUi.GraphsUiPanel"/>, 路径: Hud.VBoxContainer.Pages.GraphsUi
    /// </summary>
    public class GraphsUi : UiNode<HudPanel, Game.Scripts.Ui.GraphsUi.GraphsUiPanel, GraphsUi>
    {
        public GraphsUi(HudPanel uiPanel, Game.Scripts.Ui.GraphsUi.GraphsUiPanel node) : base(uiPanel, node) {  }
        public override GraphsUi Clone()
        {
            var uiNode = new GraphsUi(UiPanel, (Game.Scripts.Ui.GraphsUi.GraphsUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.TabContainer"/>, 路径: Hud.VBoxContainer.Pages
    /// </summary>
    public class Pages : UiNode<HudPanel, Godot.TabContainer, Pages>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.EditorUi.EditorUiPanel"/>, 节点路径: Hud.VBoxContainer.EditorUi
        /// </summary>
        public EditorUi L_EditorUi
        {
            get
            {
                if (_L_EditorUi == null) _L_EditorUi = new EditorUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.EditorUi.EditorUiPanel>("EditorUi"));
                return _L_EditorUi;
            }
        }
        private EditorUi _L_EditorUi;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.SettingsUi.SettingsUiPanel"/>, 节点路径: Hud.VBoxContainer.SettingsUi
        /// </summary>
        public SettingsUi L_SettingsUi
        {
            get
            {
                if (_L_SettingsUi == null) _L_SettingsUi = new SettingsUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.SettingsUi.SettingsUiPanel>("SettingsUi"));
                return _L_SettingsUi;
            }
        }
        private SettingsUi _L_SettingsUi;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.GraphsUi.GraphsUiPanel"/>, 节点路径: Hud.VBoxContainer.GraphsUi
        /// </summary>
        public GraphsUi L_GraphsUi
        {
            get
            {
                if (_L_GraphsUi == null) _L_GraphsUi = new GraphsUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.GraphsUi.GraphsUiPanel>("GraphsUi"));
                return _L_GraphsUi;
            }
        }
        private GraphsUi _L_GraphsUi;

        public Pages(HudPanel uiPanel, Godot.TabContainer node) : base(uiPanel, node) {  }
        public override Pages Clone() => new (UiPanel, (Godot.TabContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: Hud.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<HudPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 节点路径: Hud.UiShellHeader
        /// </summary>
        public UiShellHeader L_UiShellHeader
        {
            get
            {
                if (_L_UiShellHeader == null) _L_UiShellHeader = new UiShellHeader(UiPanel, Instance.GetNode<Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel>("UiShellHeader"));
                return _L_UiShellHeader;
            }
        }
        private UiShellHeader _L_UiShellHeader;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Hud.ColorRect
        /// </summary>
        public ColorRect_1 L_ColorRect
        {
            get
            {
                if (_L_ColorRect == null) _L_ColorRect = new ColorRect_1(UiPanel, Instance.GetNode<Godot.ColorRect>("ColorRect"));
                return _L_ColorRect;
            }
        }
        private ColorRect_1 _L_ColorRect;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: Hud.Pages
        /// </summary>
        public Pages L_Pages
        {
            get
            {
                if (_L_Pages == null) _L_Pages = new Pages(UiPanel, Instance.GetNode<Godot.TabContainer>("Pages"));
                return _L_Pages;
            }
        }
        private Pages _L_Pages;

        public VBoxContainer(HudPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 节点路径: Hud.VBoxContainer.UiShellHeader
    /// </summary>
    public UiShellHeader S_UiShellHeader => L_VBoxContainer.L_UiShellHeader;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.EditorUi.EditorUiPanel"/>, 节点路径: Hud.VBoxContainer.Pages.EditorUi
    /// </summary>
    public EditorUi S_EditorUi => L_VBoxContainer.L_Pages.L_EditorUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.SettingsUi.SettingsUiPanel"/>, 节点路径: Hud.VBoxContainer.Pages.SettingsUi
    /// </summary>
    public SettingsUi S_SettingsUi => L_VBoxContainer.L_Pages.L_SettingsUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.GraphsUi.GraphsUiPanel"/>, 节点路径: Hud.VBoxContainer.Pages.GraphsUi
    /// </summary>
    public GraphsUi S_GraphsUi => L_VBoxContainer.L_Pages.L_GraphsUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: Hud.VBoxContainer.Pages
    /// </summary>
    public Pages S_Pages => L_VBoxContainer.L_Pages;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Hud.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_VBoxContainer;

}
