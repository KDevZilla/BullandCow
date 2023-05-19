using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullandCow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game game = null;
        public class RowControl
        {
            public Label lblGuessNumber { get; set; }
            public Label lblBull { get; set; }
            public Label lblCow { get; set; }
            public RowControl (Label plblGuessNumber,
                Label plblBull,
                Label plblCow)
            {
                this.lblGuessNumber = plblGuessNumber;
                this.lblBull = plblBull;
                this.lblCow = plblCow;
            }
            public void Clear()
            {
                lblGuessNumber.Text  = "";
                lblBull.Text  = "";
                lblCow.Text  = "";
            }
        }
        private List<RowControl> listRowControl = new List<RowControl>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listRowControl = new List<RowControl>();
            listRowControl.Add(new RowControl(this.lblGuess1, lblBulls1, lblCows1));
            listRowControl.Add(new RowControl(this.lblGuess2, lblBulls2, lblCows2));
            listRowControl.Add(new RowControl(this.lblGuess3, lblBulls3, lblCows3));
            listRowControl.Add(new RowControl(this.lblGuess4, lblBulls4, lblCows4));
            listRowControl.Add(new RowControl(this.lblGuess5, lblBulls5, lblCows5));
            listRowControl.Add(new RowControl(this.lblGuess6, lblBulls6, lblCows6));
            listRowControl.Add(new RowControl(this.lblGuess7, lblBulls7, lblCows7));
            listRowControl.Add(new RowControl(this.lblGuess8, lblBulls8, lblCows8));
            listRowControl.Add(new RowControl(this.lblGuess9, lblBulls9, lblCows9));

            NewGame();
            //listRowControl.Add(new RowControl(this.lblGuess1, lblBulls8, lblCows1))

        }
        private void NewGame()
        {
            int i;
            for (i = 0; i < listRowControl.Count; i++)
            {
                listRowControl[i].Clear();
            }
            int numberofDigit = 4;
            int numberofTimeAllowtoguess = 9;
            game = new Game(numberofDigit, numberofTimeAllowtoguess);
            Render();
        }
        private String InsertSpaceBetweenDigit(String digits)
        {
            StringBuilder strB = new StringBuilder();
            digits.ForEach(x => strB.Append(x).Append(" "));
            return strB.ToString();
        }
        private void Render()
        {
            int i;
            this.lblFin.Text = game.GameResult == Game.GameResultEnum.NotDecide
                                ? "? ? ? ?"
                                : InsertSpaceBetweenDigit(game.SecretNumber);
            for (i = 0; i < game.listGuessNumberHistory.Count; i++)
            {
                listRowControl[i].lblGuessNumber.Text = InsertSpaceBetweenDigit(game.listGuessNumberHistory[i]);
                listRowControl[i].lblBull.Text = game.listGuessResultHistory[i].NumberofBulls.ToString();
                listRowControl[i].lblCow.Text = game.listGuessResultHistory[i].NumberofCows.ToString();

                listRowControl[i].lblBull.ForeColor = Color.Black;
                listRowControl[i].lblCow.ForeColor = Color.Black;

                if (int.Parse ( listRowControl[i].lblBull.Text) > 0)
                {
                    listRowControl[i].lblBull.ForeColor = Color.Teal;
                }

                if (int.Parse(listRowControl[i].lblCow.Text) > 0)
                {
                    listRowControl[i].lblCow.ForeColor = Color.Teal;
                }


                /*
                if (game.GameResult != Game.GameResultEnum.NotDecide)
                {
                    this.lblFin.Text = InsertSpaceBetweenDigit(game.SecretNumber);
                }
                */
            }
        }

        private void btnCheckResult_Click(object sender, EventArgs e)
        {

            if(this.txtGuessNumber.Text.Trim ().Length !=
                game.DigitLength)
            {
                MessageBox.Show($"Please enter number {game.DigitLength} length");
                return;
            }
            

            String numberGuess = this.txtGuessNumber.Text;
            try
            {
                game.CheckResult(numberGuess);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Render();
            this.txtGuessNumber.Text = "";
            if(game.GameResult == Game.GameResultEnum.Win)
            {
                MessageBox.Show("You won");
                return;
            }
            if(game.GameResult == Game.GameResultEnum.Lose)
            {
                MessageBox.Show("You lost");
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show ("Do you want to exit ?","", MessageBoxButtons.OKCancel ) != DialogResult.OK)
            {
                return;
            }
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);

        }
    }
}
