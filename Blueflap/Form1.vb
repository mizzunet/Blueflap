Public Class Fenetre_Principale
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Class Bluerend : Inherits ToolStripProfessionalRenderer
        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
            If e.Item.Selected Then
                If e.Item.Width > 140 OrElse e.Item.Text = "Facebook" OrElse e.Item.Text = "Twitter" Then
                    Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                    'Element du menu Blueflap au passage de la souris
                    e.Graphics.FillRectangle(Brushes.Transparent, rc)
                    e.Graphics.DrawRectangle(Pens.WhiteSmoke, 1, 0, rc.Width + 1, rc.Height - 1)
                    e.Item.ForeColor = Color.SteelBlue
                Else
                    Dim rc As New Rectangle(New System.Drawing.Point(19, 0), New System.Drawing.Size(2, 25))
                    'Element du menu Blueflap au passage de la souris
                    e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rc)
                    e.Graphics.DrawRectangle(Pens.Transparent, 1, 0, rc.Width - 1, rc.Height - 1)
                    e.Item.ForeColor = Color.SteelBlue
                End If
            Else
                Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                'Element du menu Blueflap au repos
                e.Graphics.FillRectangle(Brushes.Transparent, rc)
                e.Item.ForeColor = Color.DeepSkyBlue
            End If
        End Sub
    End Class
    Private Sub MenuBoutton_Click(sender As Object, e As EventArgs) Handles Menu_ShowHide_Button.Click
        If voletlateral.Width = 27 Then
            voletlateral.Width = 160
            voletlateral.BackColor = Color.White
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        Else
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
            voletlateral.Width = 27
            voletlateral.BackColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim textArray = SmartAdressbox.Text.Split(" ")
        If (SmartAdressbox.Text.Contains(".") = True And SmartAdressbox.Text.Contains(" ") = False And SmartAdressbox.Text.Contains(" .") = False And SmartAdressbox.Text.Contains(". ") = False) Or textArray(0).Contains(":/") = True Or textArray(0).Contains(":\") Then
            If SmartAdressbox.Text.Contains("http://") OrElse SmartAdressbox.Text.Contains("https://") Then
                Web.Source = New Uri(SmartAdressbox.Text)
            Else
                Web.Source = New Uri("http://" + SmartAdressbox.Text)
            End If
        Else

            If Stng_MoteurRecherche_URL.Text.Contains("http://") OrElse Stng_MoteurRecherche_URL.Text.Contains("https://") Then
                Web.Source = New Uri(Stng_MoteurRecherche_URL.Text + SmartAdressbox.Text)
            Else
                MessageBox.Show("Veuillez vérifier les paramètres du moteur de recherche")
            End If

        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Menu_Settings.Click
        ABlueflap_Settings.BringToFront()

        If Stng_MP_confirm.Text.Equals(Stng_MP.Text) OrElse String.IsNullOrWhiteSpace(Stng_MP.Text) Then
            Stng_MP.Enabled = True
        Else
            Stng_MP.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Settings_Back.Click
        ABlueflap_Navigateur.BringToFront()

        Menu_Home.Visible = Home_checkbox.Checked
        Menu_Fight.Visible = Sfight_Checkbox.Checked
        Menu_Favos.Visible = favo_checkbox.Checked
        Menu_Share.Visible = infos_checkbox.Checked
        menu_partage.Visible = Share_checkbox.Checked
        Menu_Lock.Visible = lock_checkbox.Checked
        Menu_FullScr.Visible = fullscreen_checkbox.Checked
        Menu_Memo.Visible = memo_checkbox.Checked

        If Stng_Volet_Mousehover_agrandir.Visible = False Then
            Stng_Volet_Mousehover_agrandir.Checked = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Stng_MoteurRecherche_choose.SelectedIndexChanged
        If Stng_MoteurRecherche_choose.Text = "Google" Then
            Stng_MoteurRecherche_URL.Text = "http://www.google.fr/#hl=fr&sclient=psy-ab&q="
        ElseIf Stng_MoteurRecherche_choose.Text = "Bing" Then
            Stng_MoteurRecherche_URL.Text = "http://www.bing.com/search?q="

        ElseIf Stng_MoteurRecherche_choose.Text = "Yahoo" Then
            Stng_MoteurRecherche_URL.Text = "http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p="

        ElseIf Stng_MoteurRecherche_choose.Text = "Youtube" Then
            Stng_MoteurRecherche_URL.Text = "http://www.youtube.com/results?search_query="

        ElseIf Stng_MoteurRecherche_choose.Text = "DuckDuckGo" Then
            Stng_MoteurRecherche_URL.Text = "http://duckduckgo.com/?q="

        ElseIf Stng_MoteurRecherche_choose.Text = "Wikipedia" Then
            Stng_MoteurRecherche_URL.Text = "http://fr.wikipedia.org/w/index.php?search="

        ElseIf Stng_MoteurRecherche_choose.Text = "Qwant" Then
            Stng_MoteurRecherche_URL.Text = "http://www.qwant.com/?q="

        ElseIf Stng_MoteurRecherche_choose.Text = "Github" Then
            Stng_MoteurRecherche_URL.Text = "https://github.com/search?q="

        ElseIf Stng_MoteurRecherche_choose.Text = "Ask" Then
            Stng_MoteurRecherche_URL.Text = "http://fr.ask.com/web?q="
        End If
    End Sub
    Private Sub ActualiserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Refresh.Click
        Web.Reload(True)
    End Sub

    Private Sub ArrêterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Stop.Click
        Web.Stop()
        Menu_Refresh.Visible = True
        Menu_Stop.Visible = False
        Loader.Visible = False
    End Sub

    Private Sub PrécédentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Back.Click
        Web.GoBack()
    End Sub

    Private Sub SuivantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Forward.Click
        Web.GoForward()
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_DocumentReady(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles Web.DocumentReady
        Dim webSource As String = Web.Source.ToString()

        SmartAdressbox.Text = webSource
        Infos_Adresse.Text = webSource
        If Fav_fav_List.Items.Contains(webSource) Then
            AddFavo_Button.BackColor = Color.Azure
        Else
            AddFavo_Button.BackColor = Color.White
        End If

        Menu_Back.Enabled = Web.CanGoBack
        Menu_Forward.Enabled = Web.CanGoForward
        Notif_internet.Visible = Not My.Computer.Network.IsAvailable

        Dim html As String = Web.ExecuteJavascriptWithResult("document.getElementsByTagName('html')[0].innerHTML")
        Infos_code_source.Text = html
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        voletlateral.Renderer = New Bluerend
        If Stng_MPActiv.Checked Then
            ABlueflap_Verrouillage.BringToFront()
        Else
            If Stng_bluestart_checkbox.Checked Then
                ABlueflap_Bluestart.Visible = True
                ABlueflap_Bluestart.BringToFront()
            Else
                ABlueflap_Navigateur.BringToFront()
                ABlueflap_Verrouillage.Visible = False
            End If
        End If

        If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
            Web.Source = New Uri(Stng_HomePage_Url.Text)
        Else
            Web.Source = New Uri("http://google.fr")
            MessageBox.Show("La page d'accueil définie dans les paramètres n'est pas valide")
        End If

        If Stng_Volet_reduire.Checked Then
            voletlateral.Width = 27
            voletlateral.BackColor = Color.Black
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
        Else
            voletlateral.Width = 160
            voletlateral.BackColor = Color.White
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        End If

        Notif_internet.Visible = Not My.Computer.Network.IsAvailable

        For Each item As String In My.Settings.Bookmarks
            Fav_fav_List.Items.Add(item)
        Next
        For Each item As String In My.Settings.Bookmarks
            BS_Favlist.Items.Add(item)
        Next

        For Each item As String In My.Settings.Historique
            Fav_Historique_List.Items.Add(item)
        Next

        Menu_Home.Visible = Home_checkbox.Checked
        Menu_Fight.Visible = Sfight_Checkbox.Checked
        Menu_Favos.Visible = favo_checkbox.Checked
        Menu_Share.Visible = infos_checkbox.Checked
        menu_partage.Visible = Share_checkbox.Checked
        Menu_Lock.Visible = lock_checkbox.Checked
        Menu_FullScr.Visible = fullscreen_checkbox.Checked
        Menu_Memo.Visible = memo_checkbox.Checked

 
        Label14.Left = (Me.Width - Label14.Width) / 2
        BS_Date.Text = System.DateTime.Now.ToString("dddd dd MMMM yyyy")
        BS_Date.Left = (Me.Width - BS_Date.Width) / 2
        Verr_BlackEffect.Left = (Me.Width - Verr_BlackEffect.Width) / 2
        Verr_Time.Text = System.DateTime.Now.ToString("HH:mm")
        Verr_Date.Text = System.DateTime.Now.ToString("dddd dd MMMM yyyy")
        If Not BackgroundChemin.Text Is DBNull.Value Then
            If System.IO.File.Exists(BackgroundChemin.Text) Then
                Dim fileeName As String = System.IO.Path.GetFullPath(BackgroundChemin.Text)
                ABlueflap_Bluestart.BackgroundImage = Image.FromFile(BackgroundChemin.Text)
                ABlueflap_Verrouillage.BackgroundImage = Image.FromFile(BackgroundChemin.Text)
                stng_picdemo.BackgroundImage = Image.FromFile(BackgroundChemin.Text)
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Stng_HomePage_Url.TextChanged
          If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
            Stng_ErreurURLHomepage.Visible = False
        Else
            Stng_ErreurURLHomepage.Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Menu_Home.Click
        If Stng_bluestart_checkbox.Checked = True Then
            ABlueflap_Bluestart.Visible = True
            ABlueflap_Bluestart.BringToFront()
        Else
            If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
                Web.Source = New Uri(Stng_HomePage_Url.Text)
            Else
                Web.Source = New Uri("http://google.fr")
                MessageBox.Show("La page d'accueil définie dans les paramètres n'est pas valide")
            End If
        End If
    End Sub

    Private Sub Volet_settings_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_Volet_reduire.CheckedChanged
        If Stng_Volet_reduire.Checked Then
            voletlateral.Width = 27
            voletlateral.BackColor = Color.Black
            Stng_Volet_Mousehover_agrandir.Visible = True
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
        Else
            voletlateral.Width = 160
            voletlateral.BackColor = Color.White
            voletlateral.SendToBack()
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            Stng_Volet_Mousehover_agrandir.Visible = False
        End If
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_FullScr.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Normal
            Me.WindowState = FormWindowState.Maximized
            Menu_FullScr.Text = "Mode fenêtre"
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Menu_FullScr.Text = "Plein écran"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Stng_MP_confirm.TextChanged
        If Stng_MP_confirm.Text.Equals(Stng_MP.Text) Then
            Stng_MPActiv.Enabled = True
            Stng_MP.Enabled = True
            Stng_MP_confirm.ForeColor = Color.Green
        Else
            Stng_MPActiv.Enabled = False
            Stng_MP.Enabled = False
            Stng_MP_confirm.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles Menu_Lock.Click
        Form2.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Menu_Share.Click
        ABlueflap_Infos.BringToFront()
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub Back_info_Click(sender As Object, e As EventArgs) Handles Infos_back.Click
        ABlueflap_Navigateur.BringToFront()
        Infos_Trident_Browser_Recup_Infos.Navigate("about:blank")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Verr_AcceptButt.Click
        If Verr_Textbox.Text.Equals(Stng_MP.Text) Then
            ABlueflap_Navigateur.BringToFront()
            ABlueflap_Verrouillage.Visible = False
        Else
            Verr_WrongMp.Visible = True
        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_Volet_Mousehover_agrandir.CheckedChanged
        If Stng_Volet_Mousehover_agrandir.Checked Then
            voletlateral.BringToFront()
        Else
            voletlateral.SendToBack()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles SrchF_Back.Click
        ABlueflap_Navigateur.BringToFront()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles Menu_Fight.Click
        ABlueflap_Fight.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles SrchF_Fightbutton.Click
        If SrchF_ChoixA.Text = "Google" Then
            SrchF_fighter_1.Source = New Uri("http://www.google.fr/#hl=fr&sclient=psy-ab&q=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixA.Text = "Bing" Then
            SrchF_fighter_1.Source = New Uri("http://www.bing.com/search?q=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixA.Text = "Yahoo" Then
            SrchF_fighter_1.Source = New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixA.Text = "DuckDuckGo" Then
            SrchF_fighter_1.Source = New Uri("http://duckduckgo.com/?q=" + SrchF_Searchbox.Text)
        End If


        If SrchF_ChoixB.Text = "Google" Then
            SrchF_fighter_2.Source = New Uri("http://www.google.fr/#hl=fr&sclient=psy-ab&q=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixB.Text = "Bing" Then
            SrchF_fighter_2.Source = New Uri("http://www.bing.com/search?q=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixB.Text = "Yahoo" Then
            SrchF_fighter_2.Source = New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + SrchF_Searchbox.Text)

        ElseIf SrchF_ChoixB.Text = "DuckDuckGo" Then
            SrchF_fighter_2.Source = New Uri("http://duckduckgo.com/?q=" + SrchF_Searchbox.Text)

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles SrchF_Searchbox.TextChanged
        Me.AcceptButton = SrchF_Fightbutton
    End Sub
    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles SrchF_Searchbox.Leave
        Me.AcceptButton = Nothing
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Verr_Textbox.TextChanged
        Me.AcceptButton = Verr_AcceptButt
        Verr_WrongMp.Visible = False
    End Sub
    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles Verr_Textbox.Leave
        Me.AcceptButton = Nothing
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Infos_CodeShowHide.Click
        Infos_Share.Visible = False
        Infos_code_source.Visible = Not Infos_code_source.Visible
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Infos_Trident_Browser_Recup_Infos.DocumentCompleted
        Infos_Loader.Visible = False
        Infos_Loading.Visible = False
        Infos_Save.Visible = True
        Infos_Print.Visible = True
        If stng_nevpriv.Checked = True Then
            Web.WebSession.ClearCookies()
        End If
    End Sub
    Private Sub Infoload_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles Infos_Trident_Browser_Recup_Infos.Navigating
        Infos_Loader.Visible = True
        Infos_Loading.Visible = True
        Infos_Save.Visible = False
        Infos_Print.Visible = False
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Infos_Print.Click
        Infos_Trident_Browser_Recup_Infos.ShowPrintPreviewDialog()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Infos_Save.Click
        Infos_Trident_Browser_Recup_Infos.ShowSaveAsDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddFavo_Button.Click
        Notif_add.Visible = True
        If Fav_fav_List.Items.Contains(Web.Source.ToString) Then
            Textenotif.Text = "Page déjà dans vos favoris"
        Else
            My.Settings.Bookmarks.Add(Web.Source.ToString)
            Fav_fav_List.Items.Clear()
            For Each Item As String In My.Settings.Bookmarks
                Fav_fav_List.Items.Add(Item)
            Next
            AddFavo_Button.BackColor = Color.Azure
            Textenotif.Text = "Page ajoutée aux favoris"
        End If
    End Sub
    Private Sub Favoris_Norif(sender As Object, e As EventArgs) Handles Fav_fav_List.DoubleClick
        If Not String.IsNullOrWhiteSpace(Fav_fav_List.SelectedItem) Then
            Web.Source = New Uri(Fav_fav_List.SelectedItem)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Fav_Cancel.Click
        fav_notif_suppr.Visible = False
    End Sub
    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        fav_notif_suppr.Visible = True
    End Sub

    Private Sub AccéderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccéderToolStripMenuItem.Click
        If Not String.IsNullOrWhiteSpace(Fav_fav_List.SelectedItem) Then
            Web.Source = New Uri(Fav_fav_List.SelectedItem)
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Fav_Confirm.Click
        My.Settings.Bookmarks.Remove(Fav_fav_List.SelectedItem)
        Fav_fav_List.Items.Clear()
        For Each Item As String In My.Settings.Bookmarks
            Fav_fav_List.Items.Add(Item)
        Next
        fav_notif_suppr.Visible = False
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles Menu_Favos.Click
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub Notif_add_Click(sender As Object, e As EventArgs) Handles Notif_add.Click
        Panel1.Visible = True
        Notif_add.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Notiff_add_OKbutton.Click
        Notif_add.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Fav_Close.Click
        Panel1.Visible = False
    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl_Navig(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles Web.LoadingFrame
        Menu_Stop.Visible = True
        Loader.Visible = True
        Menu_Refresh.Visible = False
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(sender As Object, e As Awesomium.Core.FrameEventArgs) Handles Web.LoadingFrameComplete
        Menu_Stop.Visible = False
        Loader.Visible = False
        Menu_Refresh.Visible = True
        Infos_Titre.Text = Web.Title

        If Not stng_nevpriv.Checked Then
            If Not Fav_Historique_List.Items.Contains(SmartAdressbox.Text) Then
                My.Settings.Historique.Add(SmartAdressbox.Text)
                Fav_Historique_List.Items.Clear()
                For Each Item As String In My.Settings.Historique
                    Fav_Historique_List.Items.Add(Item)
                Next
            End If
        End If

        If SmartAdressbox.Text.Contains("https://") Then
            SmartAdressbox.ForeColor = Color.DarkGreen
        Else
            SmartAdressbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_Crashed(sender As Object, e As Awesomium.Core.CrashedEventArgs) Handles Web.Crashed
        MessageBox.Show("Une erreur est survenue, actualisez la page")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Process.Start("inetcpl.cpl")
    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Stng_OptionsInternet.Click
        Process.Start("inetcpl.cpl")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_TouchUI.CheckedChanged
        If Stng_TouchUI.Checked = True Then
            Form3.Show()
            Menu_Home.Font = New Font("Segoe UI Light", 16)
            Menu_Back.Font = New Font("Segoe UI Light", 16)
            Menu_Forward.Font = New Font("Segoe UI Light", 16)
            Menu_Stop.Font = New Font("Segoe UI Light", 16)
            Menu_Refresh.Font = New Font("Segoe UI Light", 16)
            Menu_Fight.Font = New Font("Segoe UI Light", 16)
            Menu_Settings.Font = New Font("Segoe UI Light", 16)
            Menu_Share.Font = New Font("Segoe UI Light", 16)
            menu_partage.Font = New Font("Segoe UI Light", 16)
            Menu_Favos.Font = New Font("Segoe UI Light", 16)
            Menu_Lock.Font = New Font("Segoe UI Light", 16)
            Menu_FullScr.Font = New Font("Segoe UI Light", 16)
            Menu_Memo.Font = New Font("Segoe UI Light", 16)
            SmartAdressbox.Font = New Font("Segoe UI Light", 13)
            Barre.Height = 40
            AddFavo_Button.Height = 31
            GoButton.Height = 29
            Menu_ShowHide_Button.Height = 38
        Else
            Form3.Close()
            Menu_Home.Font = New Font("Segoe UI Light", 11)
            Menu_Back.Font = New Font("Segoe UI Light", 11)
            Menu_Forward.Font = New Font("Segoe UI Light", 11)
            Menu_Stop.Font = New Font("Segoe UI Light", 11)
            Menu_Refresh.Font = New Font("Segoe UI Light", 11)
            Menu_Fight.Font = New Font("Segoe UI Light", 11)
            Menu_Settings.Font = New Font("Segoe UI Light", 11)
            Menu_Share.Font = New Font("Segoe UI Light", 11)
            menu_partage.Font = New Font("Segoe UI Light", 11)
            Menu_Favos.Font = New Font("Segoe UI Light", 11)
            Menu_Lock.Font = New Font("Segoe UI Light", 11)
            Menu_FullScr.Font = New Font("Segoe UI Light", 11)
            Menu_Memo.Font = New Font("Segoe UI Light", 11)
            SmartAdressbox.Font = New Font("Microsoft Sans Serif", 8)
            Barre.Height = 27
            AddFavo_Button.Height = 20
            GoButton.Height = 18
            Menu_ShowHide_Button.Height = 27
        End If
    End Sub

    Private Sub Verrouillage_MouseMove(sender As Object, e As MouseEventArgs) Handles ABlueflap_Verrouillage.MouseMove
        Verr_Time.Text = System.DateTime.Now.ToString("HH:mm")
        Verr_Date.Text = System.DateTime.Now.ToString("dddd dd MMMM yyyy")
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Stng_SupprHisto.Click
        My.Settings.Historique.Clear()
        Fav_Historique_List.Items.Clear()
    End Sub

    Private Sub Histor_Click(sender As Object, e As EventArgs) Handles Fav_Historique_List.Click
        If Not String.IsNullOrWhiteSpace(Fav_Historique_List.SelectedItem) Then
            Web.Source = New Uri(Fav_Historique_List.SelectedItem)
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles Web.ShowCreatedWebView
        Web.Source = e.TargetURL
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_1(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles SrchF_fighter_1.ShowCreatedWebView
        SrchF_fighter_1.Source = e.TargetURL
    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_2(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles SrchF_fighter_2.ShowCreatedWebView
        SrchF_fighter_2.Source = e.TargetURL
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles Stng_MaximizedWindow.CheckedChanged
        If Stng_MaximizedWindow.Checked Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Stng_SupprCacheCookies.Click
        Web.WebSession.ClearCache()
        Web.WebSession.ClearCookies()
    End Sub

    Private Sub volet_MouseHover(sender As Object, e As EventArgs) Handles voletlateral.MouseHover
        If Stng_Volet_reduire.Checked AndAlso Stng_Volet_Mousehover_agrandir.Checked Then
            voletlateral.BackColor = Color.White
            voletlateral.Width = 160
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        End If
    End Sub

    Private Sub volet_MouseLeave(sender As Object, e As EventArgs) Handles voletlateral.MouseLeave
        If Stng_Volet_reduire.Checked AndAlso Stng_Volet_Mousehover_agrandir.Checked Then
            voletlateral.Width = 27
            voletlateral.BackColor = Color.Black
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
        End If
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Stng_Volet_Mousehover_agrandir.Visible = False Then
            Stng_Volet_Mousehover_agrandir.Checked = False
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        ABlueflap_Bluestart.BringToFront()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        BS_Date.Left = (Me.Width - BS_Date.Width) / 2
        Label14.Left = (Me.Width - Label14.Width) / 2
        Verr_BlackEffect.Left = (Me.Width - Verr_BlackEffect.Width) / 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BS_Settings.Click
        Pop.Visible = Not Pop.Visible
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Bs_Searchbox.TextChanged
        Me.AcceptButton = BS_Searchbutton
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles BS_Searchbutton.Click
        If Stng_MoteurRecherche_URL.Text.Contains("http://") OrElse Stng_MoteurRecherche_URL.Text.Contains("https://") Then
            Web.Source = New Uri(Stng_MoteurRecherche_URL.Text + Bs_Searchbox.Text)
        Else
            MessageBox.Show("Veuillez vérifier les paramètres du moteur de recherche")
        End If
        ABlueflap_Navigateur.BringToFront()
        ABlueflap_Bluestart.Visible = False
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles Bs_Searchbox.Leave
        Me.AcceptButton = Nothing
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles BS_ImgChoose.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            ABlueflap_Bluestart.BackgroundImage = New Bitmap(open.FileName)
            BackgroundChemin.Text = fileName
            stng_picdemo.BackgroundImage = New Bitmap(open.FileName)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BS_DateSetColor.Click
        If BS_Date.ForeColor = Color.White Then
            BS_Date.ForeColor = Color.Black
            BS_DateSetColor.Text = "Date : Claire"
        Else
            BS_Date.ForeColor = Color.White
            BS_DateSetColor.Text = "Date : Sombre"
        End If
    End Sub
    Private Sub Flop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BS_Favlist.Click
        If Not String.IsNullOrWhiteSpace(BS_Favlist.SelectedItem) Then
            Web.Source = New Uri(BS_Favlist.SelectedItem)
            ABlueflap_Navigateur.BringToFront()
            ABlueflap_Bluestart.Visible = False
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BS_Fav.Click
        Bs_Favbulle.Visible = Not Bs_Favbulle.Visible
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles BS_Browser.Click
        ABlueflap_Navigateur.BringToFront()
        ABlueflap_Bluestart.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BS_Searchfight.Click
        ABlueflap_Fight.BringToFront()
        ABlueflap_Bluestart.Visible = False
    End Sub

    Private Sub Textenotif_Click(sender As Object, e As EventArgs) Handles Textenotif.Click
        Panel1.Visible = True
        Notif_add.Visible = False
    End Sub

    Private Sub Stng_ShowLicense_Click(sender As Object, e As EventArgs) Handles Stng_ShowLicense.Click
        Licence.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://github.com/SimpleSoftwares/Blueflap/issues")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles stng_simpleworld.Click
        Process.Start("http://simpleworld-website.weebly.com")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles stng_github.Click
        Process.Start("https://github.com/SimpleSoftwares/Blueflap")
    End Sub
    Private Sub Menu_Memo_Click(sender As Object, e As EventArgs) Handles Menu_Memo.Click
        Form4.Show()
    End Sub

    Private Sub SmartAdressbox_TextChanged(sender As Object, e As EventArgs) Handles SmartAdressbox.TextChanged
        Me.AcceptButton = GoButton
        If Web.IsLoading = True Then
            SmartAdressbox.ForeColor = Color.Black
        Else
            Dim textArray = SmartAdressbox.Text.Split(" ")
            If (SmartAdressbox.Text.Contains(".") = True And SmartAdressbox.Text.Contains(" ") = False And SmartAdressbox.Text.Contains(" .") = False And SmartAdressbox.Text.Contains(". ") = False) Or textArray(0).Contains(":/") = True Or textArray(0).Contains(":\") Then
                SmartAdressbox.ForeColor = Color.DodgerBlue
            Else
                SmartAdressbox.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Process.Start("https://github.com/SimpleSoftwares/Blueflap/issues")
    End Sub

    Private Sub sett_tab1_Click(sender As Object, e As EventArgs) Handles sett_tab1.Click
        Sett_TabB.Visible = False
        Sett_TabC.Visible = False
        Sett_TabA.Visible = True
        sett_tab1.LineColorChecked = Color.SteelBlue
        sett_tab2.LineColorChecked = Color.DeepSkyBlue
        sett_tab3.LineColorChecked = Color.DeepSkyBlue
        sett_tab2.Refresh()
        sett_tab3.Refresh()
    End Sub

    Private Sub sett_tab2_Click(sender As Object, e As EventArgs) Handles sett_tab2.Click
        Sett_TabA.Visible = False
        Sett_TabC.Visible = False
        Sett_TabB.Visible = True
        sett_tab1.LineColorChecked = Color.DeepSkyBlue
        sett_tab2.LineColorChecked = Color.SteelBlue
        sett_tab3.LineColorChecked = Color.DeepSkyBlue
        sett_tab1.Refresh()
        sett_tab3.Refresh()
    End Sub

    Private Sub sett_tab3_Click(sender As Object, e As EventArgs) Handles sett_tab3.Click
        Sett_TabB.Visible = False
        Sett_TabA.Visible = False
        Sett_TabC.Visible = True
        sett_tab1.LineColorChecked = Color.DeepSkyBlue
        sett_tab2.LineColorChecked = Color.DeepSkyBlue
        sett_tab3.LineColorChecked = Color.SteelBlue
        sett_tab1.Refresh()
        sett_tab2.Refresh()
    End Sub

    Private Sub sett_tab1_MouseEnter(sender As Object, e As EventArgs) Handles sett_tab1.MouseEnter
        sett_tab1.ForeColor = Color.SteelBlue
    End Sub

    Private Sub sett_tab1_MouseLeave(sender As Object, e As EventArgs) Handles sett_tab1.MouseLeave
        sett_tab1.ForeColor = Color.DeepSkyBlue
    End Sub
    Private Sub sett_tab2_MouseEnter(sender As Object, e As EventArgs) Handles sett_tab2.MouseEnter
        sett_tab2.ForeColor = Color.SteelBlue
    End Sub

    Private Sub sett_tab2_MouseLeave(sender As Object, e As EventArgs) Handles sett_tab2.MouseLeave
        sett_tab2.ForeColor = Color.DeepSkyBlue
    End Sub
    Private Sub sett_tab3_MouseEnter(sender As Object, e As EventArgs) Handles sett_tab3.MouseEnter
        sett_tab3.ForeColor = Color.SteelBlue
    End Sub

    Private Sub sett_tab3_MouseLeave(sender As Object, e As EventArgs) Handles sett_tab3.MouseLeave
        sett_tab3.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub MetroHeaderButton1_Click(sender As Object, e As EventArgs) Handles MetroHeaderButton1.MouseEnter
        MetroHeaderButton1.ForeColor = Color.DeepSkyBlue
    End Sub
    Private Sub MetroHeaderButton1_Sortie(sender As Object, e As EventArgs) Handles MetroHeaderButton1.MouseLeave
        MetroHeaderButton1.ForeColor = Color.SkyBlue
    End Sub

    Private Sub MetroHeaderButton1_Click_1(sender As Object, e As EventArgs) Handles MetroHeaderButton1.Click
        Form5.Show()
    End Sub

    Private Sub MetroHeaderButton2_Click(sender As Object, e As EventArgs) Handles MetroHeaderButton2.Click
        Fav_Historique_List.Visible = False
        MetroHeaderButton2.LineColorChecked = Color.SteelBlue
        MetroHeaderButton3.LineColorChecked = Color.DeepSkyBlue
        MetroHeaderButton3.Refresh()
    End Sub

    Private Sub MetroHeaderButton3_Click(sender As Object, e As EventArgs) Handles MetroHeaderButton3.Click
        Fav_Historique_List.Visible = True
        MetroHeaderButton3.LineColorChecked = Color.SteelBlue
        MetroHeaderButton2.LineColorChecked = Color.DeepSkyBlue
        MetroHeaderButton2.Refresh()
    End Sub

    Private Sub MetroHeaderButton2_MouseEnter(sender As Object, e As EventArgs) Handles MetroHeaderButton2.MouseEnter
        MetroHeaderButton2.ForeColor = Color.SteelBlue
    End Sub
    Private Sub MetroHeaderButton2_MouseLeave(sender As Object, e As EventArgs) Handles MetroHeaderButton2.MouseLeave
        MetroHeaderButton2.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub MetroHeaderButton3_MouseEnter(sender As Object, e As EventArgs) Handles MetroHeaderButton3.MouseEnter
        MetroHeaderButton3.ForeColor = Color.SteelBlue
    End Sub
    Private Sub MetroHeaderButton3_MouseLeave(sender As Object, e As EventArgs) Handles MetroHeaderButton3.MouseLeave
        MetroHeaderButton3.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            BackgroundChemin.Text = fileName
            ABlueflap_Bluestart.BackgroundImage = New Bitmap(open.FileName)
            stng_picdemo.BackgroundImage = New Bitmap(open.FileName)
        End If
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        ABlueflap_Infos.BringToFront()
        Infos_code_source.Visible = False
        Infos_Share.Visible = True
        Infos_Share.Source = New Uri("https://www.facebook.com/sharer/sharer.php?u=" + SmartAdressbox.Text)
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        ABlueflap_Infos.BringToFront()
        Infos_code_source.Visible = False
        Infos_Share.Visible = True
        Infos_Share.Source = New Uri("https://twitter.com/home?status=@BlueflapBrowser%20cette%20page%20est%20fantastique%20!%20" + SmartAdressbox.Text)
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/zyhou")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://github.com/baptisteguil")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://github.com/Bat41")
    End Sub
    Private Sub SmartAdressbox_Leave(sender As Object, e As EventArgs) Handles SmartAdressbox.Leave
        Me.AcceptButton = Nothing
    End Sub
End Class
