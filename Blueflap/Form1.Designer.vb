<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fenetre_Principale))
        Me.ABlueflap_Navigateur = New System.Windows.Forms.Panel()
        Me.Notif_internet = New System.Windows.Forms.PictureBox()
        Me.Web = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.Fav_Panel = New System.Windows.Forms.Panel()
        Me.Fav_Histotab = New MetroControls.MetroHeaderButton()
        Me.Fav_Favtab = New MetroControls.MetroHeaderButton()
        Me.Fav_Historique_List = New System.Windows.Forms.ListBox()
        Me.fav_notif_suppr = New System.Windows.Forms.Panel()
        Me.Fav_Cancel = New System.Windows.Forms.Button()
        Me.Fav_Confirm = New System.Windows.Forms.Button()
        Me.Fav_Notif_Text = New System.Windows.Forms.Label()
        Me.Fav_Close = New System.Windows.Forms.Button()
        Me.Fav_fav_List = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccéderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FP_AdressbarPanel = New System.Windows.Forms.Panel()
        Me.Notif_add = New System.Windows.Forms.Panel()
        Me.Notiff_add_OKbutton = New System.Windows.Forms.Button()
        Me.Notiff_add_Text = New System.Windows.Forms.Label()
        Me.Loader = New System.Windows.Forms.PictureBox()
        Me.AddFavo_Button = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.SmartAdressbox = New System.Windows.Forms.TextBox()
        Me.Menu_ShowHide_Button = New System.Windows.Forms.Button()
        Me.voletlateral = New System.Windows.Forms.MenuStrip()
        Me.Menua = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Home = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Back = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Forward = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Stop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Fight = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Favos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Share = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_partage = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Lock = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_FullScr = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Memo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABlueflap_Settings = New System.Windows.Forms.Panel()
        Me.Stng_Helpcenter = New MetroControls.MetroHeaderButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Sett_TabB = New System.Windows.Forms.Panel()
        Me.stng_Smartsuggestactif = New System.Windows.Forms.CheckBox()
        Me.StngLabel_Suggest = New System.Windows.Forms.Label()
        Me.Stng_ResetSuggest = New System.Windows.Forms.Button()
        Me.StngLabel_Network = New System.Windows.Forms.Label()
        Me.stng_nevpriv = New System.Windows.Forms.CheckBox()
        Me.StngLabel_Private = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Stng_OptionsInternet = New System.Windows.Forms.Button()
        Me.StngLabel_Data = New System.Windows.Forms.Label()
        Me.StngLabel_Extra = New System.Windows.Forms.Label()
        Me.Stng_SupprHisto = New System.Windows.Forms.Button()
        Me.Stng_SupprCacheCookies = New System.Windows.Forms.Button()
        Me.StngLabel_NetworkInfo = New System.Windows.Forms.Label()
        Me.StngLabel_Proxy = New System.Windows.Forms.Label()
        Me.Sett_TabC = New System.Windows.Forms.Panel()
        Me.StngLabel_Contributeurs = New System.Windows.Forms.Label()
        Me.Stng_Bat41 = New System.Windows.Forms.Button()
        Me.Stng_BaptGuil = New System.Windows.Forms.Button()
        Me.Stng_Zyhou = New System.Windows.Forms.Button()
        Me.StngLabel_OpenSource = New System.Windows.Forms.Label()
        Me.StngLabel_Version = New System.Windows.Forms.Label()
        Me.stng_github = New System.Windows.Forms.Button()
        Me.StngLabel_Devs = New System.Windows.Forms.Label()
        Me.stng_simpleworld = New System.Windows.Forms.Button()
        Me.StngLabel_Contribute = New System.Windows.Forms.Label()
        Me.Stng_VersionSystem = New System.Windows.Forms.Label()
        Me.Stng_ShowLicense = New System.Windows.Forms.Button()
        Me.Sett_TabA = New System.Windows.Forms.Panel()
        Me.BackgroundChemin = New System.Windows.Forms.TextBox()
        Me.stng_picdemo = New System.Windows.Forms.PictureBox()
        Me.Share_checkbox = New System.Windows.Forms.CheckBox()
        Me.StngmenuIcon5 = New System.Windows.Forms.PictureBox()
        Me.memo_checkbox = New System.Windows.Forms.CheckBox()
        Me.StngmenuIcon8 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StngLabel_Background = New System.Windows.Forms.Label()
        Me.Stng_bluestart_checkbox = New System.Windows.Forms.CheckBox()
        Me.StngLabel_Searchengine = New System.Windows.Forms.Label()
        Me.Stng_MoteurRecherche_choose = New System.Windows.Forms.ComboBox()
        Me.Stng_MoteurRecherche_URL = New System.Windows.Forms.TextBox()
        Me.StngLabel_Home = New System.Windows.Forms.Label()
        Me.Stng_HomePage_Url = New System.Windows.Forms.TextBox()
        Me.Stng_ErreurURLHomepage = New System.Windows.Forms.Label()
        Me.Stng_Volet_reduire = New System.Windows.Forms.CheckBox()
        Me.StngLabel_Lock = New System.Windows.Forms.Label()
        Me.Stng_MP = New System.Windows.Forms.TextBox()
        Me.Stng_MP_confirm = New System.Windows.Forms.TextBox()
        Me.Stng_MPActiv = New System.Windows.Forms.CheckBox()
        Me.StngLabel_MPConfirm = New System.Windows.Forms.Label()
        Me.StngLabel_MP = New System.Windows.Forms.Label()
        Me.Stng_Volet_Mousehover_agrandir = New System.Windows.Forms.CheckBox()
        Me.StngLabel_Interface = New System.Windows.Forms.Label()
        Me.StngLabel_Icons = New System.Windows.Forms.Label()
        Me.Stng_TouchUI = New System.Windows.Forms.CheckBox()
        Me.Stng_MaximizedWindow = New System.Windows.Forms.CheckBox()
        Me.Home_checkbox = New System.Windows.Forms.CheckBox()
        Me.Sfight_Checkbox = New System.Windows.Forms.CheckBox()
        Me.favo_checkbox = New System.Windows.Forms.CheckBox()
        Me.infos_checkbox = New System.Windows.Forms.CheckBox()
        Me.lock_checkbox = New System.Windows.Forms.CheckBox()
        Me.fullscreen_checkbox = New System.Windows.Forms.CheckBox()
        Me.StngmenuIcon1 = New System.Windows.Forms.PictureBox()
        Me.StngmenuIcon2 = New System.Windows.Forms.PictureBox()
        Me.StngmenuIcon7 = New System.Windows.Forms.PictureBox()
        Me.StngmenuIcon3 = New System.Windows.Forms.PictureBox()
        Me.StngmenuIcon6 = New System.Windows.Forms.PictureBox()
        Me.StngmenuIcon4 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.sett_tab3 = New MetroControls.MetroHeaderButton()
        Me.sett_tab2 = New MetroControls.MetroHeaderButton()
        Me.sett_tab1 = New MetroControls.MetroHeaderButton()
        Me.Settings_Back = New System.Windows.Forms.Button()
        Me.Settings_title = New System.Windows.Forms.Label()
        Me.ABlueflap_Fight = New System.Windows.Forms.Panel()
        Me.SrchFight_AdvanceRight = New System.Windows.Forms.TextBox()
        Me.SrchFight_AdvanceLeft = New System.Windows.Forms.TextBox()
        Me.SrchF_AdvanceChoice = New System.Windows.Forms.CheckBox()
        Me.SrchF_Actions = New System.Windows.Forms.ComboBox()
        Me.SrchF_Split = New System.Windows.Forms.SplitContainer()
        Me.SrchF_fighter_1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.SrchF_fighter_2 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.SrchF_Fightbutton = New System.Windows.Forms.Button()
        Me.SrchF_ChoixB = New System.Windows.Forms.ComboBox()
        Me.SrchF_ChoixA = New System.Windows.Forms.ComboBox()
        Me.SrchF_Searchbox = New System.Windows.Forms.TextBox()
        Me.SrchF_Back = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SrchF_Line = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ABlueflap_Verrouillage = New System.Windows.Forms.Panel()
        Me.Verr_BlackEffect = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Verr_Date = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Verr_Textbox = New System.Windows.Forms.TextBox()
        Me.Verr_AcceptButt = New System.Windows.Forms.Button()
        Me.Verr_Time = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Verr_WrongMp = New System.Windows.Forms.Label()
        Me.ABlueflap_Infos = New System.Windows.Forms.Panel()
        Me.Infos_code_source = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Infos_Save = New System.Windows.Forms.Button()
        Me.Infos_Print = New System.Windows.Forms.Button()
        Me.Infos_Loading = New System.Windows.Forms.Label()
        Me.Infos_Loader = New System.Windows.Forms.PictureBox()
        Me.Infos_Trident_Browser_Recup_Infos = New System.Windows.Forms.WebBrowser()
        Me.Infos_CodeShowHide = New System.Windows.Forms.Button()
        Me.Infos_back = New System.Windows.Forms.Button()
        Me.Infos_Adresse = New System.Windows.Forms.Label()
        Me.Infos_Titre = New System.Windows.Forms.Label()
        Me.Infos_Share = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.WebSessionProvider1 = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ABlueflap_Bluestart = New System.Windows.Forms.Panel()
        Me.BS_Fav = New System.Windows.Forms.Button()
        Me.BS_Searchfight = New System.Windows.Forms.Button()
        Me.BS_Browser = New System.Windows.Forms.Button()
        Me.Bs_Favbulle = New System.Windows.Forms.Panel()
        Me.BS_Favlist = New System.Windows.Forms.ListBox()
        Me.BS_Date = New System.Windows.Forms.Label()
        Me.BS_SearchBlackEffect = New System.Windows.Forms.Panel()
        Me.BS_Searchbutton = New System.Windows.Forms.Button()
        Me.Bs_Searchbox = New System.Windows.Forms.TextBox()
        Me.BS_Settings = New System.Windows.Forms.Button()
        Me.BS_Optionsbulle = New System.Windows.Forms.Panel()
        Me.BS_DateSetColor = New System.Windows.Forms.Button()
        Me.BS_ImgChoose = New System.Windows.Forms.Button()
        Me.BS_Logo = New System.Windows.Forms.PictureBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ABlueflap_Navigateur.SuspendLayout()
        CType(Me.Notif_internet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fav_Panel.SuspendLayout()
        Me.fav_notif_suppr.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.FP_AdressbarPanel.SuspendLayout()
        Me.Notif_add.SuspendLayout()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.voletlateral.SuspendLayout()
        Me.Menua.SuspendLayout()
        Me.ABlueflap_Settings.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Sett_TabB.SuspendLayout()
        Me.Sett_TabC.SuspendLayout()
        Me.Sett_TabA.SuspendLayout()
        CType(Me.stng_picdemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StngmenuIcon4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ABlueflap_Fight.SuspendLayout()
        CType(Me.SrchF_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SrchF_Split.Panel1.SuspendLayout()
        Me.SrchF_Split.Panel2.SuspendLayout()
        Me.SrchF_Split.SuspendLayout()
        Me.ABlueflap_Verrouillage.SuspendLayout()
        Me.Verr_BlackEffect.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ABlueflap_Infos.SuspendLayout()
        CType(Me.Infos_code_source, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Infos_Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ABlueflap_Bluestart.SuspendLayout()
        Me.Bs_Favbulle.SuspendLayout()
        Me.BS_SearchBlackEffect.SuspendLayout()
        Me.BS_Optionsbulle.SuspendLayout()
        CType(Me.BS_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ABlueflap_Navigateur
        '
        Me.ABlueflap_Navigateur.Controls.Add(Me.Notif_internet)
        Me.ABlueflap_Navigateur.Controls.Add(Me.Web)
        Me.ABlueflap_Navigateur.Controls.Add(Me.Fav_Panel)
        Me.ABlueflap_Navigateur.Controls.Add(Me.FP_AdressbarPanel)
        Me.ABlueflap_Navigateur.Controls.Add(Me.voletlateral)
        Me.ABlueflap_Navigateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Navigateur.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Navigateur.Name = "ABlueflap_Navigateur"
        Me.ABlueflap_Navigateur.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Navigateur.TabIndex = 0
        '
        'Notif_internet
        '
        Me.Notif_internet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Notif_internet.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Notif_internet.Image = CType(resources.GetObject("Notif_internet.Image"), System.Drawing.Image)
        Me.Notif_internet.Location = New System.Drawing.Point(0, 526)
        Me.Notif_internet.Name = "Notif_internet"
        Me.Notif_internet.Size = New System.Drawing.Size(220, 81)
        Me.Notif_internet.TabIndex = 4
        Me.Notif_internet.TabStop = False
        Me.Notif_internet.Visible = False
        '
        'Web
        '
        Me.Web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Web.Location = New System.Drawing.Point(160, 28)
        Me.Web.Size = New System.Drawing.Size(725, 579)
        Me.Web.TabIndex = 7
        '
        'Fav_Panel
        '
        Me.Fav_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Fav_Panel.Controls.Add(Me.Fav_Histotab)
        Me.Fav_Panel.Controls.Add(Me.Fav_Favtab)
        Me.Fav_Panel.Controls.Add(Me.Fav_Historique_List)
        Me.Fav_Panel.Controls.Add(Me.fav_notif_suppr)
        Me.Fav_Panel.Controls.Add(Me.Fav_Close)
        Me.Fav_Panel.Controls.Add(Me.Fav_fav_List)
        Me.Fav_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Fav_Panel.Location = New System.Drawing.Point(885, 28)
        Me.Fav_Panel.Name = "Fav_Panel"
        Me.Fav_Panel.Size = New System.Drawing.Size(232, 579)
        Me.Fav_Panel.TabIndex = 5
        Me.Fav_Panel.Visible = False
        '
        'Fav_Histotab
        '
        Me.Fav_Histotab.Checked = True
        Me.Fav_Histotab.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Fav_Histotab.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Fav_Histotab.LineColorChecked = System.Drawing.Color.DeepSkyBlue
        Me.Fav_Histotab.LineColorHover = System.Drawing.Color.DeepSkyBlue
        Me.Fav_Histotab.LineSize = 4
        Me.Fav_Histotab.Location = New System.Drawing.Point(87, 6)
        Me.Fav_Histotab.Name = "Fav_Histotab"
        Me.Fav_Histotab.Size = New System.Drawing.Size(79, 39)
        Me.Fav_Histotab.TabIndex = 9
        Me.Fav_Histotab.Text = "Historique"
        '
        'Fav_Favtab
        '
        Me.Fav_Favtab.Checked = True
        Me.Fav_Favtab.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Fav_Favtab.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Fav_Favtab.LineColorChecked = System.Drawing.Color.SteelBlue
        Me.Fav_Favtab.LineColorHover = System.Drawing.Color.DeepSkyBlue
        Me.Fav_Favtab.LineSize = 4
        Me.Fav_Favtab.Location = New System.Drawing.Point(6, 6)
        Me.Fav_Favtab.Name = "Fav_Favtab"
        Me.Fav_Favtab.Size = New System.Drawing.Size(75, 39)
        Me.Fav_Favtab.TabIndex = 8
        Me.Fav_Favtab.Text = "Favoris"
        '
        'Fav_Historique_List
        '
        Me.Fav_Historique_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fav_Historique_List.BackColor = System.Drawing.SystemColors.Control
        Me.Fav_Historique_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Fav_Historique_List.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Fav_Historique_List.FormattingEnabled = True
        Me.Fav_Historique_List.HorizontalScrollbar = True
        Me.Fav_Historique_List.ItemHeight = 15
        Me.Fav_Historique_List.Location = New System.Drawing.Point(0, 56)
        Me.Fav_Historique_List.Name = "Fav_Historique_List"
        Me.Fav_Historique_List.ScrollAlwaysVisible = True
        Me.Fav_Historique_List.Size = New System.Drawing.Size(232, 525)
        Me.Fav_Historique_List.TabIndex = 5
        Me.Fav_Historique_List.Visible = False
        '
        'fav_notif_suppr
        '
        Me.fav_notif_suppr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fav_notif_suppr.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fav_notif_suppr.Controls.Add(Me.Fav_Cancel)
        Me.fav_notif_suppr.Controls.Add(Me.Fav_Confirm)
        Me.fav_notif_suppr.Controls.Add(Me.Fav_Notif_Text)
        Me.fav_notif_suppr.Location = New System.Drawing.Point(0, 500)
        Me.fav_notif_suppr.Name = "fav_notif_suppr"
        Me.fav_notif_suppr.Size = New System.Drawing.Size(232, 81)
        Me.fav_notif_suppr.TabIndex = 1
        Me.fav_notif_suppr.Visible = False
        '
        'Fav_Cancel
        '
        Me.Fav_Cancel.Location = New System.Drawing.Point(109, 40)
        Me.Fav_Cancel.Name = "Fav_Cancel"
        Me.Fav_Cancel.Size = New System.Drawing.Size(94, 29)
        Me.Fav_Cancel.TabIndex = 2
        Me.Fav_Cancel.Text = "Annuler"
        Me.Fav_Cancel.UseVisualStyleBackColor = True
        '
        'Fav_Confirm
        '
        Me.Fav_Confirm.Location = New System.Drawing.Point(9, 40)
        Me.Fav_Confirm.Name = "Fav_Confirm"
        Me.Fav_Confirm.Size = New System.Drawing.Size(94, 29)
        Me.Fav_Confirm.TabIndex = 1
        Me.Fav_Confirm.Text = "Confirmer"
        Me.Fav_Confirm.UseVisualStyleBackColor = True
        '
        'Fav_Notif_Text
        '
        Me.Fav_Notif_Text.AutoSize = True
        Me.Fav_Notif_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Fav_Notif_Text.ForeColor = System.Drawing.Color.White
        Me.Fav_Notif_Text.Location = New System.Drawing.Point(6, 10)
        Me.Fav_Notif_Text.Name = "Fav_Notif_Text"
        Me.Fav_Notif_Text.Size = New System.Drawing.Size(143, 17)
        Me.Fav_Notif_Text.TabIndex = 0
        Me.Fav_Notif_Text.Text = "Supprimer ce favori ?"
        '
        'Fav_Close
        '
        Me.Fav_Close.BackgroundImage = CType(resources.GetObject("Fav_Close.BackgroundImage"), System.Drawing.Image)
        Me.Fav_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fav_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fav_Close.ForeColor = System.Drawing.SystemColors.Control
        Me.Fav_Close.Location = New System.Drawing.Point(210, 3)
        Me.Fav_Close.Name = "Fav_Close"
        Me.Fav_Close.Size = New System.Drawing.Size(19, 19)
        Me.Fav_Close.TabIndex = 3
        Me.Fav_Close.UseVisualStyleBackColor = True
        '
        'Fav_fav_List
        '
        Me.Fav_fav_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fav_fav_List.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Fav_fav_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Fav_fav_List.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Fav_fav_List.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fav_fav_List.FormattingEnabled = True
        Me.Fav_fav_List.HorizontalScrollbar = True
        Me.Fav_fav_List.ItemHeight = 15
        Me.Fav_fav_List.Location = New System.Drawing.Point(0, 56)
        Me.Fav_fav_List.Name = "Fav_fav_List"
        Me.Fav_fav_List.ScrollAlwaysVisible = True
        Me.Fav_fav_List.Size = New System.Drawing.Size(232, 525)
        Me.Fav_fav_List.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.AccéderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 52)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = CType(resources.GetObject("SupprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupprimerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'AccéderToolStripMenuItem
        '
        Me.AccéderToolStripMenuItem.Image = CType(resources.GetObject("AccéderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccéderToolStripMenuItem.Name = "AccéderToolStripMenuItem"
        Me.AccéderToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.AccéderToolStripMenuItem.Text = "Accéder"
        '
        'FP_AdressbarPanel
        '
        Me.FP_AdressbarPanel.BackColor = System.Drawing.SystemColors.Control
        Me.FP_AdressbarPanel.Controls.Add(Me.Notif_add)
        Me.FP_AdressbarPanel.Controls.Add(Me.Loader)
        Me.FP_AdressbarPanel.Controls.Add(Me.AddFavo_Button)
        Me.FP_AdressbarPanel.Controls.Add(Me.GoButton)
        Me.FP_AdressbarPanel.Controls.Add(Me.SmartAdressbox)
        Me.FP_AdressbarPanel.Controls.Add(Me.Menu_ShowHide_Button)
        Me.FP_AdressbarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FP_AdressbarPanel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FP_AdressbarPanel.Location = New System.Drawing.Point(160, 0)
        Me.FP_AdressbarPanel.Name = "FP_AdressbarPanel"
        Me.FP_AdressbarPanel.Size = New System.Drawing.Size(957, 28)
        Me.FP_AdressbarPanel.TabIndex = 2
        '
        'Notif_add
        '
        Me.Notif_add.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Notif_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Notif_add.Controls.Add(Me.Notiff_add_OKbutton)
        Me.Notif_add.Controls.Add(Me.Notiff_add_Text)
        Me.Notif_add.Location = New System.Drawing.Point(53, 5)
        Me.Notif_add.Name = "Notif_add"
        Me.Notif_add.Size = New System.Drawing.Size(246, 18)
        Me.Notif_add.TabIndex = 6
        Me.Notif_add.Visible = False
        '
        'Notiff_add_OKbutton
        '
        Me.Notiff_add_OKbutton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Notiff_add_OKbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Notiff_add_OKbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Notiff_add_OKbutton.FlatAppearance.BorderSize = 0
        Me.Notiff_add_OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Notiff_add_OKbutton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Notiff_add_OKbutton.Location = New System.Drawing.Point(216, -1)
        Me.Notiff_add_OKbutton.Name = "Notiff_add_OKbutton"
        Me.Notiff_add_OKbutton.Size = New System.Drawing.Size(30, 21)
        Me.Notiff_add_OKbutton.TabIndex = 1
        Me.Notiff_add_OKbutton.Text = "OK"
        Me.Notiff_add_OKbutton.UseVisualStyleBackColor = False
        '
        'Notiff_add_Text
        '
        Me.Notiff_add_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Notiff_add_Text.AutoSize = True
        Me.Notiff_add_Text.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Notiff_add_Text.ForeColor = System.Drawing.Color.White
        Me.Notiff_add_Text.Location = New System.Drawing.Point(3, -1)
        Me.Notiff_add_Text.Name = "Notiff_add_Text"
        Me.Notiff_add_Text.Size = New System.Drawing.Size(163, 19)
        Me.Notiff_add_Text.TabIndex = 0
        Me.Notiff_add_Text.Text = "Page déjà dans vos favoris"
        '
        'Loader
        '
        Me.Loader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Loader.Image = CType(resources.GetObject("Loader.Image"), System.Drawing.Image)
        Me.Loader.Location = New System.Drawing.Point(904, 10)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(24, 8)
        Me.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Loader.TabIndex = 6
        Me.Loader.TabStop = False
        Me.Loader.Visible = False
        '
        'AddFavo_Button
        '
        Me.AddFavo_Button.BackColor = System.Drawing.SystemColors.Control
        Me.AddFavo_Button.BackgroundImage = CType(resources.GetObject("AddFavo_Button.BackgroundImage"), System.Drawing.Image)
        Me.AddFavo_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AddFavo_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.AddFavo_Button.FlatAppearance.BorderSize = 0
        Me.AddFavo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFavo_Button.ForeColor = System.Drawing.SystemColors.Control
        Me.AddFavo_Button.Location = New System.Drawing.Point(34, 4)
        Me.AddFavo_Button.Name = "AddFavo_Button"
        Me.AddFavo_Button.Size = New System.Drawing.Size(20, 20)
        Me.AddFavo_Button.TabIndex = 5
        Me.AddFavo_Button.Text = " "
        Me.AddFavo_Button.UseVisualStyleBackColor = False
        '
        'GoButton
        '
        Me.GoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoButton.BackColor = System.Drawing.Color.White
        Me.GoButton.FlatAppearance.BorderSize = 0
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoButton.ForeColor = System.Drawing.Color.White
        Me.GoButton.Image = CType(resources.GetObject("GoButton.Image"), System.Drawing.Image)
        Me.GoButton.Location = New System.Drawing.Point(934, 5)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(18, 18)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = " "
        Me.GoButton.UseVisualStyleBackColor = False
        '
        'SmartAdressbox
        '
        Me.SmartAdressbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmartAdressbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SmartAdressbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SmartAdressbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.SmartAdressbox.Location = New System.Drawing.Point(53, 4)
        Me.SmartAdressbox.Name = "SmartAdressbox"
        Me.SmartAdressbox.Size = New System.Drawing.Size(900, 20)
        Me.SmartAdressbox.TabIndex = 1
        Me.SmartAdressbox.Text = "about:blank"
        '
        'Menu_ShowHide_Button
        '
        Me.Menu_ShowHide_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Menu_ShowHide_Button.BackColor = System.Drawing.Color.Transparent
        Me.Menu_ShowHide_Button.FlatAppearance.BorderSize = 0
        Me.Menu_ShowHide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu_ShowHide_Button.ForeColor = System.Drawing.SystemColors.Control
        Me.Menu_ShowHide_Button.Image = CType(resources.GetObject("Menu_ShowHide_Button.Image"), System.Drawing.Image)
        Me.Menu_ShowHide_Button.Location = New System.Drawing.Point(1, 0)
        Me.Menu_ShowHide_Button.Name = "Menu_ShowHide_Button"
        Me.Menu_ShowHide_Button.Size = New System.Drawing.Size(28, 28)
        Me.Menu_ShowHide_Button.TabIndex = 0
        Me.Menu_ShowHide_Button.TabStop = False
        Me.Menu_ShowHide_Button.Text = " "
        Me.Menu_ShowHide_Button.UseVisualStyleBackColor = False
        '
        'voletlateral
        '
        Me.voletlateral.AllowItemReorder = True
        Me.voletlateral.AutoSize = False
        Me.voletlateral.BackColor = System.Drawing.Color.White
        Me.voletlateral.BackgroundImage = CType(resources.GetObject("voletlateral.BackgroundImage"), System.Drawing.Image)
        Me.voletlateral.ContextMenuStrip = Me.Menua
        Me.voletlateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.voletlateral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Home, Me.Menu_Back, Me.Menu_Forward, Me.Menu_Stop, Me.Menu_Refresh, Me.Menu_Fight, Me.Menu_Favos, Me.Menu_Share, Me.menu_partage, Me.Menu_Settings, Me.Menu_Lock, Me.Menu_FullScr, Me.Menu_Memo})
        Me.voletlateral.Location = New System.Drawing.Point(0, 0)
        Me.voletlateral.Name = "voletlateral"
        Me.voletlateral.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.voletlateral.Size = New System.Drawing.Size(160, 607)
        Me.voletlateral.TabIndex = 1
        Me.voletlateral.Text = "MenuStrip1"
        '
        'Menua
        '
        Me.Menua.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Menua.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.Menua.Name = "Menu"
        Me.Menua.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Menua.Size = New System.Drawing.Size(160, 28)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 24)
        Me.ToolStripMenuItem2.Text = "Signaler un bug"
        '
        'Menu_Home
        '
        Me.Menu_Home.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Home.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Home.Image = CType(resources.GetObject("Menu_Home.Image"), System.Drawing.Image)
        Me.Menu_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Home.Name = "Menu_Home"
        Me.Menu_Home.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Home.Text = "Accueil"
        '
        'Menu_Back
        '
        Me.Menu_Back.Enabled = False
        Me.Menu_Back.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Back.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Back.Image = CType(resources.GetObject("Menu_Back.Image"), System.Drawing.Image)
        Me.Menu_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Back.Name = "Menu_Back"
        Me.Menu_Back.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Back.Text = "Précédent"
        '
        'Menu_Forward
        '
        Me.Menu_Forward.Enabled = False
        Me.Menu_Forward.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Forward.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Forward.Image = CType(resources.GetObject("Menu_Forward.Image"), System.Drawing.Image)
        Me.Menu_Forward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Forward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Forward.Name = "Menu_Forward"
        Me.Menu_Forward.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Forward.Text = "Suivant"
        '
        'Menu_Stop
        '
        Me.Menu_Stop.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Stop.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Stop.Image = CType(resources.GetObject("Menu_Stop.Image"), System.Drawing.Image)
        Me.Menu_Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Stop.Name = "Menu_Stop"
        Me.Menu_Stop.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Stop.Text = "Arrêter"
        Me.Menu_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Stop.Visible = False
        '
        'Menu_Refresh
        '
        Me.Menu_Refresh.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Refresh.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Refresh.Image = CType(resources.GetObject("Menu_Refresh.Image"), System.Drawing.Image)
        Me.Menu_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Refresh.Name = "Menu_Refresh"
        Me.Menu_Refresh.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Menu_Refresh.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Refresh.Text = "Actualiser"
        '
        'Menu_Fight
        '
        Me.Menu_Fight.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Fight.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Fight.Image = CType(resources.GetObject("Menu_Fight.Image"), System.Drawing.Image)
        Me.Menu_Fight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Fight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Fight.Name = "Menu_Fight"
        Me.Menu_Fight.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.Menu_Fight.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Fight.Text = "Search Fight"
        '
        'Menu_Favos
        '
        Me.Menu_Favos.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Favos.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Favos.Image = CType(resources.GetObject("Menu_Favos.Image"), System.Drawing.Image)
        Me.Menu_Favos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Favos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Favos.Name = "Menu_Favos"
        Me.Menu_Favos.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Favos.Text = "Favoris"
        '
        'Menu_Share
        '
        Me.Menu_Share.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Share.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Share.Image = CType(resources.GetObject("Menu_Share.Image"), System.Drawing.Image)
        Me.Menu_Share.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Share.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Share.Name = "Menu_Share"
        Me.Menu_Share.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Menu_Share.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Share.Text = "Informations"
        '
        'menu_partage
        '
        Me.menu_partage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacebookToolStripMenuItem, Me.TwitterToolStripMenuItem})
        Me.menu_partage.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_partage.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.menu_partage.Image = CType(resources.GetObject("menu_partage.Image"), System.Drawing.Image)
        Me.menu_partage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_partage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_partage.Name = "menu_partage"
        Me.menu_partage.Size = New System.Drawing.Size(153, 24)
        Me.menu_partage.Text = "Partager"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FacebookToolStripMenuItem.Image = CType(resources.GetObject("FacebookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacebookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.FacebookToolStripMenuItem.Text = "Facebook"
        '
        'TwitterToolStripMenuItem
        '
        Me.TwitterToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TwitterToolStripMenuItem.Image = CType(resources.GetObject("TwitterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TwitterToolStripMenuItem.Name = "TwitterToolStripMenuItem"
        Me.TwitterToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.TwitterToolStripMenuItem.Text = "Twitter"
        '
        'Menu_Settings
        '
        Me.Menu_Settings.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Settings.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Settings.Image = CType(resources.GetObject("Menu_Settings.Image"), System.Drawing.Image)
        Me.Menu_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Settings.Name = "Menu_Settings"
        Me.Menu_Settings.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Settings.Text = "Paramètres"
        '
        'Menu_Lock
        '
        Me.Menu_Lock.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Lock.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Lock.Image = CType(resources.GetObject("Menu_Lock.Image"), System.Drawing.Image)
        Me.Menu_Lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Lock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Lock.Name = "Menu_Lock"
        Me.Menu_Lock.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Lock.Text = "Verrouiller"
        '
        'Menu_FullScr
        '
        Me.Menu_FullScr.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_FullScr.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_FullScr.Image = CType(resources.GetObject("Menu_FullScr.Image"), System.Drawing.Image)
        Me.Menu_FullScr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_FullScr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_FullScr.Name = "Menu_FullScr"
        Me.Menu_FullScr.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.Menu_FullScr.Size = New System.Drawing.Size(153, 24)
        Me.Menu_FullScr.Text = "Plein écran"
        '
        'Menu_Memo
        '
        Me.Menu_Memo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Memo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Menu_Memo.Image = CType(resources.GetObject("Menu_Memo.Image"), System.Drawing.Image)
        Me.Menu_Memo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Memo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_Memo.Name = "Menu_Memo"
        Me.Menu_Memo.Size = New System.Drawing.Size(153, 24)
        Me.Menu_Memo.Text = "Post-It"
        Me.Menu_Memo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ABlueflap_Settings
        '
        Me.ABlueflap_Settings.AutoScrollMargin = New System.Drawing.Size(15, 15)
        Me.ABlueflap_Settings.Controls.Add(Me.Stng_Helpcenter)
        Me.ABlueflap_Settings.Controls.Add(Me.Panel3)
        Me.ABlueflap_Settings.Controls.Add(Me.sett_tab3)
        Me.ABlueflap_Settings.Controls.Add(Me.sett_tab2)
        Me.ABlueflap_Settings.Controls.Add(Me.sett_tab1)
        Me.ABlueflap_Settings.Controls.Add(Me.Settings_Back)
        Me.ABlueflap_Settings.Controls.Add(Me.Settings_title)
        Me.ABlueflap_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Settings.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Settings.Name = "ABlueflap_Settings"
        Me.ABlueflap_Settings.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Settings.TabIndex = 1
        '
        'Stng_Helpcenter
        '
        Me.Stng_Helpcenter.Checked = True
        Me.Stng_Helpcenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Stng_Helpcenter.ForeColor = System.Drawing.Color.SkyBlue
        Me.Stng_Helpcenter.LineColorChecked = System.Drawing.Color.SkyBlue
        Me.Stng_Helpcenter.LineColorHover = System.Drawing.Color.SkyBlue
        Me.Stng_Helpcenter.LineSize = 4
        Me.Stng_Helpcenter.Location = New System.Drawing.Point(775, 49)
        Me.Stng_Helpcenter.Name = "Stng_Helpcenter"
        Me.Stng_Helpcenter.Size = New System.Drawing.Size(104, 43)
        Me.Stng_Helpcenter.TabIndex = 61
        Me.Stng_Helpcenter.Text = "Help Center"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Sett_TabA)
        Me.Panel3.Controls.Add(Me.Sett_TabC)
        Me.Panel3.Controls.Add(Me.Sett_TabB)
        Me.Panel3.Location = New System.Drawing.Point(0, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1117, 491)
        Me.Panel3.TabIndex = 60
        '
        'Sett_TabB
        '
        Me.Sett_TabB.Controls.Add(Me.stng_Smartsuggestactif)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Suggest)
        Me.Sett_TabB.Controls.Add(Me.Stng_ResetSuggest)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Network)
        Me.Sett_TabB.Controls.Add(Me.stng_nevpriv)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Private)
        Me.Sett_TabB.Controls.Add(Me.Button1)
        Me.Sett_TabB.Controls.Add(Me.Stng_OptionsInternet)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Data)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Extra)
        Me.Sett_TabB.Controls.Add(Me.Stng_SupprHisto)
        Me.Sett_TabB.Controls.Add(Me.Stng_SupprCacheCookies)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_NetworkInfo)
        Me.Sett_TabB.Controls.Add(Me.StngLabel_Proxy)
        Me.Sett_TabB.Location = New System.Drawing.Point(87, 15)
        Me.Sett_TabB.Name = "Sett_TabB"
        Me.Sett_TabB.Size = New System.Drawing.Size(925, 349)
        Me.Sett_TabB.TabIndex = 58
        Me.Sett_TabB.Visible = False
        '
        'stng_Smartsuggestactif
        '
        Me.stng_Smartsuggestactif.AutoSize = True
        Me.stng_Smartsuggestactif.Checked = Global.Blueflap.My.MySettings.Default.Smartsuggest
        Me.stng_Smartsuggestactif.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Smartsuggest", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.stng_Smartsuggestactif.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.stng_Smartsuggestactif.Location = New System.Drawing.Point(277, 69)
        Me.stng_Smartsuggestactif.Name = "stng_Smartsuggestactif"
        Me.stng_Smartsuggestactif.Size = New System.Drawing.Size(61, 21)
        Me.stng_Smartsuggestactif.TabIndex = 53
        Me.stng_Smartsuggestactif.Text = "Activé"
        Me.stng_Smartsuggestactif.UseVisualStyleBackColor = True
        '
        'StngLabel_Suggest
        '
        Me.StngLabel_Suggest.AutoSize = True
        Me.StngLabel_Suggest.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Suggest.Location = New System.Drawing.Point(14, 68)
        Me.StngLabel_Suggest.Name = "StngLabel_Suggest"
        Me.StngLabel_Suggest.Size = New System.Drawing.Size(101, 20)
        Me.StngLabel_Suggest.TabIndex = 52
        Me.StngLabel_Suggest.Text = "SmartSuggest"
        '
        'Stng_ResetSuggest
        '
        Me.Stng_ResetSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_ResetSuggest.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_ResetSuggest.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Stng_ResetSuggest.Location = New System.Drawing.Point(163, 61)
        Me.Stng_ResetSuggest.Name = "Stng_ResetSuggest"
        Me.Stng_ResetSuggest.Size = New System.Drawing.Size(104, 35)
        Me.Stng_ResetSuggest.TabIndex = 51
        Me.Stng_ResetSuggest.Text = "Réinitialiser"
        Me.Stng_ResetSuggest.UseVisualStyleBackColor = True
        '
        'StngLabel_Network
        '
        Me.StngLabel_Network.AutoSize = True
        Me.StngLabel_Network.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Network.Location = New System.Drawing.Point(14, 121)
        Me.StngLabel_Network.Name = "StngLabel_Network"
        Me.StngLabel_Network.Size = New System.Drawing.Size(56, 20)
        Me.StngLabel_Network.TabIndex = 50
        Me.StngLabel_Network.Text = "Réseau"
        '
        'stng_nevpriv
        '
        Me.stng_nevpriv.AutoSize = True
        Me.stng_nevpriv.Checked = Global.Blueflap.My.MySettings.Default.navprivee
        Me.stng_nevpriv.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "navprivee", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.stng_nevpriv.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.stng_nevpriv.Location = New System.Drawing.Point(163, 19)
        Me.stng_nevpriv.Name = "stng_nevpriv"
        Me.stng_nevpriv.Size = New System.Drawing.Size(68, 21)
        Me.stng_nevpriv.TabIndex = 49
        Me.stng_nevpriv.Text = "Activée"
        Me.stng_nevpriv.UseVisualStyleBackColor = True
        '
        'StngLabel_Private
        '
        Me.StngLabel_Private.AutoSize = True
        Me.StngLabel_Private.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Private.Location = New System.Drawing.Point(13, 18)
        Me.StngLabel_Private.Name = "StngLabel_Private"
        Me.StngLabel_Private.Size = New System.Drawing.Size(124, 20)
        Me.StngLabel_Private.TabIndex = 34
        Me.StngLabel_Private.Text = "Navigation privée"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Location = New System.Drawing.Point(163, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 25)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Signaler un bug"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Stng_OptionsInternet
        '
        Me.Stng_OptionsInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_OptionsInternet.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_OptionsInternet.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Stng_OptionsInternet.Location = New System.Drawing.Point(163, 114)
        Me.Stng_OptionsInternet.Name = "Stng_OptionsInternet"
        Me.Stng_OptionsInternet.Size = New System.Drawing.Size(154, 35)
        Me.Stng_OptionsInternet.TabIndex = 33
        Me.Stng_OptionsInternet.Text = "Options Internet"
        Me.Stng_OptionsInternet.UseVisualStyleBackColor = True
        '
        'StngLabel_Data
        '
        Me.StngLabel_Data.AutoSize = True
        Me.StngLabel_Data.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Data.Location = New System.Drawing.Point(14, 183)
        Me.StngLabel_Data.Name = "StngLabel_Data"
        Me.StngLabel_Data.Size = New System.Drawing.Size(66, 20)
        Me.StngLabel_Data.TabIndex = 40
        Me.StngLabel_Data.Text = "Données"
        '
        'StngLabel_Extra
        '
        Me.StngLabel_Extra.AutoSize = True
        Me.StngLabel_Extra.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Extra.Location = New System.Drawing.Point(13, 233)
        Me.StngLabel_Extra.Name = "StngLabel_Extra"
        Me.StngLabel_Extra.Size = New System.Drawing.Size(48, 20)
        Me.StngLabel_Extra.TabIndex = 46
        Me.StngLabel_Extra.Text = "Extras"
        '
        'Stng_SupprHisto
        '
        Me.Stng_SupprHisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_SupprHisto.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_SupprHisto.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Stng_SupprHisto.Location = New System.Drawing.Point(164, 174)
        Me.Stng_SupprHisto.Name = "Stng_SupprHisto"
        Me.Stng_SupprHisto.Size = New System.Drawing.Size(154, 35)
        Me.Stng_SupprHisto.TabIndex = 39
        Me.Stng_SupprHisto.Text = "Effacer l'historique"
        Me.Stng_SupprHisto.UseVisualStyleBackColor = True
        '
        'Stng_SupprCacheCookies
        '
        Me.Stng_SupprCacheCookies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_SupprCacheCookies.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_SupprCacheCookies.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Stng_SupprCacheCookies.Location = New System.Drawing.Point(323, 174)
        Me.Stng_SupprCacheCookies.Name = "Stng_SupprCacheCookies"
        Me.Stng_SupprCacheCookies.Size = New System.Drawing.Size(212, 35)
        Me.Stng_SupprCacheCookies.TabIndex = 42
        Me.Stng_SupprCacheCookies.Text = "Effacer les cookies et le cache"
        Me.Stng_SupprCacheCookies.UseVisualStyleBackColor = True
        '
        'StngLabel_NetworkInfo
        '
        Me.StngLabel_NetworkInfo.AutoSize = True
        Me.StngLabel_NetworkInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StngLabel_NetworkInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StngLabel_NetworkInfo.Location = New System.Drawing.Point(320, 130)
        Me.StngLabel_NetworkInfo.Name = "StngLabel_NetworkInfo"
        Me.StngLabel_NetworkInfo.Size = New System.Drawing.Size(183, 15)
        Me.StngLabel_NetworkInfo.TabIndex = 36
        Me.StngLabel_NetworkInfo.Text = "Cliquer sur l'onglet ""connexions"""
        '
        'StngLabel_Proxy
        '
        Me.StngLabel_Proxy.AutoSize = True
        Me.StngLabel_Proxy.ForeColor = System.Drawing.Color.Black
        Me.StngLabel_Proxy.Location = New System.Drawing.Point(320, 117)
        Me.StngLabel_Proxy.Name = "StngLabel_Proxy"
        Me.StngLabel_Proxy.Size = New System.Drawing.Size(371, 13)
        Me.StngLabel_Proxy.TabIndex = 35
        Me.StngLabel_Proxy.Text = "Blueflap utilise les paramètres proxy du système pour se connecter au réseau."
        '
        'Sett_TabC
        '
        Me.Sett_TabC.Controls.Add(Me.StngLabel_Contributeurs)
        Me.Sett_TabC.Controls.Add(Me.Stng_Bat41)
        Me.Sett_TabC.Controls.Add(Me.Stng_BaptGuil)
        Me.Sett_TabC.Controls.Add(Me.Stng_Zyhou)
        Me.Sett_TabC.Controls.Add(Me.StngLabel_OpenSource)
        Me.Sett_TabC.Controls.Add(Me.StngLabel_Version)
        Me.Sett_TabC.Controls.Add(Me.stng_github)
        Me.Sett_TabC.Controls.Add(Me.StngLabel_Devs)
        Me.Sett_TabC.Controls.Add(Me.stng_simpleworld)
        Me.Sett_TabC.Controls.Add(Me.StngLabel_Contribute)
        Me.Sett_TabC.Controls.Add(Me.Stng_VersionSystem)
        Me.Sett_TabC.Controls.Add(Me.Stng_ShowLicense)
        Me.Sett_TabC.Location = New System.Drawing.Point(87, 15)
        Me.Sett_TabC.Name = "Sett_TabC"
        Me.Sett_TabC.Size = New System.Drawing.Size(798, 368)
        Me.Sett_TabC.TabIndex = 59
        Me.Sett_TabC.Visible = False
        '
        'StngLabel_Contributeurs
        '
        Me.StngLabel_Contributeurs.AutoSize = True
        Me.StngLabel_Contributeurs.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Contributeurs.Location = New System.Drawing.Point(14, 171)
        Me.StngLabel_Contributeurs.Name = "StngLabel_Contributeurs"
        Me.StngLabel_Contributeurs.Size = New System.Drawing.Size(97, 20)
        Me.StngLabel_Contributeurs.TabIndex = 58
        Me.StngLabel_Contributeurs.Text = "Contributeurs"
        '
        'Stng_Bat41
        '
        Me.Stng_Bat41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_Bat41.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_Bat41.ForeColor = System.Drawing.Color.DarkGray
        Me.Stng_Bat41.Location = New System.Drawing.Point(270, 164)
        Me.Stng_Bat41.Name = "Stng_Bat41"
        Me.Stng_Bat41.Size = New System.Drawing.Size(57, 35)
        Me.Stng_Bat41.TabIndex = 57
        Me.Stng_Bat41.Text = "Bat41"
        Me.Stng_Bat41.UseVisualStyleBackColor = True
        '
        'Stng_BaptGuil
        '
        Me.Stng_BaptGuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_BaptGuil.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_BaptGuil.ForeColor = System.Drawing.Color.DarkGray
        Me.Stng_BaptGuil.Location = New System.Drawing.Point(164, 164)
        Me.Stng_BaptGuil.Name = "Stng_BaptGuil"
        Me.Stng_BaptGuil.Size = New System.Drawing.Size(100, 35)
        Me.Stng_BaptGuil.TabIndex = 56
        Me.Stng_BaptGuil.Text = "Baptisteguil "
        Me.Stng_BaptGuil.UseVisualStyleBackColor = True
        '
        'Stng_Zyhou
        '
        Me.Stng_Zyhou.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_Zyhou.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Stng_Zyhou.ForeColor = System.Drawing.Color.DarkGray
        Me.Stng_Zyhou.Location = New System.Drawing.Point(333, 164)
        Me.Stng_Zyhou.Name = "Stng_Zyhou"
        Me.Stng_Zyhou.Size = New System.Drawing.Size(73, 35)
        Me.Stng_Zyhou.TabIndex = 55
        Me.Stng_Zyhou.Text = "Zyhou"
        Me.Stng_Zyhou.UseVisualStyleBackColor = True
        '
        'StngLabel_OpenSource
        '
        Me.StngLabel_OpenSource.AutoSize = True
        Me.StngLabel_OpenSource.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_OpenSource.Location = New System.Drawing.Point(14, 222)
        Me.StngLabel_OpenSource.Name = "StngLabel_OpenSource"
        Me.StngLabel_OpenSource.Size = New System.Drawing.Size(90, 20)
        Me.StngLabel_OpenSource.TabIndex = 54
        Me.StngLabel_OpenSource.Text = "OpenSource"
        '
        'StngLabel_Version
        '
        Me.StngLabel_Version.AutoSize = True
        Me.StngLabel_Version.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Version.Location = New System.Drawing.Point(14, 18)
        Me.StngLabel_Version.Name = "StngLabel_Version"
        Me.StngLabel_Version.Size = New System.Drawing.Size(56, 20)
        Me.StngLabel_Version.TabIndex = 53
        Me.StngLabel_Version.Text = "Version"
        '
        'stng_github
        '
        Me.stng_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stng_github.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.stng_github.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.stng_github.Location = New System.Drawing.Point(164, 114)
        Me.stng_github.Name = "stng_github"
        Me.stng_github.Size = New System.Drawing.Size(154, 35)
        Me.stng_github.TabIndex = 52
        Me.stng_github.Text = "GitHub"
        Me.stng_github.UseVisualStyleBackColor = True
        '
        'StngLabel_Devs
        '
        Me.StngLabel_Devs.AutoSize = True
        Me.StngLabel_Devs.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Devs.Location = New System.Drawing.Point(14, 68)
        Me.StngLabel_Devs.Name = "StngLabel_Devs"
        Me.StngLabel_Devs.Size = New System.Drawing.Size(40, 20)
        Me.StngLabel_Devs.TabIndex = 49
        Me.StngLabel_Devs.Text = "Devs"
        '
        'stng_simpleworld
        '
        Me.stng_simpleworld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stng_simpleworld.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.stng_simpleworld.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.stng_simpleworld.Location = New System.Drawing.Point(163, 61)
        Me.stng_simpleworld.Name = "stng_simpleworld"
        Me.stng_simpleworld.Size = New System.Drawing.Size(154, 35)
        Me.stng_simpleworld.TabIndex = 50
        Me.stng_simpleworld.Text = "Simpleworld"
        Me.stng_simpleworld.UseVisualStyleBackColor = True
        '
        'StngLabel_Contribute
        '
        Me.StngLabel_Contribute.AutoSize = True
        Me.StngLabel_Contribute.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Contribute.Location = New System.Drawing.Point(14, 121)
        Me.StngLabel_Contribute.Name = "StngLabel_Contribute"
        Me.StngLabel_Contribute.Size = New System.Drawing.Size(78, 20)
        Me.StngLabel_Contribute.TabIndex = 51
        Me.StngLabel_Contribute.Text = "Contribuer"
        '
        'Stng_VersionSystem
        '
        Me.Stng_VersionSystem.AutoSize = True
        Me.Stng_VersionSystem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Stng_VersionSystem.Location = New System.Drawing.Point(160, 20)
        Me.Stng_VersionSystem.Name = "Stng_VersionSystem"
        Me.Stng_VersionSystem.Size = New System.Drawing.Size(97, 13)
        Me.Stng_VersionSystem.TabIndex = 19
        Me.Stng_VersionSystem.Text = "Blueflap 3.0 Beta 6"
        '
        'Stng_ShowLicense
        '
        Me.Stng_ShowLicense.FlatAppearance.BorderSize = 0
        Me.Stng_ShowLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stng_ShowLicense.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_ShowLicense.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Stng_ShowLicense.Location = New System.Drawing.Point(164, 219)
        Me.Stng_ShowLicense.Name = "Stng_ShowLicense"
        Me.Stng_ShowLicense.Size = New System.Drawing.Size(151, 28)
        Me.Stng_ShowLicense.TabIndex = 47
        Me.Stng_ShowLicense.Text = "Licence OpenSource"
        Me.Stng_ShowLicense.UseVisualStyleBackColor = True
        '
        'Sett_TabA
        '
        Me.Sett_TabA.AutoScroll = True
        Me.Sett_TabA.Controls.Add(Me.BackgroundChemin)
        Me.Sett_TabA.Controls.Add(Me.stng_picdemo)
        Me.Sett_TabA.Controls.Add(Me.Share_checkbox)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon5)
        Me.Sett_TabA.Controls.Add(Me.memo_checkbox)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon8)
        Me.Sett_TabA.Controls.Add(Me.Button2)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Background)
        Me.Sett_TabA.Controls.Add(Me.Stng_bluestart_checkbox)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Searchengine)
        Me.Sett_TabA.Controls.Add(Me.Stng_MoteurRecherche_choose)
        Me.Sett_TabA.Controls.Add(Me.Stng_MoteurRecherche_URL)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Home)
        Me.Sett_TabA.Controls.Add(Me.Stng_HomePage_Url)
        Me.Sett_TabA.Controls.Add(Me.Stng_ErreurURLHomepage)
        Me.Sett_TabA.Controls.Add(Me.Stng_Volet_reduire)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Lock)
        Me.Sett_TabA.Controls.Add(Me.Stng_MP)
        Me.Sett_TabA.Controls.Add(Me.Stng_MP_confirm)
        Me.Sett_TabA.Controls.Add(Me.Stng_MPActiv)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_MPConfirm)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_MP)
        Me.Sett_TabA.Controls.Add(Me.Stng_Volet_Mousehover_agrandir)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Interface)
        Me.Sett_TabA.Controls.Add(Me.StngLabel_Icons)
        Me.Sett_TabA.Controls.Add(Me.Stng_TouchUI)
        Me.Sett_TabA.Controls.Add(Me.Stng_MaximizedWindow)
        Me.Sett_TabA.Controls.Add(Me.Home_checkbox)
        Me.Sett_TabA.Controls.Add(Me.Sfight_Checkbox)
        Me.Sett_TabA.Controls.Add(Me.favo_checkbox)
        Me.Sett_TabA.Controls.Add(Me.infos_checkbox)
        Me.Sett_TabA.Controls.Add(Me.lock_checkbox)
        Me.Sett_TabA.Controls.Add(Me.fullscreen_checkbox)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon1)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon2)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon7)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon3)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon6)
        Me.Sett_TabA.Controls.Add(Me.StngmenuIcon4)
        Me.Sett_TabA.Controls.Add(Me.ShapeContainer3)
        Me.Sett_TabA.Location = New System.Drawing.Point(87, 15)
        Me.Sett_TabA.Name = "Sett_TabA"
        Me.Sett_TabA.Size = New System.Drawing.Size(1030, 410)
        Me.Sett_TabA.TabIndex = 57
        '
        'BackgroundChemin
        '
        Me.BackgroundChemin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BackgroundChemin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "Cheminback", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BackgroundChemin.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundChemin.ForeColor = System.Drawing.Color.DarkGray
        Me.BackgroundChemin.Location = New System.Drawing.Point(377, 304)
        Me.BackgroundChemin.Name = "BackgroundChemin"
        Me.BackgroundChemin.ReadOnly = True
        Me.BackgroundChemin.Size = New System.Drawing.Size(370, 15)
        Me.BackgroundChemin.TabIndex = 56
        Me.BackgroundChemin.Text = Global.Blueflap.My.MySettings.Default.Cheminback
        '
        'stng_picdemo
        '
        Me.stng_picdemo.BackColor = System.Drawing.SystemColors.Control
        Me.stng_picdemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stng_picdemo.Image = CType(resources.GetObject("stng_picdemo.Image"), System.Drawing.Image)
        Me.stng_picdemo.Location = New System.Drawing.Point(322, 292)
        Me.stng_picdemo.Name = "stng_picdemo"
        Me.stng_picdemo.Size = New System.Drawing.Size(46, 33)
        Me.stng_picdemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.stng_picdemo.TabIndex = 55
        Me.stng_picdemo.TabStop = False
        '
        'Share_checkbox
        '
        Me.Share_checkbox.AutoSize = True
        Me.Share_checkbox.Checked = Global.Blueflap.My.MySettings.Default.h
        Me.Share_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Share_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "h", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Share_checkbox.Location = New System.Drawing.Point(340, 238)
        Me.Share_checkbox.Name = "Share_checkbox"
        Me.Share_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Share_checkbox.TabIndex = 53
        Me.Share_checkbox.UseVisualStyleBackColor = True
        '
        'StngmenuIcon5
        '
        Me.StngmenuIcon5.Image = CType(resources.GetObject("StngmenuIcon5.Image"), System.Drawing.Image)
        Me.StngmenuIcon5.Location = New System.Drawing.Point(322, 237)
        Me.StngmenuIcon5.Name = "StngmenuIcon5"
        Me.StngmenuIcon5.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon5.TabIndex = 54
        Me.StngmenuIcon5.TabStop = False
        '
        'memo_checkbox
        '
        Me.memo_checkbox.AutoSize = True
        Me.memo_checkbox.Checked = Global.Blueflap.My.MySettings.Default.g
        Me.memo_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.memo_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "g", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.memo_checkbox.Location = New System.Drawing.Point(453, 238)
        Me.memo_checkbox.Name = "memo_checkbox"
        Me.memo_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.memo_checkbox.TabIndex = 51
        Me.memo_checkbox.UseVisualStyleBackColor = True
        '
        'StngmenuIcon8
        '
        Me.StngmenuIcon8.Image = CType(resources.GetObject("StngmenuIcon8.Image"), System.Drawing.Image)
        Me.StngmenuIcon8.Location = New System.Drawing.Point(436, 237)
        Me.StngmenuIcon8.Name = "StngmenuIcon8"
        Me.StngmenuIcon8.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon8.TabIndex = 52
        Me.StngmenuIcon8.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.Location = New System.Drawing.Point(161, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 35)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Changer l'image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StngLabel_Background
        '
        Me.StngLabel_Background.AutoSize = True
        Me.StngLabel_Background.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Background.Location = New System.Drawing.Point(14, 299)
        Me.StngLabel_Background.Name = "StngLabel_Background"
        Me.StngLabel_Background.Size = New System.Drawing.Size(106, 20)
        Me.StngLabel_Background.TabIndex = 49
        Me.StngLabel_Background.Text = "Image de fond"
        '
        'Stng_bluestart_checkbox
        '
        Me.Stng_bluestart_checkbox.AutoSize = True
        Me.Stng_bluestart_checkbox.Checked = Global.Blueflap.My.MySettings.Default.startou
        Me.Stng_bluestart_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "startou", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_bluestart_checkbox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Stng_bluestart_checkbox.Location = New System.Drawing.Point(449, 65)
        Me.Stng_bluestart_checkbox.Name = "Stng_bluestart_checkbox"
        Me.Stng_bluestart_checkbox.Size = New System.Drawing.Size(119, 21)
        Me.Stng_bluestart_checkbox.TabIndex = 44
        Me.Stng_bluestart_checkbox.Text = "Utiliser BlueStart"
        Me.Stng_bluestart_checkbox.UseVisualStyleBackColor = True
        '
        'StngLabel_Searchengine
        '
        Me.StngLabel_Searchengine.AutoSize = True
        Me.StngLabel_Searchengine.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Searchengine.Location = New System.Drawing.Point(13, 18)
        Me.StngLabel_Searchengine.Name = "StngLabel_Searchengine"
        Me.StngLabel_Searchengine.Size = New System.Drawing.Size(146, 20)
        Me.StngLabel_Searchengine.TabIndex = 2
        Me.StngLabel_Searchengine.Text = "Moteur de recherche"
        '
        'Stng_MoteurRecherche_choose
        '
        Me.Stng_MoteurRecherche_choose.AutoCompleteCustomSource.AddRange(New String() {"Google", "Bing", "Yahoo", "Youtube", "DuckDuckGo", "Wikipedia"})
        Me.Stng_MoteurRecherche_choose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Stng_MoteurRecherche_choose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Stng_MoteurRecherche_choose.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "NomMoteur", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_MoteurRecherche_choose.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_MoteurRecherche_choose.FormattingEnabled = True
        Me.Stng_MoteurRecherche_choose.Items.AddRange(New Object() {"Google", "Bing", "Yahoo", "Ask", "Youtube", "DuckDuckGo", "Wikipedia", "Qwant", "Github"})
        Me.Stng_MoteurRecherche_choose.Location = New System.Drawing.Point(165, 17)
        Me.Stng_MoteurRecherche_choose.Name = "Stng_MoteurRecherche_choose"
        Me.Stng_MoteurRecherche_choose.Size = New System.Drawing.Size(121, 25)
        Me.Stng_MoteurRecherche_choose.TabIndex = 3
        Me.Stng_MoteurRecherche_choose.Text = Global.Blueflap.My.MySettings.Default.NomMoteur
        '
        'Stng_MoteurRecherche_URL
        '
        Me.Stng_MoteurRecherche_URL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "Moteur", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_MoteurRecherche_URL.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_MoteurRecherche_URL.Location = New System.Drawing.Point(300, 17)
        Me.Stng_MoteurRecherche_URL.Name = "Stng_MoteurRecherche_URL"
        Me.Stng_MoteurRecherche_URL.Size = New System.Drawing.Size(449, 25)
        Me.Stng_MoteurRecherche_URL.TabIndex = 4
        Me.Stng_MoteurRecherche_URL.Text = Global.Blueflap.My.MySettings.Default.Moteur
        '
        'StngLabel_Home
        '
        Me.StngLabel_Home.AutoSize = True
        Me.StngLabel_Home.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Home.Location = New System.Drawing.Point(13, 64)
        Me.StngLabel_Home.Name = "StngLabel_Home"
        Me.StngLabel_Home.Size = New System.Drawing.Size(102, 20)
        Me.StngLabel_Home.TabIndex = 7
        Me.StngLabel_Home.Text = "Page d'accueil"
        '
        'Stng_HomePage_Url
        '
        Me.Stng_HomePage_Url.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "home", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_HomePage_Url.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Stng_HomePage_Url.Location = New System.Drawing.Point(165, 63)
        Me.Stng_HomePage_Url.Name = "Stng_HomePage_Url"
        Me.Stng_HomePage_Url.Size = New System.Drawing.Size(278, 25)
        Me.Stng_HomePage_Url.TabIndex = 8
        Me.Stng_HomePage_Url.Text = Global.Blueflap.My.MySettings.Default.home
        '
        'Stng_ErreurURLHomepage
        '
        Me.Stng_ErreurURLHomepage.AutoSize = True
        Me.Stng_ErreurURLHomepage.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_ErreurURLHomepage.ForeColor = System.Drawing.Color.DarkRed
        Me.Stng_ErreurURLHomepage.Location = New System.Drawing.Point(162, 86)
        Me.Stng_ErreurURLHomepage.Name = "Stng_ErreurURLHomepage"
        Me.Stng_ErreurURLHomepage.Size = New System.Drawing.Size(452, 17)
        Me.Stng_ErreurURLHomepage.TabIndex = 9
        Me.Stng_ErreurURLHomepage.Text = "Veuillez entrer une adresse valide (vérifiez la présence du [http://] ou [https:/" & _
    "/] )"
        Me.Stng_ErreurURLHomepage.Visible = False
        '
        'Stng_Volet_reduire
        '
        Me.Stng_Volet_reduire.AutoSize = True
        Me.Stng_Volet_reduire.Checked = Global.Blueflap.My.MySettings.Default.Réduit
        Me.Stng_Volet_reduire.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Réduit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_Volet_reduire.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Stng_Volet_reduire.Location = New System.Drawing.Point(312, 179)
        Me.Stng_Volet_reduire.Name = "Stng_Volet_reduire"
        Me.Stng_Volet_reduire.Size = New System.Drawing.Size(196, 19)
        Me.Stng_Volet_reduire.TabIndex = 10
        Me.Stng_Volet_reduire.Text = "Volet latéral réduit au démarrage"
        Me.Stng_Volet_reduire.UseVisualStyleBackColor = True
        '
        'StngLabel_Lock
        '
        Me.StngLabel_Lock.AutoSize = True
        Me.StngLabel_Lock.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Lock.Location = New System.Drawing.Point(13, 117)
        Me.StngLabel_Lock.Name = "StngLabel_Lock"
        Me.StngLabel_Lock.Size = New System.Drawing.Size(86, 20)
        Me.StngLabel_Lock.TabIndex = 11
        Me.StngLabel_Lock.Text = "Verrouillage"
        '
        'Stng_MP
        '
        Me.Stng_MP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "MP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_MP.Enabled = False
        Me.Stng_MP.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Stng_MP.Location = New System.Drawing.Point(245, 118)
        Me.Stng_MP.Name = "Stng_MP"
        Me.Stng_MP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Stng_MP.Size = New System.Drawing.Size(150, 25)
        Me.Stng_MP.TabIndex = 12
        Me.Stng_MP.Text = Global.Blueflap.My.MySettings.Default.MP
        '
        'Stng_MP_confirm
        '
        Me.Stng_MP_confirm.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Stng_MP_confirm.Location = New System.Drawing.Point(494, 118)
        Me.Stng_MP_confirm.Name = "Stng_MP_confirm"
        Me.Stng_MP_confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Stng_MP_confirm.Size = New System.Drawing.Size(151, 25)
        Me.Stng_MP_confirm.TabIndex = 13
        '
        'Stng_MPActiv
        '
        Me.Stng_MPActiv.AutoSize = True
        Me.Stng_MPActiv.Checked = Global.Blueflap.My.MySettings.Default.Verr_def
        Me.Stng_MPActiv.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Verr_def", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_MPActiv.Enabled = False
        Me.Stng_MPActiv.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Stng_MPActiv.Location = New System.Drawing.Point(669, 120)
        Me.Stng_MPActiv.Name = "Stng_MPActiv"
        Me.Stng_MPActiv.Size = New System.Drawing.Size(65, 21)
        Me.Stng_MPActiv.TabIndex = 14
        Me.Stng_MPActiv.Text = "Activer"
        Me.Stng_MPActiv.UseVisualStyleBackColor = True
        '
        'StngLabel_MPConfirm
        '
        Me.StngLabel_MPConfirm.AutoSize = True
        Me.StngLabel_MPConfirm.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.StngLabel_MPConfirm.Location = New System.Drawing.Point(413, 124)
        Me.StngLabel_MPConfirm.Name = "StngLabel_MPConfirm"
        Me.StngLabel_MPConfirm.Size = New System.Drawing.Size(75, 13)
        Me.StngLabel_MPConfirm.TabIndex = 15
        Me.StngLabel_MPConfirm.Text = "Retapez le MP"
        '
        'StngLabel_MP
        '
        Me.StngLabel_MP.AutoSize = True
        Me.StngLabel_MP.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.StngLabel_MP.Location = New System.Drawing.Point(170, 124)
        Me.StngLabel_MP.Name = "StngLabel_MP"
        Me.StngLabel_MP.Size = New System.Drawing.Size(72, 13)
        Me.StngLabel_MP.TabIndex = 16
        Me.StngLabel_MP.Text = "Définir un MP"
        '
        'Stng_Volet_Mousehover_agrandir
        '
        Me.Stng_Volet_Mousehover_agrandir.AutoSize = True
        Me.Stng_Volet_Mousehover_agrandir.Checked = Global.Blueflap.My.MySettings.Default.mousess
        Me.Stng_Volet_Mousehover_agrandir.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "mousess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_Volet_Mousehover_agrandir.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Stng_Volet_Mousehover_agrandir.Location = New System.Drawing.Point(312, 196)
        Me.Stng_Volet_Mousehover_agrandir.Name = "Stng_Volet_Mousehover_agrandir"
        Me.Stng_Volet_Mousehover_agrandir.Size = New System.Drawing.Size(224, 19)
        Me.Stng_Volet_Mousehover_agrandir.TabIndex = 43
        Me.Stng_Volet_Mousehover_agrandir.Text = "Agrandir volet au passage de la souris"
        Me.Stng_Volet_Mousehover_agrandir.UseVisualStyleBackColor = True
        Me.Stng_Volet_Mousehover_agrandir.Visible = False
        '
        'StngLabel_Interface
        '
        Me.StngLabel_Interface.AutoSize = True
        Me.StngLabel_Interface.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Interface.Location = New System.Drawing.Point(14, 176)
        Me.StngLabel_Interface.Name = "StngLabel_Interface"
        Me.StngLabel_Interface.Size = New System.Drawing.Size(66, 20)
        Me.StngLabel_Interface.TabIndex = 18
        Me.StngLabel_Interface.Text = "Interface"
        '
        'StngLabel_Icons
        '
        Me.StngLabel_Icons.AutoSize = True
        Me.StngLabel_Icons.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.StngLabel_Icons.Location = New System.Drawing.Point(13, 232)
        Me.StngLabel_Icons.Name = "StngLabel_Icons"
        Me.StngLabel_Icons.Size = New System.Drawing.Size(113, 20)
        Me.StngLabel_Icons.TabIndex = 20
        Me.StngLabel_Icons.Text = "Icônes du menu"
        '
        'Stng_TouchUI
        '
        Me.Stng_TouchUI.AutoSize = True
        Me.Stng_TouchUI.Checked = Global.Blueflap.My.MySettings.Default.Touchkeyboard
        Me.Stng_TouchUI.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Touchkeyboard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_TouchUI.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stng_TouchUI.Location = New System.Drawing.Point(165, 179)
        Me.Stng_TouchUI.Name = "Stng_TouchUI"
        Me.Stng_TouchUI.Size = New System.Drawing.Size(106, 19)
        Me.Stng_TouchUI.TabIndex = 37
        Me.Stng_TouchUI.Text = "Interface Tactile"
        Me.Stng_TouchUI.UseVisualStyleBackColor = True
        '
        'Stng_MaximizedWindow
        '
        Me.Stng_MaximizedWindow.AutoSize = True
        Me.Stng_MaximizedWindow.Checked = Global.Blueflap.My.MySettings.Default.Winstata
        Me.Stng_MaximizedWindow.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Winstata", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Stng_MaximizedWindow.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Stng_MaximizedWindow.Location = New System.Drawing.Point(545, 179)
        Me.Stng_MaximizedWindow.Name = "Stng_MaximizedWindow"
        Me.Stng_MaximizedWindow.Size = New System.Drawing.Size(189, 19)
        Me.Stng_MaximizedWindow.TabIndex = 41
        Me.Stng_MaximizedWindow.Text = "Fenêtre agrandie au démarrage"
        Me.Stng_MaximizedWindow.UseVisualStyleBackColor = True
        '
        'Home_checkbox
        '
        Me.Home_checkbox.AutoSize = True
        Me.Home_checkbox.Checked = Global.Blueflap.My.MySettings.Default.a
        Me.Home_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Home_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "a", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Home_checkbox.Location = New System.Drawing.Point(190, 238)
        Me.Home_checkbox.Name = "Home_checkbox"
        Me.Home_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Home_checkbox.TabIndex = 21
        Me.Home_checkbox.UseVisualStyleBackColor = True
        '
        'Sfight_Checkbox
        '
        Me.Sfight_Checkbox.AutoSize = True
        Me.Sfight_Checkbox.Checked = Global.Blueflap.My.MySettings.Default.b
        Me.Sfight_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Sfight_Checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "b", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Sfight_Checkbox.Location = New System.Drawing.Point(227, 238)
        Me.Sfight_Checkbox.Name = "Sfight_Checkbox"
        Me.Sfight_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Sfight_Checkbox.TabIndex = 22
        Me.Sfight_Checkbox.UseVisualStyleBackColor = True
        '
        'favo_checkbox
        '
        Me.favo_checkbox.AutoSize = True
        Me.favo_checkbox.Checked = Global.Blueflap.My.MySettings.Default.c
        Me.favo_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.favo_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.favo_checkbox.Location = New System.Drawing.Point(264, 238)
        Me.favo_checkbox.Name = "favo_checkbox"
        Me.favo_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.favo_checkbox.TabIndex = 23
        Me.favo_checkbox.UseVisualStyleBackColor = True
        '
        'infos_checkbox
        '
        Me.infos_checkbox.AutoSize = True
        Me.infos_checkbox.Checked = Global.Blueflap.My.MySettings.Default.d
        Me.infos_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.infos_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "d", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.infos_checkbox.Location = New System.Drawing.Point(301, 238)
        Me.infos_checkbox.Name = "infos_checkbox"
        Me.infos_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.infos_checkbox.TabIndex = 24
        Me.infos_checkbox.UseVisualStyleBackColor = True
        '
        'lock_checkbox
        '
        Me.lock_checkbox.AutoSize = True
        Me.lock_checkbox.Checked = Global.Blueflap.My.MySettings.Default.e
        Me.lock_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lock_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "e", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lock_checkbox.Location = New System.Drawing.Point(377, 238)
        Me.lock_checkbox.Name = "lock_checkbox"
        Me.lock_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.lock_checkbox.TabIndex = 25
        Me.lock_checkbox.UseVisualStyleBackColor = True
        '
        'fullscreen_checkbox
        '
        Me.fullscreen_checkbox.AutoSize = True
        Me.fullscreen_checkbox.Checked = Global.Blueflap.My.MySettings.Default.f
        Me.fullscreen_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fullscreen_checkbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "f", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.fullscreen_checkbox.Location = New System.Drawing.Point(415, 238)
        Me.fullscreen_checkbox.Name = "fullscreen_checkbox"
        Me.fullscreen_checkbox.Size = New System.Drawing.Size(15, 14)
        Me.fullscreen_checkbox.TabIndex = 26
        Me.fullscreen_checkbox.UseVisualStyleBackColor = True
        '
        'StngmenuIcon1
        '
        Me.StngmenuIcon1.Image = CType(resources.GetObject("StngmenuIcon1.Image"), System.Drawing.Image)
        Me.StngmenuIcon1.Location = New System.Drawing.Point(174, 237)
        Me.StngmenuIcon1.Name = "StngmenuIcon1"
        Me.StngmenuIcon1.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon1.TabIndex = 27
        Me.StngmenuIcon1.TabStop = False
        '
        'StngmenuIcon2
        '
        Me.StngmenuIcon2.Image = CType(resources.GetObject("StngmenuIcon2.Image"), System.Drawing.Image)
        Me.StngmenuIcon2.Location = New System.Drawing.Point(211, 237)
        Me.StngmenuIcon2.Name = "StngmenuIcon2"
        Me.StngmenuIcon2.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon2.TabIndex = 28
        Me.StngmenuIcon2.TabStop = False
        '
        'StngmenuIcon7
        '
        Me.StngmenuIcon7.Image = CType(resources.GetObject("StngmenuIcon7.Image"), System.Drawing.Image)
        Me.StngmenuIcon7.Location = New System.Drawing.Point(399, 237)
        Me.StngmenuIcon7.Name = "StngmenuIcon7"
        Me.StngmenuIcon7.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon7.TabIndex = 32
        Me.StngmenuIcon7.TabStop = False
        '
        'StngmenuIcon3
        '
        Me.StngmenuIcon3.Image = CType(resources.GetObject("StngmenuIcon3.Image"), System.Drawing.Image)
        Me.StngmenuIcon3.Location = New System.Drawing.Point(248, 237)
        Me.StngmenuIcon3.Name = "StngmenuIcon3"
        Me.StngmenuIcon3.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon3.TabIndex = 29
        Me.StngmenuIcon3.TabStop = False
        '
        'StngmenuIcon6
        '
        Me.StngmenuIcon6.Image = CType(resources.GetObject("StngmenuIcon6.Image"), System.Drawing.Image)
        Me.StngmenuIcon6.Location = New System.Drawing.Point(361, 237)
        Me.StngmenuIcon6.Name = "StngmenuIcon6"
        Me.StngmenuIcon6.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon6.TabIndex = 31
        Me.StngmenuIcon6.TabStop = False
        '
        'StngmenuIcon4
        '
        Me.StngmenuIcon4.Image = CType(resources.GetObject("StngmenuIcon4.Image"), System.Drawing.Image)
        Me.StngmenuIcon4.Location = New System.Drawing.Point(285, 237)
        Me.StngmenuIcon4.Name = "StngmenuIcon4"
        Me.StngmenuIcon4.Size = New System.Drawing.Size(15, 15)
        Me.StngmenuIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StngmenuIcon4.TabIndex = 30
        Me.StngmenuIcon4.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1030, 410)
        Me.ShapeContainer3.TabIndex = 44
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.RectangleShape2.Location = New System.Drawing.Point(164, 113)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(583, 34)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.RectangleShape1.Location = New System.Drawing.Point(164, 225)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(583, 36)
        '
        'sett_tab3
        '
        Me.sett_tab3.Checked = True
        Me.sett_tab3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sett_tab3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab3.LineColorChecked = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab3.LineColorHover = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab3.LineSize = 4
        Me.sett_tab3.Location = New System.Drawing.Point(628, 49)
        Me.sett_tab3.Name = "sett_tab3"
        Me.sett_tab3.Size = New System.Drawing.Size(104, 43)
        Me.sett_tab3.TabIndex = 56
        Me.sett_tab3.Text = "À propos"
        '
        'sett_tab2
        '
        Me.sett_tab2.Checked = True
        Me.sett_tab2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sett_tab2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab2.LineColorChecked = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab2.LineColorHover = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab2.LineSize = 4
        Me.sett_tab2.Location = New System.Drawing.Point(507, 49)
        Me.sett_tab2.Name = "sett_tab2"
        Me.sett_tab2.Size = New System.Drawing.Size(115, 43)
        Me.sett_tab2.TabIndex = 55
        Me.sett_tab2.Text = "Options avancées"
        '
        'sett_tab1
        '
        Me.sett_tab1.Checked = True
        Me.sett_tab1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sett_tab1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab1.LineColorChecked = System.Drawing.Color.SteelBlue
        Me.sett_tab1.LineColorHover = System.Drawing.Color.DeepSkyBlue
        Me.sett_tab1.LineSize = 4
        Me.sett_tab1.Location = New System.Drawing.Point(395, 49)
        Me.sett_tab1.Name = "sett_tab1"
        Me.sett_tab1.Size = New System.Drawing.Size(106, 43)
        Me.sett_tab1.TabIndex = 54
        Me.sett_tab1.Text = "Personnalisation"
        '
        'Settings_Back
        '
        Me.Settings_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_Back.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_Back.ForeColor = System.Drawing.SystemColors.Control
        Me.Settings_Back.Image = CType(resources.GetObject("Settings_Back.Image"), System.Drawing.Image)
        Me.Settings_Back.Location = New System.Drawing.Point(21, 46)
        Me.Settings_Back.Name = "Settings_Back"
        Me.Settings_Back.Size = New System.Drawing.Size(46, 46)
        Me.Settings_Back.TabIndex = 1
        Me.Settings_Back.Text = " "
        Me.Settings_Back.UseVisualStyleBackColor = True
        '
        'Settings_title
        '
        Me.Settings_title.AutoSize = True
        Me.Settings_title.Font = New System.Drawing.Font("Segoe UI Light", 43.0!)
        Me.Settings_title.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Settings_title.Location = New System.Drawing.Point(74, 26)
        Me.Settings_title.Name = "Settings_title"
        Me.Settings_title.Size = New System.Drawing.Size(303, 77)
        Me.Settings_title.TabIndex = 0
        Me.Settings_title.Text = "Paramètres"
        '
        'ABlueflap_Fight
        '
        Me.ABlueflap_Fight.Controls.Add(Me.SrchFight_AdvanceRight)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchFight_AdvanceLeft)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_AdvanceChoice)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_Actions)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_Split)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_Fightbutton)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_ChoixB)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_ChoixA)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_Searchbox)
        Me.ABlueflap_Fight.Controls.Add(Me.SrchF_Back)
        Me.ABlueflap_Fight.Controls.Add(Me.ShapeContainer2)
        Me.ABlueflap_Fight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Fight.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Fight.Name = "ABlueflap_Fight"
        Me.ABlueflap_Fight.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Fight.TabIndex = 2
        '
        'SrchFight_AdvanceRight
        '
        Me.SrchFight_AdvanceRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchFight_AdvanceRight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "SFAdvanceB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SrchFight_AdvanceRight.Location = New System.Drawing.Point(789, 30)
        Me.SrchFight_AdvanceRight.Name = "SrchFight_AdvanceRight"
        Me.SrchFight_AdvanceRight.Size = New System.Drawing.Size(189, 20)
        Me.SrchFight_AdvanceRight.TabIndex = 12
        Me.SrchFight_AdvanceRight.Text = Global.Blueflap.My.MySettings.Default.SFAdvanceB
        Me.SrchFight_AdvanceRight.Visible = False
        '
        'SrchFight_AdvanceLeft
        '
        Me.SrchFight_AdvanceLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchFight_AdvanceLeft.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "SFAdvanceA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SrchFight_AdvanceLeft.Location = New System.Drawing.Point(789, 8)
        Me.SrchFight_AdvanceLeft.Name = "SrchFight_AdvanceLeft"
        Me.SrchFight_AdvanceLeft.Size = New System.Drawing.Size(189, 20)
        Me.SrchFight_AdvanceLeft.TabIndex = 11
        Me.SrchFight_AdvanceLeft.Text = Global.Blueflap.My.MySettings.Default.SFAdvanceA
        Me.SrchFight_AdvanceLeft.Visible = False
        '
        'SrchF_AdvanceChoice
        '
        Me.SrchF_AdvanceChoice.AutoSize = True
        Me.SrchF_AdvanceChoice.Checked = Global.Blueflap.My.MySettings.Default.Fightavdvanced
        Me.SrchF_AdvanceChoice.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Blueflap.My.MySettings.Default, "Fightavdvanced", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SrchF_AdvanceChoice.Location = New System.Drawing.Point(691, 21)
        Me.SrchF_AdvanceChoice.Name = "SrchF_AdvanceChoice"
        Me.SrchF_AdvanceChoice.Size = New System.Drawing.Size(92, 17)
        Me.SrchF_AdvanceChoice.TabIndex = 10
        Me.SrchF_AdvanceChoice.Text = "Mode avancé"
        Me.SrchF_AdvanceChoice.UseVisualStyleBackColor = True
        '
        'SrchF_Actions
        '
        Me.SrchF_Actions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchF_Actions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SrchF_Actions.ForeColor = System.Drawing.Color.DarkCyan
        Me.SrchF_Actions.FormattingEnabled = True
        Me.SrchF_Actions.Items.AddRange(New Object() {"Vue double", "Masquer droite", "Masquer gauche", "Ouvrir droite", "Ouvrir gauche"})
        Me.SrchF_Actions.Location = New System.Drawing.Point(984, 18)
        Me.SrchF_Actions.Name = "SrchF_Actions"
        Me.SrchF_Actions.Size = New System.Drawing.Size(121, 21)
        Me.SrchF_Actions.TabIndex = 9
        Me.SrchF_Actions.Text = "Actions"
        '
        'SrchF_Split
        '
        Me.SrchF_Split.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchF_Split.Location = New System.Drawing.Point(0, 56)
        Me.SrchF_Split.Name = "SrchF_Split"
        '
        'SrchF_Split.Panel1
        '
        Me.SrchF_Split.Panel1.Controls.Add(Me.SrchF_fighter_1)
        '
        'SrchF_Split.Panel2
        '
        Me.SrchF_Split.Panel2.Controls.Add(Me.SrchF_fighter_2)
        Me.SrchF_Split.Size = New System.Drawing.Size(1117, 551)
        Me.SrchF_Split.SplitterDistance = 558
        Me.SrchF_Split.TabIndex = 0
        '
        'SrchF_fighter_1
        '
        Me.SrchF_fighter_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SrchF_fighter_1.Location = New System.Drawing.Point(0, 0)
        Me.SrchF_fighter_1.Size = New System.Drawing.Size(558, 551)
        Me.SrchF_fighter_1.TabIndex = 0
        '
        'SrchF_fighter_2
        '
        Me.SrchF_fighter_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SrchF_fighter_2.Location = New System.Drawing.Point(0, 0)
        Me.SrchF_fighter_2.Size = New System.Drawing.Size(555, 551)
        Me.SrchF_fighter_2.TabIndex = 0
        '
        'SrchF_Fightbutton
        '
        Me.SrchF_Fightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SrchF_Fightbutton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrchF_Fightbutton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SrchF_Fightbutton.Location = New System.Drawing.Point(346, 10)
        Me.SrchF_Fightbutton.Name = "SrchF_Fightbutton"
        Me.SrchF_Fightbutton.Size = New System.Drawing.Size(56, 32)
        Me.SrchF_Fightbutton.TabIndex = 8
        Me.SrchF_Fightbutton.Text = "Fight !"
        Me.SrchF_Fightbutton.UseVisualStyleBackColor = True
        '
        'SrchF_ChoixB
        '
        Me.SrchF_ChoixB.AutoCompleteCustomSource.AddRange(New String() {"Google", "Yahoo", "Bing", "DuckDuckGo"})
        Me.SrchF_ChoixB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SrchF_ChoixB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SrchF_ChoixB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "SF2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SrchF_ChoixB.FormattingEnabled = True
        Me.SrchF_ChoixB.Items.AddRange(New Object() {"Google", "Yahoo", "Bing", "DuckDuckGo"})
        Me.SrchF_ChoixB.Location = New System.Drawing.Point(564, 18)
        Me.SrchF_ChoixB.Name = "SrchF_ChoixB"
        Me.SrchF_ChoixB.Size = New System.Drawing.Size(121, 21)
        Me.SrchF_ChoixB.TabIndex = 7
        Me.SrchF_ChoixB.Text = Global.Blueflap.My.MySettings.Default.SF2
        '
        'SrchF_ChoixA
        '
        Me.SrchF_ChoixA.AutoCompleteCustomSource.AddRange(New String() {"Google", "Yahoo", "Bing", "DuckDuckGo"})
        Me.SrchF_ChoixA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SrchF_ChoixA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SrchF_ChoixA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "SF1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SrchF_ChoixA.FormattingEnabled = True
        Me.SrchF_ChoixA.Items.AddRange(New Object() {"Google", "Yahoo", "Bing", "DuckDuckGo"})
        Me.SrchF_ChoixA.Location = New System.Drawing.Point(437, 18)
        Me.SrchF_ChoixA.Name = "SrchF_ChoixA"
        Me.SrchF_ChoixA.Size = New System.Drawing.Size(121, 21)
        Me.SrchF_ChoixA.TabIndex = 6
        Me.SrchF_ChoixA.Text = Global.Blueflap.My.MySettings.Default.SF1
        '
        'SrchF_Searchbox
        '
        Me.SrchF_Searchbox.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrchF_Searchbox.Location = New System.Drawing.Point(54, 10)
        Me.SrchF_Searchbox.Name = "SrchF_Searchbox"
        Me.SrchF_Searchbox.Size = New System.Drawing.Size(288, 33)
        Me.SrchF_Searchbox.TabIndex = 4
        '
        'SrchF_Back
        '
        Me.SrchF_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SrchF_Back.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrchF_Back.ForeColor = System.Drawing.SystemColors.Control
        Me.SrchF_Back.Image = CType(resources.GetObject("SrchF_Back.Image"), System.Drawing.Image)
        Me.SrchF_Back.Location = New System.Drawing.Point(3, 3)
        Me.SrchF_Back.Name = "SrchF_Back"
        Me.SrchF_Back.Size = New System.Drawing.Size(46, 46)
        Me.SrchF_Back.TabIndex = 3
        Me.SrchF_Back.Text = " "
        Me.SrchF_Back.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.SrchF_Line})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1117, 607)
        Me.ShapeContainer2.TabIndex = 5
        Me.ShapeContainer2.TabStop = False
        '
        'SrchF_Line
        '
        Me.SrchF_Line.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchF_Line.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.SrchF_Line.Name = "SrchF_Line"
        Me.SrchF_Line.X1 = 0
        Me.SrchF_Line.X2 = 1120
        Me.SrchF_Line.Y1 = 55
        Me.SrchF_Line.Y2 = 55
        '
        'ABlueflap_Verrouillage
        '
        Me.ABlueflap_Verrouillage.Controls.Add(Me.Verr_BlackEffect)
        Me.ABlueflap_Verrouillage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Verrouillage.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Verrouillage.Name = "ABlueflap_Verrouillage"
        Me.ABlueflap_Verrouillage.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Verrouillage.TabIndex = 3
        '
        'Verr_BlackEffect
        '
        Me.Verr_BlackEffect.BackColor = System.Drawing.Color.Transparent
        Me.Verr_BlackEffect.BackgroundImage = CType(resources.GetObject("Verr_BlackEffect.BackgroundImage"), System.Drawing.Image)
        Me.Verr_BlackEffect.Controls.Add(Me.PictureBox2)
        Me.Verr_BlackEffect.Controls.Add(Me.Verr_Date)
        Me.Verr_BlackEffect.Controls.Add(Me.Panel2)
        Me.Verr_BlackEffect.Controls.Add(Me.Verr_Time)
        Me.Verr_BlackEffect.Controls.Add(Me.Label7)
        Me.Verr_BlackEffect.Controls.Add(Me.Verr_WrongMp)
        Me.Verr_BlackEffect.Location = New System.Drawing.Point(354, 116)
        Me.Verr_BlackEffect.Name = "Verr_BlackEffect"
        Me.Verr_BlackEffect.Size = New System.Drawing.Size(347, 283)
        Me.Verr_BlackEffect.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Verr_Date
        '
        Me.Verr_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Verr_Date.AutoSize = True
        Me.Verr_Date.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verr_Date.ForeColor = System.Drawing.Color.White
        Me.Verr_Date.Location = New System.Drawing.Point(23, 78)
        Me.Verr_Date.Name = "Verr_Date"
        Me.Verr_Date.Size = New System.Drawing.Size(55, 20)
        Me.Verr_Date.TabIndex = 11
        Me.Verr_Date.Text = "Label15"
        Me.Verr_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Verr_Textbox)
        Me.Panel2.Controls.Add(Me.Verr_AcceptButt)
        Me.Panel2.Location = New System.Drawing.Point(117, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 34)
        Me.Panel2.TabIndex = 12
        '
        'Verr_Textbox
        '
        Me.Verr_Textbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Verr_Textbox.Location = New System.Drawing.Point(9, 7)
        Me.Verr_Textbox.Name = "Verr_Textbox"
        Me.Verr_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Verr_Textbox.Size = New System.Drawing.Size(168, 20)
        Me.Verr_Textbox.TabIndex = 7
        '
        'Verr_AcceptButt
        '
        Me.Verr_AcceptButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Verr_AcceptButt.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verr_AcceptButt.ForeColor = System.Drawing.SystemColors.Control
        Me.Verr_AcceptButt.Image = CType(resources.GetObject("Verr_AcceptButt.Image"), System.Drawing.Image)
        Me.Verr_AcceptButt.Location = New System.Drawing.Point(178, 4)
        Me.Verr_AcceptButt.Name = "Verr_AcceptButt"
        Me.Verr_AcceptButt.Size = New System.Drawing.Size(26, 26)
        Me.Verr_AcceptButt.TabIndex = 5
        Me.Verr_AcceptButt.Text = " "
        Me.Verr_AcceptButt.UseVisualStyleBackColor = True
        '
        'Verr_Time
        '
        Me.Verr_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Verr_Time.AutoSize = True
        Me.Verr_Time.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verr_Time.ForeColor = System.Drawing.Color.White
        Me.Verr_Time.Location = New System.Drawing.Point(3, 0)
        Me.Verr_Time.Name = "Verr_Time"
        Me.Verr_Time.Size = New System.Drawing.Size(235, 86)
        Me.Verr_Time.TabIndex = 10
        Me.Verr_Time.Text = "Label15"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(117, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Blueflap est verrouillé"
        '
        'Verr_WrongMp
        '
        Me.Verr_WrongMp.AutoSize = True
        Me.Verr_WrongMp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verr_WrongMp.ForeColor = System.Drawing.Color.PeachPuff
        Me.Verr_WrongMp.Location = New System.Drawing.Point(118, 226)
        Me.Verr_WrongMp.Name = "Verr_WrongMp"
        Me.Verr_WrongMp.Size = New System.Drawing.Size(116, 13)
        Me.Verr_WrongMp.TabIndex = 9
        Me.Verr_WrongMp.Text = "Mot de passe incorrect"
        Me.Verr_WrongMp.Visible = False
        '
        'ABlueflap_Infos
        '
        Me.ABlueflap_Infos.BackgroundImage = CType(resources.GetObject("ABlueflap_Infos.BackgroundImage"), System.Drawing.Image)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_code_source)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Save)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Print)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Loading)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Loader)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Trident_Browser_Recup_Infos)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_CodeShowHide)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_back)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Adresse)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Titre)
        Me.ABlueflap_Infos.Controls.Add(Me.Infos_Share)
        Me.ABlueflap_Infos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Infos.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Infos.Name = "ABlueflap_Infos"
        Me.ABlueflap_Infos.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Infos.TabIndex = 4
        '
        'Infos_code_source
        '
        Me.Infos_code_source.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Infos_code_source.AutoScrollMinSize = New System.Drawing.Size(123, 14)
        Me.Infos_code_source.BackBrush = Nothing
        Me.Infos_code_source.BackColor = System.Drawing.SystemColors.Control
        Me.Infos_code_source.CharHeight = 14
        Me.Infos_code_source.CharWidth = 8
        Me.Infos_code_source.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Infos_code_source.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Infos_code_source.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Infos_code_source.IndentBackColor = System.Drawing.SystemColors.Control
        Me.Infos_code_source.IsReplaceMode = False
        Me.Infos_code_source.Location = New System.Drawing.Point(74, 194)
        Me.Infos_code_source.Name = "Infos_code_source"
        Me.Infos_code_source.Paddings = New System.Windows.Forms.Padding(0)
        Me.Infos_code_source.ReadOnly = True
        Me.Infos_code_source.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Infos_code_source.Size = New System.Drawing.Size(1040, 413)
        Me.Infos_code_source.TabIndex = 14
        Me.Infos_code_source.Text = "Patientez..."
        Me.Infos_code_source.Visible = False
        Me.Infos_code_source.Zoom = 100
        '
        'Infos_Save
        '
        Me.Infos_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Infos_Save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Infos_Save.Image = CType(resources.GetObject("Infos_Save.Image"), System.Drawing.Image)
        Me.Infos_Save.Location = New System.Drawing.Point(110, 144)
        Me.Infos_Save.Name = "Infos_Save"
        Me.Infos_Save.Size = New System.Drawing.Size(44, 44)
        Me.Infos_Save.TabIndex = 12
        Me.Infos_Save.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Infos_Save.UseVisualStyleBackColor = True
        Me.Infos_Save.Visible = False
        '
        'Infos_Print
        '
        Me.Infos_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Infos_Print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Infos_Print.Image = CType(resources.GetObject("Infos_Print.Image"), System.Drawing.Image)
        Me.Infos_Print.Location = New System.Drawing.Point(63, 144)
        Me.Infos_Print.Name = "Infos_Print"
        Me.Infos_Print.Size = New System.Drawing.Size(45, 45)
        Me.Infos_Print.TabIndex = 11
        Me.Infos_Print.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Infos_Print.UseVisualStyleBackColor = True
        Me.Infos_Print.Visible = False
        '
        'Infos_Loading
        '
        Me.Infos_Loading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Infos_Loading.AutoSize = True
        Me.Infos_Loading.BackColor = System.Drawing.Color.Transparent
        Me.Infos_Loading.ForeColor = System.Drawing.Color.Gainsboro
        Me.Infos_Loading.Location = New System.Drawing.Point(825, 160)
        Me.Infos_Loading.Name = "Infos_Loading"
        Me.Infos_Loading.Size = New System.Drawing.Size(98, 13)
        Me.Infos_Loading.TabIndex = 10
        Me.Infos_Loading.Text = "Obtention des infos"
        Me.Infos_Loading.Visible = False
        '
        'Infos_Loader
        '
        Me.Infos_Loader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Infos_Loader.BackColor = System.Drawing.Color.Transparent
        Me.Infos_Loader.Image = CType(resources.GetObject("Infos_Loader.Image"), System.Drawing.Image)
        Me.Infos_Loader.Location = New System.Drawing.Point(929, 159)
        Me.Infos_Loader.Name = "Infos_Loader"
        Me.Infos_Loader.Size = New System.Drawing.Size(176, 16)
        Me.Infos_Loader.TabIndex = 9
        Me.Infos_Loader.TabStop = False
        Me.Infos_Loader.Visible = False
        '
        'Infos_Trident_Browser_Recup_Infos
        '
        Me.Infos_Trident_Browser_Recup_Infos.Location = New System.Drawing.Point(194, 573)
        Me.Infos_Trident_Browser_Recup_Infos.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Infos_Trident_Browser_Recup_Infos.Name = "Infos_Trident_Browser_Recup_Infos"
        Me.Infos_Trident_Browser_Recup_Infos.ScriptErrorsSuppressed = True
        Me.Infos_Trident_Browser_Recup_Infos.ScrollBarsEnabled = False
        Me.Infos_Trident_Browser_Recup_Infos.Size = New System.Drawing.Size(125, 32)
        Me.Infos_Trident_Browser_Recup_Infos.TabIndex = 6
        Me.Infos_Trident_Browser_Recup_Infos.TabStop = False
        Me.Infos_Trident_Browser_Recup_Infos.Visible = False
        '
        'Infos_CodeShowHide
        '
        Me.Infos_CodeShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Infos_CodeShowHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Infos_CodeShowHide.Image = CType(resources.GetObject("Infos_CodeShowHide.Image"), System.Drawing.Image)
        Me.Infos_CodeShowHide.Location = New System.Drawing.Point(160, 144)
        Me.Infos_CodeShowHide.Name = "Infos_CodeShowHide"
        Me.Infos_CodeShowHide.Size = New System.Drawing.Size(45, 45)
        Me.Infos_CodeShowHide.TabIndex = 5
        Me.Infos_CodeShowHide.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Infos_CodeShowHide.UseVisualStyleBackColor = True
        '
        'Infos_back
        '
        Me.Infos_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Infos_back.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Infos_back.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Infos_back.Image = CType(resources.GetObject("Infos_back.Image"), System.Drawing.Image)
        Me.Infos_back.Location = New System.Drawing.Point(12, 57)
        Me.Infos_back.Name = "Infos_back"
        Me.Infos_back.Size = New System.Drawing.Size(46, 46)
        Me.Infos_back.TabIndex = 3
        Me.Infos_back.Text = " "
        Me.Infos_back.UseVisualStyleBackColor = True
        '
        'Infos_Adresse
        '
        Me.Infos_Adresse.AutoSize = True
        Me.Infos_Adresse.BackColor = System.Drawing.Color.Transparent
        Me.Infos_Adresse.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Infos_Adresse.ForeColor = System.Drawing.Color.White
        Me.Infos_Adresse.Location = New System.Drawing.Point(69, 95)
        Me.Infos_Adresse.Name = "Infos_Adresse"
        Me.Infos_Adresse.Size = New System.Drawing.Size(91, 28)
        Me.Infos_Adresse.TabIndex = 4
        Me.Infos_Adresse.Text = "[Adresse]"
        '
        'Infos_Titre
        '
        Me.Infos_Titre.AutoSize = True
        Me.Infos_Titre.BackColor = System.Drawing.Color.Transparent
        Me.Infos_Titre.Font = New System.Drawing.Font("Segoe UI Light", 40.0!)
        Me.Infos_Titre.ForeColor = System.Drawing.Color.White
        Me.Infos_Titre.Location = New System.Drawing.Point(55, 20)
        Me.Infos_Titre.Name = "Infos_Titre"
        Me.Infos_Titre.Size = New System.Drawing.Size(159, 72)
        Me.Infos_Titre.TabIndex = 7
        Me.Infos_Titre.Text = "[Titre]"
        '
        'Infos_Share
        '
        Me.Infos_Share.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Infos_Share.BackColor = System.Drawing.Color.White
        Me.Infos_Share.Location = New System.Drawing.Point(0, 191)
        Me.Infos_Share.Size = New System.Drawing.Size(1117, 415)
        Me.Infos_Share.TabIndex = 15
        Me.Infos_Share.Visible = False
        '
        'WebSessionProvider1
        '
        Me.WebSessionProvider1.DataPath = "C:\Blueflap\Data"
        Me.WebSessionProvider1.Views.Add(Me.Web)
        Me.WebSessionProvider1.Views.Add(Me.Infos_Share)
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Note"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Note"
        '
        'ABlueflap_Bluestart
        '
        Me.ABlueflap_Bluestart.BackColor = System.Drawing.SystemColors.Control
        Me.ABlueflap_Bluestart.BackgroundImage = CType(resources.GetObject("ABlueflap_Bluestart.BackgroundImage"), System.Drawing.Image)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Fav)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Searchfight)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Browser)
        Me.ABlueflap_Bluestart.Controls.Add(Me.Bs_Favbulle)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Date)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_SearchBlackEffect)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Settings)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Optionsbulle)
        Me.ABlueflap_Bluestart.Controls.Add(Me.BS_Logo)
        Me.ABlueflap_Bluestart.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Global.Blueflap.My.MySettings.Default, "Hey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ABlueflap_Bluestart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ABlueflap_Bluestart.Location = New System.Drawing.Point(0, 0)
        Me.ABlueflap_Bluestart.Name = "ABlueflap_Bluestart"
        Me.ABlueflap_Bluestart.Size = New System.Drawing.Size(1117, 607)
        Me.ABlueflap_Bluestart.TabIndex = 5
        Me.ABlueflap_Bluestart.Tag = Global.Blueflap.My.MySettings.Default.Hey
        Me.ABlueflap_Bluestart.Visible = False
        '
        'BS_Fav
        '
        Me.BS_Fav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BS_Fav.BackColor = System.Drawing.Color.Transparent
        Me.BS_Fav.BackgroundImage = CType(resources.GetObject("BS_Fav.BackgroundImage"), System.Drawing.Image)
        Me.BS_Fav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BS_Fav.FlatAppearance.BorderSize = 0
        Me.BS_Fav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BS_Fav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BS_Fav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_Fav.Location = New System.Drawing.Point(95, 541)
        Me.BS_Fav.Name = "BS_Fav"
        Me.BS_Fav.Size = New System.Drawing.Size(54, 54)
        Me.BS_Fav.TabIndex = 0
        Me.BS_Fav.UseVisualStyleBackColor = False
        '
        'BS_Searchfight
        '
        Me.BS_Searchfight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BS_Searchfight.BackColor = System.Drawing.Color.Transparent
        Me.BS_Searchfight.BackgroundImage = CType(resources.GetObject("BS_Searchfight.BackgroundImage"), System.Drawing.Image)
        Me.BS_Searchfight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BS_Searchfight.FlatAppearance.BorderSize = 0
        Me.BS_Searchfight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BS_Searchfight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BS_Searchfight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_Searchfight.Location = New System.Drawing.Point(161, 541)
        Me.BS_Searchfight.Name = "BS_Searchfight"
        Me.BS_Searchfight.Size = New System.Drawing.Size(54, 54)
        Me.BS_Searchfight.TabIndex = 9
        Me.BS_Searchfight.UseVisualStyleBackColor = False
        '
        'BS_Browser
        '
        Me.BS_Browser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BS_Browser.BackColor = System.Drawing.Color.Transparent
        Me.BS_Browser.BackgroundImage = CType(resources.GetObject("BS_Browser.BackgroundImage"), System.Drawing.Image)
        Me.BS_Browser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BS_Browser.FlatAppearance.BorderSize = 0
        Me.BS_Browser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BS_Browser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BS_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_Browser.Location = New System.Drawing.Point(29, 541)
        Me.BS_Browser.Name = "BS_Browser"
        Me.BS_Browser.Size = New System.Drawing.Size(54, 54)
        Me.BS_Browser.TabIndex = 8
        Me.BS_Browser.UseVisualStyleBackColor = False
        '
        'Bs_Favbulle
        '
        Me.Bs_Favbulle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bs_Favbulle.BackColor = System.Drawing.Color.Transparent
        Me.Bs_Favbulle.BackgroundImage = CType(resources.GetObject("Bs_Favbulle.BackgroundImage"), System.Drawing.Image)
        Me.Bs_Favbulle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Bs_Favbulle.Controls.Add(Me.BS_Favlist)
        Me.Bs_Favbulle.Location = New System.Drawing.Point(28, 248)
        Me.Bs_Favbulle.Name = "Bs_Favbulle"
        Me.Bs_Favbulle.Size = New System.Drawing.Size(452, 302)
        Me.Bs_Favbulle.TabIndex = 7
        Me.Bs_Favbulle.Visible = False
        '
        'BS_Favlist
        '
        Me.BS_Favlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BS_Favlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BS_Favlist.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BS_Favlist.FormattingEnabled = True
        Me.BS_Favlist.ItemHeight = 20
        Me.BS_Favlist.Location = New System.Drawing.Point(8, 3)
        Me.BS_Favlist.Name = "BS_Favlist"
        Me.BS_Favlist.Size = New System.Drawing.Size(436, 260)
        Me.BS_Favlist.TabIndex = 0
        '
        'BS_Date
        '
        Me.BS_Date.AutoSize = True
        Me.BS_Date.BackColor = System.Drawing.Color.Transparent
        Me.BS_Date.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Blueflap.My.MySettings.Default, "clair", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BS_Date.Font = New System.Drawing.Font("Segoe UI Light", 27.0!)
        Me.BS_Date.ForeColor = Global.Blueflap.My.MySettings.Default.clair
        Me.BS_Date.Location = New System.Drawing.Point(478, 55)
        Me.BS_Date.Name = "BS_Date"
        Me.BS_Date.Size = New System.Drawing.Size(157, 48)
        Me.BS_Date.TabIndex = 4
        Me.BS_Date.Text = "Bonjour !"
        '
        'BS_SearchBlackEffect
        '
        Me.BS_SearchBlackEffect.BackColor = System.Drawing.Color.Transparent
        Me.BS_SearchBlackEffect.BackgroundImage = CType(resources.GetObject("BS_SearchBlackEffect.BackgroundImage"), System.Drawing.Image)
        Me.BS_SearchBlackEffect.Controls.Add(Me.BS_Searchbutton)
        Me.BS_SearchBlackEffect.Controls.Add(Me.Bs_Searchbox)
        Me.BS_SearchBlackEffect.Location = New System.Drawing.Point(346, 318)
        Me.BS_SearchBlackEffect.Name = "BS_SearchBlackEffect"
        Me.BS_SearchBlackEffect.Size = New System.Drawing.Size(426, 73)
        Me.BS_SearchBlackEffect.TabIndex = 6
        '
        'BS_Searchbutton
        '
        Me.BS_Searchbutton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BS_Searchbutton.FlatAppearance.BorderSize = 0
        Me.BS_Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_Searchbutton.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BS_Searchbutton.ForeColor = System.Drawing.Color.White
        Me.BS_Searchbutton.Location = New System.Drawing.Point(323, 15)
        Me.BS_Searchbutton.Name = "BS_Searchbutton"
        Me.BS_Searchbutton.Size = New System.Drawing.Size(87, 44)
        Me.BS_Searchbutton.TabIndex = 1
        Me.BS_Searchbutton.Text = "OK"
        Me.BS_Searchbutton.UseVisualStyleBackColor = False
        '
        'Bs_Searchbox
        '
        Me.Bs_Searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bs_Searchbox.Font = New System.Drawing.Font("Segoe UI Semilight", 24.25!)
        Me.Bs_Searchbox.Location = New System.Drawing.Point(14, 15)
        Me.Bs_Searchbox.Name = "Bs_Searchbox"
        Me.Bs_Searchbox.Size = New System.Drawing.Size(309, 44)
        Me.Bs_Searchbox.TabIndex = 0
        '
        'BS_Settings
        '
        Me.BS_Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BS_Settings.BackColor = System.Drawing.Color.Transparent
        Me.BS_Settings.BackgroundImage = CType(resources.GetObject("BS_Settings.BackgroundImage"), System.Drawing.Image)
        Me.BS_Settings.FlatAppearance.BorderSize = 0
        Me.BS_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BS_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BS_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_Settings.Location = New System.Drawing.Point(1076, 4)
        Me.BS_Settings.Name = "BS_Settings"
        Me.BS_Settings.Size = New System.Drawing.Size(37, 37)
        Me.BS_Settings.TabIndex = 0
        Me.BS_Settings.UseVisualStyleBackColor = False
        '
        'BS_Optionsbulle
        '
        Me.BS_Optionsbulle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BS_Optionsbulle.BackColor = System.Drawing.Color.Transparent
        Me.BS_Optionsbulle.BackgroundImage = CType(resources.GetObject("BS_Optionsbulle.BackgroundImage"), System.Drawing.Image)
        Me.BS_Optionsbulle.Controls.Add(Me.BS_DateSetColor)
        Me.BS_Optionsbulle.Controls.Add(Me.BS_ImgChoose)
        Me.BS_Optionsbulle.Location = New System.Drawing.Point(891, 37)
        Me.BS_Optionsbulle.Name = "BS_Optionsbulle"
        Me.BS_Optionsbulle.Size = New System.Drawing.Size(220, 160)
        Me.BS_Optionsbulle.TabIndex = 5
        Me.BS_Optionsbulle.Visible = False
        '
        'BS_DateSetColor
        '
        Me.BS_DateSetColor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Blueflap.My.MySettings.Default, "sombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BS_DateSetColor.FlatAppearance.BorderSize = 0
        Me.BS_DateSetColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BS_DateSetColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BS_DateSetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_DateSetColor.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BS_DateSetColor.ForeColor = System.Drawing.Color.White
        Me.BS_DateSetColor.Location = New System.Drawing.Point(12, 96)
        Me.BS_DateSetColor.Name = "BS_DateSetColor"
        Me.BS_DateSetColor.Size = New System.Drawing.Size(192, 44)
        Me.BS_DateSetColor.TabIndex = 1
        Me.BS_DateSetColor.Text = Global.Blueflap.My.MySettings.Default.sombre
        Me.BS_DateSetColor.UseVisualStyleBackColor = True
        '
        'BS_ImgChoose
        '
        Me.BS_ImgChoose.FlatAppearance.BorderSize = 0
        Me.BS_ImgChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BS_ImgChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BS_ImgChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS_ImgChoose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BS_ImgChoose.ForeColor = System.Drawing.Color.White
        Me.BS_ImgChoose.Location = New System.Drawing.Point(12, 42)
        Me.BS_ImgChoose.Name = "BS_ImgChoose"
        Me.BS_ImgChoose.Size = New System.Drawing.Size(192, 44)
        Me.BS_ImgChoose.TabIndex = 0
        Me.BS_ImgChoose.Text = "Choisir une image"
        Me.BS_ImgChoose.UseVisualStyleBackColor = True
        '
        'BS_Logo
        '
        Me.BS_Logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BS_Logo.BackColor = System.Drawing.Color.Transparent
        Me.BS_Logo.Image = CType(resources.GetObject("BS_Logo.Image"), System.Drawing.Image)
        Me.BS_Logo.Location = New System.Drawing.Point(0, 155)
        Me.BS_Logo.Name = "BS_Logo"
        Me.BS_Logo.Size = New System.Drawing.Size(1121, 139)
        Me.BS_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BS_Logo.TabIndex = 1
        Me.BS_Logo.TabStop = False
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = ""
        '
        'Fenetre_Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 607)
        Me.Controls.Add(Me.ABlueflap_Settings)
        Me.Controls.Add(Me.ABlueflap_Infos)
        Me.Controls.Add(Me.ABlueflap_Fight)
        Me.Controls.Add(Me.ABlueflap_Bluestart)
        Me.Controls.Add(Me.ABlueflap_Navigateur)
        Me.Controls.Add(Me.ABlueflap_Verrouillage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(240, 39)
        Me.Name = "Fenetre_Principale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blueflap"
        Me.ABlueflap_Navigateur.ResumeLayout(False)
        CType(Me.Notif_internet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fav_Panel.ResumeLayout(False)
        Me.fav_notif_suppr.ResumeLayout(False)
        Me.fav_notif_suppr.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.FP_AdressbarPanel.ResumeLayout(False)
        Me.FP_AdressbarPanel.PerformLayout()
        Me.Notif_add.ResumeLayout(False)
        Me.Notif_add.PerformLayout()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.voletlateral.ResumeLayout(False)
        Me.voletlateral.PerformLayout()
        Me.Menua.ResumeLayout(False)
        Me.ABlueflap_Settings.ResumeLayout(False)
        Me.ABlueflap_Settings.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Sett_TabB.ResumeLayout(False)
        Me.Sett_TabB.PerformLayout()
        Me.Sett_TabC.ResumeLayout(False)
        Me.Sett_TabC.PerformLayout()
        Me.Sett_TabA.ResumeLayout(False)
        Me.Sett_TabA.PerformLayout()
        CType(Me.stng_picdemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StngmenuIcon4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ABlueflap_Fight.ResumeLayout(False)
        Me.ABlueflap_Fight.PerformLayout()
        Me.SrchF_Split.Panel1.ResumeLayout(False)
        Me.SrchF_Split.Panel2.ResumeLayout(False)
        CType(Me.SrchF_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SrchF_Split.ResumeLayout(False)
        Me.ABlueflap_Verrouillage.ResumeLayout(False)
        Me.Verr_BlackEffect.ResumeLayout(False)
        Me.Verr_BlackEffect.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ABlueflap_Infos.ResumeLayout(False)
        Me.ABlueflap_Infos.PerformLayout()
        CType(Me.Infos_code_source, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Infos_Loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ABlueflap_Bluestart.ResumeLayout(False)
        Me.ABlueflap_Bluestart.PerformLayout()
        Me.Bs_Favbulle.ResumeLayout(False)
        Me.BS_SearchBlackEffect.ResumeLayout(False)
        Me.BS_SearchBlackEffect.PerformLayout()
        Me.BS_Optionsbulle.ResumeLayout(False)
        CType(Me.BS_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ABlueflap_Navigateur As System.Windows.Forms.Panel
    Friend WithEvents ABlueflap_Settings As System.Windows.Forms.Panel
    Friend WithEvents ABlueflap_Fight As System.Windows.Forms.Panel
    Friend WithEvents ABlueflap_Verrouillage As System.Windows.Forms.Panel
    Friend WithEvents ABlueflap_Infos As System.Windows.Forms.Panel
    Public WithEvents voletlateral As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_Home As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Forward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Stop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Fight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Favos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Share As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Lock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_FullScr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FP_AdressbarPanel As System.Windows.Forms.Panel
    Friend WithEvents Menu_ShowHide_Button As System.Windows.Forms.Button
    Friend WithEvents SmartAdressbox As System.Windows.Forms.TextBox
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents AddFavo_Button As System.Windows.Forms.Button
    Friend WithEvents Settings_title As System.Windows.Forms.Label
    Friend WithEvents Settings_Back As System.Windows.Forms.Button
    Friend WithEvents Stng_MoteurRecherche_choose As System.Windows.Forms.ComboBox
    Friend WithEvents StngLabel_Searchengine As System.Windows.Forms.Label
    Friend WithEvents Stng_MoteurRecherche_URL As System.Windows.Forms.TextBox
    Friend WithEvents Notif_internet As System.Windows.Forms.PictureBox
    Friend WithEvents Stng_HomePage_Url As System.Windows.Forms.TextBox
    Friend WithEvents StngLabel_Home As System.Windows.Forms.Label
    Friend WithEvents Stng_ErreurURLHomepage As System.Windows.Forms.Label
    Friend WithEvents Stng_Volet_reduire As System.Windows.Forms.CheckBox
    Friend WithEvents Stng_MPActiv As System.Windows.Forms.CheckBox
    Friend WithEvents Stng_MP_confirm As System.Windows.Forms.TextBox
    Friend WithEvents Stng_MP As System.Windows.Forms.TextBox
    Friend WithEvents StngLabel_Lock As System.Windows.Forms.Label
    Friend WithEvents StngLabel_MP As System.Windows.Forms.Label
    Friend WithEvents StngLabel_MPConfirm As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents StngLabel_Interface As System.Windows.Forms.Label
    Friend WithEvents Infos_back As System.Windows.Forms.Button
    Friend WithEvents Infos_Adresse As System.Windows.Forms.Label
    Friend WithEvents Verr_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Verr_AcceptButt As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SrchF_Searchbox As System.Windows.Forms.TextBox
    Friend WithEvents SrchF_Back As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents SrchF_Line As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents SrchF_Fightbutton As System.Windows.Forms.Button
    Friend WithEvents SrchF_ChoixB As System.Windows.Forms.ComboBox
    Friend WithEvents SrchF_ChoixA As System.Windows.Forms.ComboBox
    Friend WithEvents SrchF_Split As System.Windows.Forms.SplitContainer
    Private WithEvents SrchF_fighter_1 As Awesomium.Windows.Forms.WebControl
    Private WithEvents SrchF_fighter_2 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents Infos_CodeShowHide As System.Windows.Forms.Button
    Friend WithEvents Infos_Trident_Browser_Recup_Infos As System.Windows.Forms.WebBrowser
    Friend WithEvents Infos_Titre As System.Windows.Forms.Label
    Friend WithEvents Infos_Loader As System.Windows.Forms.PictureBox
    Friend WithEvents Infos_Loading As System.Windows.Forms.Label
    Friend WithEvents Infos_Save As System.Windows.Forms.Button
    Friend WithEvents Infos_Print As System.Windows.Forms.Button
    Friend WithEvents Fav_Panel As System.Windows.Forms.Panel
    Friend WithEvents Fav_fav_List As System.Windows.Forms.ListBox
    Friend WithEvents fav_notif_suppr As System.Windows.Forms.Panel
    Friend WithEvents Fav_Cancel As System.Windows.Forms.Button
    Friend WithEvents Fav_Confirm As System.Windows.Forms.Button
    Friend WithEvents Fav_Notif_Text As System.Windows.Forms.Label
    Friend WithEvents Notif_add As System.Windows.Forms.Panel
    Friend WithEvents Notiff_add_Text As System.Windows.Forms.Label
    Friend WithEvents Notiff_add_OKbutton As System.Windows.Forms.Button
    Friend WithEvents Fav_Close As System.Windows.Forms.Button
    Friend WithEvents Loader As System.Windows.Forms.PictureBox
    Friend WithEvents Stng_VersionSystem As System.Windows.Forms.Label
    Friend WithEvents StngmenuIcon6 As System.Windows.Forms.PictureBox
    Friend WithEvents StngmenuIcon4 As System.Windows.Forms.PictureBox
    Friend WithEvents StngmenuIcon3 As System.Windows.Forms.PictureBox
    Friend WithEvents StngmenuIcon2 As System.Windows.Forms.PictureBox
    Friend WithEvents StngmenuIcon1 As System.Windows.Forms.PictureBox
    Friend WithEvents fullscreen_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents lock_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents infos_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents favo_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Sfight_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Home_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents StngLabel_Icons As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents StngmenuIcon7 As System.Windows.Forms.PictureBox
    Friend WithEvents Verr_WrongMp As System.Windows.Forms.Label
    Friend WithEvents WebSessionProvider1 As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents Stng_OptionsInternet As System.Windows.Forms.Button
    Friend WithEvents StngLabel_NetworkInfo As System.Windows.Forms.Label
    Friend WithEvents StngLabel_Proxy As System.Windows.Forms.Label
    Friend WithEvents StngLabel_Private As System.Windows.Forms.Label
    Friend WithEvents Stng_TouchUI As System.Windows.Forms.CheckBox
    Friend WithEvents Verr_Time As System.Windows.Forms.Label
    Friend WithEvents Verr_Date As System.Windows.Forms.Label
    Friend WithEvents Fav_Historique_List As System.Windows.Forms.ListBox
    Friend WithEvents Stng_SupprHisto As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Data As System.Windows.Forms.Label
    Friend WithEvents Stng_MaximizedWindow As System.Windows.Forms.CheckBox
    Friend WithEvents Stng_SupprCacheCookies As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Infos_code_source As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Stng_Volet_Mousehover_agrandir As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ABlueflap_Bluestart As System.Windows.Forms.Panel
    Friend WithEvents BS_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents BS_Settings As System.Windows.Forms.Button
    Friend WithEvents BS_Date As System.Windows.Forms.Label
    Friend WithEvents BS_Optionsbulle As System.Windows.Forms.Panel
    Friend WithEvents BS_SearchBlackEffect As System.Windows.Forms.Panel
    Friend WithEvents BS_Searchbutton As System.Windows.Forms.Button
    Friend WithEvents Bs_Searchbox As System.Windows.Forms.TextBox
    Friend WithEvents BS_ImgChoose As System.Windows.Forms.Button
    Friend WithEvents BS_DateSetColor As System.Windows.Forms.Button
    Friend WithEvents Verr_BlackEffect As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Stng_bluestart_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Bs_Favbulle As System.Windows.Forms.Panel
    Friend WithEvents BS_Favlist As System.Windows.Forms.ListBox
    Friend WithEvents BS_Fav As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Extra As System.Windows.Forms.Label
    Friend WithEvents BS_Browser As System.Windows.Forms.Button
    Friend WithEvents BS_Searchfight As System.Windows.Forms.Button
    Friend WithEvents Stng_ShowLicense As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents stng_simpleworld As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Devs As System.Windows.Forms.Label
    Friend WithEvents stng_github As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Contribute As System.Windows.Forms.Label
    Friend WithEvents Menu_Memo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menua As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sett_TabA As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents sett_tab3 As MetroControls.MetroHeaderButton
    Friend WithEvents sett_tab2 As MetroControls.MetroHeaderButton
    Friend WithEvents sett_tab1 As MetroControls.MetroHeaderButton
    Friend WithEvents Sett_TabC As System.Windows.Forms.Panel
    Friend WithEvents Sett_TabB As System.Windows.Forms.Panel
    Private WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Stng_Helpcenter As MetroControls.MetroHeaderButton
    Friend WithEvents Fav_Favtab As MetroControls.MetroHeaderButton
    Friend WithEvents Fav_Histotab As MetroControls.MetroHeaderButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccéderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Background As System.Windows.Forms.Label
    Friend WithEvents StngLabel_OpenSource As System.Windows.Forms.Label
    Friend WithEvents StngLabel_Version As System.Windows.Forms.Label
    Friend WithEvents memo_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents StngmenuIcon8 As System.Windows.Forms.PictureBox
    Friend WithEvents stng_nevpriv As System.Windows.Forms.CheckBox
    Friend WithEvents StngLabel_Network As System.Windows.Forms.Label
    Private WithEvents Web As Awesomium.Windows.Forms.WebControl
    Friend WithEvents menu_partage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TwitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Infos_Share As Awesomium.Windows.Forms.WebControl
    Friend WithEvents Share_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents StngmenuIcon5 As System.Windows.Forms.PictureBox
    Friend WithEvents stng_picdemo As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundChemin As System.Windows.Forms.TextBox
    Friend WithEvents Stng_Zyhou As System.Windows.Forms.Button
    Friend WithEvents Stng_BaptGuil As System.Windows.Forms.Button
    Friend WithEvents Stng_Bat41 As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Contributeurs As System.Windows.Forms.Label
    Friend WithEvents SrchF_Actions As System.Windows.Forms.ComboBox
    Friend WithEvents SrchFight_AdvanceRight As System.Windows.Forms.TextBox
    Friend WithEvents SrchFight_AdvanceLeft As System.Windows.Forms.TextBox
    Friend WithEvents SrchF_AdvanceChoice As System.Windows.Forms.CheckBox
    Friend WithEvents Stng_ResetSuggest As System.Windows.Forms.Button
    Friend WithEvents StngLabel_Suggest As System.Windows.Forms.Label
    Friend WithEvents stng_Smartsuggestactif As System.Windows.Forms.CheckBox

End Class
