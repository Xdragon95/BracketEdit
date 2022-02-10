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
//send stuff back to bracketedit
namespace BracketEdit
{
    public partial class Scoreboard : Form
    {
        public Scoreboard(string strTextBox, string strTextBox2, string strTextBox3, string strTextBox4)
        {
            InitializeComponent();
            P1Name.Text = strTextBox;
            P2Name.Text = strTextBox2;
            P1Score.Text = strTextBox3;
            P2Score.Text = strTextBox4;
        }

        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {

        }
        private int a = 0;
        private int b = 0;

        private void P1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void P2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void GetFolderLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FolderLocation.Text = dialog.SelectedPath;
            }
        }

        private void P1ScoreAdd_Click(object sender, EventArgs e)
        {
            a++;
            P1Score.Text = a.ToString();
        }

        private void P2ScoreAdd_Click(object sender, EventArgs e)
        {
            b++;
            P2Score.Text = b.ToString();
        }

        private void P1ScoreMinus_Click(object sender, EventArgs e)
        {
            a--;
            P1Score.Text = a.ToString();
            if (a < 0)
            {
                a = 0;
                P1Score.Text = "0";
            }
        }

        private void P2ScoreMinus_Click(object sender, EventArgs e)
        {
            b--;
            P2Score.Text = a.ToString();
            if (b < 0)
            {
                b = 0;
                P2Score.Text = "0";
            }
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            string text1 = P1Name.Text;
            string score1 = P1Score.Text;
            P1Name.Text = P2Name.Text;
            P1Score.Text = P2Score.Text;
            P2Name.Text = text1;
            P2Score.Text = score1;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            P1Name.Text = "";
            P1Score.Text = "0";
            P2Name.Text = "";
            P2Score.Text = "0";
        }

        private void BracketLocation_TextChanged(object sender, EventArgs e)
        {
            if
                (BracketLocation.Text == "WF")
            {
                BracketLocation.Text = "Winners Final";
            }
            else if (BracketLocation.Text == "wf")
            {
                BracketLocation.Text = "Winners Final";
            }
            else if (BracketLocation.Text == "Wf")
            {
                BracketLocation.Text = "Winners Final";
            }
            else if (BracketLocation.Text == "wF")
            {
                BracketLocation.Text = "Winners Final";
            }
            else if
                (BracketLocation.Text == "LF")
            {
                BracketLocation.Text = "Losers Final";
            }
            else if (BracketLocation.Text == "lf")
            {
                BracketLocation.Text = "Losers Final";
            }
            else if (BracketLocation.Text == "Lf")
            {
                BracketLocation.Text = "Losers Final";
            }
            else if (BracketLocation.Text == "lF")
            {
                BracketLocation.Text = "Losers Final";
            }
            else if
                (BracketLocation.Text == "WS")
            {
                BracketLocation.Text = "Winners Semis";
            }
            else if (BracketLocation.Text == "ws")
            {
                BracketLocation.Text = "Winners Semis";
            }
            else if (BracketLocation.Text == "Ws")
            {
                BracketLocation.Text = "Winners Semis";
            }
            else if (BracketLocation.Text == "wS")
            {
                BracketLocation.Text = "Winners Semis";
            }
            else if
               (BracketLocation.Text == "GF")
            {
                BracketLocation.Text = "Grand Finals";
            }
            else if (BracketLocation.Text == "gf")
            {
                BracketLocation.Text = "Grand Finals";
            }
            else if (BracketLocation.Text == "Gf")
            {
                BracketLocation.Text = "Grand Finals";
            }
            else if (BracketLocation.Text == "gF")
            {
                BracketLocation.Text = "Grand Finals";
            }
        }

        private void SaveAll_Click(object sender, EventArgs e)
        {
            if
                (FolderLocation.Text == "")
            {
                MessageBox.Show("Specify a folder to save to.");
                return;
            }
            if
                (FolderLocation.Text != "")
            {
                File.WriteAllText(FolderLocation.Text + "\\Player 1 Name.txt", P1Name.Text);
                File.WriteAllText(FolderLocation.Text + "\\Player 1 Score.txt", P1Score.Text);
                File.WriteAllText(FolderLocation.Text + "\\Player 2 Name.txt", P2Name.Text);
                File.WriteAllText(FolderLocation.Text + "\\Player 2 Score.txt", P2Score.Text);
                File.WriteAllText(FolderLocation.Text + "\\Bracket Placement.txt", BracketLocation.Text);
            }
            else
            {
                MessageBox.Show("Specify locations for all of your files.");
            }
        }
    }
    
}
