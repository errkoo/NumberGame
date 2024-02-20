namespace NumberGame
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.userGuess = new System.Windows.Forms.TextBox();
            this.guessNumber = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftGuess = new System.Windows.Forms.Label();
            this.userHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(271, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess the Number!";
            // 
            // userGuess
            // 
            this.userGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userGuess.Location = new System.Drawing.Point(151, 195);
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(189, 44);
            this.userGuess.TabIndex = 1;
            // 
            // guessNumber
            // 
            this.guessNumber.Location = new System.Drawing.Point(406, 195);
            this.guessNumber.Name = "guessNumber";
            this.guessNumber.Size = new System.Drawing.Size(143, 44);
            this.guessNumber.TabIndex = 2;
            this.guessNumber.Text = "Guess";
            this.guessNumber.UseVisualStyleBackColor = true;
            this.guessNumber.Click += new System.EventHandler(this.guessNumber_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(158, 299);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(145, 25);
            this.text1.TabIndex = 3;
            this.text1.Text = "Guesses Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hint:";
            // 
            // leftGuess
            // 
            this.leftGuess.AutoSize = true;
            this.leftGuess.Location = new System.Drawing.Point(309, 299);
            this.leftGuess.Name = "leftGuess";
            this.leftGuess.Size = new System.Drawing.Size(19, 25);
            this.leftGuess.TabIndex = 5;
            this.leftGuess.Text = "-";
            // 
            // userHint
            // 
            this.userHint.AutoSize = true;
            this.userHint.Location = new System.Drawing.Point(220, 348);
            this.userHint.Name = "userHint";
            this.userHint.Size = new System.Drawing.Size(19, 25);
            this.userHint.TabIndex = 6;
            this.userHint.Text = "-";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userHint);
            this.Controls.Add(this.leftGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.guessNumber);
            this.Controls.Add(this.userGuess);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Button guessNumber;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label leftGuess;
        private System.Windows.Forms.Label userHint;
    }
}