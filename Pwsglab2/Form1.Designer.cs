using System.Drawing;
using System.Windows.Forms;

namespace Pwsglab2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bestScoresButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bestScoresLabel = new System.Windows.Forms.Label();
            this.yogiBear = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameOverButton = new System.Windows.Forms.Button();
            this.gameOverTextBox = new System.Windows.Forms.TextBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.okBestScoresButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yogiBear)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameButton,
            this.bestScoresButton,
            this.settingsButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameButton
            // 
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(77, 20);
            this.newGameButton.Text = "New Game";
            this.newGameButton.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // bestScoresButton
            // 
            this.bestScoresButton.Name = "bestScoresButton";
            this.bestScoresButton.Size = new System.Drawing.Size(78, 20);
            this.bestScoresButton.Text = "Best Scores";
            this.bestScoresButton.Click += new System.EventHandler(this.bestScores_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(61, 20);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Blue;
            this.scoreLabel.Location = new System.Drawing.Point(514, 40);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 27);
            this.scoreLabel.TabIndex = 1;
            // 
            // bestScoresLabel
            // 
            this.bestScoresLabel.AutoSize = true;
            this.bestScoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestScoresLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bestScoresLabel.ForeColor = System.Drawing.Color.Blue;
            this.bestScoresLabel.Location = new System.Drawing.Point(268, 93);
            this.bestScoresLabel.Name = "bestScoresLabel";
            this.bestScoresLabel.Size = new System.Drawing.Size(0, 27);
            this.bestScoresLabel.TabIndex = 2;
            // 
            // yogiBear
            // 
            this.yogiBear.BackColor = System.Drawing.Color.Transparent;
            this.yogiBear.Image = global::Pwsglab2.Properties.Resources.Yogi_Bear;
            this.yogiBear.Location = new System.Drawing.Point(0, 319);
            this.yogiBear.Name = "yogiBear";
            this.yogiBear.Size = new System.Drawing.Size(70, 80);
            this.yogiBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yogiBear.TabIndex = 3;
            this.yogiBear.TabStop = false;
            this.yogiBear.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameOverButton
            // 
            this.gameOverButton.BackColor = System.Drawing.Color.Khaki;
            this.gameOverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gameOverButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gameOverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameOverButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOverButton.Location = new System.Drawing.Point(273, 160);
            this.gameOverButton.Name = "gameOverButton";
            this.gameOverButton.Size = new System.Drawing.Size(75, 23);
            this.gameOverButton.TabIndex = 4;
            this.gameOverButton.Text = "Submit";
            this.gameOverButton.UseVisualStyleBackColor = false;
            this.gameOverButton.Visible = false;
            this.gameOverButton.Click += new System.EventHandler(this.gameOverButton_Click);
            // 
            // gameOverTextBox
            // 
            this.gameOverTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gameOverTextBox.Location = new System.Drawing.Point(262, 122);
            this.gameOverTextBox.Name = "gameOverTextBox";
            this.gameOverTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameOverTextBox.TabIndex = 5;
            this.gameOverTextBox.Visible = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameOverLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gameOverLabel.Location = new System.Drawing.Point(257, 61);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(126, 32);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "Game over";
            this.gameOverLabel.Visible = false;
            // 
            // okBestScoresButton
            // 
            this.okBestScoresButton.BackColor = System.Drawing.Color.Khaki;
            this.okBestScoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okBestScoresButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.okBestScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBestScoresButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBestScoresButton.Location = new System.Drawing.Point(273, 290);
            this.okBestScoresButton.Name = "okBestScoresButton";
            this.okBestScoresButton.Size = new System.Drawing.Size(75, 23);
            this.okBestScoresButton.TabIndex = 7;
            this.okBestScoresButton.Text = "Ok";
            this.okBestScoresButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okBestScoresButton.UseVisualStyleBackColor = false;
            this.okBestScoresButton.Visible = false;
            this.okBestScoresButton.Click += new System.EventHandler(this.okBestScoesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.okBestScoresButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.gameOverTextBox);
            this.Controls.Add(this.gameOverButton);
            this.Controls.Add(this.yogiBear);
            this.Controls.Add(this.bestScoresLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 440);
            this.Name = "Form1";
            this.Text = "Yogi";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yogiBear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Settings dialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameButton;
        private System.Windows.Forms.ToolStripMenuItem bestScoresButton;
        private System.Windows.Forms.ToolStripMenuItem settingsButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label bestScoresLabel;
        private System.Windows.Forms.PictureBox yogiBear;
        private System.Windows.Forms.Timer timer1;
        private Button gameOverButton;
        private TextBox gameOverTextBox;
        private Label gameOverLabel;
        private Button okBestScoresButton;
    }
}

