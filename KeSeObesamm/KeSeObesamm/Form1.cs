using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeSeObesamm
{
    public partial class Form1 : Form

    {
        public RandomPicker randomPicker { get; set; }
        public HangmanWord hangmanWord { get; set; }
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            randomPicker = new RandomPicker();
            this.init();
        }
        private void updateTextBoxes()
        {
            tbWordState.Text = hangmanWord.GetMaskedWord();
            tbGuessedLetters.Text = hangmanWord.GetMaskedGuessedLetters();
        }
        private void init()
        {
            hangmanWord = new HangmanWord(randomPicker.pick());
            tbTimer.Text = "02:00";
            updateTextBoxes();
            pbWrongTries.Maximum = HangmanWord.MAX_RETRIES;
            pbWrongTries.Value = 0;
            timeLeft = 120;
            timer1.Start();

            pbTimer.Maximum = 120;
            pbTimer.Value = 120;
        }
       

        private void btnTryLetter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLetter.Text))
            {
                char letter = tbLetter.Text[0];
                hangmanWord.GuessLetter(letter);
                updateTextBoxes();
                pbWrongTries.Value = hangmanWord.WrongCount;
                if (hangmanWord.Win())
                {
                    timer1.Stop();
                    //i ovaj shit mozi da go optimiziram ama nvm
                    DialogResult dr = MessageBox.Show("YOU WIN, AGAIN?", "Game over", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        //new game
                        init();
                    }
                    else
                    {
                        this.Close();

                    }
                }
                else if (hangmanWord.Lose())
                {
                    timer1.Stop();
                    DialogResult dr = MessageBox.Show("YOU LOSE, AGAIN?", "Game over", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        //new game
                        init();
                    }
                    else
                    {
                        this.Close();

                    }

                }

            }
            tbLetter.Text = "";

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLeft -= 1;
            tbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            pbTimer.Value = timeLeft;

            if (timeLeft <= 0)
            {
                timer1.Stop();
                
                DialogResult dr = MessageBox.Show("YOU LOSE, AGAIN?", "Game over", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //new game
                    init();



                }
                else
                {
                    this.Close();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
