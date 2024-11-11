namespace Game.Scripts.Ui.GraphsUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class GraphsUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: GraphsUi.HSplitContainer
    /// </summary>
    public HSplitContainer L_HSplitContainer
    {
        get
        {
            if (_L_HSplitContainer == null) _L_HSplitContainer = new HSplitContainer((GraphsUiPanel)this, GetNode<Godot.HSplitContainer>("HSplitContainer"));
            return _L_HSplitContainer;
        }
    }
    private HSplitContainer _L_HSplitContainer;


    public GraphsUi() : base(nameof(GraphsUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_HSplitContainer.L_VBoxContainer;
        RecordNestedUi(inst1.L_SearchBarUi.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_SearchBarUi.Instance.OnCreateUi();
        inst1.L_SearchBarUi.Instance.OnInitNestedUi();

        var inst2 = L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage;
        RecordNestedUi(inst2.L_LabelWithToolTipBtn.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_LabelWithToolTipBtn.Instance.OnCreateUi();
        inst2.L_LabelWithToolTipBtn.Instance.OnInitNestedUi();

        var inst3 = L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Identifier;
        RecordNestedUi(inst3.L_LabelWithToolTipBtn.Instance, inst3, UiManager.RecordType.Open);
        inst3.L_LabelWithToolTipBtn.Instance.OnCreateUi();
        inst3.L_LabelWithToolTipBtn.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer.Button
    /// </summary>
    public class Button : UiNode<GraphsUiPanel, Godot.Button, Button>
    {
        public Button(GraphsUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Button Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer.SearchBarUi
    /// </summary>
    public class SearchBarUi : UiNode<GraphsUiPanel, Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel, SearchBarUi>
    {
        public SearchBarUi(GraphsUiPanel uiPanel, Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel node) : base(uiPanel, node) {  }
        public override SearchBarUi Clone()
        {
            var uiNode = new SearchBarUi(UiPanel, (Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer.ScrollContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        public VBoxContainer_1(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<GraphsUiPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer.VBoxContainer
        /// </summary>
        public VBoxContainer_1 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_1(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_1 _L_VBoxContainer;

        public ScrollContainer(GraphsUiPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<GraphsUiPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.ScrollContainer
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

        public PanelContainer(GraphsUiPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GraphsUi.HSplitContainer.Button
        /// </summary>
        public Button L_Button
        {
            get
            {
                if (_L_Button == null) _L_Button = new Button(UiPanel, Instance.GetNode<Godot.Button>("Button"));
                return _L_Button;
            }
        }
        private Button _L_Button;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 节点路径: GraphsUi.HSplitContainer.SearchBarUi
        /// </summary>
        public SearchBarUi L_SearchBarUi
        {
            get
            {
                if (_L_SearchBarUi == null) _L_SearchBarUi = new SearchBarUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel>("SearchBarUi"));
                return _L_SearchBarUi;
            }
        }
        private SearchBarUi _L_SearchBarUi;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GraphsUi.HSplitContainer.PanelContainer
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

        public VBoxContainer(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.LabelWithToolTipBtn
    /// </summary>
    public class LabelWithToolTipBtn : UiNode<GraphsUiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel, LabelWithToolTipBtn>
    {
        public LabelWithToolTipBtn(GraphsUiPanel uiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel node) : base(uiPanel, node) {  }
        public override LabelWithToolTipBtn Clone()
        {
            var uiNode = new LabelWithToolTipBtn(UiPanel, (Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.LineEdit
    /// </summary>
    public class LineEdit : UiNode<GraphsUiPanel, Godot.LineEdit, LineEdit>
    {
        public LineEdit(GraphsUiPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override LineEdit Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.TextureButton
    /// </summary>
    public class TextureButton : UiNode<GraphsUiPanel, Godot.TextureButton, TextureButton>
    {
        public TextureButton(GraphsUiPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override TextureButton Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<GraphsUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.LineEdit
        /// </summary>
        public LineEdit L_LineEdit
        {
            get
            {
                if (_L_LineEdit == null) _L_LineEdit = new LineEdit(UiPanel, Instance.GetNode<Godot.LineEdit>("LineEdit"));
                return _L_LineEdit;
            }
        }
        private LineEdit _L_LineEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.TextureButton
        /// </summary>
        public TextureButton L_TextureButton
        {
            get
            {
                if (_L_TextureButton == null) _L_TextureButton = new TextureButton(UiPanel, Instance.GetNode<Godot.TextureButton>("TextureButton"));
                return _L_TextureButton;
            }
        }
        private TextureButton _L_TextureButton;

        public HBoxContainer(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage
    /// </summary>
    public class SourceImage : UiNode<GraphsUiPanel, Godot.HBoxContainer, SourceImage>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.LabelWithToolTipBtn
        /// </summary>
        public LabelWithToolTipBtn L_LabelWithToolTipBtn
        {
            get
            {
                if (_L_LabelWithToolTipBtn == null) _L_LabelWithToolTipBtn = new LabelWithToolTipBtn(UiPanel, Instance.GetNode<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>("LabelWithToolTipBtn"));
                return _L_LabelWithToolTipBtn;
            }
        }
        private LabelWithToolTipBtn _L_LabelWithToolTipBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.HBoxContainer
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

        public SourceImage(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override SourceImage Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier.LabelWithToolTipBtn
    /// </summary>
    public class LabelWithToolTipBtn_1 : UiNode<GraphsUiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel, LabelWithToolTipBtn_1>
    {
        public LabelWithToolTipBtn_1(GraphsUiPanel uiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel node) : base(uiPanel, node) {  }
        public override LabelWithToolTipBtn_1 Clone()
        {
            var uiNode = new LabelWithToolTipBtn_1(UiPanel, (Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier.LineEdit
    /// </summary>
    public class LineEdit_1 : UiNode<GraphsUiPanel, Godot.LineEdit, LineEdit_1>
    {
        public LineEdit_1(GraphsUiPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override LineEdit_1 Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier
    /// </summary>
    public class Identifier : UiNode<GraphsUiPanel, Godot.HBoxContainer, Identifier>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.LabelWithToolTipBtn
        /// </summary>
        public LabelWithToolTipBtn_1 L_LabelWithToolTipBtn
        {
            get
            {
                if (_L_LabelWithToolTipBtn == null) _L_LabelWithToolTipBtn = new LabelWithToolTipBtn_1(UiPanel, Instance.GetNode<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>("LabelWithToolTipBtn"));
                return _L_LabelWithToolTipBtn;
            }
        }
        private LabelWithToolTipBtn_1 _L_LabelWithToolTipBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.LineEdit
        /// </summary>
        public LineEdit_1 L_LineEdit
        {
            get
            {
                if (_L_LineEdit == null) _L_LineEdit = new LineEdit_1(UiPanel, Instance.GetNode<Godot.LineEdit>("LineEdit"));
                return _L_LineEdit;
            }
        }
        private LineEdit_1 _L_LineEdit;

        public Identifier(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override Identifier Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_3 : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer_3>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.SourceImage
        /// </summary>
        public SourceImage L_SourceImage
        {
            get
            {
                if (_L_SourceImage == null) _L_SourceImage = new SourceImage(UiPanel, Instance.GetNode<Godot.HBoxContainer>("SourceImage"));
                return _L_SourceImage;
            }
        }
        private SourceImage _L_SourceImage;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.Identifier
        /// </summary>
        public Identifier L_Identifier
        {
            get
            {
                if (_L_Identifier == null) _L_Identifier = new Identifier(UiPanel, Instance.GetNode<Godot.HBoxContainer>("Identifier"));
                return _L_Identifier;
            }
        }
        private Identifier _L_Identifier;

        public VBoxContainer_3(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_3 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer
    /// </summary>
    public class MarginContainer_1 : UiNode<GraphsUiPanel, Godot.MarginContainer, MarginContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.VBoxContainer
        /// </summary>
        public VBoxContainer_3 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_3(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_3 _L_VBoxContainer;

        public MarginContainer_1(GraphsUiPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_1 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_2 : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.MarginContainer
        /// </summary>
        public MarginContainer_1 L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer_1(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer_1 _L_MarginContainer;

        public VBoxContainer_2(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_2 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<GraphsUiPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.VBoxContainer
        /// </summary>
        public VBoxContainer_2 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_2(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_2 _L_VBoxContainer;

        public MarginContainer(GraphsUiPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: GraphsUi.HSplitContainer.ColorRect
    /// </summary>
    public class ColorRect : UiNode<GraphsUiPanel, Godot.ColorRect, ColorRect>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GraphsUi.HSplitContainer.MarginContainer
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

        public ColorRect(GraphsUiPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HSplitContainer"/>, 路径: GraphsUi.HSplitContainer
    /// </summary>
    public class HSplitContainer : UiNode<GraphsUiPanel, Godot.HSplitContainer, HSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.VBoxContainer
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: GraphsUi.ColorRect
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

        public HSplitContainer(GraphsUiPanel uiPanel, Godot.HSplitContainer node) : base(uiPanel, node) {  }
        public override HSplitContainer Clone() => new (UiPanel, (Godot.HSplitContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.Button
    /// </summary>
    public Button S_Button => L_HSplitContainer.L_VBoxContainer.L_Button;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.SearchBarUi
    /// </summary>
    public SearchBarUi S_SearchBarUi => L_HSplitContainer.L_VBoxContainer.L_SearchBarUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_HSplitContainer.L_VBoxContainer.L_PanelContainer.L_ScrollContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_HSplitContainer.L_VBoxContainer.L_PanelContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.TextureButton
    /// </summary>
    public TextureButton S_TextureButton => L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage.L_HBoxContainer.L_TextureButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage
    /// </summary>
    public SourceImage S_SourceImage => L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier
    /// </summary>
    public Identifier S_Identifier => L_HSplitContainer.L_ColorRect.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Identifier;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_HSplitContainer.L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: GraphsUi.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_HSplitContainer;

}
