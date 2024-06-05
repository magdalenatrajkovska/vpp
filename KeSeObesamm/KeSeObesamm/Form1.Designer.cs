namespace KeSeObesamm
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
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.pbWrongTries = new System.Windows.Forms.ProgressBar();
            this.tbGuessedLetters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTryLetter = new System.Windows.Forms.Button();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.tbWordState = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(52, 414);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(838, 32);
            this.pbTimer.TabIndex = 15;
            // 
            // pbWrongTries
            // 
            this.pbWrongTries.Location = new System.Drawing.Point(52, 363);
            this.pbWrongTries.Name = "pbWrongTries";
            this.pbWrongTries.Size = new System.Drawing.Size(838, 32);
            this.pbWrongTries.TabIndex = 14;
           
            // 
            // tbGuessedLetters
            // 
            this.tbGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGuessedLetters.Location = new System.Drawing.Point(52, 287);
            this.tbGuessedLetters.Name = "tbGuessedLetters";
            this.tbGuessedLetters.ReadOnly = true;
            this.tbGuessedLetters.Size = new System.Drawing.Size(838, 45);
            this.tbGuessedLetters.TabIndex = 13;
            this.tbGuessedLetters.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Guessed Letters";
            // 
            // btnTryLetter
            // 
            this.btnTryLetter.Location = new System.Drawing.Point(283, 162);
            this.btnTryLetter.Name = "btnTryLetter";
            this.btnTryLetter.Size = new System.Drawing.Size(82, 45);
            this.btnTryLetter.TabIndex = 11;
            this.btnTryLetter.Text = "OK";
            this.btnTryLetter.UseVisualStyleBackColor = true;
            this.btnTryLetter.Click += new System.EventHandler(this.btnTryLetter_Click);
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLetter.Location = new System.Drawing.Point(52, 162);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(198, 45);
            this.tbLetter.TabIndex = 10;
            // 
            // tbWordState
            // 
            this.tbWordState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWordState.Location = new System.Drawing.Point(52, 66);
            this.tbWordState.Name = "tbWordState";
            this.tbWordState.ReadOnly = true;
            this.tbWordState.Size = new System.Drawing.Size(598, 45);
            this.tbWordState.TabIndex = 9;
            // 
            // tbTimer
            // 
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimer.Location = new System.Drawing.Point(742, 12);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(150, 45);
            this.tbTimer.TabIndex = 8;
            this.tbTimer.Text = "02:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pbWrongTries);
            this.Controls.Add(this.tbGuessedLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTryLetter);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.tbWordState);
            this.Controls.Add(this.tbTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.ProgressBar pbWrongTries;
        private System.Windows.Forms.TextBox tbGuessedLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTryLetter;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.TextBox tbWordState;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

