
namespace SnakeGame
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
            this.gameBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gameBox.Location = new System.Drawing.Point(12, 12);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(500, 500);
            this.gameBox.TabIndex = 0;
            this.gameBox.TabStop = false;
            this.gameBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GameBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelScore.Location = new System.Drawing.Point(598, 21);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(25, 26);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.Location = new System.Drawing.Point(525, 78);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(98, 23);
            this.buttonStartNewGame.TabIndex = 3;
            this.buttonStartNewGame.Text = "Start New Game";
            this.buttonStartNewGame.UseVisualStyleBackColor = true;
            this.buttonStartNewGame.Click += new System.EventHandler(this.ButtonStartNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.buttonStartNewGame);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonStartNewGame;
    }
}

