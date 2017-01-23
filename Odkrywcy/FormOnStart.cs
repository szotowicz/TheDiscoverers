using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odkrywcy
{
    public partial class FormOnStart : Form
    {
        Thread thread;
        int startLoad = 0;
        int endLoad = 0;
        int startThrow = 0;
        int currentThrow = 0;
        int endThrow = 0;
        int numberOfPlayers = 0;
        int currentPlayer = 0;
        int previousRandom = 0;
        string map = "";
        char[] tabId;
        //char[] tabId = {'g','r','b'};
        char[] idPlayers = {'r', 'b', 'g', 'y'};
        int[] tabScore = { 0, 0, 0, 0 };

        TextBox[] textBoxes = new TextBox[4];
        Random random = new Random();

        public FormOnStart()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            //timer_waitForStart.Enabled = true;
            //timer_waitForStart.Start();

            showLoadGamePanel();
            
        }
        
        private void showLoadGamePanel()
        {
            LoadGamePanel.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            LoadGamePanel.Location = new Point(0, 0);

            NameOfGamePicBox.Size = new Size(Constants.WIDTH_NAME_OF_GAME, Constants.HEIGHT_NAME_OF_GAME);
            NameOfGamePicBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - NameOfGamePicBox.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - NameOfGamePicBox.Size.Height);

            LoadGameLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 400, Screen.PrimaryScreen.Bounds.Height - 150);

            LoadGamePanel.Enabled = true;
            LoadGamePanel.Visible = true;

            
            endLoad = random.Next(Constants.MIN_TIME_LOAD, Constants.MAX_TIME_LOAD);

            timer_loadGame.Enabled = true;
            timer_loadGame.Interval = Constants.TIME_LOAD;
            timer_loadGame.Start();
        }

        private void timer_loadGame_Tick(object sender, EventArgs e)
        {
            if (startLoad % 3 == 0)
                LoadGameLabel.Text = "Ładowanie.  ";
            else if (startLoad % 3 == 1)
                LoadGameLabel.Text = "Ładowanie.. ";
            else if (startLoad % 3 == 2)
                LoadGameLabel.Text = "Ładowanie...";
            startLoad++;
            if (startLoad == endLoad)
            {
                timer_loadGame.Stop();
                showInitGamePanel();
                LoadGamePanel.Enabled = false;
                LoadGamePanel.Visible = false;
            }
        }

        private void showInitGamePanel()
        {
            InitGamePanel.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            InitGamePanel.Location = new Point(0, 0);

            ExitButton.Size = new Size(Constants.EXIT_SIZE, Constants.EXIT_SIZE);
            ExitButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width - Constants.EXIT_SIZE - Constants.EXIT_MARGIN, Constants.EXIT_MARGIN);

            SmallNameOfGamePicBox.Size = new Size(Constants.SMALL_WIDTH_NAME_OF_GAME, Constants.SMALL_HEIGHT_NAME_OF_GAME);
            SmallNameOfGamePicBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - SmallNameOfGamePicBox.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 4 - SmallNameOfGamePicBox.Size.Height);

            NumberOfPlayersLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - NumberOfPlayersLabel.Size.Width / 2, SmallNameOfGamePicBox.Location.Y + Constants.MARGIN_NR_PLAYERS_LABEL);

            TwoPlayersButton.Size = new Size(Constants.NUMBER_OF_PLAYERS_SIZE, Constants.NUMBER_OF_PLAYERS_SIZE);
            TwoPlayersButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (Constants.NUMBER_OF_PLAYERS_SIZE + Constants.MARGIN_BETWEEN_NUMBER_OF_PLAYERS + Constants.NUMBER_OF_PLAYERS_SIZE / 2), NumberOfPlayersLabel.Location.Y + Constants.MARGIN_NR_PLAYERS);
            ThreePlayersButton.Size = new Size(Constants.NUMBER_OF_PLAYERS_SIZE, Constants.NUMBER_OF_PLAYERS_SIZE);
            ThreePlayersButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Constants.NUMBER_OF_PLAYERS_SIZE / 2, NumberOfPlayersLabel.Location.Y + Constants.MARGIN_NR_PLAYERS);
            FourPlayersButton.Size = new Size(Constants.NUMBER_OF_PLAYERS_SIZE, Constants.NUMBER_OF_PLAYERS_SIZE);
            FourPlayersButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + (Constants.MARGIN_BETWEEN_NUMBER_OF_PLAYERS + Constants.NUMBER_OF_PLAYERS_SIZE / 2), NumberOfPlayersLabel.Location.Y + Constants.MARGIN_NR_PLAYERS);

            RedPlayerLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (RedPlayerLabel.Size.Width + RedPlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS);
            RedPlayerTextBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (RedPlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS);
            BluePlayerLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + Constants.MARGIN_BETWEEN_PLAYERS, TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS);
            BluePlayerTextBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + (BluePlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS);
            GreenPlayerLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (RedPlayerLabel.Size.Width + RedPlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS + Constants.MARGIN_PLAYERS / 2);
            GreenPlayerTextBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (RedPlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS + Constants.MARGIN_PLAYERS / 2);
            YellowPlayerLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + Constants.MARGIN_BETWEEN_PLAYERS, TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS + Constants.MARGIN_PLAYERS / 2);
            YellowPlayerTextBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + (BluePlayerTextBox.Size.Width + Constants.MARGIN_BETWEEN_PLAYERS), TwoPlayersButton.Location.Y + Constants.MARGIN_PLAYERS + Constants.MARGIN_PLAYERS / 2);

            MapLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - MapLabel.Size.Width / 2, GreenPlayerLabel.Location.Y + Constants.MARGIN_MAP_LABEL);

            PolandMapButton.Size = new Size(Constants.MAP_SIZE_W, Constants.MAP_SIZE_H);
            PolandMapButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (Constants.MAP_SIZE_W + Constants.MARGIN_BETWEEN_MAP + Constants.MAP_SIZE_W / 2), MapLabel.Location.Y + Constants.MARGIN_MAP);
            EuropeMapButton.Size = new Size(Constants.MAP_SIZE_W, Constants.MAP_SIZE_H);
            EuropeMapButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Constants.MAP_SIZE_W / 2, MapLabel.Location.Y + Constants.MARGIN_MAP);
            WorldMapButton.Size = new Size(Constants.MAP_SIZE_W, Constants.MAP_SIZE_H);
            WorldMapButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + Constants.MARGIN_BETWEEN_MAP + Constants.MAP_SIZE_W / 2, MapLabel.Location.Y + Constants.MARGIN_MAP);

            PolandLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (Constants.MAP_SIZE_W + Constants.MARGIN_BETWEEN_MAP + Constants.MAP_SIZE_W / 2) + 20, PolandMapButton.Location.Y + Constants.MARGIN_MAP_NAMES);
            EuropeLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Constants.MAP_SIZE_W / 2 + 23, PolandMapButton.Location.Y + Constants.MARGIN_MAP_NAMES);
            WorldLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + Constants.MARGIN_BETWEEN_MAP + Constants.MAP_SIZE_W / 2 + 27, PolandMapButton.Location.Y + Constants.MARGIN_MAP_NAMES);

            PlayButton.Size = new Size(Constants.PLAY_BUTTON_SIZE, Constants.PLAY_BUTTON_SIZE);
            PlayButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width - (PlayButton.Size.Width + Constants.MARGIN_PLAY_BUTTON_RIGHT), Screen.PrimaryScreen.Bounds.Height - (PlayButton.Size.Height + Constants.MARGIN_PLAY_BUTTON_DOWN));

            textBoxes[0] = RedPlayerTextBox;
            textBoxes[1] = BluePlayerTextBox;
            textBoxes[2] = GreenPlayerTextBox;
            textBoxes[3] = YellowPlayerTextBox;

            InitGamePanel.Enabled = true;
            InitGamePanel.Visible = true;
        }
        
        private void TwoPlayersButton_Click(object sender, EventArgs e)
        {
            TwoPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.two_players_selected;
            ThreePlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.three_players_unselected;
            FourPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.four_players_unselected;

            showPlayers(2);
        }

        private void ThreePlayersButton_Click(object sender, EventArgs e)
        {
            TwoPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.two_players_unselected;
            ThreePlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.three_players_selected;
            FourPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.four_players_unselected;

            showPlayers(3);
        }

        private void FourPlayersButton_Click(object sender, EventArgs e)
        {
            TwoPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.two_players_unselected;
            ThreePlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.three_players_unselected;
            FourPlayersButton.BackgroundImage = global::Odkrywcy.Properties.Resources.four_players_selected;

            showPlayers(4);
        }

        private void showPlayers(int number)
        {
            Label[] labels = { RedPlayerLabel, BluePlayerLabel, GreenPlayerLabel, YellowPlayerLabel };

            for(int i = 0; i < 4; i++)
            {
                if (i < number)
                {
                    labels[i].Enabled = true;
                    labels[i].Visible = true;
                    textBoxes[i].Enabled = true;
                    textBoxes[i].Visible = true;
                }
                else if(labels[i].Visible == true)
                {
                    labels[i].Enabled = false;
                    labels[i].Visible = false;
                    textBoxes[i].Enabled = false;
                    textBoxes[i].Visible = false;
                }
            }
            numberOfPlayers = number;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PolandMapButton_Click(object sender, EventArgs e)
        {
            PolandMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.poland_selected;
            EuropeMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.europe_unselected;
            WorldMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.world_unselected;
            PolandLabel.ForeColor = System.Drawing.Color.SteelBlue;
            EuropeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            WorldLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            map = "poland";
        }

        private void EuropeMapButton_Click(object sender, EventArgs e)
        {
            PolandMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.poland_unselected;
            EuropeMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.europe_selected;
            WorldMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.world_unselected;
            PolandLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            EuropeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            WorldLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            map = "europe";
        }

        private void WorldMapButton_Click(object sender, EventArgs e)
        {
            PolandMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.poland_unselected;
            EuropeMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.europe_unselected;
            WorldMapButton.BackgroundImage = global::Odkrywcy.Properties.Resources.world_selected;
            PolandLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            EuropeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            WorldLabel.ForeColor = System.Drawing.Color.SteelBlue;
            map = "world";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //check
            bool canRun = true;
            for(int i = 0 ; i < numberOfPlayers ; i++)
            {
                if(textBoxes[i].Text == "")
                    canRun = false;
            }
            

            if (canRun && numberOfPlayers > 0 && map != "")
            {
                showAssignOrderPanel();

                InitGamePanel.Enabled = false;
                InitGamePanel.Visible = false;
            }
            else
                MessageBox.Show("Aby zagrać musisz wybrać ilość graczy, podać nazwy dla każdego gracza oraz wybrać mapę, na której rozgrywać się będzie się gra. Pamiętaj, że wybór mapy wpływa na rodzaj pytań.", "Uzupełnij wymagane pola");
        }


        private void showAssignOrderPanel()
        {
            AssignOrderPanel.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            AssignOrderPanel.Location = new Point(0, 0);

            ExitBtn.Size = new Size(Constants.EXIT_SIZE, Constants.EXIT_SIZE);
            ExitBtn.Location = new Point(Screen.PrimaryScreen.Bounds.Width - Constants.EXIT_SIZE - Constants.EXIT_MARGIN, Constants.EXIT_MARGIN);

            SmallNameOfGamePictureBox.Size = new Size(Constants.SMALL_WIDTH_NAME_OF_GAME, Constants.SMALL_HEIGHT_NAME_OF_GAME);
            SmallNameOfGamePictureBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - SmallNameOfGamePictureBox.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 4 - SmallNameOfGamePictureBox.Size.Height);

            DiceBackgroundPictureBox.Size = new Size(Constants.DICE_BACKGROUND_SIZE_IN_ASSIGN, Constants.DICE_BACKGROUND_SIZE_IN_ASSIGN);
            DiceBackgroundPictureBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - DiceBackgroundPictureBox.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - DiceBackgroundPictureBox.Size.Height / 2);

            DicePictureBox.Size = new Size(Constants.DICE_SIZE_IN_ASSIGN, Constants.DICE_SIZE_IN_ASSIGN);
            DicePictureBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - DicePictureBox.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - DicePictureBox.Size.Height / 2);

            ThrowDiceButton.Size = new Size(Constants.THROW_DICE_W_IN_ASSIGN, Constants.THROW_DICE_H_IN_ASSIGN);
            ThrowDiceButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - ThrowDiceButton.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 + DicePictureBox.Size.Height / 2 + 100);

            InfoDicePictureBox.Size = new Size(Constants.INFO_DICE_W_IN_ASSIGN, Constants.INFO_DICE_H_IN_ASSIGN);
            InfoDicePictureBox.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (DiceBackgroundPictureBox.Size.Width / 2 + Constants.INFO_DICE_W_IN_ASSIGN + 50), Screen.PrimaryScreen.Bounds.Height / 2 - InfoDicePictureBox.Size.Height / 2 + 50);

            OrderLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + 250, Screen.PrimaryScreen.Bounds.Height / 2);
            showOrderList();

            tabId = new char[numberOfPlayers];
            startThrow = currentThrow = changeDice();

            AssignOrderPanel.Enabled = true;
            AssignOrderPanel.Visible = true;
        }

        private void ThrowDiceButton_Click(object sender, EventArgs e)
        {
            ThrowDiceButton.Enabled = false;
            startThrow = 0;
            previousRandom = 0;
            endThrow = random.Next(20, 26);

            timer_changeDice.Enabled = true;
            timer_changeDice.Interval = 100;
            timer_changeDice.Start();
        }

        private void timer_changeDice_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playerMusicDice = new System.Media.SoundPlayer();
            playerMusicDice.SoundLocation = "dice.wav";
            playerMusicDice.Play();

            currentThrow = changeDice();
            if (startThrow > (endThrow - endThrow / 4))
                timer_changeDice.Interval += 80;

            if(startThrow == endThrow)
            {
                timer_changeDice.Stop();
                ThrowDiceButton.Enabled = true;
                tabScore[currentPlayer] = currentThrow;
                tabId[currentPlayer] = idPlayers[currentPlayer];
                setOrder();
                showOrderList();
                currentPlayer++;
                if (currentPlayer == numberOfPlayers)
                {
                    ThrowDiceButton.Enabled = false;
                    timer_waitForStart.Enabled = true;
                    timer_waitForStart.Start();
                }
                else
                {
                    switch (idPlayers[currentPlayer])
                    {
                        case 'b':
                            DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_blue;
                            break;
                        case 'g':
                            DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_green;
                            break;
                        case 'y':
                            DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_yellow;
                            break;
                    }
                }
            }
            startThrow++;
        }

        private int changeDice()
        {
            int nr = random.Next(1, 7);
            while (nr == previousRandom)
            {
                nr = random.Next(1, 7);
            }
            previousRandom = nr;
            switch (nr)
            {
                case 1:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_one;
                    break;
                case 2:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_two;
                    break;
                case 3:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_three;
                    break;
                case 4:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_four;
                    break;
                case 5:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_five;
                    break;
                case 6:
                    DicePictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_six;
                    break;
            }
            return nr;
        }

        private void setOrder()
        {
            for(int i = 0; i < currentPlayer; i++)
            {
                if(tabScore[currentPlayer] > tabScore[i])
                {
                    int memInt = tabScore[currentPlayer];
                    char memChar = tabId[currentPlayer];
                    TextBox memTB = textBoxes[currentPlayer];
                    for (int j = currentPlayer; j > i; j--)
                    {
                        tabScore[j] = tabScore[j - 1];
                        tabId[j] = tabId[j - 1];
                        textBoxes[j] = textBoxes[j - 1];
                    }
                    tabScore[i] = memInt;
                    tabId[i] = memChar;
                    textBoxes[i] = memTB;
                }
            }
        }

        private void showOrderList()
        {
            OrderLabel.Text = "";
            for(int i = 0; i < numberOfPlayers; i++)
            {
                OrderLabel.Text += i+1 + ". " + textBoxes[i].Text + ": \t " + tabScore[i].ToString() + "\n";
            }
        }

        private void timer_waitForStart_Tick(object sender, EventArgs e)
        {

            timer_waitForStart.Stop();
            //this.Close();
            thread = new Thread(openNewFormWithGame);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        private void openNewFormWithGame(object obj)
        {
            Application.Run(new FormWithGame(new Game(numberOfPlayers, RedPlayerTextBox.Text, BluePlayerTextBox.Text, GreenPlayerTextBox.Text,
                        YellowPlayerTextBox.Text, tabId, map)));
            //Application.Run(new FormWithGame(new Game(3, "czerwony", "niebieski", "zielony",
            //            "", tabId, "poland")));
        }


    }
}
