namespace Cards_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UseJokers = new System.Windows.Forms.CheckBox();
            this.UseMagic = new System.Windows.Forms.CheckBox();
            this.NumberOfPlayersParametre = new System.Windows.Forms.ComboBox();
            this.RemainingPlayersListView = new System.Windows.Forms.ListView();
            this.PlayerNameListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HpListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinsListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LosseListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrawListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListAvatar = new System.Windows.Forms.ImageList(this.components);
            this.NewPlayersButton = new System.Windows.Forms.RadioButton();
            this.SavedPlayersButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownHp = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPlayers_Label = new System.Windows.Forms.Label();
            this.UseFavoritePlayersButton = new System.Windows.Forms.Button();
            this.CreatePlayersButton = new System.Windows.Forms.Button();
            this.Players = new System.Windows.Forms.GroupBox();
            this.textBoxOfPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.SaveAsFavoritePlayers = new System.Windows.Forms.CheckBox();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.Avatar = new System.Windows.Forms.Label();
            this.NameOfPlayer = new System.Windows.Forms.Label();
            this.FirstPlayerPlayingLabel = new System.Windows.Forms.Label();
            this.SecondPlayerPlayingLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.DrawCardsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RoundCountLabel = new System.Windows.Forms.GroupBox();
            this.LoserIndicator = new System.Windows.Forms.Label();
            this.HpOfPlayerTwoProgressBar = new System.Windows.Forms.Label();
            this.HpOfPlayerOneProgressBar = new System.Windows.Forms.Label();
            this.PlayerTwoDeck = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CardImages = new System.Windows.Forms.ImageList(this.components);
            this.PlayerOneDeck = new System.Windows.Forms.PictureBox();
            this.BiggerImages = new System.Windows.Forms.ImageList(this.components);
            this.PlayerTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerOnePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHp)).BeginInit();
            this.Players.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.RoundCountLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoDeck)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOnePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UseJokers
            // 
            this.UseJokers.AutoSize = true;
            this.UseJokers.Location = new System.Drawing.Point(44, 26);
            this.UseJokers.Name = "UseJokers";
            this.UseJokers.Size = new System.Drawing.Size(76, 17);
            this.UseJokers.TabIndex = 1;
            this.UseJokers.Text = "Use jokers";
            this.UseJokers.UseVisualStyleBackColor = true;
            this.UseJokers.CheckedChanged += new System.EventHandler(this.UseJokers_CheckedChanged);
            // 
            // UseMagic
            // 
            this.UseMagic.AutoSize = true;
            this.UseMagic.Location = new System.Drawing.Point(44, 49);
            this.UseMagic.Name = "UseMagic";
            this.UseMagic.Size = new System.Drawing.Size(76, 17);
            this.UseMagic.TabIndex = 2;
            this.UseMagic.Text = "Use magic";
            this.UseMagic.UseVisualStyleBackColor = true;
            // 
            // NumberOfPlayersParametre
            // 
            this.NumberOfPlayersParametre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfPlayersParametre.FormattingEnabled = true;
            this.NumberOfPlayersParametre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumberOfPlayersParametre.Location = new System.Drawing.Point(561, 27);
            this.NumberOfPlayersParametre.Name = "NumberOfPlayersParametre";
            this.NumberOfPlayersParametre.Size = new System.Drawing.Size(83, 21);
            this.NumberOfPlayersParametre.TabIndex = 6;
            this.NumberOfPlayersParametre.SelectedIndexChanged += new System.EventHandler(this.NumberOfPlayersParametre_SelectedIndexChanged);
            // 
            // RemainingPlayersListView
            // 
            this.RemainingPlayersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerNameListView,
            this.HpListView,
            this.WinsListView,
            this.LosseListView,
            this.DrawListView});
            this.RemainingPlayersListView.HideSelection = false;
            this.RemainingPlayersListView.Location = new System.Drawing.Point(25, 85);
            this.RemainingPlayersListView.Name = "RemainingPlayersListView";
            this.RemainingPlayersListView.Size = new System.Drawing.Size(785, 122);
            this.RemainingPlayersListView.SmallImageList = this.imageListAvatar;
            this.RemainingPlayersListView.TabIndex = 3;
            this.RemainingPlayersListView.UseCompatibleStateImageBehavior = false;
            this.RemainingPlayersListView.View = System.Windows.Forms.View.Details;
            // 
            // PlayerNameListView
            // 
            this.PlayerNameListView.Text = "Player name";
            this.PlayerNameListView.Width = 139;
            // 
            // HpListView
            // 
            this.HpListView.Text = "HP";
            this.HpListView.Width = 86;
            // 
            // WinsListView
            // 
            this.WinsListView.Text = "Wins";
            this.WinsListView.Width = 72;
            // 
            // LosseListView
            // 
            this.LosseListView.Text = "Losses";
            this.LosseListView.Width = 83;
            // 
            // DrawListView
            // 
            this.DrawListView.Text = "Draw";
            this.DrawListView.Width = 77;
            // 
            // imageListAvatar
            // 
            this.imageListAvatar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAvatar.ImageStream")));
            this.imageListAvatar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAvatar.Images.SetKeyName(0, "mahrez (1).png");
            this.imageListAvatar.Images.SetKeyName(1, "halland (1).png");
            this.imageListAvatar.Images.SetKeyName(2, "neymar (1).png");
            this.imageListAvatar.Images.SetKeyName(3, "messi.png");
            this.imageListAvatar.Images.SetKeyName(4, "cr7.jpg");
            // 
            // NewPlayersButton
            // 
            this.NewPlayersButton.AutoSize = true;
            this.NewPlayersButton.Location = new System.Drawing.Point(274, 27);
            this.NewPlayersButton.Name = "NewPlayersButton";
            this.NewPlayersButton.Size = new System.Drawing.Size(83, 17);
            this.NewPlayersButton.TabIndex = 4;
            this.NewPlayersButton.TabStop = true;
            this.NewPlayersButton.Text = "New players";
            this.NewPlayersButton.UseVisualStyleBackColor = true;
            // 
            // SavedPlayersButton
            // 
            this.SavedPlayersButton.AutoSize = true;
            this.SavedPlayersButton.Location = new System.Drawing.Point(274, 68);
            this.SavedPlayersButton.Name = "SavedPlayersButton";
            this.SavedPlayersButton.Size = new System.Drawing.Size(92, 17);
            this.SavedPlayersButton.TabIndex = 5;
            this.SavedPlayersButton.TabStop = true;
            this.SavedPlayersButton.Text = "Saved players";
            this.SavedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownHp);
            this.groupBox1.Controls.Add(this.NewPlayersButton);
            this.groupBox1.Controls.Add(this.NumberOfPlayersParametre);
            this.groupBox1.Controls.Add(this.NumberOfPlayers_Label);
            this.groupBox1.Controls.Add(this.UseJokers);
            this.groupBox1.Controls.Add(this.SavedPlayersButton);
            this.groupBox1.Controls.Add(this.UseFavoritePlayersButton);
            this.groupBox1.Controls.Add(this.CreatePlayersButton);
            this.groupBox1.Controls.Add(this.UseMagic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MaxHp";
            // 
            // numericUpDownHp
            // 
            this.numericUpDownHp.Location = new System.Drawing.Point(32, 68);
            this.numericUpDownHp.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownHp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHp.Name = "numericUpDownHp";
            this.numericUpDownHp.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownHp.TabIndex = 3;
            this.numericUpDownHp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NumberOfPlayers_Label
            // 
            this.NumberOfPlayers_Label.AutoSize = true;
            this.NumberOfPlayers_Label.Location = new System.Drawing.Point(447, 28);
            this.NumberOfPlayers_Label.Name = "NumberOfPlayers_Label";
            this.NumberOfPlayers_Label.Size = new System.Drawing.Size(95, 13);
            this.NumberOfPlayers_Label.TabIndex = 6;
            this.NumberOfPlayers_Label.Text = "Number of players:";
            // 
            // UseFavoritePlayersButton
            // 
            this.UseFavoritePlayersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UseFavoritePlayersButton.Location = new System.Drawing.Point(675, 68);
            this.UseFavoritePlayersButton.Name = "UseFavoritePlayersButton";
            this.UseFavoritePlayersButton.Size = new System.Drawing.Size(158, 42);
            this.UseFavoritePlayersButton.TabIndex = 8;
            this.UseFavoritePlayersButton.Text = "Use favorite players";
            this.UseFavoritePlayersButton.UseVisualStyleBackColor = false;
            this.UseFavoritePlayersButton.Click += new System.EventHandler(this.UseFavoritePlayersButton_Click);
            // 
            // CreatePlayersButton
            // 
            this.CreatePlayersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreatePlayersButton.Location = new System.Drawing.Point(675, 13);
            this.CreatePlayersButton.Name = "CreatePlayersButton";
            this.CreatePlayersButton.Size = new System.Drawing.Size(158, 42);
            this.CreatePlayersButton.TabIndex = 7;
            this.CreatePlayersButton.Text = "Create players";
            this.CreatePlayersButton.UseVisualStyleBackColor = false;
            this.CreatePlayersButton.Click += new System.EventHandler(this.CreatePlayersButton_Click);
            // 
            // Players
            // 
            this.Players.Controls.Add(this.textBoxOfPlayerName);
            this.Players.Controls.Add(this.label1);
            this.Players.Controls.Add(this.AddPlayerButton);
            this.Players.Controls.Add(this.SaveAsFavoritePlayers);
            this.Players.Controls.Add(this.RemainingPlayersListView);
            this.Players.Controls.Add(this.avatarPicture);
            this.Players.Controls.Add(this.Avatar);
            this.Players.Controls.Add(this.NameOfPlayer);
            this.Players.Enabled = false;
            this.Players.Location = new System.Drawing.Point(12, 134);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(849, 226);
            this.Players.TabIndex = 7;
            this.Players.TabStop = false;
            this.Players.Text = "Players";
            this.Players.UseCompatibleTextRendering = true;
            // 
            // textBoxOfPlayerName
            // 
            this.textBoxOfPlayerName.Location = new System.Drawing.Point(132, 30);
            this.textBoxOfPlayerName.Name = "textBoxOfPlayerName";
            this.textBoxOfPlayerName.Size = new System.Drawing.Size(145, 20);
            this.textBoxOfPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remaining players:";
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(675, 16);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(135, 40);
            this.AddPlayerButton.TabIndex = 3;
            this.AddPlayerButton.Text = "Add player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // SaveAsFavoritePlayers
            // 
            this.SaveAsFavoritePlayers.AutoSize = true;
            this.SaveAsFavoritePlayers.Location = new System.Drawing.Point(675, 61);
            this.SaveAsFavoritePlayers.Name = "SaveAsFavoritePlayers";
            this.SaveAsFavoritePlayers.Size = new System.Drawing.Size(139, 17);
            this.SaveAsFavoritePlayers.TabIndex = 2;
            this.SaveAsFavoritePlayers.Text = "Save as favorite players";
            this.SaveAsFavoritePlayers.UseVisualStyleBackColor = true;
            // 
            // avatarPicture
            // 
            this.avatarPicture.Image = global::Cards_Game.Properties.Resources.mahrez;
            this.avatarPicture.Location = new System.Drawing.Point(581, 16);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(63, 59);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 3;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.Click += new System.EventHandler(this.avatarPicture_Click);
            // 
            // Avatar
            // 
            this.Avatar.AutoSize = true;
            this.Avatar.Location = new System.Drawing.Point(520, 30);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(41, 13);
            this.Avatar.TabIndex = 2;
            this.Avatar.Text = "Avatar:";
            // 
            // NameOfPlayer
            // 
            this.NameOfPlayer.AutoSize = true;
            this.NameOfPlayer.Location = new System.Drawing.Point(41, 30);
            this.NameOfPlayer.Name = "NameOfPlayer";
            this.NameOfPlayer.Size = new System.Drawing.Size(84, 13);
            this.NameOfPlayer.TabIndex = 0;
            this.NameOfPlayer.Text = "Name of player :";
            // 
            // FirstPlayerPlayingLabel
            // 
            this.FirstPlayerPlayingLabel.AutoSize = true;
            this.FirstPlayerPlayingLabel.Location = new System.Drawing.Point(29, 20);
            this.FirstPlayerPlayingLabel.Name = "FirstPlayerPlayingLabel";
            this.FirstPlayerPlayingLabel.Size = new System.Drawing.Size(45, 13);
            this.FirstPlayerPlayingLabel.TabIndex = 10;
            this.FirstPlayerPlayingLabel.Text = "Player 1";
            // 
            // SecondPlayerPlayingLabel
            // 
            this.SecondPlayerPlayingLabel.AutoSize = true;
            this.SecondPlayerPlayingLabel.Location = new System.Drawing.Point(718, 20);
            this.SecondPlayerPlayingLabel.Name = "SecondPlayerPlayingLabel";
            this.SecondPlayerPlayingLabel.Size = new System.Drawing.Size(45, 13);
            this.SecondPlayerPlayingLabel.TabIndex = 11;
            this.SecondPlayerPlayingLabel.Text = "Player 2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 145);
            this.progressBar1.Maximum = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(86, 32);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(720, 145);
            this.progressBar2.Maximum = 25;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(90, 32);
            this.progressBar2.TabIndex = 13;
            // 
            // DrawCardsButton
            // 
            this.DrawCardsButton.Location = new System.Drawing.Point(25, 215);
            this.DrawCardsButton.Name = "DrawCardsButton";
            this.DrawCardsButton.Size = new System.Drawing.Size(139, 43);
            this.DrawCardsButton.TabIndex = 1;
            this.DrawCardsButton.Text = "Draw cards";
            this.DrawCardsButton.UseVisualStyleBackColor = true;
            this.DrawCardsButton.Click += new System.EventHandler(this.DrawCardsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Draw pile";
            // 
            // RoundCountLabel
            // 
            this.RoundCountLabel.Controls.Add(this.PlayerOnePictureBox);
            this.RoundCountLabel.Controls.Add(this.PlayerTwoPictureBox);
            this.RoundCountLabel.Controls.Add(this.FirstPlayerPlayingLabel);
            this.RoundCountLabel.Controls.Add(this.LoserIndicator);
            this.RoundCountLabel.Controls.Add(this.PlayerOneDeck);
            this.RoundCountLabel.Controls.Add(this.DrawCardsButton);
            this.RoundCountLabel.Controls.Add(this.HpOfPlayerTwoProgressBar);
            this.RoundCountLabel.Controls.Add(this.HpOfPlayerOneProgressBar);
            this.RoundCountLabel.Controls.Add(this.label4);
            this.RoundCountLabel.Controls.Add(this.SecondPlayerPlayingLabel);
            this.RoundCountLabel.Controls.Add(this.PlayerTwoDeck);
            this.RoundCountLabel.Controls.Add(this.panel2);
            this.RoundCountLabel.Controls.Add(this.progressBar1);
            this.RoundCountLabel.Controls.Add(this.progressBar2);
            this.RoundCountLabel.Enabled = false;
            this.RoundCountLabel.Location = new System.Drawing.Point(12, 366);
            this.RoundCountLabel.Name = "RoundCountLabel";
            this.RoundCountLabel.Size = new System.Drawing.Size(849, 278);
            this.RoundCountLabel.TabIndex = 16;
            this.RoundCountLabel.TabStop = false;
            this.RoundCountLabel.Text = "Round1";
            // 
            // LoserIndicator
            // 
            this.LoserIndicator.AutoSize = true;
            this.LoserIndicator.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoserIndicator.Location = new System.Drawing.Point(174, 239);
            this.LoserIndicator.Name = "LoserIndicator";
            this.LoserIndicator.Size = new System.Drawing.Size(233, 24);
            this.LoserIndicator.TabIndex = 19;
            this.LoserIndicator.Text = "Click button to draw cards";
            // 
            // HpOfPlayerTwoProgressBar
            // 
            this.HpOfPlayerTwoProgressBar.AutoSize = true;
            this.HpOfPlayerTwoProgressBar.Location = new System.Drawing.Point(781, 154);
            this.HpOfPlayerTwoProgressBar.Name = "HpOfPlayerTwoProgressBar";
            this.HpOfPlayerTwoProgressBar.Size = new System.Drawing.Size(0, 13);
            this.HpOfPlayerTwoProgressBar.TabIndex = 18;
            // 
            // HpOfPlayerOneProgressBar
            // 
            this.HpOfPlayerOneProgressBar.AutoSize = true;
            this.HpOfPlayerOneProgressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HpOfPlayerOneProgressBar.Location = new System.Drawing.Point(74, 154);
            this.HpOfPlayerOneProgressBar.Name = "HpOfPlayerOneProgressBar";
            this.HpOfPlayerOneProgressBar.Size = new System.Drawing.Size(0, 13);
            this.HpOfPlayerOneProgressBar.TabIndex = 17;
            // 
            // PlayerTwoDeck
            // 
            this.PlayerTwoDeck.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerTwoDeck.Image = global::Cards_Game.Properties.Resources._20568124;
            this.PlayerTwoDeck.Location = new System.Drawing.Point(545, 32);
            this.PlayerTwoDeck.Name = "PlayerTwoDeck";
            this.PlayerTwoDeck.Size = new System.Drawing.Size(149, 165);
            this.PlayerTwoDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTwoDeck.TabIndex = 9;
            this.PlayerTwoDeck.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 163);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(330, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 163);
            this.panel2.TabIndex = 17;
            // 
            // CardImages
            // 
            this.CardImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CardImages.ImageStream")));
            this.CardImages.TransparentColor = System.Drawing.Color.Transparent;
            this.CardImages.Images.SetKeyName(0, "2_of_clubs.png");
            this.CardImages.Images.SetKeyName(1, "2_of_diamonds.png");
            this.CardImages.Images.SetKeyName(2, "3_of_clubs.png");
            this.CardImages.Images.SetKeyName(3, "3_of_hearts.png");
            this.CardImages.Images.SetKeyName(4, "3_of_spades.png");
            this.CardImages.Images.SetKeyName(5, "4_of_diamonds.png");
            this.CardImages.Images.SetKeyName(6, "6_of_clubs.png");
            this.CardImages.Images.SetKeyName(7, "6_of_diamonds.png");
            this.CardImages.Images.SetKeyName(8, "6_of_hearts.png");
            this.CardImages.Images.SetKeyName(9, "6_of_spades.png");
            this.CardImages.Images.SetKeyName(10, "7_of_clubs.png");
            this.CardImages.Images.SetKeyName(11, "8_of_clubs.png");
            this.CardImages.Images.SetKeyName(12, "8_of_spades.png");
            this.CardImages.Images.SetKeyName(13, "9_of_diamonds.png");
            this.CardImages.Images.SetKeyName(14, "9_of_spades.png");
            this.CardImages.Images.SetKeyName(15, "10_of_diamonds.png");
            this.CardImages.Images.SetKeyName(16, "ace_of_diamonds.png");
            this.CardImages.Images.SetKeyName(17, "ace_of_hearts.png");
            this.CardImages.Images.SetKeyName(18, "ace_of_spades.png");
            this.CardImages.Images.SetKeyName(19, "jack_of_clubs.png");
            this.CardImages.Images.SetKeyName(20, "jack_of_diamonds.png");
            this.CardImages.Images.SetKeyName(21, "king_of_diamonds.png");
            this.CardImages.Images.SetKeyName(22, "king_of_hearts.png");
            this.CardImages.Images.SetKeyName(23, "queen_of_clubs.png");
            this.CardImages.Images.SetKeyName(24, "queen_of_diamonds.png");
            this.CardImages.Images.SetKeyName(25, "queen_of_spades.png");
            this.CardImages.Images.SetKeyName(26, "2_of_hearts.png");
            this.CardImages.Images.SetKeyName(27, "2_of_spades.png");
            this.CardImages.Images.SetKeyName(28, "3_of_diamonds.png");
            this.CardImages.Images.SetKeyName(29, "4_of_clubs.png");
            this.CardImages.Images.SetKeyName(30, "4_of_hearts.png");
            this.CardImages.Images.SetKeyName(31, "4_of_spades.png");
            this.CardImages.Images.SetKeyName(32, "5_of_clubs.png");
            this.CardImages.Images.SetKeyName(33, "5_of_diamonds.png");
            this.CardImages.Images.SetKeyName(34, "5_of_hearts.png");
            this.CardImages.Images.SetKeyName(35, "5_of_spades.png");
            this.CardImages.Images.SetKeyName(36, "7_of_diamonds.png");
            this.CardImages.Images.SetKeyName(37, "7_of_hearts.png");
            this.CardImages.Images.SetKeyName(38, "7_of_spades.png");
            this.CardImages.Images.SetKeyName(39, "8_of_diamonds.png");
            this.CardImages.Images.SetKeyName(40, "8_of_hearts.png");
            this.CardImages.Images.SetKeyName(41, "9_of_clubs.png");
            this.CardImages.Images.SetKeyName(42, "9_of_hearts.png");
            this.CardImages.Images.SetKeyName(43, "10_of_clubs.png");
            this.CardImages.Images.SetKeyName(44, "10_of_hearts.png");
            this.CardImages.Images.SetKeyName(45, "10_of_spades.png");
            this.CardImages.Images.SetKeyName(46, "ace_of_clubs.png");
            this.CardImages.Images.SetKeyName(47, "joker_of_joker.png");
            this.CardImages.Images.SetKeyName(48, "jack_of_hearts.png");
            this.CardImages.Images.SetKeyName(49, "jack_of_spades.png");
            this.CardImages.Images.SetKeyName(50, "joker_of_joker.png");
            this.CardImages.Images.SetKeyName(51, "king_of_clubs.png");
            this.CardImages.Images.SetKeyName(52, "king_of_spades.png");
            this.CardImages.Images.SetKeyName(53, "queen_of_hearts.png");
            // 
            // PlayerOneDeck
            // 
            this.PlayerOneDeck.Image = global::Cards_Game.Properties.Resources._20568124;
            this.PlayerOneDeck.Location = new System.Drawing.Point(128, 32);
            this.PlayerOneDeck.Name = "PlayerOneDeck";
            this.PlayerOneDeck.Size = new System.Drawing.Size(149, 165);
            this.PlayerOneDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerOneDeck.TabIndex = 8;
            this.PlayerOneDeck.TabStop = false;
            // 
            // BiggerImages
            // 
            this.BiggerImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BiggerImages.ImageStream")));
            this.BiggerImages.TransparentColor = System.Drawing.Color.Transparent;
            this.BiggerImages.Images.SetKeyName(0, "mahrez (2).png");
            this.BiggerImages.Images.SetKeyName(1, "halland (2).png");
            this.BiggerImages.Images.SetKeyName(2, "neymar (2).png");
            this.BiggerImages.Images.SetKeyName(3, "messi (1).png");
            this.BiggerImages.Images.SetKeyName(4, "cr7.png");
            // 
            // PlayerTwoPictureBox
            // 
            this.PlayerTwoPictureBox.Location = new System.Drawing.Point(721, 49);
            this.PlayerTwoPictureBox.Name = "PlayerTwoPictureBox";
            this.PlayerTwoPictureBox.Size = new System.Drawing.Size(86, 90);
            this.PlayerTwoPictureBox.TabIndex = 21;
            this.PlayerTwoPictureBox.TabStop = false;
            // 
            // PlayerOnePictureBox
            // 
            this.PlayerOnePictureBox.Location = new System.Drawing.Point(25, 49);
            this.PlayerOnePictureBox.Name = "PlayerOnePictureBox";
            this.PlayerOnePictureBox.Size = new System.Drawing.Size(86, 90);
            this.PlayerOnePictureBox.TabIndex = 22;
            this.PlayerOnePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 647);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoundCountLabel);
            this.Name = "Form1";
            this.Text = "Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHp)).EndInit();
            this.Players.ResumeLayout(false);
            this.Players.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.RoundCountLabel.ResumeLayout(false);
            this.RoundCountLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoDeck)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOnePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox UseJokers;
        private System.Windows.Forms.CheckBox UseMagic;
        private System.Windows.Forms.ListView RemainingPlayersListView;
        private System.Windows.Forms.RadioButton NewPlayersButton;
        private System.Windows.Forms.RadioButton SavedPlayersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UseFavoritePlayersButton;
        private System.Windows.Forms.Button CreatePlayersButton;
        private System.Windows.Forms.Label NumberOfPlayers_Label;
        private System.Windows.Forms.GroupBox Players;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.CheckBox SaveAsFavoritePlayers;
        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.Label Avatar;
        private System.Windows.Forms.TextBox textBoxOfPlayerName;
        private System.Windows.Forms.Label NameOfPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PlayerOneDeck;
        private System.Windows.Forms.PictureBox PlayerTwoDeck;
        private System.Windows.Forms.Label FirstPlayerPlayingLabel;
        private System.Windows.Forms.Label SecondPlayerPlayingLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button DrawCardsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader PlayerNameListView;
        private System.Windows.Forms.ColumnHeader HpListView;
        private System.Windows.Forms.ColumnHeader WinsListView;
        private System.Windows.Forms.ColumnHeader LosseListView;
        private System.Windows.Forms.ColumnHeader DrawListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownHp;
        private System.Windows.Forms.GroupBox RoundCountLabel;
        private System.Windows.Forms.ImageList imageListAvatar;
        private System.Windows.Forms.ComboBox NumberOfPlayersParametre;
        private System.Windows.Forms.ImageList CardImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HpOfPlayerOneProgressBar;
        private System.Windows.Forms.Label HpOfPlayerTwoProgressBar;
        private System.Windows.Forms.Label LoserIndicator;
        private System.Windows.Forms.ImageList BiggerImages;
        private System.Windows.Forms.PictureBox PlayerOnePictureBox;
        private System.Windows.Forms.PictureBox PlayerTwoPictureBox;
    }
}

