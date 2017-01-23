using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odkrywcy
{
    public partial class FormWithGame : Form
    {
        private Game game;
        int startThrow = 0;
        int currentThrow = 0;
        int endThrow = 0;
        int startPlace = 0;
        int endPlace = 0;
        int previousRandom = 0;
        int currentPlayer = 0;
        Player[] playersTab = new Player[4];
        int[] locationsAreas;
        int[] questionsAreas = new int[3];
        string[] questionsTab;
        string[] questionsAttackTab;
        int randomQuestion = 0;
        int openGameWindows = 2;
        bool resultAnswerPlayer = false;
        Player red;
        Player blue;
        Player green;
        Player yellow;
        Player Attacker;
        Player Attacked;

        Random random = new Random();

        public FormWithGame()
        {
            InitializeComponent();
        }

        public FormWithGame(Game game)
        {
            InitializeComponent();
            this.game = game;
            red = new Player(game.red, 0, 0, Color.Red, DotRedPictureBox);
            blue = new Player(game.blue, 0, 0, Color.Blue, DotBluePictureBox);
            green = new Player(game.green, 0, 0, Color.Green, DotGreenPictureBox);
            yellow = new Player(game.yellow, 0, 0, Color.Yellow, DotYellowPictureBox);

            for (int i = 0; i < game.numberOfPlayers; i++ )
            {
                if (game.order[i] == 'r')
                    playersTab[i] = red;
                else if (game.order[i] == 'b')
                    playersTab[i] = blue;
                else if (game.order[i] == 'g')
                    playersTab[i] = green;
                else if (game.order[i] == 'y')
                    playersTab[i] = yellow;
                playersTab[i].pic.Visible = true;
            }

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            ShowMapOfGamePanel();
        }

        private void ShowMapOfGamePanel()
        {
            MapOfGamePanel.Size = new Size(Constants.MAP_WIDTH, Constants.MAP_HEIGHT);
            MapOfGamePanel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - MapOfGamePanel.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - MapOfGamePanel.Size.Height / 2);
            
            switch(game.map)
            {
                case "poland":
                    MapOfGamePanel.BackgroundImage = global::Odkrywcy.Properties.Resources.map_of_poland;
                    break;
                case "europe":
                    MapOfGamePanel.BackgroundImage = global::Odkrywcy.Properties.Resources.map_of_poland; //CHANGE THIS
                    break;
                case "world":
                    MapOfGamePanel.BackgroundImage = global::Odkrywcy.Properties.Resources.map_of_poland;  //CHANGE THIS
                    break;
            }

            OpenLegendAndRulesButton.Size = new Size(Constants.OPEN_LA_SIZE, Constants.OPEN_LA_SIZE);
            OpenLegendAndRulesButton.Location = new Point(0, MapOfGamePanel.Size.Height - Constants.OPEN_LA_SIZE);
            OpenDicePanelButton.Size = new Size(Constants.OPEN_LA_SIZE, Constants.OPEN_LA_SIZE);
            OpenDicePanelButton.Location = new Point(MapOfGamePanel.Size.Width - Constants.OPEN_LA_SIZE, MapOfGamePanel.Size.Height - Constants.OPEN_LA_SIZE);

            ExitButton.Size = new Size(Constants.EXIT_SIZE, Constants.EXIT_SIZE);
            ExitButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width - Constants.EXIT_SIZE - Constants.EXIT_MARGIN, Constants.EXIT_MARGIN);

            ShowDicePanel();
            InitLegendAndRulesPanel();
            HideLegendAndRulesPanel();
            InitQuestionsPanels();
            InitAreas();
            StartDotsPlayers();
            
            MapOfGamePanel.Enabled = true;
            MapOfGamePanel.Visible = true;
        }

        private void ShowDicePanel()
        {
            DicePanel.Size = new Size(Constants.DICE_PANEL_WIDTH, Constants.DICE_PANEL_HEIGHT);
            DicePanel.Location = new Point(Screen.PrimaryScreen.Bounds.Width - (DicePanel.Size.Width + Constants.DICE_PANEL_MARGIN), Screen.PrimaryScreen.Bounds.Height - (DicePanel.Size.Height + Constants.DICE_PANEL_MARGIN));
            
            MinimizeDicePanelButton.Size = new Size(Constants.DICE_EXIT_BUTTON, Constants.DICE_EXIT_BUTTON);
            MinimizeDicePanelButton.Location = new Point(DicePanel.Size.Width - (MinimizeDicePanelButton.Size.Width + Constants.DICE_EXIT_BUTTON_MARGIN), Constants.DICE_EXIT_BUTTON_MARGIN);

            DiceBackgroundPictureBox.Size = new Size(Constants.DICE_BACKGROUND_SIZE, Constants.DICE_BACKGROUND_SIZE);
            DiceBackgroundPictureBox.Location = new Point((DicePanel.Size.Width - DiceBackgroundPictureBox.Size.Width) / 2, (DicePanel.Size.Width - DiceBackgroundPictureBox.Size.Width) / 2);
            switch (game.order[0])
            {
                case 'r':
                    DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_red;
                    break;
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


            DicePictureBox.Size = new Size(Constants.DICE_SIZE, Constants.DICE_SIZE);
            DicePictureBox.Location = new Point((DicePanel.Size.Width - DiceBackgroundPictureBox.Size.Width) / 2 + DicePictureBox.Size.Width / 2, (DicePanel.Size.Width - DiceBackgroundPictureBox.Size.Width) / 2 + DicePictureBox.Size.Width / 2);
            startThrow = currentThrow = ChangeDice();

            ThrowDiceButton.Size = new Size(Constants.THROW_DICE_W, Constants.THROW_DICE_H);
            ThrowDiceButton.Location = new Point((DicePanel.Size.Width - ThrowDiceButton.Size.Width) / 2, DiceBackgroundPictureBox.Location.Y + DiceBackgroundPictureBox.Size.Height + 15);
        }

        private void InitLegendAndRulesPanel()
        {
            LegendAndRulesPanel.Size = new Size(Constants.LEGEND_AND_RULES_PANEL_WIDTH, Constants.LEGEND_AND_RULES_PANEL_HEIGHT);
            LegendAndRulesPanel.Location = new Point(Constants.LEGEND_AND_RULES_PANEL_MARGIN, Screen.PrimaryScreen.Bounds.Height - (LegendAndRulesPanel.Size.Height + Constants.LEGEND_AND_RULES_PANEL_MARGIN));

            MinimizeLRPanelButton.Size = new Size(Constants.LEGEND_AND_RULES_EXIT_BUTTON, Constants.LEGEND_AND_RULES_EXIT_BUTTON);
            MinimizeLRPanelButton.Location = new Point(LegendAndRulesPanel.Size.Width - (MinimizeLRPanelButton.Size.Width + Constants.LEGEND_AND_RULES_BUTTONS_MARGIN),Constants.LEGEND_AND_RULES_BUTTONS_MARGIN);

            ShowRulesButton.Size = new Size(Constants.LEGEND_AND_RULES_BUTTONS_WIDTH + 50, Constants.LEGEND_AND_RULES_BUTTONS_HEIGHT);
            ShowRulesButton.Location = new Point(Constants.LEGEND_AND_RULES_BUTTONS_MARGIN, Constants.LEGEND_AND_RULES_BUTTONS_MARGIN);
            ShowLegendButton.Size = new Size(Constants.LEGEND_AND_RULES_BUTTONS_WIDTH, Constants.LEGEND_AND_RULES_BUTTONS_HEIGHT);
            ShowLegendButton.Location = new Point(ShowRulesButton.Size.Width + Constants.LEGEND_AND_RULES_BUTTONS_MARGIN, Constants.LEGEND_AND_RULES_BUTTONS_MARGIN);

            LegendAndRulesPictureBox.Size = new Size(Constants.LEGEND_AND_RULES_PANEL_WIDTH - 2 * Constants.LEGEND_AND_RULES_BUTTONS_MARGIN, Constants.LEGEND_AND_RULES_PANEL_HEIGHT - (Constants.LEGEND_AND_RULES_BUTTONS_HEIGHT + 2* Constants.LEGEND_AND_RULES_BUTTONS_MARGIN));
            LegendAndRulesPictureBox.Location = new Point(Constants.LEGEND_AND_RULES_BUTTONS_MARGIN, Constants.LEGEND_AND_RULES_BUTTONS_HEIGHT);
        }
        
        private int ChangeDice()
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            currentThrow = ChangeDice();
            if (startThrow > (endThrow - endThrow / 4))
                timer_changeDice.Interval += 80;
            if (startThrow == endThrow)
            {
                timer_changeDice.Stop();

                if (playersTab[currentPlayer].place + currentThrow < locationsAreas.Length / 3)
                {
                    endPlace = currentThrow;
                    timer_changePlaces.Enabled = true;
                    timer_changePlaces.Start();
                }
                else
                {
                    ThrowDiceButton.Enabled = true;
                    IncreasePlayerNumber();
                    ChangeDiceBackground();
                }

            }
            startThrow++;
        }

        private void timer_changePlaces_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playerMusicMove = new System.Media.SoundPlayer();
            playerMusicMove.SoundLocation = "move.wav";
            playerMusicMove.Play();

            playersTab[currentPlayer].place += 1;
            ShowDotsPlayers();
            startPlace++;
            if(startPlace == endPlace)
            {
                ChangeStartArea();
                timer_changePlaces.Stop();
                CheckWin();

                if (CheckPlace() == false)
                {
                    playersTab[currentPlayer].previousPlace = playersTab[currentPlayer].place;
                    IncreasePlayerNumber();
                }
                else
                {
                    System.Media.SoundPlayer playerMusicQuestion = new System.Media.SoundPlayer();
                    playerMusicQuestion.SoundLocation = "askQuestion.wav";
                    playerMusicQuestion.Play();
                }

                ChangeDiceBackground();
                ThrowDiceButton.Enabled = true;
                startPlace = 0;
                
            }
        }

        private void ShowLegendAndRulesPanel()
        {
            LegendAndRulesPanel.Enabled = true;
            LegendAndRulesPanel.Visible = true;
        }

        private void HideLegendAndRulesPanel()
        {
            LegendAndRulesPanel.Enabled = false;
            LegendAndRulesPanel.Visible = false;
        }

        private void ShowLegendButton_Click(object sender, EventArgs e)
        {
            ShowLegendButton.ForeColor = Color.FromArgb(111, 56, 0);
            ShowRulesButton.ForeColor = Color.FromArgb(169, 90, 11);
            LegendAndRulesPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.legend;
        }

        private void ShowRulesButton_Click(object sender, EventArgs e)
        {
            ShowRulesButton.ForeColor = Color.FromArgb(111, 56, 0);
            ShowLegendButton.ForeColor = Color.FromArgb(169, 90, 11);
            LegendAndRulesPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.rules;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            HideLegendAndRulesPanel();
            openGameWindows -= 1;
        }

        private void OpenLegendAndRulesButton_Click(object sender, EventArgs e)
        {
            ShowLegendAndRulesPanel();
            openGameWindows += 1;
        }

        private void MinimizeDicePanelButton_Click(object sender, EventArgs e)
        {
            DicePanel.Enabled = false;
            DicePanel.Visible = false;
            openGameWindows -= 2;
        }

        private void OpenDicePanelButton_Click(object sender, EventArgs e)
        {
            DicePanel.Enabled = true;
            DicePanel.Visible = true;
            openGameWindows += 2;
        }

        private void InitAreas()
        {
            int centerWidth = MapOfGamePanel.Size.Width / 2;
            int centerHeight = MapOfGamePanel.Size.Height / 2;
            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"Lib/LocationsAreasPoland.txt");
            string[] locations = System.IO.File.ReadAllLines(path);

            locationsAreas = new int[locations.Length];
            for(int i = 0; i < locations.Length; i++)
                locationsAreas[i] = Int32.Parse(locations[i]);

            //QUESTIONS AREAS
            for (int i = 0; i < 3; i++)
            {
                int randomTMP = random.Next(5, locationsAreas.Length / 3 - 6);
                questionsAreas[i] = randomTMP;

                if (locationsAreas[randomTMP * 3 + 2] != 0 || locationsAreas[(randomTMP + 1) * 3 + 2] != 0 || locationsAreas[(randomTMP + 2) * 3 + 2] != 0
                    || locationsAreas[(randomTMP - 1) * 3 + 2] != 0 || locationsAreas[(randomTMP - 2) * 3 + 2] != 0 )  //not in brigde and near bridge
                    i--;
                
                for (int j = 0; j < i; j++)  //without repetition and near existing questions
                {
                    if(questionsAreas[j] == questionsAreas[i] || Math.Abs(questionsAreas[j] - questionsAreas[i]) <= 2)
                    {
                        i--;
                        break;
                    }
                }
            }

            PictureBox[] pictureBoxes =
            { 
                StartPictureBox,
                DotRedPictureBox, DotBluePictureBox, DotGreenPictureBox, DotYellowPictureBox,
                pictureBox1, pictureBox2, pictureBox3
            };

            int locationsQuestionAreas = 0;
            for(int i = 0; i < pictureBoxes.Length; i++)
            {
                if(i == 0) //start
                {
                    switch(game.numberOfPlayers)
                    {
                        case 2:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.start_RB;
                            break;
                        case 3:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.start_RGB;
                            break;
                        case 4:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.start_RGBY;
                            break;
                    }
                    pictureBoxes[i].Size = new Size(Constants.AREAS_START_SIZE, Constants.AREAS_START_SIZE);
                    pictureBoxes[i].Location = new Point(centerWidth + locationsAreas[i * 3], centerHeight + locationsAreas[i * 3 + 1]);
                }
                else
                {
                    switch(i)
                    {
                        case 1:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.dot_player_red;
                            break;
                        case 2:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.dot_player_blue;
                            break;
                        case 3:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.dot_player_green;
                            break;
                        case 4:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.dot_player_yellow;
                            break;
                        default:
                            pictureBoxes[i].BackgroundImage = global::Odkrywcy.Properties.Resources.question_mark;
                            pictureBoxes[i].Location = new Point(centerWidth + locationsAreas[questionsAreas[locationsQuestionAreas] * 3], centerHeight + locationsAreas[questionsAreas[locationsQuestionAreas] * 3 + 1]);
                            locationsQuestionAreas++;
                            break;
                    }
                    pictureBoxes[i].Size = new Size(Constants.AREAS_SIZE, Constants.AREAS_SIZE);
                }
                
            }
        }

        private void StartDotsPlayers()
        {
            for (int i = 0; i < game.numberOfPlayers; i++ )
                playersTab[i].pic.Location = new Point(MapOfGamePanel.Size.Width / 2 + locationsAreas[playersTab[i].place * 3], MapOfGamePanel.Size.Height / 2 + locationsAreas[playersTab[i].place * 3 + 1]);
        }

        private void ShowDotsPlayers()
        {
            for (int i = 0; i < game.numberOfPlayers; i++ )
            {
                if (playersTab[i].place != 0)
                {
                    playersTab[i].pic.Visible = true;
                    playersTab[i].pic.BringToFront();
                    playersTab[i].pic.Location = new Point(MapOfGamePanel.Size.Width / 2 + locationsAreas[playersTab[i].place * 3], MapOfGamePanel.Size.Height / 2 + locationsAreas[playersTab[i].place * 3 + 1]);
                }
                else
                    playersTab[i].pic.Visible = false;

            }
        }

        private void ChangeDiceBackground()
        {
            switch (game.order[currentPlayer])
            {
                case 'r':
                    DiceBackgroundPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.dice_red;
                    break;
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

        private void CheckWin()
        {
            if (playersTab[currentPlayer].place == (locationsAreas.Length / 3) - 1)
            {
                ThrowDiceButton.Enabled = false;
                playersTab[currentPlayer].pic.Size = new Size(Constants.AREAS_META_SIZE, Constants.AREAS_META_SIZE);
                ShowDotsPlayers();
                MessageBox.Show(playersTab[currentPlayer].name + "! Jesteś zwycięzcą! ", "Koniec gry");
                Application.Restart();
            }
        }

        private bool CheckPlace()
        {
            //ANOTHER PLAYER
            for(int i = 0; i < game.numberOfPlayers; i++)
            {
                for(int j = i + 1; j < game.numberOfPlayers; j++)
                {
                    if (playersTab[i].place == playersTab[j].place && i != j && playersTab[i].place != 0)
                    {
                        if (playersTab[i] == playersTab[currentPlayer])
                            AskQuestionAttackForPlayers(playersTab[currentPlayer], playersTab[j]);
                        else
                            AskQuestionAttackForPlayers(playersTab[currentPlayer], playersTab[i]);
                        
                        //ShowDotsPlayers();
                        IncreasePlayerNumber();
                        return true;
                    }
                }
            }


            for (int i = 0; i < questionsAreas.Length; i++) //QUESTIONS AREAS
            {
                if (playersTab[currentPlayer].place == questionsAreas[i])
                {
                    AskQuestionForPlayer();
                    return true;
                }
            }

            if (locationsAreas[playersTab[currentPlayer].place * 3 + 2] != 0)   //BRIDGES
            {
                AskQuestionForPlayer();
                return true;
            }
            ShowDotsPlayers();
            return false;
        }

        private void ChangeStartArea()
        {
            switch(game.numberOfPlayers)
            {
                case 2:
                    if (red.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_R;
                    else if (blue.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_B;
                    else
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_clear;
                    break;
                case 3:
                    if (red.place == 0 && blue.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RB;
                    else if (blue.place == 0 && green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_BG;
                    else if (red.place == 0 && green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RG;
                    else if (red.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_R;
                    else if (blue.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_B;
                    else if (green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_G;
                    else
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_clear;
                    break;
                case 4:
                    if (red.place == 0 && blue.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RBY;
                    else if (blue.place == 0 && green.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_GBY;
                    else if (red.place == 0 && blue.place == 0 && green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RGB;
                    else if (red.place == 0 && green.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RGY;
                    else if (red.place == 0 && blue.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RB;
                    else if (blue.place == 0 && green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_BG;
                    else if (red.place == 0 && green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RG;
                    else if (red.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_RY;
                    else if (blue.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_BY;
                    else if (green.place == 0 && yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_GY;
                    else if (red.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_R;
                    else if (blue.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_B;
                    else if (green.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_G;
                    else if (yellow.place == 0)
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_Y;
                    else
                        StartPictureBox.BackgroundImage = global::Odkrywcy.Properties.Resources.start_clear;
                    break;
            }
        }

        public void InitQuestionsPanels()
        {
            QuestionsPanel.Size = new Size(Constants.QUESTIONS_PANEL_WIDTH, Constants.QUESTIONS_PANEL_HEIGHT);
            QuestionsPanel.Location = new Point(MapOfGamePanel.Width / 2 - QuestionsPanel.Width / 2, MapOfGamePanel.Height / 2 - QuestionsPanel.Height / 2);
            
            PlayerNameLabel.Location = new Point(150, 100);
            
            button1.Size = new Size(Constants.QUESTIONS_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_PANEL_BUTTONS_HEIGHT);
            button2.Size = new Size(Constants.QUESTIONS_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_PANEL_BUTTONS_HEIGHT);
            button3.Size = new Size(Constants.QUESTIONS_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_PANEL_BUTTONS_HEIGHT);
            button4.Size = new Size(Constants.QUESTIONS_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_PANEL_BUTTONS_HEIGHT);

            ExitQuestionPanelButton.Size = new Size(Constants.QUESTIONS_PANEL_EXIT_BUTTON_WIDTH, Constants.QUESTIONS_PANEL_EXIT_BUTTON_HEIGHT);
            ExitQuestionPanelButton.Location = new Point(QuestionsPanel.Width - 250 , QuestionsPanel.Height - 120);


            /* QuestionsAttack */
            QuestionsAttackPanel.Size = new Size(Constants.QUESTIONS_PANEL_WIDTH, Constants.QUESTIONS_PANEL_HEIGHT);
            QuestionsAttackPanel.Location = new Point(MapOfGamePanel.Width / 2 - QuestionsPanel.Width / 2, MapOfGamePanel.Height / 2 - QuestionsPanel.Height / 2);

            ConfirmButton.Size = new Size(Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH / 2 - 20, Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_HEIGHT - 10);
            LessButton.Size = new Size(Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_HEIGHT);
            EqualButton.Size = new Size(Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_HEIGHT);
            MoreButton.Size = new Size(Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH, Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_HEIGHT);

            ExitQuestionAttackPanelButton.Size = new Size(Constants.QUESTIONS_PANEL_EXIT_BUTTON_WIDTH, Constants.QUESTIONS_PANEL_EXIT_BUTTON_HEIGHT);
            ExitQuestionAttackPanelButton.Location = new Point(QuestionsPanel.Width - 250, QuestionsPanel.Height - 120);

            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"Lib/Questions.txt");
            questionsTab = System.IO.File.ReadAllLines(path);
            string path2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"Lib/QuestionsAttack.txt");
            questionsAttackTab = System.IO.File.ReadAllLines(path2);
        }

        private void AskQuestionForPlayer()
        {
            randomQuestion = random.Next(0, questionsTab.Length / 7);
            
            PlayerNameLabel.Text = playersTab[currentPlayer].name + ":";
            PlayerNameLabel.ForeColor = playersTab[currentPlayer].color;
            QuestionLabel.Text = questionsTab[randomQuestion * 7];
            QuestionLabel.AutoSize = true;
            QuestionLabel.MaximumSize = new Size(600, 0);
            QuestionLabel.Location = new Point(QuestionsPanel.Width / 2 - QuestionLabel.Width / 2, 150);
            button1.Location = new Point(QuestionsPanel.Width / 2 - (Constants.QUESTIONS_PANEL_BUTTONS_WIDTH + 15), QuestionLabel.Location.Y + QuestionLabel.Height + 30);
            button2.Location = new Point(QuestionsPanel.Width / 2 + 15, QuestionLabel.Location.Y + QuestionLabel.Height + 30);
            button3.Location = new Point(QuestionsPanel.Width / 2 - (Constants.QUESTIONS_PANEL_BUTTONS_WIDTH + 15), QuestionLabel.Location.Y + QuestionLabel.Height + 80);
            button4.Location = new Point(QuestionsPanel.Width / 2 + 15, QuestionLabel.Location.Y + QuestionLabel.Height + 80);
            AnswerLabel.Text = "";

            Button[] buttons = { button1, button2, button3, button4 };
            for(int i = 0; i < 4; i++)  //change order buttons
            {
                int replaceFrom = random.Next(0, buttons.Length);
                int replaceTo = random.Next(0, buttons.Length);
                Button buttonsTmp = buttons[replaceTo];
                buttons[replaceTo] = buttons[replaceFrom];
                buttons[replaceFrom] = buttonsTmp;
            }
            for(int i = 0; i < 4; i++)  //set possible answers
            {
                buttons[i].Text = questionsTab[randomQuestion * 7 + 1 + i];
                buttons[i].Enabled = true;
            }
            QuestionsPanel.Enabled = true;
            QuestionsPanel.Visible = true;
            DicePanel.Enabled = false;
            DicePanel.Visible = false;
            OpenDicePanelButton.Enabled = false;
            OpenLegendAndRulesButton.Enabled = false;
            HideLegendAndRulesPanel();
            for (int i = 0; i < game.numberOfPlayers; i++)
                playersTab[i].pic.Visible = false;
            
        }

        private void AnswerQuestion(string answer)
        {
            if (answer == questionsTab[randomQuestion * 7 + 5])
            {
                AnswerLabel.Text = "Brawo! ";
                resultAnswerPlayer = true;
                System.Media.SoundPlayer playerMusicAnswer = new System.Media.SoundPlayer();
                playerMusicAnswer.SoundLocation = "correctAnswer.wav";
                playerMusicAnswer.Play();
            }
            else
            {
                AnswerLabel.Text = "Błąd! ";
                resultAnswerPlayer = false;
                System.Media.SoundPlayer playerMusicAnswer = new System.Media.SoundPlayer();
                playerMusicAnswer.SoundLocation = "incorrectAnswer.wav";
                playerMusicAnswer.Play();
            }
            
            AnswerLabel.Text += "Poprawna odpowiedź to: " + questionsTab[randomQuestion * 7 + 5] + '\n' + questionsTab[randomQuestion * 7 + 6];
            AnswerLabel.AutoSize = true;
            AnswerLabel.MaximumSize = new Size(800, 0);
            AnswerLabel.Location = new Point(QuestionsPanel.Width / 2 - AnswerLabel.Width / 2, button4.Location.Y + 70);
            ExitQuestionPanelButton.Enabled = true;
            ExitQuestionPanelButton.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (locationsAreas[playersTab[currentPlayer].place * 3 + 2] == 0)   //in question area
            {
                if (resultAnswerPlayer == true)
                    playersTab[currentPlayer].place += 2;
                else
                    playersTab[currentPlayer].place -= 1;
            }
            else         //in bridge
            {
                if (locationsAreas[playersTab[currentPlayer].place * 3 + 2] > 0)    //green bridge
                {
                    if (resultAnswerPlayer == true)
                    {
                       // playersTab[currentPlayer].previousPlace = playersTab[currentPlayer].place;
                        playersTab[currentPlayer].place += locationsAreas[playersTab[currentPlayer].place * 3 + 2];
                    }
                }
                else      //red bridge
                {
                    if (resultAnswerPlayer == false)
                    {
                       // playersTab[currentPlayer].previousPlace = playersTab[currentPlayer].place;
                        playersTab[currentPlayer].place += locationsAreas[playersTab[currentPlayer].place * 3 + 2];
                    }
                }
            }
            playersTab[currentPlayer].previousPlace = playersTab[currentPlayer].place;
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerQuestion(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnswerQuestion(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnswerQuestion(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnswerQuestion(button4.Text);
        }

        private void ExitQuestionPanelButton_Click(object sender, EventArgs e)
        {
            QuestionsPanel.Enabled = false;
            QuestionsPanel.Visible = false;
            OpenDicePanelButton.Enabled = true;
            OpenLegendAndRulesButton.Enabled = true;
            if (openGameWindows != 0)
            {
                if (openGameWindows == 1)
                    ShowLegendAndRulesPanel();
                else if (openGameWindows == 2)
                {
                    DicePanel.Enabled = true;
                    DicePanel.Visible = true;
                }
                else
                {
                    ShowLegendAndRulesPanel();
                    DicePanel.Enabled = true;
                    DicePanel.Visible = true;
                }
            }
            ExitQuestionPanelButton.Enabled = false;
            ExitQuestionPanelButton.Visible = false;

            ShowDotsPlayers();
            //if(CheckPlace() == false) PO MOSCIE NIE CHECKUJ
                IncreasePlayerNumber();
                ChangeDiceBackground();
        }

        private void AskQuestionAttackForPlayers(Player attacker, Player attacked)
        {
            QuestionsAttackPanel.Enabled = true;
            QuestionsAttackPanel.Visible = true;

            Attacker = attacker;
            Attacked = attacked;
            randomQuestion = random.Next(0, questionsAttackTab.Length / 3);

            QuestionAttackLabel.Text = questionsAttackTab[randomQuestion * 3];
            QuestionAttackLabel.AutoSize = true;
            QuestionAttackLabel.MaximumSize = new Size(600, 0);
            QuestionAttackLabel.Location = new Point(QuestionsAttackPanel.Width / 2 - QuestionAttackLabel.Width / 2, 80);

            PlayerAttackerLabel.Text = attacker.name + ":";
            PlayerAttackerLabel.ForeColor = attacker.color;
            PlayerAttackerLabel.Location = new Point(100, QuestionAttackLabel.Location.Y + QuestionAttackLabel.Height + 20);

            AttackerTextBox.Text = "";
            AttackerTextBox.Enabled = true;
            AttackerTextBox.Size = new Size(Constants.TEXT_BOX_WIDTH, Constants.TEXT_BOX_HEIGHT);
            AttackerTextBox.Location = new Point(PlayerAttackerLabel.Location.X + PlayerAttackerLabel.Width + 10, PlayerAttackerLabel.Location.Y + 7);

            ConfirmButton.Location = new Point(AttackerTextBox.Location.X + AttackerTextBox.Width + 10, AttackerTextBox.Location.Y + (AttackerTextBox.Height - ConfirmButton.Height) / 2);

            PlayerAttackedLabel.Text = attacked.name + " poprawna odpowiedź jest:";
            PlayerAttackedLabel.ForeColor = attacked.color;
            PlayerAttackedLabel.Location = new Point(100, PlayerAttackerLabel.Location.Y + PlayerAttackerLabel.Height + 20);

            LessButton.Location = new Point(MapOfGamePanel.Width / 2 - (Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH + 10 + Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH / 2), PlayerAttackedLabel.Location.Y + PlayerAttackedLabel.Height + 30);
            EqualButton.Location = new Point(MapOfGamePanel.Width / 2 - (Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH / 2), PlayerAttackedLabel.Location.Y + PlayerAttackedLabel.Height + 30);
            MoreButton.Location = new Point(MapOfGamePanel.Width / 2 + (10 + Constants.QUESTIONS_ATTACK_PANEL_BUTTONS_WIDTH / 2), PlayerAttackedLabel.Location.Y + PlayerAttackedLabel.Height + 30);

            AnswerAttackLabel.Text = "";

            DicePanel.Enabled = false;
            DicePanel.Visible = false;
            HideLegendAndRulesPanel();
            OpenDicePanelButton.Enabled = false;
            OpenLegendAndRulesButton.Enabled = false;
            
            for (int i = 0; i < game.numberOfPlayers; i++)
                playersTab[i].pic.Visible = false;
        }

        private void AttackerWin()
        {
            Attacked.place = Attacked.previousPlace = Attacker.previousPlace;
            Attacker.previousPlace = Attacker.place;

            System.Media.SoundPlayer playerMusicAnswer = new System.Media.SoundPlayer();
            playerMusicAnswer.SoundLocation = "correctAnswer.wav";
            playerMusicAnswer.Play();
        }
        
        private void AttackedWin()
        {
            Attacker.place = Attacker.previousPlace;

            System.Media.SoundPlayer playerMusicAnswer = new System.Media.SoundPlayer();
            playerMusicAnswer.SoundLocation = "incorrectAnswer.wav";
            playerMusicAnswer.Play();
        }

        private void AnswerQuestionAttack(char answer)
        {
            switch (answer)
            {
                case 'l':
                    if (Int32.Parse(AttackerTextBox.Text) > Int32.Parse(questionsAttackTab[randomQuestion * 3 + 1]))
                    {
                       // MessageBox.Show("atakowany ma racje!");
                        AttackedWin();
                    }
                    else
                    {
                       // MessageBox.Show("atakujacy ma racje!");
                        AttackerWin();
                    }
                    break;
                case 'e':
                    if (Int32.Parse(AttackerTextBox.Text) == Int32.Parse(questionsAttackTab[randomQuestion * 3 + 1]))
                    {
                       // MessageBox.Show("atakowany ma racje!");
                        AttackedWin();
                    }
                    else
                    {
                      //  MessageBox.Show("atakujacy ma racje!");
                        AttackerWin();
                    }
                    break;
                case 'm':
                    if (Int32.Parse(AttackerTextBox.Text) < Int32.Parse(questionsAttackTab[randomQuestion * 3 + 1]))
                    {
                      //  MessageBox.Show("atakowany ma racje!");
                        AttackedWin();
                    }
                    else
                    {
                      //  MessageBox.Show("atakujacy ma racje!");
                        AttackerWin();
                    }
                    break;
            }
            

            AnswerAttackLabel.Text = "Poprawna odpowiedź to: " + questionsAttackTab[randomQuestion * 3 + 1] + '\n' + questionsAttackTab[randomQuestion * 3 + 2];
            AnswerAttackLabel.AutoSize = true;
            AnswerAttackLabel.MaximumSize = new Size(800, 0);
            AnswerAttackLabel.Location = new Point(QuestionsAttackPanel.Width / 2 - AnswerAttackLabel.Width / 2, MoreButton.Location.Y + MoreButton.Height + 20);

            AttackerTextBox.Enabled = false;
            LessButton.Enabled = false;
            EqualButton.Enabled = false;
            MoreButton.Enabled = false;
            ExitQuestionAttackPanelButton.Enabled = true;
            ExitQuestionAttackPanelButton.Visible = true;

        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            AnswerQuestionAttack('l');
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            AnswerQuestionAttack('e');
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            AnswerQuestionAttack('m');
        }

        //private void MoveDotAfterQuestion()
        //{
            
        //    for (int i = 0; i < questionsAreas.Length; i++) //QUESTIONS AREAS
        //    {
        //        if (currentPlayer - 1 < 0)
        //        {
        //            MessageBox.Show(playersTab[game.numberOfPlayers - 1].place.ToString() + " \t " + questionsAreas[i] + " \t " + resultAnswerPlayer.ToString());
        //            if (playersTab[game.numberOfPlayers - 1].place == questionsAreas[i])
        //            {
        //                if (resultAnswerPlayer == true){
                                
        //                    playersTab[game.numberOfPlayers - 1].place += 2;
        //                    MessageBox.Show("nowy: " + playersTab[game.numberOfPlayers - 1].place.ToString());
        //                 }
        //                else
        //                    playersTab[game.numberOfPlayers - 1].place -= 1;
                        
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(playersTab[currentPlayer - 1].place.ToString() + " \t " + questionsAreas[i] + " \t " + resultAnswerPlayer.ToString());
        //            if (playersTab[currentPlayer - 1].place == questionsAreas[i])
        //            {
        //                if (resultAnswerPlayer == true)
        //                {
        //                    playersTab[currentPlayer - 1].place += 2;
        //                    MessageBox.Show("nowy: " + playersTab[currentPlayer - 1].place.ToString());
        //                }
        //                else
        //                    playersTab[currentPlayer - 1].place -= 1;
        //                break;
        //            }
        //        }
                
        //    }
        //    ShowDotsPlayers();
        //}

        private void IncreasePlayerNumber()
        {
            currentPlayer++;
            if (currentPlayer == game.numberOfPlayers)
                currentPlayer = 0;
        }

        private void ExitQuestionAttackPanelButton_Click(object sender, EventArgs e)
        {
            QuestionsAttackPanel.Enabled = false;
            QuestionsAttackPanel.Visible = false;
            OpenDicePanelButton.Enabled = true;
            OpenLegendAndRulesButton.Enabled = true;

            if (openGameWindows != 0)
            {
                if (openGameWindows == 1)
                    ShowLegendAndRulesPanel();
                else if (openGameWindows == 2)
                {
                    DicePanel.Enabled = true;
                    DicePanel.Visible = true;
                }
                else
                {
                    ShowLegendAndRulesPanel();
                    DicePanel.Enabled = true;
                    DicePanel.Visible = true;
                }
            }

            
            ShowDotsPlayers();
            ChangeStartArea();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(AttackerTextBox.Text, out wynik))
            {
                LessButton.Enabled = true;
                EqualButton.Enabled = true;
                MoreButton.Enabled = true;

                AttackerTextBox.Enabled = false;
            }
            else
                MessageBox.Show("Wprowadź poprawną liczbę!");

        }

        



    }
}
