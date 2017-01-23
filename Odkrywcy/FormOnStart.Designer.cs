namespace Odkrywcy
{
    partial class FormOnStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadGamePanel = new System.Windows.Forms.Panel();
            this.LoadGameLabel = new System.Windows.Forms.Label();
            this.NameOfGamePicBox = new System.Windows.Forms.PictureBox();
            this.timer_loadGame = new System.Windows.Forms.Timer(this.components);
            this.InitGamePanel = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.WorldLabel = new System.Windows.Forms.Label();
            this.EuropeLabel = new System.Windows.Forms.Label();
            this.PolandLabel = new System.Windows.Forms.Label();
            this.WorldMapButton = new System.Windows.Forms.Button();
            this.EuropeMapButton = new System.Windows.Forms.Button();
            this.PolandMapButton = new System.Windows.Forms.Button();
            this.MapLabel = new System.Windows.Forms.Label();
            this.YellowPlayerTextBox = new System.Windows.Forms.TextBox();
            this.BluePlayerTextBox = new System.Windows.Forms.TextBox();
            this.GreenPlayerTextBox = new System.Windows.Forms.TextBox();
            this.RedPlayerTextBox = new System.Windows.Forms.TextBox();
            this.YellowPlayerLabel = new System.Windows.Forms.Label();
            this.GreenPlayerLabel = new System.Windows.Forms.Label();
            this.BluePlayerLabel = new System.Windows.Forms.Label();
            this.RedPlayerLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FourPlayersButton = new System.Windows.Forms.Button();
            this.ThreePlayersButton = new System.Windows.Forms.Button();
            this.TwoPlayersButton = new System.Windows.Forms.Button();
            this.NumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.SmallNameOfGamePicBox = new System.Windows.Forms.PictureBox();
            this.AssignOrderPanel = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.ThrowDiceButton = new System.Windows.Forms.Button();
            this.InfoDicePictureBox = new System.Windows.Forms.PictureBox();
            this.DicePictureBox = new System.Windows.Forms.PictureBox();
            this.DiceBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SmallNameOfGamePictureBox = new System.Windows.Forms.PictureBox();
            this.timer_changeDice = new System.Windows.Forms.Timer(this.components);
            this.timer_waitForStart = new System.Windows.Forms.Timer(this.components);
            this.LoadGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameOfGamePicBox)).BeginInit();
            this.InitGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallNameOfGamePicBox)).BeginInit();
            this.AssignOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBackgroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallNameOfGamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadGamePanel
            // 
            this.LoadGamePanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadGamePanel.Controls.Add(this.LoadGameLabel);
            this.LoadGamePanel.Controls.Add(this.NameOfGamePicBox);
            this.LoadGamePanel.Enabled = false;
            this.LoadGamePanel.Location = new System.Drawing.Point(-23, -45);
            this.LoadGamePanel.Name = "LoadGamePanel";
            this.LoadGamePanel.Size = new System.Drawing.Size(347, 187);
            this.LoadGamePanel.TabIndex = 0;
            this.LoadGamePanel.Visible = false;
            // 
            // LoadGameLabel
            // 
            this.LoadGameLabel.AutoSize = true;
            this.LoadGameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadGameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoadGameLabel.Location = new System.Drawing.Point(35, 117);
            this.LoadGameLabel.Name = "LoadGameLabel";
            this.LoadGameLabel.Size = new System.Drawing.Size(298, 79);
            this.LoadGameLabel.TabIndex = 2;
            this.LoadGameLabel.Text = "Ładowanie";
            // 
            // NameOfGamePicBox
            // 
            this.NameOfGamePicBox.BackColor = System.Drawing.Color.Transparent;
            this.NameOfGamePicBox.BackgroundImage = global::Odkrywcy.Properties.Resources.name_of_game;
            this.NameOfGamePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NameOfGamePicBox.Location = new System.Drawing.Point(35, 57);
            this.NameOfGamePicBox.Name = "NameOfGamePicBox";
            this.NameOfGamePicBox.Size = new System.Drawing.Size(277, 57);
            this.NameOfGamePicBox.TabIndex = 1;
            this.NameOfGamePicBox.TabStop = false;
            // 
            // timer_loadGame
            // 
            this.timer_loadGame.Interval = 1000;
            this.timer_loadGame.Tick += new System.EventHandler(this.timer_loadGame_Tick);
            // 
            // InitGamePanel
            // 
            this.InitGamePanel.BackColor = System.Drawing.Color.Transparent;
            this.InitGamePanel.Controls.Add(this.PlayButton);
            this.InitGamePanel.Controls.Add(this.WorldLabel);
            this.InitGamePanel.Controls.Add(this.EuropeLabel);
            this.InitGamePanel.Controls.Add(this.PolandLabel);
            this.InitGamePanel.Controls.Add(this.WorldMapButton);
            this.InitGamePanel.Controls.Add(this.EuropeMapButton);
            this.InitGamePanel.Controls.Add(this.PolandMapButton);
            this.InitGamePanel.Controls.Add(this.MapLabel);
            this.InitGamePanel.Controls.Add(this.YellowPlayerTextBox);
            this.InitGamePanel.Controls.Add(this.BluePlayerTextBox);
            this.InitGamePanel.Controls.Add(this.GreenPlayerTextBox);
            this.InitGamePanel.Controls.Add(this.RedPlayerTextBox);
            this.InitGamePanel.Controls.Add(this.YellowPlayerLabel);
            this.InitGamePanel.Controls.Add(this.GreenPlayerLabel);
            this.InitGamePanel.Controls.Add(this.BluePlayerLabel);
            this.InitGamePanel.Controls.Add(this.RedPlayerLabel);
            this.InitGamePanel.Controls.Add(this.ExitButton);
            this.InitGamePanel.Controls.Add(this.FourPlayersButton);
            this.InitGamePanel.Controls.Add(this.ThreePlayersButton);
            this.InitGamePanel.Controls.Add(this.TwoPlayersButton);
            this.InitGamePanel.Controls.Add(this.NumberOfPlayersLabel);
            this.InitGamePanel.Controls.Add(this.SmallNameOfGamePicBox);
            this.InitGamePanel.Enabled = false;
            this.InitGamePanel.Location = new System.Drawing.Point(224, 27);
            this.InitGamePanel.Name = "InitGamePanel";
            this.InitGamePanel.Size = new System.Drawing.Size(413, 374);
            this.InitGamePanel.TabIndex = 1;
            this.InitGamePanel.Visible = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = global::Odkrywcy.Properties.Resources.play_png;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(323, 277);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 68);
            this.PlayButton.TabIndex = 21;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // WorldLabel
            // 
            this.WorldLabel.AutoSize = true;
            this.WorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorldLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.WorldLabel.Location = new System.Drawing.Point(269, 325);
            this.WorldLabel.Name = "WorldLabel";
            this.WorldLabel.Size = new System.Drawing.Size(48, 20);
            this.WorldLabel.TabIndex = 20;
            this.WorldLabel.Text = "Świat";
            // 
            // EuropeLabel
            // 
            this.EuropeLabel.AutoSize = true;
            this.EuropeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EuropeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EuropeLabel.Location = new System.Drawing.Point(173, 325);
            this.EuropeLabel.Name = "EuropeLabel";
            this.EuropeLabel.Size = new System.Drawing.Size(61, 20);
            this.EuropeLabel.TabIndex = 19;
            this.EuropeLabel.Text = "Europa";
            // 
            // PolandLabel
            // 
            this.PolandLabel.AutoSize = true;
            this.PolandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PolandLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PolandLabel.Location = new System.Drawing.Point(85, 325);
            this.PolandLabel.Name = "PolandLabel";
            this.PolandLabel.Size = new System.Drawing.Size(56, 20);
            this.PolandLabel.TabIndex = 18;
            this.PolandLabel.Text = "Polska";
            // 
            // WorldMapButton
            // 
            this.WorldMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.world_unselected;
            this.WorldMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorldMapButton.FlatAppearance.BorderSize = 0;
            this.WorldMapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WorldMapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WorldMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorldMapButton.Location = new System.Drawing.Point(265, 277);
            this.WorldMapButton.Name = "WorldMapButton";
            this.WorldMapButton.Size = new System.Drawing.Size(52, 45);
            this.WorldMapButton.TabIndex = 17;
            this.WorldMapButton.UseVisualStyleBackColor = true;
            this.WorldMapButton.Click += new System.EventHandler(this.WorldMapButton_Click);
            // 
            // EuropeMapButton
            // 
            this.EuropeMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.europe_unselected;
            this.EuropeMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EuropeMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EuropeMapButton.FlatAppearance.BorderSize = 0;
            this.EuropeMapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EuropeMapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EuropeMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EuropeMapButton.Location = new System.Drawing.Point(177, 277);
            this.EuropeMapButton.Name = "EuropeMapButton";
            this.EuropeMapButton.Size = new System.Drawing.Size(55, 45);
            this.EuropeMapButton.TabIndex = 16;
            this.EuropeMapButton.UseVisualStyleBackColor = true;
            this.EuropeMapButton.Click += new System.EventHandler(this.EuropeMapButton_Click);
            // 
            // PolandMapButton
            // 
            this.PolandMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.poland_unselected;
            this.PolandMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PolandMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PolandMapButton.FlatAppearance.BorderSize = 0;
            this.PolandMapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PolandMapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PolandMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolandMapButton.Location = new System.Drawing.Point(82, 277);
            this.PolandMapButton.Name = "PolandMapButton";
            this.PolandMapButton.Size = new System.Drawing.Size(60, 45);
            this.PolandMapButton.TabIndex = 15;
            this.PolandMapButton.UseVisualStyleBackColor = true;
            this.PolandMapButton.Click += new System.EventHandler(this.PolandMapButton_Click);
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MapLabel.Location = new System.Drawing.Point(161, 254);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(77, 25);
            this.MapLabel.TabIndex = 14;
            this.MapLabel.Text = "Mapa:";
            // 
            // YellowPlayerTextBox
            // 
            this.YellowPlayerTextBox.Enabled = false;
            this.YellowPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YellowPlayerTextBox.Location = new System.Drawing.Point(189, 222);
            this.YellowPlayerTextBox.Name = "YellowPlayerTextBox";
            this.YellowPlayerTextBox.Size = new System.Drawing.Size(161, 29);
            this.YellowPlayerTextBox.TabIndex = 13;
            this.YellowPlayerTextBox.Visible = false;
            // 
            // BluePlayerTextBox
            // 
            this.BluePlayerTextBox.Enabled = false;
            this.BluePlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BluePlayerTextBox.Location = new System.Drawing.Point(28, 222);
            this.BluePlayerTextBox.Name = "BluePlayerTextBox";
            this.BluePlayerTextBox.Size = new System.Drawing.Size(161, 29);
            this.BluePlayerTextBox.TabIndex = 12;
            this.BluePlayerTextBox.Visible = false;
            // 
            // GreenPlayerTextBox
            // 
            this.GreenPlayerTextBox.Enabled = false;
            this.GreenPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreenPlayerTextBox.Location = new System.Drawing.Point(189, 172);
            this.GreenPlayerTextBox.Name = "GreenPlayerTextBox";
            this.GreenPlayerTextBox.Size = new System.Drawing.Size(161, 29);
            this.GreenPlayerTextBox.TabIndex = 11;
            this.GreenPlayerTextBox.Visible = false;
            // 
            // RedPlayerTextBox
            // 
            this.RedPlayerTextBox.Enabled = false;
            this.RedPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RedPlayerTextBox.Location = new System.Drawing.Point(28, 172);
            this.RedPlayerTextBox.Name = "RedPlayerTextBox";
            this.RedPlayerTextBox.Size = new System.Drawing.Size(161, 29);
            this.RedPlayerTextBox.TabIndex = 10;
            this.RedPlayerTextBox.Visible = false;
            // 
            // YellowPlayerLabel
            // 
            this.YellowPlayerLabel.AutoSize = true;
            this.YellowPlayerLabel.Enabled = false;
            this.YellowPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YellowPlayerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.YellowPlayerLabel.Location = new System.Drawing.Point(195, 204);
            this.YellowPlayerLabel.Name = "YellowPlayerLabel";
            this.YellowPlayerLabel.Size = new System.Drawing.Size(122, 24);
            this.YellowPlayerLabel.TabIndex = 9;
            this.YellowPlayerLabel.Text = "Gracz żółty:";
            this.YellowPlayerLabel.Visible = false;
            // 
            // GreenPlayerLabel
            // 
            this.GreenPlayerLabel.AutoSize = true;
            this.GreenPlayerLabel.Enabled = false;
            this.GreenPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreenPlayerLabel.ForeColor = System.Drawing.Color.Green;
            this.GreenPlayerLabel.Location = new System.Drawing.Point(187, 145);
            this.GreenPlayerLabel.Name = "GreenPlayerLabel";
            this.GreenPlayerLabel.Size = new System.Drawing.Size(142, 24);
            this.GreenPlayerLabel.TabIndex = 8;
            this.GreenPlayerLabel.Text = "Gracz zielony:";
            this.GreenPlayerLabel.Visible = false;
            // 
            // BluePlayerLabel
            // 
            this.BluePlayerLabel.AutoSize = true;
            this.BluePlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.BluePlayerLabel.Enabled = false;
            this.BluePlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BluePlayerLabel.ForeColor = System.Drawing.Color.Blue;
            this.BluePlayerLabel.Location = new System.Drawing.Point(30, 204);
            this.BluePlayerLabel.Name = "BluePlayerLabel";
            this.BluePlayerLabel.Size = new System.Drawing.Size(159, 24);
            this.BluePlayerLabel.TabIndex = 7;
            this.BluePlayerLabel.Text = "Gracz niebieski:";
            this.BluePlayerLabel.Visible = false;
            // 
            // RedPlayerLabel
            // 
            this.RedPlayerLabel.AutoSize = true;
            this.RedPlayerLabel.Enabled = false;
            this.RedPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RedPlayerLabel.ForeColor = System.Drawing.Color.Red;
            this.RedPlayerLabel.Location = new System.Drawing.Point(24, 145);
            this.RedPlayerLabel.Name = "RedPlayerLabel";
            this.RedPlayerLabel.Size = new System.Drawing.Size(165, 24);
            this.RedPlayerLabel.TabIndex = 6;
            this.RedPlayerLabel.Text = "Gracz czerwony:";
            this.RedPlayerLabel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::Odkrywcy.Properties.Resources.exit_icon;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(323, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 37);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FourPlayersButton
            // 
            this.FourPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.four_players_unselected;
            this.FourPlayersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourPlayersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourPlayersButton.FlatAppearance.BorderSize = 0;
            this.FourPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FourPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FourPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourPlayersButton.Location = new System.Drawing.Point(243, 97);
            this.FourPlayersButton.Name = "FourPlayersButton";
            this.FourPlayersButton.Size = new System.Drawing.Size(52, 45);
            this.FourPlayersButton.TabIndex = 4;
            this.FourPlayersButton.UseVisualStyleBackColor = true;
            this.FourPlayersButton.Click += new System.EventHandler(this.FourPlayersButton_Click);
            // 
            // ThreePlayersButton
            // 
            this.ThreePlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.three_players_unselected;
            this.ThreePlayersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThreePlayersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreePlayersButton.FlatAppearance.BorderSize = 0;
            this.ThreePlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ThreePlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ThreePlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreePlayersButton.Location = new System.Drawing.Point(155, 97);
            this.ThreePlayersButton.Name = "ThreePlayersButton";
            this.ThreePlayersButton.Size = new System.Drawing.Size(55, 45);
            this.ThreePlayersButton.TabIndex = 3;
            this.ThreePlayersButton.UseVisualStyleBackColor = true;
            this.ThreePlayersButton.Click += new System.EventHandler(this.ThreePlayersButton_Click);
            // 
            // TwoPlayersButton
            // 
            this.TwoPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.two_players_unselected;
            this.TwoPlayersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwoPlayersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoPlayersButton.FlatAppearance.BorderSize = 0;
            this.TwoPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TwoPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TwoPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPlayersButton.Location = new System.Drawing.Point(60, 97);
            this.TwoPlayersButton.Name = "TwoPlayersButton";
            this.TwoPlayersButton.Size = new System.Drawing.Size(60, 45);
            this.TwoPlayersButton.TabIndex = 2;
            this.TwoPlayersButton.UseVisualStyleBackColor = true;
            this.TwoPlayersButton.Click += new System.EventHandler(this.TwoPlayersButton_Click);
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(92, 44);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(165, 25);
            this.NumberOfPlayersLabel.TabIndex = 1;
            this.NumberOfPlayersLabel.Text = "Liczba graczy:";
            // 
            // SmallNameOfGamePicBox
            // 
            this.SmallNameOfGamePicBox.BackgroundImage = global::Odkrywcy.Properties.Resources.name_of_game;
            this.SmallNameOfGamePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmallNameOfGamePicBox.Location = new System.Drawing.Point(106, 3);
            this.SmallNameOfGamePicBox.Name = "SmallNameOfGamePicBox";
            this.SmallNameOfGamePicBox.Size = new System.Drawing.Size(123, 50);
            this.SmallNameOfGamePicBox.TabIndex = 0;
            this.SmallNameOfGamePicBox.TabStop = false;
            // 
            // AssignOrderPanel
            // 
            this.AssignOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.AssignOrderPanel.Controls.Add(this.OrderLabel);
            this.AssignOrderPanel.Controls.Add(this.ThrowDiceButton);
            this.AssignOrderPanel.Controls.Add(this.InfoDicePictureBox);
            this.AssignOrderPanel.Controls.Add(this.DicePictureBox);
            this.AssignOrderPanel.Controls.Add(this.DiceBackgroundPictureBox);
            this.AssignOrderPanel.Controls.Add(this.ExitBtn);
            this.AssignOrderPanel.Controls.Add(this.SmallNameOfGamePictureBox);
            this.AssignOrderPanel.Enabled = false;
            this.AssignOrderPanel.Location = new System.Drawing.Point(26, 96);
            this.AssignOrderPanel.Name = "AssignOrderPanel";
            this.AssignOrderPanel.Size = new System.Drawing.Size(245, 284);
            this.AssignOrderPanel.TabIndex = 2;
            this.AssignOrderPanel.Visible = false;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderLabel.Location = new System.Drawing.Point(72, 76);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(155, 43);
            this.OrderLabel.TabIndex = 11;
            this.OrderLabel.Text = "Order List";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThrowDiceButton
            // 
            this.ThrowDiceButton.BackgroundImage = global::Odkrywcy.Properties.Resources.throw_dice;
            this.ThrowDiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThrowDiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThrowDiceButton.FlatAppearance.BorderSize = 0;
            this.ThrowDiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ThrowDiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ThrowDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThrowDiceButton.Location = new System.Drawing.Point(86, 224);
            this.ThrowDiceButton.Name = "ThrowDiceButton";
            this.ThrowDiceButton.Size = new System.Drawing.Size(94, 28);
            this.ThrowDiceButton.TabIndex = 10;
            this.ThrowDiceButton.UseVisualStyleBackColor = true;
            this.ThrowDiceButton.Click += new System.EventHandler(this.ThrowDiceButton_Click);
            // 
            // InfoDicePictureBox
            // 
            this.InfoDicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.infoDice;
            this.InfoDicePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoDicePictureBox.Location = new System.Drawing.Point(-14, 76);
            this.InfoDicePictureBox.Name = "InfoDicePictureBox";
            this.InfoDicePictureBox.Size = new System.Drawing.Size(80, 37);
            this.InfoDicePictureBox.TabIndex = 9;
            this.InfoDicePictureBox.TabStop = false;
            // 
            // DicePictureBox
            // 
            this.DicePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.DicePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DicePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DicePictureBox.Location = new System.Drawing.Point(100, 153);
            this.DicePictureBox.Name = "DicePictureBox";
            this.DicePictureBox.Size = new System.Drawing.Size(74, 58);
            this.DicePictureBox.TabIndex = 8;
            this.DicePictureBox.TabStop = false;
            // 
            // DiceBackgroundPictureBox
            // 
            this.DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_red;
            this.DiceBackgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DiceBackgroundPictureBox.Location = new System.Drawing.Point(-14, 124);
            this.DiceBackgroundPictureBox.Name = "DiceBackgroundPictureBox";
            this.DiceBackgroundPictureBox.Size = new System.Drawing.Size(108, 86);
            this.DiceBackgroundPictureBox.TabIndex = 7;
            this.DiceBackgroundPictureBox.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::Odkrywcy.Properties.Resources.exit_icon;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(198, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(35, 37);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SmallNameOfGamePictureBox
            // 
            this.SmallNameOfGamePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.name_of_game;
            this.SmallNameOfGamePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmallNameOfGamePictureBox.Location = new System.Drawing.Point(59, 18);
            this.SmallNameOfGamePictureBox.Name = "SmallNameOfGamePictureBox";
            this.SmallNameOfGamePictureBox.Size = new System.Drawing.Size(123, 50);
            this.SmallNameOfGamePictureBox.TabIndex = 1;
            this.SmallNameOfGamePictureBox.TabStop = false;
            // 
            // timer_changeDice
            // 
            this.timer_changeDice.Tick += new System.EventHandler(this.timer_changeDice_Tick);
            // 
            // timer_waitForStart
            // 
            this.timer_waitForStart.Interval = 3000;
            this.timer_waitForStart.Tick += new System.EventHandler(this.timer_waitForStart_Tick);
            // 
            // FormOnStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Odkrywcy.Properties.Resources.old_map_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 402);
            this.Controls.Add(this.AssignOrderPanel);
            this.Controls.Add(this.InitGamePanel);
            this.Controls.Add(this.LoadGamePanel);
            this.Name = "FormOnStart";
            this.Text = "Form1";
            this.LoadGamePanel.ResumeLayout(false);
            this.LoadGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameOfGamePicBox)).EndInit();
            this.InitGamePanel.ResumeLayout(false);
            this.InitGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallNameOfGamePicBox)).EndInit();
            this.AssignOrderPanel.ResumeLayout(false);
            this.AssignOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBackgroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallNameOfGamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadGamePanel;
        private System.Windows.Forms.PictureBox NameOfGamePicBox;
        private System.Windows.Forms.Label LoadGameLabel;
        private System.Windows.Forms.Timer timer_loadGame;
        private System.Windows.Forms.Panel InitGamePanel;
        private System.Windows.Forms.Button FourPlayersButton;
        private System.Windows.Forms.Button ThreePlayersButton;
        private System.Windows.Forms.Button TwoPlayersButton;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.PictureBox SmallNameOfGamePicBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox RedPlayerTextBox;
        private System.Windows.Forms.Label YellowPlayerLabel;
        private System.Windows.Forms.Label GreenPlayerLabel;
        private System.Windows.Forms.Label BluePlayerLabel;
        private System.Windows.Forms.Label RedPlayerLabel;
        private System.Windows.Forms.TextBox YellowPlayerTextBox;
        private System.Windows.Forms.TextBox BluePlayerTextBox;
        private System.Windows.Forms.TextBox GreenPlayerTextBox;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.Button WorldMapButton;
        private System.Windows.Forms.Button EuropeMapButton;
        private System.Windows.Forms.Button PolandMapButton;
        private System.Windows.Forms.Label PolandLabel;
        private System.Windows.Forms.Label EuropeLabel;
        private System.Windows.Forms.Label WorldLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel AssignOrderPanel;
        private System.Windows.Forms.PictureBox SmallNameOfGamePictureBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox DiceBackgroundPictureBox;
        private System.Windows.Forms.PictureBox DicePictureBox;
        private System.Windows.Forms.PictureBox InfoDicePictureBox;
        private System.Windows.Forms.Button ThrowDiceButton;
        private System.Windows.Forms.Timer timer_changeDice;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Timer timer_waitForStart;
    }
}

