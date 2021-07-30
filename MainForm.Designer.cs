namespace Config
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkShowDmg = new System.Windows.Forms.CheckBox();
            this.checkShowChat = new System.Windows.Forms.CheckBox();
            this.checkShowshopnames = new System.Windows.Forms.CheckBox();
            this.checkSoftwarecursor = new System.Windows.Forms.CheckBox();
            this.checkDecompresstexture = new System.Windows.Forms.CheckBox();
            this.checkDefaultIME = new System.Windows.Forms.CheckBox();
            this.trackMusic = new System.Windows.Forms.TrackBar();
            this.labelSFX = new System.Windows.Forms.Label();
            this.trackSFX = new System.Windows.Forms.TrackBar();
            this.labelMusic = new System.Windows.Forms.Label();
            this.comboResolution = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelAntialias = new System.Windows.Forms.Label();
            this.comboAntialias = new System.Windows.Forms.ComboBox();
            this.checkWindowed = new System.Windows.Forms.CheckBox();
            this.checkMute = new System.Windows.Forms.CheckBox();
            this.checkObjectCulling = new System.Windows.Forms.CheckBox();
            this.comboFog = new System.Windows.Forms.ComboBox();
            this.labelFog = new System.Windows.Forms.Label();
            this.comboShadows = new System.Windows.Forms.ComboBox();
            this.labelShadows = new System.Windows.Forms.Label();
            this.checkBpp = new System.Windows.Forms.ComboBox();
            this.labelBpp = new System.Windows.Forms.Label();
            this.checkSnow = new System.Windows.Forms.CheckBox();
            this.checkDaylight = new System.Windows.Forms.CheckBox();
            this.checkHFR = new System.Windows.Forms.CheckBox();
            this.comboTNL = new System.Windows.Forms.ComboBox();
            this.labelTNL = new System.Windows.Forms.Label();
            this.checkLightMode = new System.Windows.Forms.CheckBox();
            this.checkFastText = new System.Windows.Forms.CheckBox();
            this.checkDisableLod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboReShade = new System.Windows.Forms.ComboBox();
            this.checkDiscord = new System.Windows.Forms.CheckBox();
            this.checkRenderTarget = new System.Windows.Forms.CheckBox();
            this.labelShowName = new System.Windows.Forms.Label();
            this.comboShowName = new System.Windows.Forms.ComboBox();
            this.GFXContainer = new System.Windows.Forms.GroupBox();
            this.audioContainer = new System.Windows.Forms.GroupBox();
            this.GFXContainer2 = new System.Windows.Forms.GroupBox();
            this.gameContainer = new System.Windows.Forms.GroupBox();
            this.advContainer = new System.Windows.Forms.GroupBox();
            this.checkYangQuantity = new System.Windows.Forms.CheckBox();
            this.checkItemQuantity = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSFX)).BeginInit();
            this.GFXContainer.SuspendLayout();
            this.audioContainer.SuspendLayout();
            this.GFXContainer2.SuspendLayout();
            this.gameContainer.SuspendLayout();
            this.advContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 0;
            this.toolTip.ReshowDelay = 100;
            // 
            // checkShowDmg
            // 
            this.checkShowDmg.AutoSize = true;
            this.checkShowDmg.Location = new System.Drawing.Point(6, 21);
            this.checkShowDmg.Name = "checkShowDmg";
            this.checkShowDmg.Size = new System.Drawing.Size(105, 18);
            this.checkShowDmg.TabIndex = 1;
            this.checkShowDmg.Text = "Show Damage";
            this.toolTip.SetToolTip(this.checkShowDmg, "Show the damage you deal and receive.");
            this.checkShowDmg.UseVisualStyleBackColor = true;
            this.checkShowDmg.CheckedChanged += new System.EventHandler(this.CheckShowDmgCheckedChanged);
            // 
            // checkShowChat
            // 
            this.checkShowChat.AutoSize = true;
            this.checkShowChat.Location = new System.Drawing.Point(6, 46);
            this.checkShowChat.Name = "checkShowChat";
            this.checkShowChat.Size = new System.Drawing.Size(85, 18);
            this.checkShowChat.TabIndex = 2;
            this.checkShowChat.Text = "Show chat";
            this.toolTip.SetToolTip(this.checkShowChat, "Show chat lines.");
            this.checkShowChat.UseVisualStyleBackColor = true;
            this.checkShowChat.CheckedChanged += new System.EventHandler(this.CheckShowChatCheckedChanged);
            // 
            // checkShowshopnames
            // 
            this.checkShowshopnames.AutoSize = true;
            this.checkShowshopnames.Location = new System.Drawing.Point(184, 21);
            this.checkShowshopnames.Name = "checkShowshopnames";
            this.checkShowshopnames.Size = new System.Drawing.Size(119, 18);
            this.checkShowshopnames.TabIndex = 3;
            this.checkShowshopnames.Text = "Show shop nams";
            this.toolTip.SetToolTip(this.checkShowshopnames, "Show the names of private shops.");
            this.checkShowshopnames.UseVisualStyleBackColor = true;
            this.checkShowshopnames.CheckedChanged += new System.EventHandler(this.CheckShowshopnamesCheckedChanged);
            // 
            // checkSoftwarecursor
            // 
            this.checkSoftwarecursor.AutoSize = true;
            this.checkSoftwarecursor.Location = new System.Drawing.Point(254, 89);
            this.checkSoftwarecursor.Name = "checkSoftwarecursor";
            this.checkSoftwarecursor.Size = new System.Drawing.Size(135, 18);
            this.checkSoftwarecursor.TabIndex = 18;
            this.checkSoftwarecursor.Text = "Use software cursor";
            this.toolTip.SetToolTip(this.checkSoftwarecursor, "Advanced: Leave off if in doubt.\r\nLet Windows manage the game cursor.");
            this.checkSoftwarecursor.UseVisualStyleBackColor = true;
            this.checkSoftwarecursor.CheckedChanged += new System.EventHandler(this.CheckSoftwarecursorCheckedChanged);
            // 
            // checkDecompresstexture
            // 
            this.checkDecompresstexture.AutoSize = true;
            this.checkDecompresstexture.Location = new System.Drawing.Point(448, 90);
            this.checkDecompresstexture.Name = "checkDecompresstexture";
            this.checkDecompresstexture.Size = new System.Drawing.Size(159, 18);
            this.checkDecompresstexture.TabIndex = 19;
            this.checkDecompresstexture.Text = "Decompressed Textures";
            this.toolTip.SetToolTip(this.checkDecompresstexture, "Better texture visuals but higher video memory demand");
            this.checkDecompresstexture.UseVisualStyleBackColor = true;
            this.checkDecompresstexture.CheckedChanged += new System.EventHandler(this.CheckDecompresstextureCheckedChanged);
            // 
            // checkDefaultIME
            // 
            this.checkDefaultIME.AutoSize = true;
            this.checkDefaultIME.Location = new System.Drawing.Point(254, 65);
            this.checkDefaultIME.Name = "checkDefaultIME";
            this.checkDefaultIME.Size = new System.Drawing.Size(89, 18);
            this.checkDefaultIME.TabIndex = 20;
            this.checkDefaultIME.Text = "Default IME";
            this.toolTip.SetToolTip(this.checkDefaultIME, "Advanced: Leave off if in doubt.\r\nLet Windows manage the game input.");
            this.checkDefaultIME.UseVisualStyleBackColor = true;
            this.checkDefaultIME.CheckedChanged += new System.EventHandler(this.CheckExternalImeCheckedChanged);
            // 
            // trackMusic
            // 
            this.trackMusic.AutoSize = false;
            this.trackMusic.LargeChange = 2;
            this.trackMusic.Location = new System.Drawing.Point(9, 88);
            this.trackMusic.Maximum = 500;
            this.trackMusic.Name = "trackMusic";
            this.trackMusic.Size = new System.Drawing.Size(283, 32);
            this.trackMusic.TabIndex = 0;
            this.trackMusic.TickFrequency = 100;
            this.trackMusic.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toolTip.SetToolTip(this.trackMusic, "In game music volume.");
            this.trackMusic.Scroll += new System.EventHandler(this.TrackMusicScroll);
            // 
            // labelSFX
            // 
            this.labelSFX.AutoSize = true;
            this.labelSFX.Location = new System.Drawing.Point(6, 19);
            this.labelSFX.Name = "labelSFX";
            this.labelSFX.Size = new System.Drawing.Size(27, 14);
            this.labelSFX.TabIndex = 1;
            this.labelSFX.Text = "SFX";
            this.toolTip.SetToolTip(this.labelSFX, "Effects volume.");
            // 
            // trackSFX
            // 
            this.trackSFX.AutoSize = false;
            this.trackSFX.LargeChange = 2;
            this.trackSFX.Location = new System.Drawing.Point(9, 34);
            this.trackSFX.Maximum = 5;
            this.trackSFX.Name = "trackSFX";
            this.trackSFX.Size = new System.Drawing.Size(283, 27);
            this.trackSFX.TabIndex = 2;
            this.trackSFX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toolTip.SetToolTip(this.trackSFX, "Effects volume.");
            this.trackSFX.Scroll += new System.EventHandler(this.TrackSfxScroll);
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Location = new System.Drawing.Point(6, 71);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(36, 14);
            this.labelMusic.TabIndex = 3;
            this.labelMusic.Text = "Music";
            this.toolTip.SetToolTip(this.labelMusic, "In game music volume.");
            // 
            // comboResolution
            // 
            this.comboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResolution.FormattingEnabled = true;
            this.comboResolution.Location = new System.Drawing.Point(9, 39);
            this.comboResolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboResolution.Name = "comboResolution";
            this.comboResolution.Size = new System.Drawing.Size(255, 22);
            this.comboResolution.TabIndex = 0;
            this.toolTip.SetToolTip(this.comboResolution, "Set game resolution.");
            this.comboResolution.SelectedIndexChanged += new System.EventHandler(this.ComboResolutionSelectedIndexChanged);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(6, 20);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(63, 14);
            this.labelResolution.TabIndex = 1;
            this.labelResolution.Text = "Resolution";
            this.toolTip.SetToolTip(this.labelResolution, "Set game resolution.");
            // 
            // labelAntialias
            // 
            this.labelAntialias.AutoSize = true;
            this.labelAntialias.Location = new System.Drawing.Point(6, 66);
            this.labelAntialias.Name = "labelAntialias";
            this.labelAntialias.Size = new System.Drawing.Size(66, 14);
            this.labelAntialias.TabIndex = 9;
            this.labelAntialias.Text = "Antialiasing";
            this.toolTip.SetToolTip(this.labelAntialias, "Smoothes out jagged edges on 3D Models. Will hinder performance on older computer" +
        "s.");
            // 
            // comboAntialias
            // 
            this.comboAntialias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAntialias.FormattingEnabled = true;
            this.comboAntialias.Items.AddRange(new object[] {
            "Disabled",
            "MSAA 2x",
            "MSAA 4x",
            "MSAA 8x"});
            this.comboAntialias.Location = new System.Drawing.Point(9, 85);
            this.comboAntialias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboAntialias.Name = "comboAntialias";
            this.comboAntialias.Size = new System.Drawing.Size(255, 22);
            this.comboAntialias.TabIndex = 10;
            this.toolTip.SetToolTip(this.comboAntialias, "Smoothes out jagged edges on 3D Models. Will hinder performance on older computer" +
        "s.");
            this.comboAntialias.SelectedIndexChanged += new System.EventHandler(this.ComboAntialiasSelectedIndexChanged);
            // 
            // checkWindowed
            // 
            this.checkWindowed.AutoSize = true;
            this.checkWindowed.Location = new System.Drawing.Point(6, 115);
            this.checkWindowed.Name = "checkWindowed";
            this.checkWindowed.Size = new System.Drawing.Size(156, 18);
            this.checkWindowed.TabIndex = 19;
            this.checkWindowed.Text = "Windowed (suggested)";
            this.toolTip.SetToolTip(this.checkWindowed, "Play in window instead of full screen.");
            this.checkWindowed.UseVisualStyleBackColor = true;
            this.checkWindowed.CheckedChanged += new System.EventHandler(this.CheckFullscreenCheckedChanged);
            // 
            // checkMute
            // 
            this.checkMute.AutoSize = true;
            this.checkMute.Location = new System.Drawing.Point(196, 126);
            this.checkMute.Name = "checkMute";
            this.checkMute.Size = new System.Drawing.Size(96, 18);
            this.checkMute.TabIndex = 23;
            this.checkMute.Text = "Disable audio";
            this.toolTip.SetToolTip(this.checkMute, "Disable all in game audio and music.");
            this.checkMute.UseVisualStyleBackColor = true;
            this.checkMute.CheckedChanged += new System.EventHandler(this.checkMute_CheckedChanged);
            // 
            // checkObjectCulling
            // 
            this.checkObjectCulling.AutoSize = true;
            this.checkObjectCulling.Location = new System.Drawing.Point(254, 41);
            this.checkObjectCulling.Name = "checkObjectCulling";
            this.checkObjectCulling.Size = new System.Drawing.Size(100, 18);
            this.checkObjectCulling.TabIndex = 24;
            this.checkObjectCulling.Text = "Object culling";
            this.toolTip.SetToolTip(this.checkObjectCulling, "The game will hide models that are not in the player field of view to save on per" +
        "formance.");
            this.checkObjectCulling.UseVisualStyleBackColor = true;
            this.checkObjectCulling.CheckedChanged += new System.EventHandler(this.checkObjectCulling_CheckedChanged);
            // 
            // comboFog
            // 
            this.comboFog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFog.FormattingEnabled = true;
            this.comboFog.Items.AddRange(new object[] {
            "Near",
            "Mid",
            "Far"});
            this.comboFog.Location = new System.Drawing.Point(6, 40);
            this.comboFog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboFog.Name = "comboFog";
            this.comboFog.Size = new System.Drawing.Size(147, 22);
            this.comboFog.TabIndex = 14;
            this.toolTip.SetToolTip(this.comboFog, "Sets the distance you can view far away.");
            this.comboFog.SelectedIndexChanged += new System.EventHandler(this.ComboFogSelectedIndexChanged);
            // 
            // labelFog
            // 
            this.labelFog.AutoSize = true;
            this.labelFog.Location = new System.Drawing.Point(6, 20);
            this.labelFog.Name = "labelFog";
            this.labelFog.Size = new System.Drawing.Size(27, 14);
            this.labelFog.TabIndex = 15;
            this.labelFog.Text = "Fog";
            this.toolTip.SetToolTip(this.labelFog, "Sets the distance you can view far away.");
            // 
            // comboShadows
            // 
            this.comboShadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShadows.FormattingEnabled = true;
            this.comboShadows.Items.AddRange(new object[] {
            "None",
            "Environment",
            "Environment and Players",
            "Everything",
            "Everything (Plus)",
            "Everything (Ultra)"});
            this.comboShadows.Location = new System.Drawing.Point(6, 88);
            this.comboShadows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboShadows.Name = "comboShadows";
            this.comboShadows.Size = new System.Drawing.Size(147, 22);
            this.comboShadows.TabIndex = 16;
            this.toolTip.SetToolTip(this.comboShadows, "Decide what draws a shadow. Will hinder performance on older machines.");
            this.comboShadows.SelectedIndexChanged += new System.EventHandler(this.ComboShadowsSelectedIndexChanged);
            // 
            // labelShadows
            // 
            this.labelShadows.AutoSize = true;
            this.labelShadows.Location = new System.Drawing.Point(6, 68);
            this.labelShadows.Name = "labelShadows";
            this.labelShadows.Size = new System.Drawing.Size(56, 14);
            this.labelShadows.TabIndex = 17;
            this.labelShadows.Text = "Shadows";
            this.toolTip.SetToolTip(this.labelShadows, "Decide what draws a shadow. Will hinder performance on older machines.");
            // 
            // checkBpp
            // 
            this.checkBpp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkBpp.FormattingEnabled = true;
            this.checkBpp.Items.AddRange(new object[] {
            "16 BPP",
            "32 BPP"});
            this.checkBpp.Location = new System.Drawing.Point(6, 85);
            this.checkBpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBpp.Name = "checkBpp";
            this.checkBpp.Size = new System.Drawing.Size(198, 22);
            this.checkBpp.TabIndex = 23;
            this.toolTip.SetToolTip(this.checkBpp, "Color depth. Leave on 32 DPP for better colors. Use 16 DPP to troubleshoot issues" +
        "");
            this.checkBpp.SelectedIndexChanged += new System.EventHandler(this.checkBpp_SelectedIndexChanged);
            // 
            // labelBpp
            // 
            this.labelBpp.AutoSize = true;
            this.labelBpp.Location = new System.Drawing.Point(6, 65);
            this.labelBpp.Name = "labelBpp";
            this.labelBpp.Size = new System.Drawing.Size(71, 14);
            this.labelBpp.TabIndex = 24;
            this.labelBpp.Text = "Color depth";
            this.toolTip.SetToolTip(this.labelBpp, "Color depth. Leave on 32 DPP for better colors. Use 16 DPP to troubleshoot issues" +
        "");
            // 
            // checkSnow
            // 
            this.checkSnow.AutoSize = true;
            this.checkSnow.Location = new System.Drawing.Point(184, 44);
            this.checkSnow.Name = "checkSnow";
            this.checkSnow.Size = new System.Drawing.Size(130, 18);
            this.checkSnow.TabIndex = 25;
            this.checkSnow.Text = "Snow on Christmas";
            this.toolTip.SetToolTip(this.checkSnow, "Do you want to build a snowman?");
            this.checkSnow.UseVisualStyleBackColor = true;
            this.checkSnow.CheckedChanged += new System.EventHandler(this.checkSnow_CheckedChanged);
            // 
            // checkDaylight
            // 
            this.checkDaylight.AutoSize = true;
            this.checkDaylight.Location = new System.Drawing.Point(184, 68);
            this.checkDaylight.Name = "checkDaylight";
            this.checkDaylight.Size = new System.Drawing.Size(101, 18);
            this.checkDaylight.TabIndex = 26;
            this.checkDaylight.Text = "Daylight Cycle";
            this.toolTip.SetToolTip(this.checkDaylight, "If on, the game sky changes accordingly to your local time.");
            this.checkDaylight.UseVisualStyleBackColor = true;
            this.checkDaylight.CheckedChanged += new System.EventHandler(this.checkDaylight_CheckedChanged);
            // 
            // checkHFR
            // 
            this.checkHFR.AutoSize = true;
            this.checkHFR.Location = new System.Drawing.Point(6, 140);
            this.checkHFR.Name = "checkHFR";
            this.checkHFR.Size = new System.Drawing.Size(170, 18);
            this.checkHFR.TabIndex = 27;
            this.checkHFR.Text = "High Refresh Rate support";
            this.toolTip.SetToolTip(this.checkHFR, "Experimental. If you have a High Refresh Rate screen (144Hz) this will make Metin" +
        "2 run at higher refresh rates.");
            this.checkHFR.UseVisualStyleBackColor = true;
            this.checkHFR.CheckedChanged += new System.EventHandler(this.checkHFR_CheckedChanged);
            // 
            // comboTNL
            // 
            this.comboTNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTNL.FormattingEnabled = true;
            this.comboTNL.Items.AddRange(new object[] {
            "Auto",
            "CPU",
            "GPU"});
            this.comboTNL.Location = new System.Drawing.Point(6, 38);
            this.comboTNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTNL.Name = "comboTNL";
            this.comboTNL.Size = new System.Drawing.Size(195, 22);
            this.comboTNL.TabIndex = 16;
            this.toolTip.SetToolTip(this.comboTNL, "Leave this on Auto or GPU. Use CPU only to troubleshoot issues, but it will cause" +
        " graphical issues.");
            this.comboTNL.SelectedIndexChanged += new System.EventHandler(this.ComboTnlSelectedIndexChanged);
            // 
            // labelTNL
            // 
            this.labelTNL.AutoSize = true;
            this.labelTNL.Location = new System.Drawing.Point(6, 19);
            this.labelTNL.Name = "labelTNL";
            this.labelTNL.Size = new System.Drawing.Size(62, 14);
            this.labelTNL.TabIndex = 17;
            this.labelTNL.Text = "Rendering";
            this.toolTip.SetToolTip(this.labelTNL, "Leave this on Auto or GPU. Use CPU only to troubleshoot issues, but it will cause" +
        " graphical issues.");
            this.labelTNL.Click += new System.EventHandler(this.labelTNL_Click);
            // 
            // checkLightMode
            // 
            this.checkLightMode.AutoSize = true;
            this.checkLightMode.Location = new System.Drawing.Point(6, 70);
            this.checkLightMode.Name = "checkLightMode";
            this.checkLightMode.Size = new System.Drawing.Size(88, 18);
            this.checkLightMode.TabIndex = 27;
            this.checkLightMode.Text = "Light mode";
            this.toolTip.SetToolTip(this.checkLightMode, "When active, every map will be light and clear as day.");
            this.checkLightMode.UseVisualStyleBackColor = true;
            this.checkLightMode.CheckedChanged += new System.EventHandler(this.checkLightMode_CheckedChanged);
            // 
            // checkFastText
            // 
            this.checkFastText.AutoSize = true;
            this.checkFastText.Location = new System.Drawing.Point(448, 42);
            this.checkFastText.Name = "checkFastText";
            this.checkFastText.Size = new System.Drawing.Size(137, 18);
            this.checkFastText.TabIndex = 25;
            this.checkFastText.Text = "Fast Text Rendering";
            this.toolTip.SetToolTip(this.checkFastText, "In-Game Text will be rendered with a shadow instead of an outline.\r\nThis might im" +
        "prove performance on older Computers.");
            this.checkFastText.UseVisualStyleBackColor = true;
            this.checkFastText.CheckedChanged += new System.EventHandler(this.checkFastText_CheckedChanged);
            // 
            // checkDisableLod
            // 
            this.checkDisableLod.AutoSize = true;
            this.checkDisableLod.Location = new System.Drawing.Point(448, 66);
            this.checkDisableLod.Name = "checkDisableLod";
            this.checkDisableLod.Size = new System.Drawing.Size(148, 18);
            this.checkDisableLod.TabIndex = 26;
            this.checkDisableLod.Text = "Advanced Model Draw";
            this.toolTip.SetToolTip(this.checkDisableLod, "If you enable this options, farther models will always be rendered at full qualit" +
        "y. While this might decrease performance it will improve game looks on modern Co" +
        "mputers.");
            this.checkDisableLod.UseVisualStyleBackColor = true;
            this.checkDisableLod.CheckedChanged += new System.EventHandler(this.checkDisableLod_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reshade";
            this.toolTip.SetToolTip(this.label1, "Sets the distance you can view far away.");
            // 
            // comboReShade
            // 
            this.comboReShade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReShade.FormattingEnabled = true;
            this.comboReShade.Items.AddRange(new object[] {
            "Off",
            "Low",
            "Mid",
            "Extreme"});
            this.comboReShade.Location = new System.Drawing.Point(178, 40);
            this.comboReShade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboReShade.Name = "comboReShade";
            this.comboReShade.Size = new System.Drawing.Size(147, 22);
            this.comboReShade.TabIndex = 19;
            this.toolTip.SetToolTip(this.comboReShade, "Sets the distance you can view far away.");
            this.comboReShade.SelectedIndexChanged += new System.EventHandler(this.comboReShade_SelectedIndexChanged);
            // 
            // checkDiscord
            // 
            this.checkDiscord.AutoSize = true;
            this.checkDiscord.Location = new System.Drawing.Point(184, 92);
            this.checkDiscord.Name = "checkDiscord";
            this.checkDiscord.Size = new System.Drawing.Size(130, 18);
            this.checkDiscord.TabIndex = 28;
            this.checkDiscord.Text = "Discord Integration";
            this.toolTip.SetToolTip(this.checkDiscord, "When active, Discord will show to others when you\'re in game");
            this.checkDiscord.UseVisualStyleBackColor = true;
            this.checkDiscord.CheckedChanged += new System.EventHandler(this.checkDiscord_CheckedChanged);
            // 
            // checkRenderTarget
            // 
            this.checkRenderTarget.AutoSize = true;
            this.checkRenderTarget.Location = new System.Drawing.Point(6, 94);
            this.checkRenderTarget.Name = "checkRenderTarget";
            this.checkRenderTarget.Size = new System.Drawing.Size(114, 18);
            this.checkRenderTarget.TabIndex = 29;
            this.checkRenderTarget.Text = "Enable Previews";
            this.toolTip.SetToolTip(this.checkRenderTarget, "When active some quests will show monster previews and some vendors will shop ite" +
        "m previews. Disable it if you\'re having issues");
            this.checkRenderTarget.UseVisualStyleBackColor = true;
            this.checkRenderTarget.CheckedChanged += new System.EventHandler(this.checkRenderTarget_CheckedChanged);
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.Location = new System.Drawing.Point(6, 156);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(72, 14);
            this.labelShowName.TabIndex = 21;
            this.labelShowName.Text = "Show name";
            this.toolTip.SetToolTip(this.labelShowName, "Decide what draws a shadow. Will hinder performance on older machines.");
            // 
            // comboShowName
            // 
            this.comboShowName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShowName.FormattingEnabled = true;
            this.comboShowName.Items.AddRange(new object[] {
            "Off",
            "On",
            "Extra"});
            this.comboShowName.Location = new System.Drawing.Point(6, 176);
            this.comboShowName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboShowName.Name = "comboShowName";
            this.comboShowName.Size = new System.Drawing.Size(181, 22);
            this.comboShowName.TabIndex = 20;
            this.toolTip.SetToolTip(this.comboShowName, "Decide what draws a shadow. Will hinder performance on older machines.");
            this.comboShowName.SelectedIndexChanged += new System.EventHandler(this.comboShowName_SelectedIndexChanged);
            // 
            // GFXContainer
            // 
            this.GFXContainer.Controls.Add(this.checkHFR);
            this.GFXContainer.Controls.Add(this.comboResolution);
            this.GFXContainer.Controls.Add(this.labelResolution);
            this.GFXContainer.Controls.Add(this.labelAntialias);
            this.GFXContainer.Controls.Add(this.comboAntialias);
            this.GFXContainer.Controls.Add(this.checkWindowed);
            this.GFXContainer.Location = new System.Drawing.Point(12, 12);
            this.GFXContainer.Name = "GFXContainer";
            this.GFXContainer.Size = new System.Drawing.Size(298, 173);
            this.GFXContainer.TabIndex = 2;
            this.GFXContainer.TabStop = false;
            this.GFXContainer.Text = "Display";
            // 
            // audioContainer
            // 
            this.audioContainer.Controls.Add(this.trackSFX);
            this.audioContainer.Controls.Add(this.checkMute);
            this.audioContainer.Controls.Add(this.labelMusic);
            this.audioContainer.Controls.Add(this.trackMusic);
            this.audioContainer.Controls.Add(this.labelSFX);
            this.audioContainer.Location = new System.Drawing.Point(12, 191);
            this.audioContainer.Name = "audioContainer";
            this.audioContainer.Size = new System.Drawing.Size(298, 182);
            this.audioContainer.TabIndex = 3;
            this.audioContainer.TabStop = false;
            this.audioContainer.Text = "Sound";
            // 
            // GFXContainer2
            // 
            this.GFXContainer2.Controls.Add(this.comboReShade);
            this.GFXContainer2.Controls.Add(this.label1);
            this.GFXContainer2.Controls.Add(this.labelFog);
            this.GFXContainer2.Controls.Add(this.comboFog);
            this.GFXContainer2.Controls.Add(this.labelShadows);
            this.GFXContainer2.Controls.Add(this.comboShadows);
            this.GFXContainer2.Location = new System.Drawing.Point(322, 12);
            this.GFXContainer2.Name = "GFXContainer2";
            this.GFXContainer2.Size = new System.Drawing.Size(363, 144);
            this.GFXContainer2.TabIndex = 19;
            this.GFXContainer2.TabStop = false;
            this.GFXContainer2.Text = "Graphics";
            // 
            // gameContainer
            // 
            this.gameContainer.Controls.Add(this.checkYangQuantity);
            this.gameContainer.Controls.Add(this.checkItemQuantity);
            this.gameContainer.Controls.Add(this.labelShowName);
            this.gameContainer.Controls.Add(this.checkRenderTarget);
            this.gameContainer.Controls.Add(this.comboShowName);
            this.gameContainer.Controls.Add(this.checkDiscord);
            this.gameContainer.Controls.Add(this.checkLightMode);
            this.gameContainer.Controls.Add(this.checkShowDmg);
            this.gameContainer.Controls.Add(this.checkShowChat);
            this.gameContainer.Controls.Add(this.checkShowshopnames);
            this.gameContainer.Controls.Add(this.checkSnow);
            this.gameContainer.Controls.Add(this.checkDaylight);
            this.gameContainer.Location = new System.Drawing.Point(316, 162);
            this.gameContainer.Name = "gameContainer";
            this.gameContainer.Size = new System.Drawing.Size(375, 211);
            this.gameContainer.TabIndex = 27;
            this.gameContainer.TabStop = false;
            this.gameContainer.Text = "Game";
            // 
            // advContainer
            // 
            this.advContainer.Controls.Add(this.checkDisableLod);
            this.advContainer.Controls.Add(this.checkFastText);
            this.advContainer.Controls.Add(this.labelTNL);
            this.advContainer.Controls.Add(this.comboTNL);
            this.advContainer.Controls.Add(this.checkDecompresstexture);
            this.advContainer.Controls.Add(this.checkObjectCulling);
            this.advContainer.Controls.Add(this.labelBpp);
            this.advContainer.Controls.Add(this.checkDefaultIME);
            this.advContainer.Controls.Add(this.checkBpp);
            this.advContainer.Controls.Add(this.checkSoftwarecursor);
            this.advContainer.Location = new System.Drawing.Point(12, 379);
            this.advContainer.Name = "advContainer";
            this.advContainer.Size = new System.Drawing.Size(679, 135);
            this.advContainer.TabIndex = 28;
            this.advContainer.TabStop = false;
            this.advContainer.Text = "Advanced";
            // 
            // checkYangQuantity
            // 
            this.checkYangQuantity.AutoSize = true;
            this.checkYangQuantity.Location = new System.Drawing.Point(6, 118);
            this.checkYangQuantity.Name = "checkYangQuantity";
            this.checkYangQuantity.Size = new System.Drawing.Size(156, 18);
            this.checkYangQuantity.TabIndex = 31;
            this.checkYangQuantity.Text = "Dropped Yang Quantity";
            this.toolTip.SetToolTip(this.checkYangQuantity, "Yang on the ground will show their amount");
            this.checkYangQuantity.UseVisualStyleBackColor = true;
            this.checkYangQuantity.CheckedChanged += new System.EventHandler(this.checkYangQuantity_CheckedChanged);
            // 
            // checkItemQuantity
            // 
            this.checkItemQuantity.AutoSize = true;
            this.checkItemQuantity.Location = new System.Drawing.Point(184, 116);
            this.checkItemQuantity.Name = "checkItemQuantity";
            this.checkItemQuantity.Size = new System.Drawing.Size(154, 18);
            this.checkItemQuantity.TabIndex = 30;
            this.checkItemQuantity.Text = "Dropped Item Quantity";
            this.toolTip.SetToolTip(this.checkItemQuantity, "Items on the ground will show their amount");
            this.checkItemQuantity.UseVisualStyleBackColor = true;
            this.checkItemQuantity.CheckedChanged += new System.EventHandler(this.checkItemQuantity_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(696, 526);
            this.Controls.Add(this.advContainer);
            this.Controls.Add(this.gameContainer);
            this.Controls.Add(this.GFXContainer2);
            this.Controls.Add(this.audioContainer);
            this.Controls.Add(this.GFXContainer);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSFX)).EndInit();
            this.GFXContainer.ResumeLayout(false);
            this.GFXContainer.PerformLayout();
            this.audioContainer.ResumeLayout(false);
            this.audioContainer.PerformLayout();
            this.GFXContainer2.ResumeLayout(false);
            this.GFXContainer2.PerformLayout();
            this.gameContainer.ResumeLayout(false);
            this.gameContainer.PerformLayout();
            this.advContainer.ResumeLayout(false);
            this.advContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkDefaultIME;
        private System.Windows.Forms.CheckBox checkDecompresstexture;
        private System.Windows.Forms.CheckBox checkSoftwarecursor;
        private System.Windows.Forms.CheckBox checkShowshopnames;
        private System.Windows.Forms.CheckBox checkShowChat;
        private System.Windows.Forms.CheckBox checkShowDmg;
        private System.Windows.Forms.Label labelMusic;
        private System.Windows.Forms.TrackBar trackSFX;
        private System.Windows.Forms.Label labelSFX;
        private System.Windows.Forms.TrackBar trackMusic;
        private System.Windows.Forms.CheckBox checkWindowed;
        private System.Windows.Forms.ComboBox comboAntialias;
        private System.Windows.Forms.Label labelAntialias;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.ComboBox comboResolution;
        private System.Windows.Forms.CheckBox checkMute;
        private System.Windows.Forms.CheckBox checkObjectCulling;
        private System.Windows.Forms.Label labelBpp;
        private System.Windows.Forms.ComboBox checkBpp;
        private System.Windows.Forms.Label labelShadows;
        private System.Windows.Forms.ComboBox comboShadows;
        private System.Windows.Forms.Label labelFog;
        private System.Windows.Forms.ComboBox comboFog;
        private System.Windows.Forms.CheckBox checkSnow;
        private System.Windows.Forms.CheckBox checkDaylight;
        private System.Windows.Forms.GroupBox GFXContainer;
        private System.Windows.Forms.CheckBox checkHFR;
        private System.Windows.Forms.GroupBox audioContainer;
        private System.Windows.Forms.GroupBox GFXContainer2;
        private System.Windows.Forms.ComboBox comboTNL;
        private System.Windows.Forms.Label labelTNL;
        private System.Windows.Forms.GroupBox gameContainer;
        private System.Windows.Forms.CheckBox checkLightMode;
        private System.Windows.Forms.GroupBox advContainer;
        private System.Windows.Forms.CheckBox checkFastText;
        private System.Windows.Forms.CheckBox checkDisableLod;
        private System.Windows.Forms.ComboBox comboReShade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDiscord;
        private System.Windows.Forms.CheckBox checkRenderTarget;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.ComboBox comboShowName;
        private System.Windows.Forms.CheckBox checkYangQuantity;
        private System.Windows.Forms.CheckBox checkItemQuantity;
    }
}

