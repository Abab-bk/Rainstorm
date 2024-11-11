namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string EditorUi = "EditorUi";
        public const string GraphsUi = "GraphsUi";
        public const string Hud = "Hud";
        public const string LabelWithToolTipBtn = "LabelWithToolTipBtn";
        public const string Modal = "Modal";
        public const string NewProjectPopup = "NewProjectPopup";
        public const string ProjectItem = "ProjectItem";
        public const string SearchBarUi = "SearchBarUi";
        public const string SettingsUi = "SettingsUi";
        public const string TextInputFluid = "TextInputFluid";
        public const string UiShellHeader = "UiShellHeader";
        public const string WelcomeUi = "WelcomeUi";
    }

    /// <summary>
    /// 创建 EditorUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.EditorUi.EditorUiPanel Create_EditorUi()
    {
        return CreateUi<Game.Scripts.Ui.EditorUi.EditorUiPanel>(UiName.EditorUi);
    }

    /// <summary>
    /// 打开 EditorUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.EditorUi.EditorUiPanel Open_EditorUi()
    {
        return OpenUi<Game.Scripts.Ui.EditorUi.EditorUiPanel>(UiName.EditorUi);
    }

    /// <summary>
    /// 隐藏 EditorUi 的所有实例
    /// </summary>
    public static void Hide_EditorUi()
    {
        var uiInstance = Get_EditorUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 EditorUi 的所有实例
    /// </summary>
    public static void Destroy_EditorUi()
    {
        var uiInstance = Get_EditorUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 EditorUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.EditorUi.EditorUiPanel[] Get_EditorUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.EditorUi.EditorUiPanel>(nameof(Game.Scripts.Ui.EditorUi.EditorUi));
    }

    /// <summary>
    /// 创建 GraphsUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.GraphsUi.GraphsUiPanel Create_GraphsUi()
    {
        return CreateUi<Game.Scripts.Ui.GraphsUi.GraphsUiPanel>(UiName.GraphsUi);
    }

    /// <summary>
    /// 打开 GraphsUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.GraphsUi.GraphsUiPanel Open_GraphsUi()
    {
        return OpenUi<Game.Scripts.Ui.GraphsUi.GraphsUiPanel>(UiName.GraphsUi);
    }

    /// <summary>
    /// 隐藏 GraphsUi 的所有实例
    /// </summary>
    public static void Hide_GraphsUi()
    {
        var uiInstance = Get_GraphsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 GraphsUi 的所有实例
    /// </summary>
    public static void Destroy_GraphsUi()
    {
        var uiInstance = Get_GraphsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 GraphsUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.GraphsUi.GraphsUiPanel[] Get_GraphsUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.GraphsUi.GraphsUiPanel>(nameof(Game.Scripts.Ui.GraphsUi.GraphsUi));
    }

    /// <summary>
    /// 创建 Hud, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Create_Hud()
    {
        return CreateUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 打开 Hud, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Open_Hud()
    {
        return OpenUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 隐藏 Hud 的所有实例
    /// </summary>
    public static void Hide_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Hud 的所有实例
    /// </summary>
    public static void Destroy_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Hud 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel[] Get_Hud_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Hud.HudPanel>(nameof(Game.Scripts.Ui.Hud.Hud));
    }

    /// <summary>
    /// 创建 LabelWithToolTipBtn, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel Create_LabelWithToolTipBtn()
    {
        return CreateUi<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>(UiName.LabelWithToolTipBtn);
    }

    /// <summary>
    /// 打开 LabelWithToolTipBtn, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel Open_LabelWithToolTipBtn()
    {
        return OpenUi<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>(UiName.LabelWithToolTipBtn);
    }

    /// <summary>
    /// 隐藏 LabelWithToolTipBtn 的所有实例
    /// </summary>
    public static void Hide_LabelWithToolTipBtn()
    {
        var uiInstance = Get_LabelWithToolTipBtn_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 LabelWithToolTipBtn 的所有实例
    /// </summary>
    public static void Destroy_LabelWithToolTipBtn()
    {
        var uiInstance = Get_LabelWithToolTipBtn_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 LabelWithToolTipBtn 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel[] Get_LabelWithToolTipBtn_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtnPanel>(nameof(Game.Scripts.Ui.LabelWithToolTipBtn.LabelWithToolTipBtn));
    }

    /// <summary>
    /// 创建 Modal, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Create_Modal()
    {
        return CreateUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 打开 Modal, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Open_Modal()
    {
        return OpenUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 隐藏 Modal 的所有实例
    /// </summary>
    public static void Hide_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Modal 的所有实例
    /// </summary>
    public static void Destroy_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Modal 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel[] Get_Modal_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Modal.ModalPanel>(nameof(Game.Scripts.Ui.Modal.Modal));
    }

    /// <summary>
    /// 创建 NewProjectPopup, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel Create_NewProjectPopup()
    {
        return CreateUi<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(UiName.NewProjectPopup);
    }

    /// <summary>
    /// 打开 NewProjectPopup, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel Open_NewProjectPopup()
    {
        return OpenUi<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(UiName.NewProjectPopup);
    }

    /// <summary>
    /// 隐藏 NewProjectPopup 的所有实例
    /// </summary>
    public static void Hide_NewProjectPopup()
    {
        var uiInstance = Get_NewProjectPopup_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 NewProjectPopup 的所有实例
    /// </summary>
    public static void Destroy_NewProjectPopup()
    {
        var uiInstance = Get_NewProjectPopup_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 NewProjectPopup 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel[] Get_NewProjectPopup_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(nameof(Game.Scripts.Ui.NewProjectPopup.NewProjectPopup));
    }

    /// <summary>
    /// 创建 ProjectItem, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.ProjectItem.ProjectItemPanel Create_ProjectItem()
    {
        return CreateUi<Game.Scripts.Ui.ProjectItem.ProjectItemPanel>(UiName.ProjectItem);
    }

    /// <summary>
    /// 打开 ProjectItem, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.ProjectItem.ProjectItemPanel Open_ProjectItem()
    {
        return OpenUi<Game.Scripts.Ui.ProjectItem.ProjectItemPanel>(UiName.ProjectItem);
    }

    /// <summary>
    /// 隐藏 ProjectItem 的所有实例
    /// </summary>
    public static void Hide_ProjectItem()
    {
        var uiInstance = Get_ProjectItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 ProjectItem 的所有实例
    /// </summary>
    public static void Destroy_ProjectItem()
    {
        var uiInstance = Get_ProjectItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 ProjectItem 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.ProjectItem.ProjectItemPanel[] Get_ProjectItem_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.ProjectItem.ProjectItemPanel>(nameof(Game.Scripts.Ui.ProjectItem.ProjectItem));
    }

    /// <summary>
    /// 创建 SearchBarUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel Create_SearchBarUi()
    {
        return CreateUi<Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel>(UiName.SearchBarUi);
    }

    /// <summary>
    /// 打开 SearchBarUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel Open_SearchBarUi()
    {
        return OpenUi<Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel>(UiName.SearchBarUi);
    }

    /// <summary>
    /// 隐藏 SearchBarUi 的所有实例
    /// </summary>
    public static void Hide_SearchBarUi()
    {
        var uiInstance = Get_SearchBarUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 SearchBarUi 的所有实例
    /// </summary>
    public static void Destroy_SearchBarUi()
    {
        var uiInstance = Get_SearchBarUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 SearchBarUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel[] Get_SearchBarUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.SearchBarUi.SearchBarUiPanel>(nameof(Game.Scripts.Ui.SearchBarUi.SearchBarUi));
    }

    /// <summary>
    /// 创建 SettingsUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.SettingsUi.SettingsUiPanel Create_SettingsUi()
    {
        return CreateUi<Game.Scripts.Ui.SettingsUi.SettingsUiPanel>(UiName.SettingsUi);
    }

    /// <summary>
    /// 打开 SettingsUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.SettingsUi.SettingsUiPanel Open_SettingsUi()
    {
        return OpenUi<Game.Scripts.Ui.SettingsUi.SettingsUiPanel>(UiName.SettingsUi);
    }

    /// <summary>
    /// 隐藏 SettingsUi 的所有实例
    /// </summary>
    public static void Hide_SettingsUi()
    {
        var uiInstance = Get_SettingsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 SettingsUi 的所有实例
    /// </summary>
    public static void Destroy_SettingsUi()
    {
        var uiInstance = Get_SettingsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 SettingsUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.SettingsUi.SettingsUiPanel[] Get_SettingsUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.SettingsUi.SettingsUiPanel>(nameof(Game.Scripts.Ui.SettingsUi.SettingsUi));
    }

    /// <summary>
    /// 创建 TextInputFluid, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel Create_TextInputFluid()
    {
        return CreateUi<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(UiName.TextInputFluid);
    }

    /// <summary>
    /// 打开 TextInputFluid, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel Open_TextInputFluid()
    {
        return OpenUi<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(UiName.TextInputFluid);
    }

    /// <summary>
    /// 隐藏 TextInputFluid 的所有实例
    /// </summary>
    public static void Hide_TextInputFluid()
    {
        var uiInstance = Get_TextInputFluid_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 TextInputFluid 的所有实例
    /// </summary>
    public static void Destroy_TextInputFluid()
    {
        var uiInstance = Get_TextInputFluid_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 TextInputFluid 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel[] Get_TextInputFluid_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(nameof(Game.Scripts.Ui.TextInputFluid.TextInputFluid));
    }

    /// <summary>
    /// 创建 UiShellHeader, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel Create_UiShellHeader()
    {
        return CreateUi<Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel>(UiName.UiShellHeader);
    }

    /// <summary>
    /// 打开 UiShellHeader, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel Open_UiShellHeader()
    {
        return OpenUi<Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel>(UiName.UiShellHeader);
    }

    /// <summary>
    /// 隐藏 UiShellHeader 的所有实例
    /// </summary>
    public static void Hide_UiShellHeader()
    {
        var uiInstance = Get_UiShellHeader_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 UiShellHeader 的所有实例
    /// </summary>
    public static void Destroy_UiShellHeader()
    {
        var uiInstance = Get_UiShellHeader_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 UiShellHeader 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel[] Get_UiShellHeader_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel>(nameof(Game.Scripts.Ui.UiShellHeader.UiShellHeader));
    }

    /// <summary>
    /// 创建 WelcomeUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel Create_WelcomeUi()
    {
        return CreateUi<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(UiName.WelcomeUi);
    }

    /// <summary>
    /// 打开 WelcomeUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel Open_WelcomeUi()
    {
        return OpenUi<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(UiName.WelcomeUi);
    }

    /// <summary>
    /// 隐藏 WelcomeUi 的所有实例
    /// </summary>
    public static void Hide_WelcomeUi()
    {
        var uiInstance = Get_WelcomeUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 WelcomeUi 的所有实例
    /// </summary>
    public static void Destroy_WelcomeUi()
    {
        var uiInstance = Get_WelcomeUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 WelcomeUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel[] Get_WelcomeUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(nameof(Game.Scripts.Ui.WelcomeUi.WelcomeUi));
    }

}
