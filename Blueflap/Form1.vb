'  Blueflap a été codé par Simpleworld et vous est proposé sous license GPLV2. Avis au forkeurs, merci de laisser ce message par respect et reconnaissance au developpeur initital.
'  Nous espérons que Blueflap vous servira de support pour vos projets les plus fous.
'
'  Cordialement. Simpleworld
'  -------------------------------------------------------------------------------------
Public Class Fenetre_Principale
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public Shared Event DownloadBegin As Awesomium.Core.DownloadBeginEventHandler
    Private Class Bluerend : Inherits ToolStripProfessionalRenderer
        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
            If e.Item.Selected Then
                If e.Item.Width > 140 OrElse e.Item.Text = "Facebook" OrElse e.Item.Text = "Twitter" OrElse e.Item.Text = "AddThis" Then
                    Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                    'Element du menu Blueflap au passage de la souris
                    e.Graphics.FillRectangle(Brushes.Transparent, rc)
                    e.Graphics.DrawRectangle(Pens.WhiteSmoke, 1, 0, rc.Width + 1, rc.Height - 1)
                    e.Item.ForeColor = Fenetre_Principale.colorbox.BackColor
                Else
                    Dim rc As New Rectangle(New System.Drawing.Point(19, 0), New System.Drawing.Size(2, 25))
                    'Element du menu Blueflap au passage de la souris
                    e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rc)
                    e.Graphics.DrawRectangle(Pens.Transparent, 1, 0, rc.Width - 1, rc.Height - 1)
                    e.Item.ForeColor = Fenetre_Principale.colorbox.BackColor
                End If
            Else
                Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                'Element du menu Blueflap au repos
                e.Graphics.FillRectangle(Brushes.Transparent, rc)
                e.Item.ForeColor = Fenetre_Principale.Colorbox2.BackColor
            End If
        End Sub
    End Class
    Private Sub MenuBoutton_Click(sender As Object, e As EventArgs) Handles Menu_ShowHide_Button.Click

        If voletlateral.Width = 27 Then 'Quand le volet latéral est en position réduite > Agrandir le volet
            voletlateral.BackColor = Color.White
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            If stng_anim.Checked Then 'Si les animations sont activées
                voletlateral.Width = 60
                Do Until voletlateral.Width = 160
                    voletlateral.Width += 10
                Loop
            Else
                voletlateral.Width = 160
            End If

        Else 'Sinon réduire le volet
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
            If stng_grayicons.Checked Then
                voletlateral.BackColor = Color.WhiteSmoke
            Else
                voletlateral.BackColor = Color.Black
            End If
            If stng_anim.Checked Then 'Si les animations sont activées
                voletlateral.Width = 110
                Do Until voletlateral.Width = 30
                    voletlateral.Width -= 10
                Loop
                voletlateral.Width = 27
            Else
                voletlateral.Width = 27
            End If
        End If
        voletlateral.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        If stng_Smartsuggestactif.Checked Then 'Si SmartSuggest est actif, ajoute le mot-clé dans les suggestions
            My.Settings.Smartcoll.Add(SmartAdressbox.Text)
            SmartAdressbox.AutoCompleteCustomSource.Clear()
            For Each Item As String In My.Settings.Smartcoll
                SmartAdressbox.AutoCompleteCustomSource.Add(Item)
            Next
        End If

        Dim textArray = SmartAdressbox.Text.Split(" ")
        'Blueflap va déterminer si il s'agit d'une URL ou d'un mot-clé
        If (SmartAdressbox.Text.Contains(".") = True And SmartAdressbox.Text.Contains(" ") = False And SmartAdressbox.Text.Contains(" .") = False And SmartAdressbox.Text.Contains(". ") = False) Or textArray(0).Contains(":/") = True Or textArray(0).Contains(":\") Then
            If SmartAdressbox.Text.Contains("http://") OrElse SmartAdressbox.Text.Contains("https://") Then
                Web.Source = New Uri(SmartAdressbox.Text)
            Else
                If SmartAdressbox.Text.Contains("blueflap://") Then
                    If SmartAdressbox.Text = "blueflap://settings" Then
                        ABlueflap_Settings.BringToFront()
                    ElseIf SmartAdressbox.Text = "blueflap://searchfight" Then
                        ABlueflap_Fight.BringToFront()
                    ElseIf SmartAdressbox.Text = "blueflap://update" Then
                        ABlueflap_Update.BringToFront()
                    ElseIf SmartAdressbox.Text = "blueflap://reset:stats" Then
                        Stat1.Text = 0
                        stat2.Text = 0
                        messageboxe.Show()
                        messageboxe.BackColor = Color.CornflowerBlue
                        If My.Settings.linguuu = "English" Then
                            messageboxe.Titre.Text = "Settings"
                            messageboxe.Text.Text = "Stat has been reset"
                        Else
                            messageboxe.Titre.Text = "Paramètres"
                            messageboxe.Text.Text = "Les statistiques ont été remises à zero"
                        End If
                        messageboxe.Smiley.Text = ";)"
                    ElseIf SmartAdressbox.Text = "blueflap://reset:settings" Then
                        Reinitialisation()
                    End If
                Else
                    Web.Source = New Uri("http://" + SmartAdressbox.Text)
                End If
            End If
        Else

            'Si c'est un mot-clé, vérification de la validité du moteur de recherche
            If Stng_MoteurRecherche_URL.Text.Contains("http://") OrElse Stng_MoteurRecherche_URL.Text.Contains("https://") Then
                Dim azert As String
                azert = SmartAdressbox.Text
                Dim s As String
                s = azert.ToString
                s = s.Replace("+", "%2B")

                Web.Source = New Uri(Stng_MoteurRecherche_URL.Text + s)
            Else
                messageboxe.Show()
                messageboxe.BackColor = Color.LightCoral
                If My.Settings.linguuu = "English" Then
                    messageboxe.Titre.Text = "Error"
                    messageboxe.Text.Text = "Something is wrong with the search engine"
                Else
                    messageboxe.Titre.Text = "Erreur"
                    messageboxe.Text.Text = "Veuillez vérifier les paramètres du moteur de recherche"
                End If
                messageboxe.Smiley.Text = ":("
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Menu_Settings.Click
        ABlueflap_Settings.BringToFront() 'Affiche les paramètres

        If Stng_MP_confirm.Text.Equals(Stng_MP.Text) OrElse String.IsNullOrWhiteSpace(Stng_MP.Text) Then
            Stng_MP.Enabled = True
        Else
            Stng_MP.Enabled = False
        End If
    End Sub
    Private Sub ElementsMenu()
        'Détermine la visibilité des éléments du menu
        menuT_Home.Visible = Home_checkbox.Checked
        Menu_Home.Visible = Home_checkbox.Checked
        menuT_Fight.Visible = Sfight_Checkbox.Checked
        Menu_Fight.Visible = Sfight_Checkbox.Checked
        Menu_Favos.Visible = favo_checkbox.Checked
        menut_Info.Visible = infos_checkbox.Checked
        Menu_Share.Visible = infos_checkbox.Checked
        Menu_Translate.Visible = translate_checkbox.Checked
        menu_partage.Visible = Share_checkbox.Checked
        menuT_lock.Visible = lock_checkbox.Checked
        Menu_Lock.Visible = lock_checkbox.Checked
        menuT_fullscreen.Visible = fullscreen_checkbox.Checked
        Menu_FullScr.Visible = fullscreen_checkbox.Checked
        menuT_memo.Visible = memo_checkbox.Checked
        Menu_Memo.Visible = memo_checkbox.Checked
        menuT_clavier.Visible = stng_clavi.Checked
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Settings_Back.Click
        'Permet de quitter les paramètres
        ABlueflap_Settings.SendToBack()
        ElementsMenu()
        If Stng_Volet_Mousehover_agrandir.Visible = False Then
            Stng_Volet_Mousehover_agrandir.Checked = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Stng_MoteurRecherche_choose.SelectedIndexChanged
        'Changement de moteur de recherche
        If Stng_MoteurRecherche_choose.Text = "Google" Then
            Stng_MoteurRecherche_URL.Text = "http://www.google.fr/search?q="
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

        ElseIf Stng_MoteurRecherche_choose.Text = "Dreamvids" Then
            Stng_MoteurRecherche_URL.Text = "http://dreamvids.fr/search?q="

        ElseIf Stng_MoteurRecherche_choose.Text = "Ask" Then
            Stng_MoteurRecherche_URL.Text = "http://fr.ask.com/web?q="
        End If

    End Sub
    Private Sub ActualiserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Refresh.Click
        Web.Reload(True) 'Recharge la page
    End Sub

    Private Sub ArrêterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Stop.Click
        'Arrête le chargement de la page
        Web.Stop()
        Menu_Refresh.Visible = True
        Menu_Stop.Visible = False
        Loader.Visible = False
        Adressboxtouch.BackgroundImage = Blueflap.My.Resources.Resources.back1
        If Adressboxtouch.Height = 20 OrElse Adressboxtouch.Height = 10 Then
            Adressboxtouch.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub PrécédentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Back.Click
        Web.GoBack() 'Précédent
    End Sub

    Private Sub SuivantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_Forward.Click
        Web.GoForward() 'Suivant
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_DocumentReady(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles Web.DocumentReady
        'Quand le chargement de la page Web est terminé
        Dim webSource As String = Web.Source.ToString()
        SmartAdressbox.Text = webSource
        touchbox.Text = webSource
        Infos_Adresse.Text = webSource

        'Blueflap va déterminer si la page est déjà présente dans les favoris
        If Fav_fav_List.Items.Contains(webSource) Then
            AddFavo_Button.BackColor = Color.Azure
            Addfavtouch.BackColor = Color.MidnightBlue
        Else
            AddFavo_Button.BackColor = Color.White
            Addfavtouch.BackColor = Color.Gray
        End If

        'Blueflap règle l'affichage des icônes précedent/suivant (interface normale et tactile)
        Menu_Back.Enabled = Web.CanGoBack
        menuT_back.Visible = Web.CanGoBack
        Menu_Forward.Enabled = Web.CanGoForward
        menuT_forward.Visible = Web.CanGoForward
        Notif_internet.Visible = Not My.Computer.Network.IsAvailable

        'Le code source de la page est importé sur la page "infos"
        Dim html As String = Web.ExecuteJavascriptWithResult("document.getElementsByTagName('html')[0].innerHTML")
        Infos_code_source.Text = html
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Au démarrage de Blueflap
        If Linguabut.Text = "English" Then
            Lingua()
        End If
        voletlateral.Renderer = New Bluerend 'Affiche le style défini en début de code dans le menu

        AddHandler Awesomium.Core.WebCore.DownloadBegin, AddressOf OnDownloadBegin

        'Blueflap détermine le comportement à adopter au démarrage...
        If Stng_MPActiv.Checked Then '...doit-il afficher la page de deverrouillage ?
            ABlueflap_Verrouillage.BringToFront()
        Else
            If Stng_bluestart_checkbox.Checked Then '... doit-il afficher Bluestart ?
                ABlueflap_Bluestart.Visible = True
                ABlueflap_Bluestart.BringToFront()
            Else '...doit-il naviguer vers la page d'accueil ?
                If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
                    Web.Source = New Uri(Stng_HomePage_Url.Text)
                Else
                    Web.Source = New Uri("http://google.fr")
                    messageboxe.Show()
                    messageboxe.BackColor = Color.LightCoral

                    If My.Settings.linguuu = "English" Then
                        messageboxe.Titre.Text = "Settings"
                        messageboxe.Text.Text = "Something is wrong with the homepage"
                    Else
                        messageboxe.Titre.Text = "Paramètres"
                        messageboxe.Text.Text = "La page d'accueil définie dans les paramètres n'est pas valide"
                    End If

                    messageboxe.Smiley.Text = ":("
                End If
                ABlueflap_Navigateur.BringToFront()
                ABlueflap_Verrouillage.Visible = False
            End If
        End If

        'Permet d'afficher une page web lors du premier lancement de Blueflap puis de définir Bluestart en page d'accueil
        If Stat1.Text = "0" Then
            ABlueflap_Welcome.BringToFront()
            ABlueflap_Welcome.Visible = True
        End If

        'Bueflap retrouve les favoris enregistrés
        For Each item As String In My.Settings.Bookmarks
            Fav_fav_List.Items.Add(item)
            BS_Favlist.Items.Add(item)
            If stng_Smartsuggestactif.Checked Then
                If Not SmartAdressbox.AutoCompleteCustomSource.Contains(item) Then
                    My.Settings.Smartcoll.Add(item)
                    SmartAdressbox.AutoCompleteCustomSource.Clear()
                    SmartAdressbox.AutoCompleteCustomSource.Add(item)
                End If
            End If
        Next

        If stng_Smartsuggestactif.Checked Then
            For Each item As String In My.Settings.Smartcoll
                SmartAdressbox.AutoCompleteCustomSource.Add(item)
            Next
        End If

        For Each item As String In My.Settings.Historique
            Fav_Historique_List.Items.Add(item)
        Next

        'Détermine si le volet est réduit au démarrage
        If Stng_Volet_reduire.Checked Then
            voletlateral.Width = 27
            If stng_grayicons.Checked Then
                voletlateral.BackColor = Color.WhiteSmoke
            Else
                voletlateral.BackColor = Color.Black
            End If
            voletlateral.LayoutStyle = ToolStripLayoutStyle.Table
        Else
            voletlateral.Width = 160
            voletlateral.BackColor = Color.White
            voletlateral.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        End If

        Notif_internet.Visible = Not My.Computer.Network.IsAvailable 'Détermine si internet est connecté

        ElementsMenu() 'Affiche/masque les icônes du menu selon les paramètres de l'utilisateur

        'Charge Bluestart
        BS_SearchBlackEffect.Left = (Me.Width - BS_SearchBlackEffect.Width) / 2
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

        'Applique le thème choisi par l'utilisateur
        If stng_colorlinecheck.Checked Then
            colorline.Visible = True
        Else
            colorline.Visible = False
        End If
        Grayicons()
        colorline.BackColor = colorbox.BackColor
        Touchmode()

        If Update_startverif.Checked Then
            WebBrowser1.Navigate("http://personnalisa.bl.ee/Version.html")
            Update_currentver.Text = Stng_VersionSystem.Text
        End If

        menuT_clavier.Visible = stng_clavi.Checked

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Stng_HomePage_Url.TextChanged
        'Détermine si la page d'accueil tapée est valide
        If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
            Stng_ErreurURLHomepage.Visible = False
        Else
            Stng_ErreurURLHomepage.Visible = True
        End If
    End Sub
    Private Sub Pageaccueil()
        'Quel comportement adopter lors du clic sur le bouton "accueil"
        If Stng_bluestart_checkbox.Checked = True Then
            ABlueflap_Bluestart.Visible = True
            ABlueflap_Bluestart.BringToFront()
        Else
            If Stng_HomePage_Url.Text.Contains("http://") OrElse Stng_HomePage_Url.Text.Contains("https://") Then
                Web.Source = New Uri(Stng_HomePage_Url.Text)
            Else
                Web.Source = New Uri("http://google.fr")

                messageboxe.Show()
                messageboxe.BackColor = Color.LightCoral
                If My.Settings.linguuu = "English" Then
                    messageboxe.Titre.Text = "Settings"
                    messageboxe.Text.Text = "Something is wrong with the homepage"
                Else
                    messageboxe.Titre.Text = "Paramètres"
                    messageboxe.Text.Text = "La page d'accueil définie dans les paramètres n'est pas valide"
                End If
                messageboxe.Smiley.Text = ":("
            End If
        End If
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Menu_Home.Click
        Pageaccueil()
    End Sub

    Private Sub Volet_settings_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_Volet_reduire.CheckedChanged
        'Option pour réduire le volet au démarrage de Blueflap
        If Stng_Volet_reduire.Checked Then
            voletlateral.Width = 27
            If stng_grayicons.Checked Then
                voletlateral.BackColor = Color.WhiteSmoke
            Else
                voletlateral.BackColor = Color.Black
            End If
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
    Private Sub Pleinecran()
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
    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_FullScr.Click
        Pleinecran()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Stng_MP_confirm.TextChanged
        'confirmation du mot de passe dans les paramètres
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
        'affiche la fenêtre de demande de mot de passe
        Form2.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Menu_Share.Click
        'Affiche les informations d'une page
        ABlueflap_Infos.BringToFront()
        ABlueflap_Infos.Visible = True
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source) 'Moteur Awesomium ne permet pas de récupérer toutes les infos
    End Sub

    Private Sub Back_info_Click(sender As Object, e As EventArgs) Handles Infos_back.Click
        'Retour sur le navigateur (depuis les informations de la page)
        ABlueflap_Navigateur.BringToFront()
        ABlueflap_Infos.Visible = False
        Infos_Trident_Browser_Recup_Infos.Navigate("about:blank") 'permet d'éviter certains problèmes
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Verr_AcceptButt.Click
        'Verification du mot de passe sur l'écran verrouillé
        If Verr_Textbox.Text.Equals(Stng_MP.Text) Then
            ABlueflap_Navigateur.BringToFront()
            ABlueflap_Verrouillage.Visible = False
        Else
            Verr_WrongMp.Visible = True
        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_Volet_Mousehover_agrandir.CheckedChanged
        'Agrandir le volet au passage de la souris
        If Stng_Volet_Mousehover_agrandir.Checked Then
            voletlateral.BringToFront()
        Else
            voletlateral.SendToBack()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles SrchF_Back.Click
        'Retour au navigateur (depuis SearchFight)
        ABlueflap_Navigateur.BringToFront()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles Menu_Fight.Click
        'Afficher Searchfight
        ABlueflap_Fight.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles SrchF_Fightbutton.Click
        'Lancer un Fight
        If SrchF_AdvanceChoice.Checked = False Then
            If SrchF_ChoixA.Text = "Google" Then
                SrchF_fighter_1.Source = New Uri("http://www.google.fr/search?q=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixA.Text = "Bing" Then
                SrchF_fighter_1.Source = New Uri("http://www.bing.com/search?q=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixA.Text = "Yahoo" Then
                SrchF_fighter_1.Source = New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixA.Text = "DuckDuckGo" Then
                SrchF_fighter_1.Source = New Uri("http://duckduckgo.com/?q=" + SrchF_Searchbox.Text)
            End If


            If SrchF_ChoixB.Text = "Google" Then
                SrchF_fighter_2.Source = New Uri("http://www.google.fr/search?q=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixB.Text = "Bing" Then
                SrchF_fighter_2.Source = New Uri("http://www.bing.com/search?q=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixB.Text = "Yahoo" Then
                SrchF_fighter_2.Source = New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + SrchF_Searchbox.Text)

            ElseIf SrchF_ChoixB.Text = "DuckDuckGo" Then
                SrchF_fighter_2.Source = New Uri("http://duckduckgo.com/?q=" + SrchF_Searchbox.Text)
            End If
        Else
            SrchF_fighter_1.Source = New Uri(SrchFight_AdvanceLeft.Text + SrchF_Searchbox.Text)
            SrchF_fighter_2.Source = New Uri(SrchFight_AdvanceRight.Text + SrchF_Searchbox.Text)
        End If
        stat2.Text = stat2.Text + 1 'met à jour les statistiques présentes dans les paramètres
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles SrchF_Searchbox.TextChanged
        'Permet de lancer le combat par appui sur la touche entrée
        Me.AcceptButton = SrchF_Fightbutton
    End Sub
    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles SrchF_Searchbox.Leave
        Me.AcceptButton = Nothing
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Verr_Textbox.TextChanged
        'Textbox de l'écran de verrouillage
        Me.AcceptButton = Verr_AcceptButt
        Verr_WrongMp.Visible = False
    End Sub
    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles Verr_Textbox.Leave
        Me.AcceptButton = Nothing
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Infos_CodeShowHide.Click
        'Afficher/masquer le code source dans la page infos
        Infos_Share.Visible = False
        Infos_code_source.Visible = Not Infos_code_source.Visible
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Infos_Trident_Browser_Recup_Infos.DocumentCompleted
        'Moteur Trident de la page "info" à récupéré toutes les infos
        Infos_Loader.Visible = False
        Infos_Loading.Visible = False
        Infos_Save.Visible = True
        Infos_progress.Visible = False
        Infos_Print.Visible = True
        If stng_nevpriv.Checked = True Then
            Web.WebSession.ClearCookies()
        End If
    End Sub
    Private Sub Infoload_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles Infos_Trident_Browser_Recup_Infos.Navigating
        'Moteur trident en train de récupérer les infos
        Infos_Loader.Visible = True
        Infos_Loading.Visible = True
        Infos_progress.Visible = True
        Infos_Save.Visible = False
        Infos_Print.Visible = False
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Infos_Print.Click
        'Imprimer
        Infos_Trident_Browser_Recup_Infos.ShowPrintPreviewDialog()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Infos_Save.Click
        'Enregistrer
        Infos_Trident_Browser_Recup_Infos.ShowSaveAsDialog()
    End Sub
    Private Sub Ajouterfavoris()
        'Ajouter un favoris
        If Fav_fav_List.Items.Contains(Web.Source.ToString) Then
            If My.Settings.linguuu = "English" Then
                Notiff_add_Text.Text = "This page is already in your bookmarks list"
            Else
                Notiff_add_Text.Text = "Page déjà dans vos favoris"
            End If


        Else
            My.Settings.Bookmarks.Add(Web.Source.ToString)
            Fav_fav_List.Items.Clear()
            For Each Item As String In My.Settings.Bookmarks
                Fav_fav_List.Items.Add(Item)
            Next
            AddFavo_Button.BackColor = Color.Azure
            Addfavtouch.BackColor = Color.MidnightBlue

            If My.Settings.linguuu = "English" Then
                Notiff_add_Text.Text = "This page has been added to your bookmarks list"
            Else
                Notiff_add_Text.Text = "Page ajoutée aux favoris"
            End If
        End If
        If stng_Smartsuggestactif.Checked Then
            If Not SmartAdressbox.AutoCompleteCustomSource.Contains(Web.Source.ToString) Then
                My.Settings.Smartcoll.Add(Web.Source.ToString)
                SmartAdressbox.AutoCompleteCustomSource.Clear()
                For Each Item As String In My.Settings.Smartcoll
                    SmartAdressbox.AutoCompleteCustomSource.Add(Item)
                Next
            End If
        End If
        Notif_add.Visible = True 'Affiche une notification
        If stng_anim.Checked Then
            Dim i As Integer
            For i = 18 To 28
                Notif_add.Height = i
                Application.DoEvents()
                System.Threading.Thread.Sleep(0.1)
            Next
        End If
        Timer1.Enabled = True 'Permet de masquer la notification après un certain temps

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddFavo_Button.Click
        'Ajouter un favoris
        Ajouterfavoris()
    End Sub
    Private Sub Favoris_Norif(sender As Object, e As EventArgs) Handles Fav_fav_List.DoubleClick
        'Naviguer vers l'URL du favoris
        If Not String.IsNullOrWhiteSpace(Fav_fav_List.SelectedItem) Then
            Web.Source = New Uri(Fav_fav_List.SelectedItem)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Fav_Cancel.Click
        'Annuler suppression d'un favoris
        fav_notif_suppr.Visible = False
    End Sub
    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        'Supprimer un favoris
        fav_notif_suppr.Visible = True
    End Sub

    Private Sub AccéderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccéderToolStripMenuItem.Click
        'Naviguer vers l'URL du favoris via menu déroulant
        If Not String.IsNullOrWhiteSpace(Fav_fav_List.SelectedItem) Then
            Web.Source = New Uri(Fav_fav_List.SelectedItem)
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Fav_Confirm.Click
        'Confirme la suppression du favoris
        My.Settings.Bookmarks.Remove(Fav_fav_List.SelectedItem)
        Fav_fav_List.Items.Clear()
        For Each Item As String In My.Settings.Bookmarks
            Fav_fav_List.Items.Add(Item)
        Next
        fav_notif_suppr.Visible = False
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles Menu_Favos.Click
        'Affiche le menu des favoris
        Fav_Panel.Visible = Not Fav_Panel.Visible
        If stng_anim.Checked Then
            Dim i As Integer
            For i = 225 To 232
                Fav_Panel.Width = i
                Application.DoEvents()
                System.Threading.Thread.Sleep(0.1)
            Next
            Fav_Panel.Refresh()
        End If
    End Sub

    Private Sub Notif_add_Click(sender As Object, e As EventArgs) Handles Notif_add.Click
        'Clic sur notification d'ajout d'un favoris
        Fav_Panel.Visible = True
        Notif_add.Visible = False
        If stng_anim.Checked Then
            Dim i As Integer
            For i = 225 To 232
                Fav_Panel.Width = i
                Application.DoEvents()
                System.Threading.Thread.Sleep(0.1)
            Next
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Notiff_add_OKbutton.Click
        'Ferme notification d'ajout d'un favoris
        Notif_add.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Fav_Close.Click
        'Ferme volet des favoris
        Fav_Panel.Visible = False
    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl_Navig(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles Web.LoadingFrame
        'Blueflap est en train de charger une page
        Menu_Stop.Visible = True
        menuT_close.Visible = True
        Loader.Visible = True
        Adressboxtouch.BackgroundImage = Blueflap.My.Resources.Resources.loada
        Menu_Refresh.Visible = False
        menuT_Refresh.Visible = False
        If Adressboxtouch.Height = 20 OrElse Adressboxtouch.Height = 5 Then
            Adressboxtouch.BackColor = Color.LightSkyBlue
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(sender As Object, e As Awesomium.Core.FrameEventArgs) Handles Web.LoadingFrameComplete
        'Page chargée
        Menu_Stop.Visible = False
        menuT_close.Visible = False
        Loader.Visible = False
        Adressboxtouch.BackgroundImage = Blueflap.My.Resources.Resources.back1
        If Adressboxtouch.Height = 20 OrElse Adressboxtouch.Height = 5 Then
            Adressboxtouch.BackColor = Color.LightGray
        End If
        Menu_Refresh.Visible = True
        menuT_Refresh.Visible = True
        Infos_Titre.Text = Web.Title
        If Stng_Titlebar.Checked Then 'Affiche le nom de la page dans la barre de titre
            Me.Text = "Blueflap - " + Web.Title
        End If

        If Not stng_nevpriv.Checked Then 'Ajoute le site à l'historique
            If Not Fav_Historique_List.Items.Contains(SmartAdressbox.Text) Then
                My.Settings.Historique.Add(SmartAdressbox.Text)
                Fav_Historique_List.Items.Clear()
                For Each Item As String In My.Settings.Historique
                    Fav_Historique_List.Items.Add(Item)
                Next
            End If
            If stng_Smartsuggestactif.Checked Then ' Ajoute à Smart Suggest
                My.Settings.Smartcoll.Add(Web.Source.ToString)
                SmartAdressbox.AutoCompleteCustomSource.Clear()
                For Each Item As String In My.Settings.Smartcoll
                    SmartAdressbox.AutoCompleteCustomSource.Add(Item)
                Next
            End If
        End If

        If SmartAdressbox.Text.Contains("https://") Then
            SmartAdressbox.ForeColor = Color.DarkGreen
            touchbox.ForeColor = Color.DarkGreen
        Else
            SmartAdressbox.ForeColor = Color.Black
            touchbox.ForeColor = Color.DarkGray
        End If

        If touchbox.Text.Contains("https://") Then
            touchbox.ForeColor = Color.DarkGreen
        Else
            touchbox.ForeColor = Color.DarkGray
        End If

        If stng_Adblock.Checked Then
            Web.Source = New Uri(AdblockFunction.Text)
        End If
        Stat1.Text = Stat1.Text + 1
        If downloadbar.Visible = True Then
            downloadbar.Visible = False
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_Crashed(sender As Object, e As Awesomium.Core.CrashedEventArgs) Handles Web.Crashed
        messageboxe.Show()
        messageboxe.BackColor = Color.LightCoral
        If My.Settings.linguuu = "English" Then
            messageboxe.Titre.Text = "Error"
            messageboxe.Text.Text = "Please refresh the page"
        Else
            messageboxe.Titre.Text = "Erreur"
            messageboxe.Text.Text = "Une erreur est survenue, actualisez la page"
        End If
        messageboxe.Smiley.Text = ":("
    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Stng_OptionsInternet.Click
        'Affiche les options internet
        Process.Start("inetcpl.cpl")
    End Sub
    Private Sub Touchmode()
        'Affiche l'interface Moderne
        If Stng_TouchUI.Checked Then
            menutouch.Visible = True
            menutouch.SendToBack()
            colorline.SendToBack()
            voletlateral.Visible = False
            Adressboxtouch.Visible = True
            FP_AdressbarPanel.Visible = False
            Menu_Home.Visible = False
            Menu_Window.Visible = False
            Menu_Back.Visible = False
            Menu_Forward.Visible = False
            Menu_Fight.Visible = False
            Menu_Share.Visible = False
            Menu_Lock.Visible = False
            Menu_FullScr.Visible = False
            Menu_Memo.Visible = False
            Menu_Settings.Visible = False
            menuT_clavier.Visible = False
        Else
            menutouch.Visible = False
            voletlateral.Visible = True
            Adressboxtouch.Visible = False
            FP_AdressbarPanel.Visible = True
            voletlateral.SendToBack()
            colorline.SendToBack()
            ElementsMenu()
            Menu_Window.Visible = True
            Menu_Back.Visible = True
            Menu_Forward.Visible = True
            Menu_Settings.Visible = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Stng_TouchUI.CheckedChanged
        Touchmode()
    End Sub

    Private Sub Verrouillage_MouseMove(sender As Object, e As MouseEventArgs) Handles ABlueflap_Verrouillage.MouseMove
        'Met à jour date et heure dans l'écran de verrouillage
        Verr_Time.Text = System.DateTime.Now.ToString("HH:mm")
        Verr_Date.Text = System.DateTime.Now.ToString("dddd dd MMMM yyyy")
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Stng_SupprHisto.Click
        'Efface l'historique
        My.Settings.Historique.Clear()
        Fav_Historique_List.Items.Clear()
    End Sub

    Private Sub Histor_Click(sender As Object, e As EventArgs) Handles Fav_Historique_List.Click
        'Navigue en cliquant sur item historique
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
            If stng_grayicons.Checked Then
                voletlateral.BackColor = Color.WhiteSmoke
            Else
                voletlateral.BackColor = Color.Black
            End If
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
        BS_SearchBlackEffect.Left = (Me.Width - BS_SearchBlackEffect.Width) / 2
        Verr_BlackEffect.Left = (Me.Width - Verr_BlackEffect.Width) / 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BS_Settings.Click
        BS_Optionsbulle.Visible = Not BS_Optionsbulle.Visible
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Bs_Searchbox.TextChanged
        Me.AcceptButton = BS_Searchbutton
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles BS_Searchbutton.Click
        If Stng_MoteurRecherche_URL.Text.Contains("http://") OrElse Stng_MoteurRecherche_URL.Text.Contains("https://") Then
            Dim azert As String
            azert = Bs_Searchbox.Text
            Dim s As String
            s = azert.ToString
            s = s.Replace("+", "%2B")
            Web.Source = New Uri(Stng_MoteurRecherche_URL.Text + s)
        Else
            messageboxe.Show()
            messageboxe.BackColor = Color.LightCoral
            If My.Settings.linguuu = "English" Then
                messageboxe.Titre.Text = "Error"
                messageboxe.Text.Text = "Something is wrong with the search engine"
            Else
                messageboxe.Titre.Text = "Erreur"
                messageboxe.Text.Text = "Veuillez vérifier les paramètres du moteur de recherche"
            End If
            messageboxe.Smiley.Text = ":("
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
            If My.Settings.linguuu = "English" Then
                BS_DateSetColor.Text = "Date : White"
            Else
                BS_DateSetColor.Text = "Date : Claire"
            End If

        Else
            BS_Date.ForeColor = Color.White
            If My.Settings.linguuu = "English" Then
                BS_DateSetColor.Text = "Date : Black"
            Else
                BS_DateSetColor.Text = "Date : Sombre"
            End If
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

    Private Sub Textenotif_Click(sender As Object, e As EventArgs) Handles Notiff_add_Text.Click
        Fav_Panel.Visible = True
        Notif_add.Visible = False
    End Sub

    Private Sub Stng_ShowLicense_Click(sender As Object, e As EventArgs) Handles Stng_ShowLicense.Click
        Licence.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles stngbutt_bug.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("https://github.com/SimpleSoftwares/Blueflap/issues")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles stng_simpleworld.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("http://simpleworld-website.weebly.com")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles stng_github.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("https://github.com/SimpleSoftwares/Blueflap")
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

    Private Sub MetroHeaderButton1_Click(sender As Object, e As EventArgs) Handles Stng_Helpcenter.MouseEnter
        Stng_Helpcenter.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub MetroHeaderButton1_Sortie(sender As Object, e As EventArgs) Handles Stng_Helpcenter.MouseLeave
        Stng_Helpcenter.ForeColor = Color.SkyBlue
    End Sub

    Private Sub MetroHeaderButton1_Click_1(sender As Object, e As EventArgs) Handles Stng_Helpcenter.Click
        Form5.Show()
    End Sub

    Private Sub MetroHeaderButton2_Click(sender As Object, e As EventArgs) Handles Fav_Favtab.Click
        Fav_Historique_List.Visible = False
        Fav_Favtab.LineColorChecked = Color.SteelBlue
        Fav_Histotab.LineColorChecked = Color.DeepSkyBlue
        Fav_Histotab.Refresh()
    End Sub

    Private Sub MetroHeaderButton3_Click(sender As Object, e As EventArgs) Handles Fav_Histotab.Click
        Fav_Historique_List.Visible = True
        Fav_Histotab.LineColorChecked = Color.SteelBlue
        Fav_Favtab.LineColorChecked = Color.DeepSkyBlue
        Fav_Favtab.Refresh()
    End Sub

    Private Sub MetroHeaderButton2_MouseEnter(sender As Object, e As EventArgs) Handles Fav_Favtab.MouseEnter
        Fav_Favtab.ForeColor = Color.SteelBlue
    End Sub
    Private Sub MetroHeaderButton2_MouseLeave(sender As Object, e As EventArgs) Handles Fav_Favtab.MouseLeave
        Fav_Favtab.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub MetroHeaderButton3_MouseEnter(sender As Object, e As EventArgs) Handles Fav_Histotab.MouseEnter
        Fav_Histotab.ForeColor = Color.SteelBlue
    End Sub
    Private Sub MetroHeaderButton3_MouseLeave(sender As Object, e As EventArgs) Handles Fav_Histotab.MouseLeave
        Fav_Histotab.ForeColor = Color.DeepSkyBlue
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
        ABlueflap_Infos.Visible = True
        Infos_code_source.Visible = False
        Infos_Share.Visible = True
        Infos_Share.Source = New Uri("https://www.facebook.com/sharer/sharer.php?u=" + SmartAdressbox.Text)
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        ABlueflap_Infos.BringToFront()
        ABlueflap_Infos.Visible = True
        Infos_code_source.Visible = False
        Infos_Share.Visible = True
        Infos_Share.Source = New Uri("https://twitter.com/home?status=@BlueflapBrowser%20cette%20page%20est%20fantastique%20!%20" + SmartAdressbox.Text)
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Stng_Zyhou.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("https://github.com/zyhou")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Stng_BaptGuil.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("https://github.com/baptisteguil")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Stng_Bat41.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("https://github.com/Bat41")
    End Sub
    Private Sub SmartAdressbox_Leave(sender As Object, e As EventArgs) Handles SmartAdressbox.Leave
        Me.AcceptButton = Nothing
    End Sub
    Private Sub Fight_Actions_TextChanged(sender As Object, e As EventArgs) Handles SrchF_Actions.TextChanged
        If SrchF_Actions.Text = "Vue double" Then
            SrchF_Split.Panel1Collapsed = False
            SrchF_Split.Panel2Collapsed = False

        ElseIf SrchF_Actions.Text = "Masquer droite" Then
            SrchF_Split.Panel1Collapsed = False
            SrchF_Split.Panel2Collapsed = True

        ElseIf SrchF_Actions.Text = "Masquer gauche" Then
            SrchF_Split.Panel1Collapsed = True
            SrchF_Split.Panel2Collapsed = False

        ElseIf SrchF_Actions.Text = "Ouvrir droite" Then
            ABlueflap_Navigateur.BringToFront()
            Web.Source = New Uri(SrchF_fighter_2.Source.ToString)
        ElseIf SrchF_Actions.Text = "Ouvrir gauche" Then
            ABlueflap_Navigateur.BringToFront()
            Web.Source = New Uri(SrchF_fighter_1.Source.ToString)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SrchF_AdvanceChoice.CheckedChanged
        If SrchF_AdvanceChoice.Checked = True Then
            SrchFight_AdvanceLeft.Visible = True
            SrchFight_AdvanceRight.Visible = True
            SrchF_ChoixA.Enabled = False
            SrchF_ChoixB.Enabled = False
        Else
            SrchFight_AdvanceLeft.Visible = False
            SrchFight_AdvanceRight.Visible = False
            SrchF_ChoixA.Enabled = True
            SrchF_ChoixB.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Stng_ResetSuggest.Click
        My.Settings.Smartcoll.Clear()
        SmartAdressbox.AutoCompleteCustomSource.Clear()
    End Sub

    Private Sub Smartsuggestactif_CheckedChanged(sender As Object, e As EventArgs) Handles stng_Smartsuggestactif.CheckedChanged
        If Not stng_Smartsuggestactif.Checked Then
            My.Settings.Smartcoll.Clear()
            SmartAdressbox.AutoCompleteCustomSource.Clear()
        End If
    End Sub

    Private Sub Menu_Translate_Click(sender As Object, e As EventArgs) Handles Menu_Translate.Click
        Web.Source = New Uri("javascript:(function(){var s = document.createElement('script'); s.type = 'text/javascript'; s.src = 'http://labs.microsofttranslator.com/bookmarklet/default.aspx?f=js&to=fr'; document.body.insertBefore(s, document.body.firstChild);})()")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Web.Source = New Uri("javascript:void((function(svc) {var d=document,w=window,p=0,b=function(){if(!p){p=1;if(_atc.xol)_adr.onReady();if(w.addthis_sendto)addthis_sendto(svc||'bkmore',{product:'bmt-'+_atc.ver})}else{p=0;if(_atw)_atw.clb()}};if(!w._atc){var ol=w.addthis_onload||[],o=d.createElement('script');w.addthis_product = 'bmt-250';o.src='//s7.addthis.com/js/250/addthis_widget.js#domready=1&username=bookmarklet';ol.push(b);w.addthis_onload=ol;d.getElementsByTagName('body')[0].appendChild(o)}else b()})())")
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_TargetURLChanged(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles Web.TargetURLChanged
        If Not stng_target.Checked Then
            If Web.HasTargetURL Then
                SmartAdressbox.Text = Web.TargetURL.ToString
                touchbox.Text = Web.TargetURL.ToString
            Else
                SmartAdressbox.Text = Web.Source.ToString
                touchbox.Text = Web.Source.ToString
                If SmartAdressbox.Text.Contains("https://") Then
                    SmartAdressbox.ForeColor = Color.DarkGreen
                    touchbox.ForeColor = Color.DarkGreen
                Else
                    SmartAdressbox.ForeColor = Color.Black
                    touchbox.ForeColor = Color.DarkGray
                End If
            End If
        End If
    End Sub
    Private Sub OnDownloadBegin(sender As Object, e As Awesomium.Core.DownloadBeginEventArgs)
        downloadbar.Visible = True
        Label3.Text = e.Info.FileName
        Label4.Text = e.Info.Url.ToString
    End Sub
    Private Sub stng_nevpriv_CheckedChanged(sender As Object, e As EventArgs) Handles stng_nevpriv.CheckedChanged
        If stng_nevpriv.Checked Then
            FP_AdressbarPanel.BackColor = Color.Gainsboro
        Else
            FP_AdressbarPanel.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
        downloadbar.Visible = False
    End Sub
    Private Sub Menu_Window_Click(sender As Object, e As EventArgs) Handles Menu_Window.Click
        Dim Windy As Fenetre_Principale
        Windy = New Fenetre_Principale
        Call Windy.Show()
        Windy = Nothing
    End Sub

    Private Sub Infos_Trident_Browser_Recup_Infos_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles Infos_Trident_Browser_Recup_Infos.ProgressChanged
        Dim Progress As Integer = e.CurrentProgress
        Dim ProgressMax As Integer = e.MaximumProgress
        Dim Pourcent As Short

        If ProgressMax <> 0 Then
            On Error Resume Next
            Infos_progress.Maximum = ProgressMax
            If Not Progress < 0 Then
                Infos_progress.Value = Progress
            End If
            Pourcent = Fix((Progress / ProgressMax) * 100)
            If Pourcent > 100 Then
                Pourcent = 100
            End If
        Else
            Infos_progress.Value = 0
        End If
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        colorbox.BackColor = Color.Red
        Colorbox2.BackColor = Color.DarkRed
        colorline.BackColor = Color.Red
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        colorbox.BackColor = Color.Gold
        Colorbox2.BackColor = Color.Goldenrod
        colorline.BackColor = Color.Gold
    End Sub

    Private Sub Button6_Click_2(sender As Object, e As EventArgs) Handles Button6.Click
        colorbox.BackColor = Color.SteelBlue
        Colorbox2.BackColor = Color.DeepSkyBlue
        colorline.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        colorbox.BackColor = Color.YellowGreen
        Colorbox2.BackColor = Color.ForestGreen
        colorline.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        colorbox.BackColor = Color.DeepPink
        Colorbox2.BackColor = Color.MediumVioletRed
        colorline.BackColor = Color.DeepPink
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles stng_colorlinecheck.CheckedChanged
        If stng_colorlinecheck.Checked Then
            colorline.Visible = True
        Else
            colorline.Visible = False
        End If
    End Sub

    Private Sub Button9_Click_2(sender As Object, e As EventArgs) Handles Button9.Click
        colorbox.BackColor = Color.DarkViolet
        Colorbox2.BackColor = Color.Violet
        colorline.BackColor = Color.DarkViolet
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles stngcolor_orange.Click
        colorbox.BackColor = Color.DarkGoldenrod
        Colorbox2.BackColor = Color.Orange
        colorline.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles stngcolor_Rouge.Click
        colorbox.BackColor = Color.Chocolate
        Colorbox2.BackColor = Color.Tomato
        colorline.BackColor = Color.Chocolate
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles stngcolor_gris.Click
        colorbox.BackColor = Color.DarkSlateGray
        Colorbox2.BackColor = Color.DarkGray
        colorline.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub CheckBox2_CheckedChanged_2(sender As Object, e As EventArgs) Handles stng_grayicons.CheckedChanged
        Grayicons()
    End Sub
    Private Sub Grayicons()
        If stng_grayicons.Checked Then
            Menu_Home.Image = Blueflap.My.Resources.Resources.a13
            Menu_Back.Image = Blueflap.My.Resources.Resources.a15
            Menu_Forward.Image = Blueflap.My.Resources.Resources.a14
            Menu_FullScr.Image = Blueflap.My.Resources.Resources.a7
            Menu_Favos.Image = Blueflap.My.Resources.Resources.a9
            Menu_Memo.Image = Blueflap.My.Resources.Resources.a16
            menu_partage.Image = Blueflap.My.Resources.Resources.a4
            Menu_Refresh.Image = Blueflap.My.Resources.Resources.a1
            Menu_Settings.Image = Blueflap.My.Resources.Resources.a10
            Menu_Share.Image = Blueflap.My.Resources.Resources.a18
            Menu_Lock.Image = Blueflap.My.Resources.Resources.a11
            Menu_Stop.Image = Blueflap.My.Resources.Resources.a2
            Menu_Translate.Image = Blueflap.My.Resources.Resources.a3
            Menu_Window.Image = Blueflap.My.Resources.Resources.a19
            FacebookToolStripMenuItem.Image = Blueflap.My.Resources.Resources.a6
            TwitterToolStripMenuItem.Image = Blueflap.My.Resources.Resources.a8
            ToolStripMenuItem1.Image = Blueflap.My.Resources.Resources.a5
            Menu_Fight.Image = Blueflap.My.Resources.Resources.a12
        Else
            Menu_Home.Image = Blueflap.My.Resources.Resources.c21
            Menu_Back.Image = Blueflap.My.Resources.Resources.c27
            Menu_Forward.Image = Blueflap.My.Resources.Resources.c25
            Menu_FullScr.Image = Blueflap.My.Resources.Resources.pleinecran
            Menu_Favos.Image = Blueflap.My.Resources.Resources.c12
            Menu_Memo.Image = Blueflap.My.Resources.Resources.c28
            menu_partage.Image = Blueflap.My.Resources.Resources.shareza
            Menu_Refresh.Image = Blueflap.My.Resources.Resources.refresh
            Menu_Settings.Image = Blueflap.My.Resources.Resources.c16
            Menu_Share.Image = Blueflap.My.Resources.Resources.infos
            Menu_Lock.Image = Blueflap.My.Resources.Resources.c17
            Menu_Stop.Image = Blueflap.My.Resources.Resources.stopy
            Menu_Translate.Image = Blueflap.My.Resources.Resources.transl
            Menu_Window.Image = Blueflap.My.Resources.Resources.plus
            FacebookToolStripMenuItem.Image = Blueflap.My.Resources.Resources.facebookshare
            TwitterToolStripMenuItem.Image = Blueflap.My.Resources.Resources.twittershare
            ToolStripMenuItem1.Image = Blueflap.My.Resources.Resources.addthis
            Menu_Fight.Image = Blueflap.My.Resources.Resources.c20
        End If
    End Sub

    Private Sub SmartAdressbox_Click(sender As Object, e As EventArgs) Handles SmartAdressbox.Click
        SmartAdressbox.SelectAll()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles menuT_clavier.Click
        Process.Start("osk")
    End Sub

    Private Sub menuT_Settings_Click(sender As Object, e As EventArgs) Handles menuT_Settings.Click
        ABlueflap_Settings.BringToFront()
        If Stng_MP_confirm.Text.Equals(Stng_MP.Text) OrElse String.IsNullOrWhiteSpace(Stng_MP.Text) Then
            Stng_MP.Enabled = True
        Else
            Stng_MP.Enabled = False
        End If
    End Sub

    Private Sub menuT_Home_Click(sender As Object, e As EventArgs) Handles menuT_Home.Click
        Pageaccueil()
    End Sub

    Private Sub menuT_back_Click(sender As Object, e As EventArgs) Handles menuT_back.Click
        Web.GoBack()
    End Sub

    Private Sub menuT_forward_Click(sender As Object, e As EventArgs) Handles menuT_forward.Click
        Web.GoForward()
    End Sub

    Private Sub menuT_close_Click(sender As Object, e As EventArgs) Handles menuT_close.Click
        Web.Stop()
        Menu_Refresh.Visible = True
        Menu_Stop.Visible = False
        Adressboxtouch.BackgroundImage = Blueflap.My.Resources.Resources.back1
        If Adressboxtouch.Height = 20 OrElse Adressboxtouch.Height = 5 Then
            Adressboxtouch.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub menuT_Refresh_Click(sender As Object, e As EventArgs) Handles menuT_Refresh.Click
        Web.Reload(True)
    End Sub

    Private Sub menuT_Page_Click(sender As Object, e As EventArgs) Handles menuT_Page.Click
        Dim Windy As Fenetre_Principale
        Windy = New Fenetre_Principale
        Call Windy.Show()
        Windy = Nothing
    End Sub

    Private Sub menuT_Fight_Click(sender As Object, e As EventArgs) Handles menuT_Fight.Click
        ABlueflap_Fight.BringToFront()
    End Sub

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles menut_Info.Click
        ABlueflap_Infos.BringToFront()
        ABlueflap_Infos.Visible = True
        Infos_Trident_Browser_Recup_Infos.Navigate(Web.Source)
    End Sub

    Private Sub menuT_lock_Click(sender As Object, e As EventArgs) Handles menuT_lock.Click
        Form2.Show()
    End Sub

    Private Sub menuT_fullscreen_Click(sender As Object, e As EventArgs) Handles menuT_fullscreen.Click
        Pleinecran()
    End Sub


    Private Sub menuT_memo_Click(sender As Object, e As EventArgs) Handles menuT_memo.Click
        Form4.Show()
    End Sub

    Private Sub Button13_Click_2(sender As Object, e As EventArgs) Handles touchbox_menubut.Click
        If voletlateral.Visible Then
            If stng_anim.Checked Then
                voletlateral.Width = 80
                Do Until voletlateral.Width = 0
                    voletlateral.Width -= 20
                Loop
            End If
            voletlateral.Visible = False
            voletlateral.Width = 160

        Else
            voletlateral.BackColor = Color.WhiteSmoke
            Menu_Home.Visible = False
            Menu_Window.Visible = False
            Menu_Back.Visible = False
            Menu_Forward.Visible = False
            Menu_Fight.Visible = False
            Menu_Share.Visible = False
            Menu_Lock.Visible = False
            Menu_FullScr.Visible = False
            Menu_Memo.Visible = False
            Menu_Settings.Visible = False

            voletlateral.Visible = True
            If stng_anim.Checked Then
                Dim i As Integer
                For i = 153 To 160
                    voletlateral.Width = i
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(0.1)
                Next
            End If
        End If
    End Sub

    Private Sub Addfavtouch_Click(sender As Object, e As EventArgs) Handles Addfavtouch.Click
        Ajouterfavoris()
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Gotouchbutt.Click
        Dim textArray = touchbox.Text.Split(" ")
        If (touchbox.Text.Contains(".") = True And touchbox.Text.Contains(" ") = False And touchbox.Text.Contains(" .") = False And touchbox.Text.Contains(". ") = False) Or textArray(0).Contains(":/") = True Or textArray(0).Contains(":\") Then
            If touchbox.Text.Contains("http://") OrElse touchbox.Text.Contains("https://") Then
                Web.Source = New Uri(touchbox.Text)
            Else

                If touchbox.Text.Contains("blueflap://") Then
                    If touchbox.Text = "blueflap://settings" Then
                        ABlueflap_Settings.BringToFront()
                    ElseIf touchbox.Text = "blueflap://searchfight" Then
                        ABlueflap_Fight.BringToFront()
                    ElseIf touchbox.Text = "blueflap://update" Then
                        ABlueflap_Update.BringToFront()
                    ElseIf touchbox.Text = "blueflap://reset:stats" Then
                        Stat1.Text = 0
                        stat2.Text = 0
                        messageboxe.Show()
                        messageboxe.BackColor = Color.CornflowerBlue
                        If My.Settings.linguuu = "English" Then
                            messageboxe.Titre.Text = "Settings"
                            messageboxe.Text.Text = "Stat has been reset"
                        Else
                            messageboxe.Titre.Text = "Paramètres"
                            messageboxe.Text.Text = "Les statistiques ont été remises à zero"
                        End If
                        messageboxe.Smiley.Text = ";)"
                    ElseIf touchbox.Text = "blueflap://reset:settings" Then
                        Reinitialisation()
                    End If
                Else
                    Web.Source = New Uri("http://" + touchbox.Text)
                End If
            End If
        Else

            If Stng_MoteurRecherche_URL.Text.Contains("http://") OrElse Stng_MoteurRecherche_URL.Text.Contains("https://") Then
                Dim azert As String
                azert = touchbox.Text
                Dim s As String
                s = azert.ToString
                s = s.Replace("+", "%2B")
                Web.Source = New Uri(Stng_MoteurRecherche_URL.Text + s)
            Else
                messageboxe.Show()
                messageboxe.BackColor = Color.LightCoral
                If My.Settings.linguuu = "English" Then
                    messageboxe.Titre.Text = "Error"
                    messageboxe.Text.Text = "Something is wrong with the search engine"
                Else
                    messageboxe.Titre.Text = "Erreur"
                    messageboxe.Text.Text = "Veuillez vérifier les paramètres du moteur de recherche"
                End If
                messageboxe.Smiley.Text = ":("
            End If

        End If
    End Sub

    Private Sub touchbox_TextChanged(sender As Object, e As EventArgs) Handles touchbox.TextChanged
        Me.AcceptButton = Gotouchbutt
        If Web.IsLoading = True Then
            touchbox.ForeColor = Color.DarkGray
        Else
            Dim textArray = touchbox.Text.Split(" ")
            If (touchbox.Text.Contains(".") = True And touchbox.Text.Contains(" ") = False And touchbox.Text.Contains(" .") = False And touchbox.Text.Contains(". ") = False) Or textArray(0).Contains(":/") = True Or textArray(0).Contains(":\") Then
                touchbox.ForeColor = Color.DodgerBlue
            Else
                touchbox.ForeColor = Color.DarkGray
            End If
        End If
    End Sub

    Private Sub touchbox_Leave(sender As Object, e As EventArgs) Handles touchbox.Leave
        Me.AcceptButton = Nothing
    End Sub

    Private Sub touchbox_Click(sender As Object, e As EventArgs) Handles touchbox.Click
        touchbox.SelectAll()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stng_anim.Checked Then
            Notif_add.Height = 28
            Do Until Notif_add.Height = 0
                Notif_add.Height -= 1
            Loop
        End If
        Notif_add.Visible = False
        Timer1.Enabled = False
        Notif_add.Height = 28
    End Sub

    Private Sub Button13_Click_3(sender As Object, e As EventArgs) Handles Button13.Click
        Stng_Titlebar.Checked = True
        stng_anim.Checked = True
        Stng_MaximizedWindow.Checked = True
        Stng_Volet_reduire.Checked = True
        Sfight_Checkbox.Checked = False
        Share_checkbox.Checked = False
        translate_checkbox.Checked = False
        lock_checkbox.Checked = False
        memo_checkbox.Checked = False
        Stng_HomePage_Url.Text = "http://google.fr"
        Stng_MoteurRecherche_choose.Text = "Google"
        Stng_MoteurRecherche_URL.Text = "http://www.google.fr/search?q="
        Home_checkbox.Checked = True
        favo_checkbox.Checked = True
        infos_checkbox.Checked = True
        stng_nevpriv.Checked = True
        Stng_TouchUI.Checked = False
        stng_colorlinecheck.Checked = False
        stng_grayicons.Checked = True
        voletlateral.BackColor = Color.WhiteSmoke
        Stng_bluestart_checkbox.Checked = False
        stng_target.Checked = False
        fullscreen_checkbox.Checked = True
        stng_nevpriv.Checked = False
    End Sub

    Private Sub Button14_Click_2(sender As Object, e As EventArgs) Handles Button14.Click
        colorbox.BackColor = Color.DarkSlateGray
        Colorbox2.BackColor = Color.DarkGray
        colorline.BackColor = Color.DarkSlateGray
        voletlateral.BackColor = Color.WhiteSmoke
        colorline.SendToBack()
        Stng_Titlebar.Checked = True
        stng_anim.Checked = False
        Stng_MaximizedWindow.Checked = True
        Stng_Volet_reduire.Checked = True
        Sfight_Checkbox.Checked = False
        Share_checkbox.Checked = False
        translate_checkbox.Checked = True
        lock_checkbox.Checked = True
        memo_checkbox.Checked = False
        stng_colorlinecheck.Checked = True
        stng_grayicons.Checked = True
        Stng_bluestart_checkbox.Checked = True
        stng_target.Checked = False
        Home_checkbox.Checked = True
        favo_checkbox.Checked = True
        infos_checkbox.Checked = True
        stng_nevpriv.Checked = True
        Stng_TouchUI.Checked = False
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        colorbox.BackColor = Color.YellowGreen
        Colorbox2.BackColor = Color.ForestGreen
        colorline.BackColor = Color.YellowGreen
        voletlateral.BackColor = Color.WhiteSmoke
        colorline.SendToBack()
        Stng_Titlebar.Checked = True
        stng_anim.Checked = True
        Stng_MaximizedWindow.Checked = True
        Stng_Volet_reduire.Checked = False
        Sfight_Checkbox.Checked = True
        Share_checkbox.Checked = True
        translate_checkbox.Checked = True
        lock_checkbox.Checked = True
        memo_checkbox.Checked = True
        stng_colorlinecheck.Checked = True
        stng_grayicons.Checked = True
        Stng_bluestart_checkbox.Checked = True
        stng_target.Checked = False
        Home_checkbox.Checked = True
        favo_checkbox.Checked = True
        infos_checkbox.Checked = True
        stng_nevpriv.Checked = False
        Stng_TouchUI.Checked = True
        menuT_clavier.Visible = True
        stng_clavi.Checked = True
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        ABlueflap_Update.SendToBack()
    End Sub
    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        WebBrowser1.Navigate("http://personnalisa.bl.ee/Version.html")
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        ABlueflap_Update.BringToFront()
        Update_currentver.Text = Stng_VersionSystem.Text
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.DocumentTitle.Contains("Blueflap") Then
            Update_lastversion.Text = WebBrowser1.DocumentTitle
        End If
        If My.Computer.Network.IsAvailable Then
            Update_dattee.Text = System.DateTime.Now.ToString("dddd dd MMMM yyyy") + " à " + System.DateTime.Now.ToString("HH:mm")
            If WebBrowser1.DocumentTitle = Stng_VersionSystem.Text Then
                Update_state.Text = "Blueflap est à jour"
            Else
                WebBrowser1.Navigate("http://personnalisa.bl.ee/Redirect.html")
                Update_state.Text = "Une mise à jour est disponible"
                Update_notice.Visible = True
                ABlueflap_Update.BringToFront()
            End If
        Else
            messageboxe.Show()
            messageboxe.BackColor = Color.LightCoral
            If My.Settings.linguuu = "English" Then
                messageboxe.Titre.Text = "Blueflap Update"
                messageboxe.Text.Text = "Unable to access the server"
            Else
                messageboxe.Titre.Text = "Blueflap Update"
                messageboxe.Text.Text = "Impossible d'accéder au serveur de mise à jour"
            End If
            messageboxe.Smiley.Text = ":("
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        ABlueflap_Navigateur.BringToFront()
        Web.Source = New Uri("http://zestedesavoir.com/membres/voir/florian6973/")
    End Sub

    Private Sub SrchF_ChoixA_Enter(sender As Object, e As EventArgs) Handles SrchF_ChoixA.Enter
        SrchF_ChoixA.BackColor = Color.White
    End Sub
    Private Sub SrchF_ChoixB_Enter(sender As Object, e As EventArgs) Handles SrchF_ChoixB.Enter
        SrchF_ChoixB.BackColor = Color.White
    End Sub
    Private Sub SrchF_ChoixA_Leav(sender As Object, e As EventArgs) Handles SrchF_ChoixA.Leave
        SrchF_ChoixA.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub SrchF_ChoixB_Leav(sender As Object, e As EventArgs) Handles SrchF_ChoixB.Leave
        SrchF_ChoixB.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Adressboxtouch_Click(sender As Object, e As EventArgs) Handles Adressboxtouch.Click
        If Adressboxtouch.Height = 20 Then
            Do Until Adressboxtouch.Height = 40
                Adressboxtouch.Height += 1
            Loop
            Adressboxtouch.Height = 43
            Adressboxtouch.BackColor = Color.White
            touchbox.BackColor = Color.White
            touchbox.Visible = True
            Adressboxtouch.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub Agrandir()
        If Adressboxtouch.Height = 5 Then
            Do Until Adressboxtouch.Height = 20
                Adressboxtouch.Height += 1
            Loop
            Adressboxtouch.Cursor = Cursors.PanSouth()
        End If
    End Sub
    Private Sub Reduire()
        If Adressboxtouch.Height = 20 Then
            Do Until Adressboxtouch.Height = 5
                Adressboxtouch.Height -= 1
            Loop
            Adressboxtouch.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub Adressboxtouch_MouseEnter(sender As Object, e As EventArgs) Handles Adressboxtouch.MouseEnter
        Agrandir()
    End Sub

    Private Sub Adressboxtouch_MouseLeave(sender As Object, e As EventArgs) Handles Adressboxtouch.MouseLeave
        Reduire()
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Adressboxtouch.Height = 43 Then
            Adressboxtouch.Height = 40
            Do Until Adressboxtouch.Height = 5
                Adressboxtouch.Height -= 1
            Loop
            Adressboxtouch.BackColor = Color.LightGray
            touchbox.BackColor = Color.LightGray
            touchbox.Visible = False
        End If
    End Sub

    Private Sub Addfavtouch_MouseEnter(sender As Object, e As EventArgs) Handles Addfavtouch.MouseEnter
        Agrandir()
        Adressboxtouch.Cursor = Cursors.Default
    End Sub

    Private Sub Addfavtouch_MouseLeave(sender As Object, e As EventArgs) Handles Addfavtouch.MouseLeave
        Reduire()
    End Sub

    Private Sub touchbox_menubut_MouseEnter(sender As Object, e As EventArgs) Handles touchbox_menubut.MouseEnter
        Agrandir()
        Adressboxtouch.Cursor = Cursors.Default
    End Sub

    Private Sub touchbox_menubut_MouseLeave(sender As Object, e As EventArgs) Handles touchbox_menubut.MouseLeave
        Reduire()
    End Sub

    Private Sub ReduireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReduireToolStripMenuItem.Click
        If Adressboxtouch.Height = 43 Then
            Adressboxtouch.Height = 40
            Do Until Adressboxtouch.Height = 5
                Adressboxtouch.Height -= 1
            Loop
            Adressboxtouch.BackColor = Color.LightGray
            touchbox.BackColor = Color.LightGray
            touchbox.Visible = False
        End If
    End Sub

    Private Sub InterfaceClassiqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterfaceClassiqueToolStripMenuItem.Click
        If Stng_TouchUI.Checked Then
            Stng_TouchUI.Checked = False
            GrandesIcônesToolStripMenuItem.Checked = False
            InterfaceClassiqueToolStripMenuItem.Checked = False
        Else
            Stng_TouchUI.Checked = True
            GrandesIcônesToolStripMenuItem.Checked = True
            InterfaceClassiqueToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub GrandesIcônesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrandesIcônesToolStripMenuItem.Click
        If Stng_TouchUI.Checked Then
            Stng_TouchUI.Checked = False
            GrandesIcônesToolStripMenuItem.Checked = False
            InterfaceClassiqueToolStripMenuItem.Checked = False
        Else
            Stng_TouchUI.Checked = True
            GrandesIcônesToolStripMenuItem.Checked = True
            InterfaceClassiqueToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub MetroHeaderButton1_MouseEnter(sender As Object, e As EventArgs) Handles MetroHeaderButton1.MouseEnter
        MetroHeaderButton1.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub MetroHeaderButton1_MouseLeave(sender As Object, e As EventArgs) Handles MetroHeaderButton1.MouseLeave
        MetroHeaderButton1.ForeColor = Color.SkyBlue
    End Sub

    Private Sub MetroHeaderButton1_Click_2(sender As Object, e As EventArgs) Handles MetroHeaderButton1.Click
        ABlueflap_Update.BringToFront()
        Update_currentver.Text = Stng_VersionSystem.Text
    End Sub

    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles Button10.Click
        If Button12.Text = "English" Then
            Lingua()
            My.Settings.linguuu = "English"
        End If
        Web.Source = New Uri("http://personnalisa.bl.ee/Bienvenue.html")
        ABlueflap_Navigateur.BringToFront()
        ABlueflap_Welcome.Visible = False
    End Sub
    Private Sub Lingua()
        Menu_Home.Text = "Home"
        Menu_FullScr.Text = "Full Screen"
        Menu_Lock.Text = "Password Lock"
        menu_partage.Text = "Share"
        Menu_Refresh.Text = "Refresh"
        Menu_Settings.Text = "Settings"
        Menu_Forward.Text = "Forward"
        Menu_Back.Text = "Back"
        Menu_Favos.Text = "Bookmarks"
        Menu_Stop.Text = "Stop"
        Menu_Translate.Text = "Translate"
        Menu_Window.Text = "New Page"
        Tooltip_volettouch.SetToolTip(Me.menuT_Home, "Home")
        Tooltip_volettouch.SetToolTip(Me.menuT_forward, "Forward")
        Tooltip_volettouch.SetToolTip(Me.menuT_back, "Back")
        Tooltip_volettouch.SetToolTip(Me.menuT_clavier, "Keyboard")
        Tooltip_volettouch.SetToolTip(Me.menuT_fullscreen, "Full screen")
        Tooltip_volettouch.SetToolTip(Me.menuT_close, "Stop")
        Tooltip_volettouch.SetToolTip(Me.menuT_Refresh, "Refresh")
        Tooltip_volettouch.SetToolTip(Me.menuT_Page, "New Page")
        Tooltip_volettouch.SetToolTip(Me.menuT_Settings, "Settings")
        Tooltip_volettouch.SetToolTip(Me.menuT_lock, "Password Lock")
        Tooltip_volettouch.SetToolTip(Me.touchbox_menubut, "Show more")
        Tooltip_volettouch.SetToolTip(Me.menut_Info, "Informations")
        Fav_Favtab.Text = "Bookmrks"
        Fav_Histotab.Text = "History"
        Fav_Notif_Text.Text = "Delete this bookmark ?"
        Fav_Confirm.Text = "Yes"
        Fav_Cancel.Text = "Cancel"
        Label2.Text = "Please check your internet connection"
        SupprimerToolStripMenuItem.Text = "Delete"
        AccéderToolStripMenuItem.Text = "Go"
        Settings_title.Text = "Settings"
        StngLabel_Searchengine.Text = "Search Engine"
        StngLabel_Background.Text = "Wallpaper"
        StngLabel_Contribute.Text = "Contribute"
        StngLabel_Data.Text = "Data"
        StngLabel_Home.Text = "Homepage"
        StngLabel_Icons.Text = "Menu Icons"
        StngLabel_Lock.Text = "Password Lock"
        Stng_bluestart_checkbox.Text = "Use Bluestart"
        StngLabel_MP.Text = "Password"
        StngLabel_MPConfirm.Text = "Confirmation"
        Stng_MPActiv.Text = "Active"
        Stng_TouchUI.Text = "Large Icons"
        Stng_Titlebar.Text = "Dynamic titlebar"
        Stng_MaximizedWindow.Text = "Maximize on startup"
        Stng_Volet_reduire.Text = "Minimize the menu on startup"
        Stng_Volet_Mousehover_agrandir.Text = "Maximize the menu on mousehover"
        stng_clavi.Text = "Virtual Keyboard"
        Label5.Text = "Target Links"
        stng_target.Text = "Disable"
        Button2.Text = "Browse"
        sett_tab1.Text = "Customize"
        sett_tab1.Refresh()
        sett_tab2.Text = "Advanced options"
        sett_tab2.Refresh()
        sett_tab3.Text = "About Blueflap"
        sett_tab3.Refresh()
        Label10.Text = "Theme"
        stng_colorlinecheck.Text = "Colored line"
        stng_grayicons.Text = "Gray icons"
        StngLabel_Private.Text = "Private Browsing"
        StngLabel_Network.Text = "Network"
        StngLabel_Proxy.Text = "Blueflap uses your computer's system proxy to connect to the network"
        StngLabel_NetworkInfo.Text = "Connections tab"
        stng_nevpriv.Text = "Active"
        stng_Adblock.Text = "Active"
        stng_Smartsuggestactif.Text = "Active"
        Stng_ResetSuggest.Text = "Reset"
        Stng_OptionsInternet.Text = "Internet options"
        Stng_SupprHisto.Text = "Clear history"
        Stng_SupprCacheCookies.Text = "Clear cookies/cache"
        stngbutt_bug.Text = "Report a bug"
        StngLabel_Contributeurs.Text = "Contributors"
        Update_startverif.Text = "Check for updates on startup"
        ReduireToolStripMenuItem.Text = "Minimize Adressbox"
        InterfaceClassiqueToolStripMenuItem.Text = "Large icons"
        ToolStripMenuItem2.Text = "Report a bug"
        GrandesIcônesToolStripMenuItem.Text = "Large icons"
        ToolTip_System.SetToolTip(Me.AddFavo_Button, "Add a bookmarks")
        ToolTip_System.SetToolTip(Me.Menu_ShowHide_Button, "Maximize or Minimize the menu")
        Infos_Loading.Text = "Loading..."
        Label7.Text = " BF has been locked"
        Verr_WrongMp.Text = "This is not the good password"
        Button17.Text = "Check for new updates"
        BS_DateSetColor.Text = "Date : Black"
        BS_ImgChoose.Text = "Change wallpaper"
        Tooltip_BS.SetToolTip(Me.BS_Settings, "Bluestart settings")
        Tooltip_BS.SetToolTip(Me.BS_ImgChoose, "Change Bluestart's background image")
        Tooltip_BS.SetToolTip(Me.BS_Browser, "Browser")
        Tooltip_BS.SetToolTip(Me.BS_Fav, "Bookmarks")
        Label6.Text = "Pages"
    End Sub
    Private Sub Button12_Click_2(sender As Object, e As EventArgs) Handles Linguabut.Click
        If Linguabut.Text = "Français" Then
            Linguabut.Text = "English"
            Lingua()
        Else
            Linguabut.Text = "Français"
            messageboxe.Show()
            messageboxe.BackColor = Color.LimeGreen
            messageboxe.Titre.Text = "Changement de langue"
            messageboxe.Text.Text = "Veuillez fermer puis réouvrir Blueflap pour terminer cette action"
            messageboxe.Smiley.Text = ":)"
        End If
    End Sub

    Private Sub Button12_Click_3(sender As Object, e As EventArgs) Handles Button12.Click
        If Button12.Text = "Français" Then
            Button12.Text = "English"
            Label17.Text = "Welcome on Blueflap"
            Button20.Text = "Open settings"
            Button10.Text = "Finish"
        Else
            Button12.Text = "Français"
            Label17.Text = "Bienvenue sur Blueflap"
            Button20.Text = "Afficher les paramètres"
            Button10.Text = "Terminer"
        End If
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Form5.Show()
    End Sub

    Private Sub Button20_Click_2(sender As Object, e As EventArgs) Handles Button20.Click
        ABlueflap_Settings.BringToFront()
    End Sub
    Private Sub Reinitialisation()
        Stng_MoteurRecherche_choose.Text = "Google"
        Stng_MoteurRecherche_URL.Text = "http://www.google.fr/search?q="
        Stng_HomePage_Url.Text = "http://personnalisa.bl.ee"
        Stng_bluestart_checkbox.Checked = True
        Stng_TouchUI.Checked = True
        Stng_Titlebar.Checked = True
        Stng_MaximizedWindow.Checked = False
        stng_anim.Checked = True
        Stng_Volet_reduire.Checked = False
        Stng_Volet_Mousehover_agrandir.Checked = False
        stng_target.Checked = False
        stng_colorlinecheck.Checked = False
        stng_grayicons.Checked = False
        colorbox.BackColor = Color.SteelBlue
        Colorbox2.BackColor = Color.DeepSkyBlue
        colorline.BackColor = Color.SteelBlue
        Sfight_Checkbox.Checked = True
        Share_checkbox.Checked = True
        translate_checkbox.Checked = True
        lock_checkbox.Checked = True
        memo_checkbox.Checked = True
        Stng_bluestart_checkbox.Checked = True
        Home_checkbox.Checked = True
        favo_checkbox.Checked = True
        infos_checkbox.Checked = True
        stng_nevpriv.Checked = False
        messageboxe.Show()
        messageboxe.BackColor = Color.CornflowerBlue
        messageboxe.Titre.Text = "Paramètres"
        messageboxe.Text.Text = "Les paramètres de Blueflap ont été réinitialisés"
        messageboxe.Smiley.Text = ";)"
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Verr_Textbox.Select()
    End Sub
End Class
