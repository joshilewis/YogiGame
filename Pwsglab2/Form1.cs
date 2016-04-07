using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pwsglab2.Properties;
using System.IO;

namespace Pwsglab2
{
    public partial class Form1 : Form
    {
        private List<PictureBox> fallingItems;
        private Image imageBasket;
        private Image imageRock;
        private Random rand;
        private int score;
        private bool gameOn;
        private string bestScoresString;
        private bool gamePaused;

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameOn)
            {
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("Czy chcesz zakończyć tą grę?", "Nowa gra", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    timer1.Start();
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    disposeItems();
                }
            }
            gameOverButton.Enabled = true;
            gameOverTextBox.Enabled = true;
            score = 0;
            gamePaused = false;
            scoreLabel.Text = "Score : "+score;
            yogiBear.Visible = true;
            this.BackgroundImage = global::Pwsglab2.Properties.Resources.background;
            fallingItems = new List<PictureBox>();
            rand = new Random();
            timer1.Start();
            gameOn = true;
            gameOverButton.Visible = false;
            gameOverLabel.Visible = false;
            gameOverTextBox.Visible = false;
            scoreLabel.Visible = true;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (!gameOn)
            {
               
                dialog.Show();
            }
            else {
                timer1.Stop();
                MessageBox.Show("You can not change settings during the game!", "", MessageBoxButtons.OK);
                timer1.Start();
            }
        }

        private void bestScores_Click(object sender, EventArgs e)
        {
            bestScoresLabel.Visible = true;
            bestScoresLabel.Text = "Best scores : \n" + loadBestScores();
            okBestScoresButton.Visible = true;
            bestScoresLabel.BringToFront();
            if(gameOn)
                timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageRock = Pwsglab2.Properties.Resources.rock;
            imageBasket = Pwsglab2.Properties.Resources.basket;
            bestScoresString = loadBestScores();
            dialog = new Settings();
            okBestScoresButton.Visible = false;
            KeyPreview = true;
            scoreLabel.Visible = false;
        }

        private string loadBestScores()
        {
            String pom;
            try
            {
                pom = File.ReadAllText("best_scores.txt");
            }
            catch (FileNotFoundException ex)
            {
                File.WriteAllText("best_scores.txt", "");
                pom = "";
            }
            return pom;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = yogiBear.Location.X;
            int y = yogiBear.Location.Y;
            if (e.KeyCode == Keys.Space && gameOn)
            {
                if (gamePaused)
                {
                    timer1.Start();
                    gamePaused = false;
                }
                else
                {
                    timer1.Stop();
                    gamePaused = true;
                }
            }

            if (dialog.leftKey.Equals("Left"))
                if (e.KeyCode == Keys.Left)
                {
                    if (x - 15 >= 0)
                        yogiBear.Location = new System.Drawing.Point(x - 15, y);
                }
            if (dialog.leftKey.Equals("L")) 
                if (e.KeyCode == Keys.L)
                {
                    if (x - 15 >= 0)
                        yogiBear.Location = new System.Drawing.Point(x - 15, y);
                }
            if (dialog.rightKey.Equals("Right"))
                if (e.KeyCode == Keys.Right)
                {
                    if (x + yogiBear.Size.Width <= this.ClientSize.Width - 30)
                        yogiBear.Location = new System.Drawing.Point(x + 30, y);
                }
            if(dialog.rightKey.Equals("R"))
                    if (e.KeyCode == Keys.R)
                    {
                        if (x + yogiBear.Size.Width <= this.ClientSize.Width - 30)
                            yogiBear.Location = new System.Drawing.Point(x + 30, y);
                    }

        }

        private void addNewItemsToList(List<PictureBox> fallingItems)
        {
            int maxX = this.ClientSize.Width / 40;

            if (rand.Next() % 2 == 0)
            {
                PictureBox item = new Rock(imageRock);
                item.Location = new Point((rand.Next() % maxX) * 40, 1);
                fallingItems.Add(item);
                Controls.Add(item);
            }
            if (rand.Next() % 2 == 0)
            {
                PictureBox item = new Basket(imageBasket);
                item.Location = new Point((rand.Next() % maxX) * 40, 1);
                fallingItems.Add(item);
                Controls.Add(item);
            }
        }

        private void moveObjects(List<PictureBox> lista)
        {
            int x;
            int y;
            for (int i = 0; i < lista.Count; i++)
            {
                x = lista[i].Location.X;
                y = lista[i].Location.Y;
                if (y < this.Size.Height)
                {
                    if (x + Rock.rockSize > yogiBear.Location.X
                        && yogiBear.Location.X + yogiBear.Size.Width > x
                        && y > ClientSize.Height - yogiBear.Size.Height * 2
                        && y < ClientSize.Height - yogiBear.Size.Height-5
                         )
                    {
                        if (lista[i].Image == imageBasket)
                        {
                            score += 100;
                            this.scoreLabel.Text = "Score : " + score;
                            Controls.Remove(lista[i]);
                            lista[i].Dispose();
                            lista.RemoveAt(i--);
                            continue;
                        }
                        else
                        {
                            gameOver();
                            break;
                        }
                    }
                    lista[i].Location = new Point(x, y + 40);
                }
                else
                {
                    Controls.Remove(lista[i]);
                    lista[i].Dispose();
                    lista.RemoveAt(i--);
                }
            }
        }

        private void disposeItems()
        {
            for (int i = 0; i < fallingItems.Count; i++)
            {
                Controls.Remove(fallingItems[i]);
                fallingItems[i].Dispose();
                fallingItems.RemoveAt(i--);
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            yogiBear.Visible = false;
            this.BackgroundImage = null;
            disposeItems();
            gameOn = false;
            gameOverButton.Visible = true;
            gameOverLabel.Visible = true;
            gameOverTextBox.Visible = true;
            scoreLabel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            addNewItemsToList(fallingItems);
            moveObjects(fallingItems);

        }

        private void gameOverButton_Click(object sender, EventArgs e)
        {
            saveScoreToFile(score);
            gameOverButton.Enabled = false;
            gameOverTextBox.Enabled = false;
        }

        private void saveScoreToFile(int score)
        {
            
            bestScoresString = loadBestScores();
            string[] pom = bestScoresString.Split('\n');
            bool scoreAdded = false;
            int maxIter = pom.Length;
            if (maxIter != 0)
                maxIter--;
            bestScoresString = "";
            for (int i = 0; i < maxIter; i++)
            {
                if (score >= getScore(pom[i]) && !scoreAdded && !pom.Equals(""))
                {
                    bestScoresString += gameOverTextBox.Text + "-" + score + "\n";
                    if (maxIter > 4)
                        maxIter--;
                    score = 0;
                    scoreAdded = true;
                }
                if (pom.Equals(""))
                    continue;
                bestScoresString += pom[i] + '\n';
            }
            if(maxIter<5 && !scoreAdded)
                bestScoresString += gameOverTextBox.Text + "-" + score + "\n";
            File.WriteAllText("best_scores.txt",bestScoresString);
        }

        private int getScore(string str)
        {
            int a=0;
            string[] pom = str.Split('-');
            try {
                a = int.Parse(pom[pom.Length - 1]);
            }
            catch (Exception e) { }

            return a;
        }

        private void okBestScoesButton_Click(object sender, EventArgs e)
        {

            bestScoresLabel.Visible = false;
            okBestScoresButton.Visible = false;
            if(gameOn)
                 timer1.Start();
            this.Focus();
        }
    }
}
