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

        var inst1 = L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer;
        RecordNestedUi(inst1.L_SearchBarUi.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_SearchBarUi.Instance.OnCreateUi();
        inst1.L_SearchBarUi.Instance.OnInitNestedUi();

        var inst2 = L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage;
        RecordNestedUi(inst2.L_SourceImageTitle.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_SourceImageTitle.Instance.OnCreateUi();
        inst2.L_SourceImageTitle.Instance.OnInitNestedUi();

        var inst3 = L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Identifier;
        RecordNestedUi(inst3.L_IdentifierTitle.Instance, inst3, UiManager.RecordType.Open);
        inst3.L_IdentifierTitle.Instance.OnCreateUi();
        inst3.L_IdentifierTitle.Instance.OnInitNestedUi();

        var inst4 = L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Mode;
        RecordNestedUi(inst4.L_IdentifierTitle.Instance, inst4, UiManager.RecordType.Open);
        inst4.L_IdentifierTitle.Instance.OnCreateUi();
        inst4.L_IdentifierTitle.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.NewItemBtn
    /// </summary>
    public class NewItemBtn : UiNode<GraphsUiPanel, Godot.Button, NewItemBtn>
    {
        public NewItemBtn(GraphsUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override NewItemBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.SearchBarUi
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
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer.ScrollContainer.Items
    /// </summary>
    public class Items : UiNode<GraphsUiPanel, Godot.VBoxContainer, Items>
    {
        public Items(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override Items Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<GraphsUiPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer.Items
        /// </summary>
        public Items L_Items
        {
            get
            {
                if (_L_Items == null) _L_Items = new Items(UiPanel, Instance.GetNode<Godot.VBoxContainer>("Items"));
                return _L_Items;
            }
        }
        private Items _L_Items;

        public ScrollContainer(GraphsUiPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<GraphsUiPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.ScrollContainer
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
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.NewItemBtn
        /// </summary>
        public NewItemBtn L_NewItemBtn
        {
            get
            {
                if (_L_NewItemBtn == null) _L_NewItemBtn = new NewItemBtn(UiPanel, Instance.GetNode<Godot.Button>("NewItemBtn"));
                return _L_NewItemBtn;
            }
        }
        private NewItemBtn _L_NewItemBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.SearchBarUi
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.PanelContainer
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
    /// 类型: <see cref="Game.Scripts.Prefabs.RepoLeftPanel"/>, 路径: GraphsUi.HSplitContainer.RepoLeftPanel
    /// </summary>
    public class RepoLeftPanel : UiNode<GraphsUiPanel, Game.Scripts.Prefabs.RepoLeftPanel, RepoLeftPanel>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.VBoxContainer
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

        public RepoLeftPanel(GraphsUiPanel uiPanel, Game.Scripts.Prefabs.RepoLeftPanel node) : base(uiPanel, node) {  }
        public override RepoLeftPanel Clone() => new (UiPanel, (Game.Scripts.Prefabs.RepoLeftPanel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.Control.Label
    /// </summary>
    public class Label : UiNode<GraphsUiPanel, Godot.Label, Label>
    {
        public Label(GraphsUiPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.Control
    /// </summary>
    public class Control : UiNode<GraphsUiPanel, Godot.Control, Control>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.Label
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

        public Control(GraphsUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.SourceImageTitle
    /// </summary>
    public class SourceImageTitle : UiNode<GraphsUiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel, SourceImageTitle>
    {
        public SourceImageTitle(GraphsUiPanel uiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel node) : base(uiPanel, node) {  }
        public override SourceImageTitle Clone()
        {
            var uiNode = new SourceImageTitle(UiPanel, (Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.SourceImageText
    /// </summary>
    public class SourceImageText : UiNode<GraphsUiPanel, Godot.LineEdit, SourceImageText>
    {
        public SourceImageText(GraphsUiPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override SourceImageText Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.SelectSourceImageBtn
    /// </summary>
    public class SelectSourceImageBtn : UiNode<GraphsUiPanel, Godot.TextureButton, SelectSourceImageBtn>
    {
        public SelectSourceImageBtn(GraphsUiPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override SelectSourceImageBtn Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<GraphsUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.SourceImageText
        /// </summary>
        public SourceImageText L_SourceImageText
        {
            get
            {
                if (_L_SourceImageText == null) _L_SourceImageText = new SourceImageText(UiPanel, Instance.GetNode<Godot.LineEdit>("SourceImageText"));
                return _L_SourceImageText;
            }
        }
        private SourceImageText _L_SourceImageText;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.SelectSourceImageBtn
        /// </summary>
        public SelectSourceImageBtn L_SelectSourceImageBtn
        {
            get
            {
                if (_L_SelectSourceImageBtn == null) _L_SelectSourceImageBtn = new SelectSourceImageBtn(UiPanel, Instance.GetNode<Godot.TextureButton>("SelectSourceImageBtn"));
                return _L_SelectSourceImageBtn;
            }
        }
        private SelectSourceImageBtn _L_SelectSourceImageBtn;

        public HBoxContainer(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage
    /// </summary>
    public class SourceImage : UiNode<GraphsUiPanel, Godot.HBoxContainer, SourceImage>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImageTitle
        /// </summary>
        public SourceImageTitle L_SourceImageTitle
        {
            get
            {
                if (_L_SourceImageTitle == null) _L_SourceImageTitle = new SourceImageTitle(UiPanel, Instance.GetNode<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>("SourceImageTitle"));
                return _L_SourceImageTitle;
            }
        }
        private SourceImageTitle _L_SourceImageTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.HBoxContainer
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
    /// 类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier.IdentifierTitle
    /// </summary>
    public class IdentifierTitle : UiNode<GraphsUiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel, IdentifierTitle>
    {
        public IdentifierTitle(GraphsUiPanel uiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel node) : base(uiPanel, node) {  }
        public override IdentifierTitle Clone()
        {
            var uiNode = new IdentifierTitle(UiPanel, (Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier.IdentifierLineEdit
    /// </summary>
    public class IdentifierLineEdit : UiNode<GraphsUiPanel, Godot.LineEdit, IdentifierLineEdit>
    {
        public IdentifierLineEdit(GraphsUiPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override IdentifierLineEdit Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier
    /// </summary>
    public class Identifier : UiNode<GraphsUiPanel, Godot.HBoxContainer, Identifier>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.IdentifierTitle
        /// </summary>
        public IdentifierTitle L_IdentifierTitle
        {
            get
            {
                if (_L_IdentifierTitle == null) _L_IdentifierTitle = new IdentifierTitle(UiPanel, Instance.GetNode<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>("IdentifierTitle"));
                return _L_IdentifierTitle;
            }
        }
        private IdentifierTitle _L_IdentifierTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.IdentifierLineEdit
        /// </summary>
        public IdentifierLineEdit L_IdentifierLineEdit
        {
            get
            {
                if (_L_IdentifierLineEdit == null) _L_IdentifierLineEdit = new IdentifierLineEdit(UiPanel, Instance.GetNode<Godot.LineEdit>("IdentifierLineEdit"));
                return _L_IdentifierLineEdit;
            }
        }
        private IdentifierLineEdit _L_IdentifierLineEdit;

        public Identifier(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override Identifier Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.IdentifierTitle
    /// </summary>
    public class IdentifierTitle_1 : UiNode<GraphsUiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel, IdentifierTitle_1>
    {
        public IdentifierTitle_1(GraphsUiPanel uiPanel, Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel node) : base(uiPanel, node) {  }
        public override IdentifierTitle_1 Clone()
        {
            var uiNode = new IdentifierTitle_1(UiPanel, (Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.CheckBox"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.HBoxContainer.MultipleModeBtn
    /// </summary>
    public class MultipleModeBtn : UiNode<GraphsUiPanel, Godot.CheckBox, MultipleModeBtn>
    {
        public MultipleModeBtn(GraphsUiPanel uiPanel, Godot.CheckBox node) : base(uiPanel, node) {  }
        public override MultipleModeBtn Clone() => new (UiPanel, (Godot.CheckBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.CheckBox"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.HBoxContainer.SingleModeBtn
    /// </summary>
    public class SingleModeBtn : UiNode<GraphsUiPanel, Godot.CheckBox, SingleModeBtn>
    {
        public SingleModeBtn(GraphsUiPanel uiPanel, Godot.CheckBox node) : base(uiPanel, node) {  }
        public override SingleModeBtn Clone() => new (UiPanel, (Godot.CheckBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.HBoxContainer
    /// </summary>
    public class HBoxContainer_1 : UiNode<GraphsUiPanel, Godot.HBoxContainer, HBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.CheckBox"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.MultipleModeBtn
        /// </summary>
        public MultipleModeBtn L_MultipleModeBtn
        {
            get
            {
                if (_L_MultipleModeBtn == null) _L_MultipleModeBtn = new MultipleModeBtn(UiPanel, Instance.GetNode<Godot.CheckBox>("MultipleModeBtn"));
                return _L_MultipleModeBtn;
            }
        }
        private MultipleModeBtn _L_MultipleModeBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.CheckBox"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.SingleModeBtn
        /// </summary>
        public SingleModeBtn L_SingleModeBtn
        {
            get
            {
                if (_L_SingleModeBtn == null) _L_SingleModeBtn = new SingleModeBtn(UiPanel, Instance.GetNode<Godot.CheckBox>("SingleModeBtn"));
                return _L_SingleModeBtn;
            }
        }
        private SingleModeBtn _L_SingleModeBtn;

        public HBoxContainer_1(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode
    /// </summary>
    public class Mode : UiNode<GraphsUiPanel, Godot.HBoxContainer, Mode>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.IdentifierTitle
        /// </summary>
        public IdentifierTitle_1 L_IdentifierTitle
        {
            get
            {
                if (_L_IdentifierTitle == null) _L_IdentifierTitle = new IdentifierTitle_1(UiPanel, Instance.GetNode<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>("IdentifierTitle"));
                return _L_IdentifierTitle;
            }
        }
        private IdentifierTitle_1 _L_IdentifierTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.HBoxContainer
        /// </summary>
        public HBoxContainer_1 L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer_1(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer_1 _L_HBoxContainer;

        public Mode(GraphsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override Mode Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_2 : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.SourceImage
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.Identifier
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.Mode
        /// </summary>
        public Mode L_Mode
        {
            get
            {
                if (_L_Mode == null) _L_Mode = new Mode(UiPanel, Instance.GetNode<Godot.HBoxContainer>("Mode"));
                return _L_Mode;
            }
        }
        private Mode _L_Mode;

        public VBoxContainer_2(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_2 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer
    /// </summary>
    public class MarginContainer_1 : UiNode<GraphsUiPanel, Godot.MarginContainer, MarginContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.VBoxContainer
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

        public MarginContainer_1(GraphsUiPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_1 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<GraphsUiPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.MarginContainer
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

        public VBoxContainer_1(GraphsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<GraphsUiPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.VBoxContainer
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

        public MarginContainer(GraphsUiPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TabContainer"/>, 路径: GraphsUi.HSplitContainer.ColorRect.Pages
    /// </summary>
    public class Pages : UiNode<GraphsUiPanel, Godot.TabContainer, Pages>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Control
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.MarginContainer
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

        public Pages(GraphsUiPanel uiPanel, Godot.TabContainer node) : base(uiPanel, node) {  }
        public override Pages Clone() => new (UiPanel, (Godot.TabContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: GraphsUi.HSplitContainer.ColorRect
    /// </summary>
    public class ColorRect : UiNode<GraphsUiPanel, Godot.ColorRect, ColorRect>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: GraphsUi.HSplitContainer.Pages
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

        public ColorRect(GraphsUiPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HSplitContainer"/>, 路径: GraphsUi.HSplitContainer
    /// </summary>
    public class HSplitContainer : UiNode<GraphsUiPanel, Godot.HSplitContainer, HSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Prefabs.RepoLeftPanel"/>, 节点路径: GraphsUi.RepoLeftPanel
        /// </summary>
        public RepoLeftPanel L_RepoLeftPanel
        {
            get
            {
                if (_L_RepoLeftPanel == null) _L_RepoLeftPanel = new RepoLeftPanel(UiPanel, Instance.GetNode<Game.Scripts.Prefabs.RepoLeftPanel>("RepoLeftPanel"));
                return _L_RepoLeftPanel;
            }
        }
        private RepoLeftPanel _L_RepoLeftPanel;

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
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.NewItemBtn
    /// </summary>
    public NewItemBtn S_NewItemBtn => L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer.L_NewItemBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.SearchBarUi
    /// </summary>
    public SearchBarUi S_SearchBarUi => L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer.L_SearchBarUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer.ScrollContainer.Items
    /// </summary>
    public Items S_Items => L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer.L_PanelContainer.L_ScrollContainer.L_Items;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer.L_PanelContainer.L_ScrollContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel.VBoxContainer.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_HSplitContainer.L_RepoLeftPanel.L_VBoxContainer.L_PanelContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Prefabs.RepoLeftPanel"/>, 节点路径: GraphsUi.HSplitContainer.RepoLeftPanel
    /// </summary>
    public RepoLeftPanel S_RepoLeftPanel => L_HSplitContainer.L_RepoLeftPanel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.Control.Label
    /// </summary>
    public Label S_Label => L_HSplitContainer.L_ColorRect.L_Pages.L_Control.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.Control
    /// </summary>
    public Control S_Control => L_HSplitContainer.L_ColorRect.L_Pages.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.SourceImageTitle
    /// </summary>
    public SourceImageTitle S_SourceImageTitle => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage.L_SourceImageTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.SourceImageText
    /// </summary>
    public SourceImageText S_SourceImageText => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage.L_HBoxContainer.L_SourceImageText;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage.HBoxContainer.SelectSourceImageBtn
    /// </summary>
    public SelectSourceImageBtn S_SelectSourceImageBtn => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage.L_HBoxContainer.L_SelectSourceImageBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.SourceImage
    /// </summary>
    public SourceImage S_SourceImage => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_SourceImage;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier.IdentifierLineEdit
    /// </summary>
    public IdentifierLineEdit S_IdentifierLineEdit => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Identifier.L_IdentifierLineEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Identifier
    /// </summary>
    public Identifier S_Identifier => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Identifier;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.CheckBox"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.HBoxContainer.MultipleModeBtn
    /// </summary>
    public MultipleModeBtn S_MultipleModeBtn => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Mode.L_HBoxContainer.L_MultipleModeBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.CheckBox"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode.HBoxContainer.SingleModeBtn
    /// </summary>
    public SingleModeBtn S_SingleModeBtn => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Mode.L_HBoxContainer.L_SingleModeBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages.MarginContainer.VBoxContainer.MarginContainer.VBoxContainer.Mode
    /// </summary>
    public Mode S_Mode => L_HSplitContainer.L_ColorRect.L_Pages.L_MarginContainer.L_VBoxContainer.L_MarginContainer.L_VBoxContainer.L_Mode;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect.Pages
    /// </summary>
    public Pages S_Pages => L_HSplitContainer.L_ColorRect.L_Pages;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: GraphsUi.HSplitContainer.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_HSplitContainer.L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: GraphsUi.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_HSplitContainer;

}
