using DLL;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Hadj Aissa Adel 


namespace Cards_Game
{
    public partial class Form1 : Form
    {
        byte imageIndex = 0;
        byte NumberOfPlayers = 0;
        GameEngine game1 = new GameEngine(false);


        public Form1()
        {
            InitializeComponent();

        }
        private void UseJokers_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void NumberOfPlayersParametre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // takes the numbers of players set
            NumberOfPlayers = Convert.ToByte(NumberOfPlayersParametre.SelectedItem);
        }

        private void CreatePlayersButton_Click(object sender, EventArgs e)
        {
            if (NewPlayersButton.Checked)
            {


                //check if the game is already played if yes clear the old parameters
                if (game1.roundnumber > 1)
                {
                    game1.ActivePlayers.Clear();
                    game1.AllPlayers.Clear();
                    RemainingPlayersListView.Items.Clear();

                }

                //check if the joker case is checked
                if (UseJokers.Checked)
                {
                    game1 = new GameEngine(true);
                }
                else
                {
                    game1 = new GameEngine(false);
                }

                //check if there's at least two player to start the game
                if (NumberOfPlayers >= 2)
                {
                    // set the parameters and access to the players parameters
                    MessageBox.Show("setting updated");
                    Players.Enabled = true;
                    AddPlayerButton.Enabled = true;
                    groupBox1.Enabled = false;
                    textBoxOfPlayerName.Enabled = true;
                    SaveAsFavoritePlayers.Enabled = true;

                }
                else
                {
                    MessageBox.Show("You must select at least 2 players");
                }
            }
            else
            {
                MessageBox.Show("You must check new players button first ");
            }
        }

