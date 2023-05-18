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

            int i;
            for (i = 0; i < listRowControl.Count; i++)
            {
                listRowControl[i].Clear();
            }
            game = new Game(4);

            //listRowControl.Add(new RowControl(this.lblGuess1, lblBulls8, lblCows1))

        }
        private void Render()
        {
            int i;
            for (i = 0; i < game.listGuessNumberHistory.Count; i++)
            {
                listRowControl[i].lblGuessNumber.Text = game.listGuessNumberHistory[i];
                listRowControl[i].lblBull.Text = game.listGuessResultHistory[i].NumberofBulls.ToString();
                listRowControl[i].lblCow.Text = game.listGuessResultHistory[i].NumberofCows.ToString();

            }
        }

        private void btnCheckResult_Click(object sender, EventArgs e)
        {
            String numberGuess = this.txtGuessNumber.Text;
            game.CheckResult(numberGuess);
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
    }
}