        private void UseFavoritePlayersButton_Click(object sender, EventArgs e)
        {
            //check if the joker case is checked
            if (UseJokers.Checked)
            {
                game1 = new GameEngine(true);
            }
            else
            {
                game1 = new GameEngine(false);
            }

            if (SavedPlayersButton.Checked)
            {
                if (File.Exists("FavoritePlayers.bin"))
                {
                    if (game1.roundnumber > 1)
                    {
                        game1.ActivePlayers.Clear();
                        game1.AllPlayers.Clear();
                        RemainingPlayersListView.Items.Clear();
                    }

                    game1.Deserialize();
                    foreach (Player player in game1.ActivePlayers)
                    {
                        player.HP = (byte)numericUpDownHp.Value;
                    }
                    refreshListViewPlayerList();
                    MessageBox.Show("setting updated");
                    Players.Enabled = true;
                    groupBox1.Enabled = false;
                    RoundCountLabel.Enabled = true;
                    AddPlayerButton.Enabled = false;
                    SaveAsFavoritePlayers.Enabled = false;
                    textBoxOfPlayerName.Enabled = false;

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                }
                else
                {
                    MessageBox.Show("You must save players first");
                }
            }
            else
            {
                MessageBox.Show("You must check saved players button First ");
            }

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            //variable to check if the name is already used
            bool PlayerNameExist = false;

            //create a newPlayer and set his HP
            Player newPlayer = new Player(textBoxOfPlayerName.Text, imageIndex);
            newPlayer.HP = (byte)numericUpDownHp.Value;

            //set prograss bar according to the hp
            progressBar1.Value = newPlayer.HP;
            progressBar2.Value = newPlayer.HP;
            // Display the HP value on the ProgressBar
            HpOfPlayerOneProgressBar.Text = Convert.ToString(newPlayer.HP);
            HpOfPlayerTwoProgressBar.Text = Convert.ToString(newPlayer.HP);

            //Search if there's a player with same name 
            foreach (Player Player in game1.AllPlayers)
            {
                if (Player.name.ToLower() == textBoxOfPlayerName.Text.ToLower())
                {
                    PlayerNameExist = true;
                }
            }

            //verify if there's a player with same name or with more then 25 characters or with empty name then set his name and characteristics
            if (textBoxOfPlayerName.Text == "")
            {
                MessageBox.Show("Player Name should not be empty.");
            }
            else if (textBoxOfPlayerName.Text.Length > 25)
            {
                MessageBox.Show("Player name must be less then 25 characters");
            }
            else if (PlayerNameExist)
            {

                MessageBox.Show("this name already exist");
            }
            else
            {
                //add players to the queue
                game1.ActivePlayers.Enqueue(newPlayer);
                //add player to the list
                game1.AllPlayers.Add(newPlayer);

                refreshListView();
            }

            //if the max player of players is reached 
            if (game1.AllPlayers.Count == NumberOfPlayers)
            {
                if (SaveAsFavoritePlayers.Checked)
                {
                    game1.Serialize();
                }
                //since we created all the players, the game can start
                MessageBox.Show("the game will start");

                // set images for the players
                PlayerOnePictureBox.Image = BiggerImages.Images[game1.ActivePlayers.ElementAt(0).avatar];
                PlayerTwoPictureBox.Image = BiggerImages.Images[game1.ActivePlayers.ElementAt(1).avatar];

                RoundCountLabel.Enabled = true;
                AddPlayerButton.Enabled = false;
                SaveAsFavoritePlayers.Enabled = false;
                textBoxOfPlayerName.Enabled = false;

            }

        }
        private void refreshListViewPlayerList()
        {
            // this fonctions is to update the players stats when the game is over
            RemainingPlayersListView.Items.Clear();

            foreach (Player player in game1.AllPlayers)
            {
                ListViewItem newLine = new ListViewItem();

                newLine.Text = player.name;
                newLine.ImageIndex = player.avatar;
                newLine.SubItems.Add(player.HP.ToString());
                newLine.SubItems.Add(player.wins.ToString());
                newLine.SubItems.Add(player.losses.ToString());
                newLine.SubItems.Add(player.draws.ToString());

                RemainingPlayersListView.Items.Add(newLine);
            }

        }
        // this methode is to refresh to listview
        private void refreshListView()
        {
            RemainingPlayersListView.Items.Clear();

            foreach (Player player in game1.ActivePlayers)
            {
                ListViewItem newLine = new ListViewItem();

                newLine.Text = player.name;
                newLine.ImageIndex = player.avatar;
                newLine.SubItems.Add(player.HP.ToString());
                newLine.SubItems.Add(player.wins.ToString());
                newLine.SubItems.Add(player.losses.ToString());
                newLine.SubItems.Add(player.draws.ToString());

                RemainingPlayersListView.Items.Add(newLine);
            }
            //refresh players playing names
            FirstPlayerPlayingLabel.Text = game1.ActivePlayers.ElementAt(0).name;

            if (game1.ActivePlayers.Count > 1)
            {
                SecondPlayerPlayingLabel.Text = game1.ActivePlayers.ElementAt(1).name;
            }


        }
        private void avatarPicture_Click(object sender, EventArgs e)
        {
            // this one is to change images of players
            if (imageIndex < 4)
            {
                imageIndex++;

            }
            else
            {
                imageIndex = 0;
            }
            avatarPicture.Image = BiggerImages.Images[imageIndex];
        }

        private void DrawCardsButton_Click(object sender, EventArgs e)
        {
            //this variable is for the magic conditions
            byte Random = (byte)RandomNumberGenerator.RNG.Next(1, 26);

            // this variable is for the queue management
            Player firstElement = new Player();

            if (game1.draw_pile.Count == 0)
            {
                //shuffle the cards if the draw pile is empty 
                game1.Shuffle();

            }


            // Draw two cards from the draw_pile and add to each player's stack
            Card card1 = game1.draw_pile.Pop();
            Card card2 = game1.draw_pile.Pop();
            game1.CardPlayer1.Push(card1);
            game1.CardPlayer2.Push(card2);

            if (UseMagic.Checked == true)
            {
                if (Random == 1)
                {
                    //send a message then exchange hp players and restore progress bar info
                    MessageBox.Show("Magical strom. the two players will exchange their hp");
                    byte temp;
                    temp = game1.ActivePlayers.ElementAt(0).HP;
                    game1.ActivePlayers.ElementAt(0).HP = game1.ActivePlayers.ElementAt(1).HP;
                    game1.ActivePlayers.ElementAt(1).HP = temp;


                    RefreshHpSettings0();
                    RefreshHpSettings1();



                }
                else if (Random == 2)

                {
                    //setting progress bar style to marque then restoring hp and updating progress bar info
                    //at the end display message and reset progress bar style

                    progressBar1.Style = ProgressBarStyle.Marquee;
                    progressBar2.Style = ProgressBarStyle.Marquee;
                    game1.ActivePlayers.ElementAt(0).HP = (byte)numericUpDownHp.Value;
                    game1.ActivePlayers.ElementAt(1).HP = (byte)numericUpDownHp.Value;

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                    MessageBox.Show("Magical strom. the two players HP will be restored");
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar2.Style = ProgressBarStyle.Blocks;
                }
                else if (Random == 3)
                {
                    //restore half of the messing hp then set progress bar info
                    MessageBox.Show("Magical strom. Half the missing HP of both players will be restored.");
                    game1.ActivePlayers.ElementAt(0).HP = (byte)Math.Round(game1.ActivePlayers.ElementAt(0).HP + (numericUpDownHp.Value - game1.ActivePlayers.ElementAt(0).HP) / 2, MidpointRounding.ToEven);
                    game1.ActivePlayers.ElementAt(1).HP = (byte)Math.Round(game1.ActivePlayers.ElementAt(1).HP + (numericUpDownHp.Value - game1.ActivePlayers.ElementAt(1).HP) / 2, MidpointRounding.ToEven);

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                }
                else if (Random == 4)
                {
                    //remove both players half hp then restore progress bar info
                    MessageBox.Show("Magical strom. Both players lose half their remaining HP.");
                    game1.ActivePlayers.ElementAt(0).HP = (byte)Math.Round((double)game1.ActivePlayers.ElementAt(0).HP / 2, MidpointRounding.AwayFromZero);
                    game1.ActivePlayers.ElementAt(1).HP = (byte)Math.Round((double)game1.ActivePlayers.ElementAt(1).HP / 2, MidpointRounding.AwayFromZero);

                    RefreshHpSettings0();
                    RefreshHpSettings1();

                    RefreshHpSettings0();
                    RefreshHpSettings1();
                }
                else if (Random == 5)
                {

                    MessageBox.Show("Magical storm. The damage is tripled during this turn!");

                    //check which card is bigger then remove hp from the loser player 
                    if (card1.CardValue > card2.CardValue)
                    {
                        // if the player2 has less then 3hp make hp 0
                        if (game1.ActivePlayers.ElementAt(1).HP >= 3)
                        {
                            game1.ActivePlayers.ElementAt(1).HP -= 3;
                            RefreshHpSettings1();
                            LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(1).name} lost the turn";
                        }
                        else
                        {
                            game1.ActivePlayers.ElementAt(1).HP = 0;
                            RefreshHpSettings1();
                            LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(1).name} lost the turn";
                        }

                    }
                    else if (card1.CardValue < card2.CardValue)
                    {
                        // if the player1 has less then 3hp make hp 0
                        if (game1.ActivePlayers.ElementAt(0).HP >= 3)
                        {
                            game1.ActivePlayers.ElementAt(0).HP -= 3;
                            RefreshHpSettings0();
                            LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(0).name} lost the turn";
                        }
                        else
                        {
                            game1.ActivePlayers.ElementAt(0).HP = 0;
                            RefreshHpSettings0();
                            LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(1).name} lost the turn";
                        }

                    }
                    else
                    {
                        //checks player hp then remove 3hp or set to 0
                        if (game1.ActivePlayers.ElementAt(0).HP >= 3)
                        {
                            game1.ActivePlayers.ElementAt(0).HP -= 3;
                            RefreshHpSettings0();

                        }
                        else
                        {
                            game1.ActivePlayers.ElementAt(0).HP = 0;
                            RefreshHpSettings0();

                        }

                        if (game1.ActivePlayers.ElementAt(1).HP >= 3)
                        {
                            game1.ActivePlayers.ElementAt(1).HP -= 3;
                            RefreshHpSettings1();

                        }
                        else
                        {
                            game1.ActivePlayers.ElementAt(1).HP = 0;
                            RefreshHpSettings1();

                        }
                        LoserIndicator.Text = "Both of the players lost the turn";
                    }

                }
                else if (Random == 6)
                {
                    //check if there's more then 2 players
                    if (game1.ActivePlayers.Count > 2)
                    {
                        //send the player to the end of the queue and add one round 
                        MessageBox.Show("both players will be sent to the end of the queue");
                        firstElement = game1.ActivePlayers.Dequeue();
                        game1.ActivePlayers.Enqueue(firstElement);
                        firstElement = game1.ActivePlayers.Dequeue();
                        game1.ActivePlayers.Enqueue(firstElement);
                        game1.roundnumber++;
                        refreshListView();
                    }

                }


            }

            // check the magic storm isn't on the fifth magic
            if (Random != 5)
            {

                //compare cards then remove 1 hp from the loser player or both of them
                if (card1.CardValue > card2.CardValue)
                {
                    // remove hp to the second player and update their health bar 
                    game1.ActivePlayers.ElementAt(1).HP -= 1;
                    RefreshHpSettings1();
                    LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(1).name} lost the turn";
                }
                else if (card1.CardValue < card2.CardValue)
                {
                    // remove hp to the first player and update their health bar 
                    game1.ActivePlayers.ElementAt(0).HP -= 1;
                    RefreshHpSettings0();
                    LoserIndicator.Text = $"{game1.ActivePlayers.ElementAt(0).name} lost the turn";
                }
                else
                {
                    // remove hp to both players and update their healths bar
                    game1.ActivePlayers.ElementAt(1).HP -= 1;
                    RefreshHpSettings1();

                    game1.ActivePlayers.ElementAt(0).HP -= 1;
                    RefreshHpSettings0();
                    LoserIndicator.Text = "Both of the players lost the turn";
                }

            }

            // Get the file path for each card image
            string imagePath1 = string.Format("{0}_of_{1}.png", card1.DisplayValue().ToLower(), card1.suit);
            string imagePath2 = string.Format("{0}_of_{1}.png", card2.DisplayValue().ToLower(), card2.suit);

            // Set the images for the PlayerOneDeck and PlayerTwoDeck picture boxes
            PlayerOneDeck.Image = CardImages.Images[imagePath1];
            PlayerTwoDeck.Image = CardImages.Images[imagePath2];

            // set images for the players
            PlayerOnePictureBox.Image = BiggerImages.Images[game1.ActivePlayers.ElementAt(0).avatar];
            PlayerTwoPictureBox.Image = BiggerImages.Images[game1.ActivePlayers.ElementAt(1).avatar];

            //magical spells  
            if (UseMagic.Checked == true)
            {
                //Wizard's luck
                if (game1.ActivePlayers.ElementAt(0).HP == 0 && game1.ActivePlayers.ElementAt(1).HP == 0)
                {
                    MessageBox.Show("both of the players have died so they will revive with 3hp and be sent to the end of the queue");
                    game1.ActivePlayers.ElementAt(1).HP = 3;
                    RefreshHpSettings1();

                    game1.ActivePlayers.ElementAt(0).HP = 3;
                    RefreshHpSettings0();

                    firstElement = game1.ActivePlayers.Dequeue();
                    game1.ActivePlayers.Enqueue(firstElement);
                    firstElement = game1.ActivePlayers.Dequeue();
                    game1.ActivePlayers.Enqueue(firstElement);
                }


                //stamina
                if (game1.ActivePlayers.ElementAt(0).HP == 0)
                {
                    MessageBox.Show($"{game1.ActivePlayers.ElementAt(1).name} has been added to him 5hp because he won the round");
                    game1.ActivePlayers.ElementAt(1).HP += 5;

                    if (game1.ActivePlayers.ElementAt(1).HP >= numericUpDownHp.Value)
                    {
                        game1.ActivePlayers.ElementAt(1).HP = (byte)numericUpDownHp.Value;
                    }

                }
                else if (game1.ActivePlayers.ElementAt(1).HP == 0)
                {
                    MessageBox.Show($"{game1.ActivePlayers.ElementAt(0).name} has been added to him 5hp because he won the round");
                    game1.ActivePlayers.ElementAt(0).HP += 5;

                    if (game1.ActivePlayers.ElementAt(0).HP >= numericUpDownHp.Value)
                    {
                        game1.ActivePlayers.ElementAt(0).HP = (byte)numericUpDownHp.Value;
                    }

                }

            }
            //show the thickness of the drawing card  
            panel2.Height = panel1.Height + game1.draw_pile.Count - 1;

            //players elimination conditions 
            if (game1.ActivePlayers.ElementAt(0).HP == 0) // player1 die
            {
                // add one to player 1 losses
                game1.ActivePlayers.ElementAt(0).losses += 1;

                // add one to player 2 wins
                game1.ActivePlayers.ElementAt(1).wins += 1;

                // message that says Second player won
                MessageBox.Show($"Round is over {game1.ActivePlayers.ElementAt(1).name} won the game");

                // throw second player to the last queue
                game1.ActivePlayers.Dequeue();
                firstElement = game1.ActivePlayers.Dequeue();
                game1.ActivePlayers.Enqueue(firstElement);

                //refresh hp of the new players
                if (game1.ActivePlayers.Count > 1)
                {
                    RefreshHpSettings0();
                    RefreshHpSettings1();
                }
                //add one to round count and refresh listview
                game1.roundnumber++;
                refreshListView();

            }
            else if (game1.ActivePlayers.ElementAt(1).HP == 0) //player 2 die 
            {
                // add one to player2 losses
                game1.ActivePlayers.ElementAt(1).losses += 1;
                // add one to player2 wins
                game1.ActivePlayers.ElementAt(0).wins += 1;


                //message that says First player won
                MessageBox.Show($"Round is over {game1.ActivePlayers.ElementAt(0).name} won the game");

                // throw first player to the last queue
                firstElement = game1.ActivePlayers.Dequeue();
                game1.ActivePlayers.Dequeue();
                game1.ActivePlayers.Enqueue(firstElement);

                //refresh hp of the new players
                if (game1.ActivePlayers.Count > 1)
                {
                    RefreshHpSettings0();
                    RefreshHpSettings1();
                }
                //add one to round count and refresh listview
                game1.roundnumber++;
                refreshListView();
            }
            else if (game1.ActivePlayers.ElementAt(0).HP == 0 && game1.ActivePlayers.ElementAt(1).HP == 0) //both of them die
            {
                //add 1 to both players draw then remove them from the queue
                game1.ActivePlayers.ElementAt(0).draws += 1;
                game1.ActivePlayers.ElementAt(1).draws += 1;
                game1.ActivePlayers.Dequeue();
                game1.ActivePlayers.Dequeue();

                if (game1.ActivePlayers.Count > 1)
                {
                    //refresh hp of the new players
                    RefreshHpSettings0();
                    RefreshHpSettings1();
                }

                //message that says both player lost
                MessageBox.Show($"Round is over both player lost the game");

                //add one to round count and refresh listview
                game1.roundnumber++;
                refreshListView();
            }

            //check if the game is over and set their ranks and disable playable groupe box 
            if (game1.ActivePlayers.Count == 0 || game1.ActivePlayers.Count == 1)
            {
                MessageBox.Show("Game is Over");
                game1.rank();
                RoundCountLabel.Enabled = false;
                groupBox1.Enabled = true;
                refreshListViewPlayerList();

            }
            // set the round number on the playable groupe box
            RoundCountLabel.Text = $"Round{game1.roundnumber}";

        }

        private void RefreshHpSettings0()
        {
            //update the progress bar of first player
            progressBar1.Value = game1.ActivePlayers.ElementAt(0).HP;

            // update the Hp value of first player
            HpOfPlayerOneProgressBar.Text = Convert.ToString(game1.ActivePlayers.ElementAt(0).HP);
        }
        private void RefreshHpSettings1()
        {
            //update the progress bar of first player
            progressBar2.Value = game1.ActivePlayers.ElementAt(1).HP;

            // update the Hp value of first player
            HpOfPlayerTwoProgressBar.Text = Convert.ToString(game1.ActivePlayers.ElementAt(1).HP);
        }

    }
}
