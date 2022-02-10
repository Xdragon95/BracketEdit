using BracketEdit;
using System;
using System.IO;
using System.Windows.Forms;

//Things to add (if possible)
//Button to add an remove groups (Instead of this we're gonna hide and show shit)
//Display save file locations being used (DONE in seperate proj)
//Save files without poping up a savedialog (DONE in seperate proj)
//Import Names from Challonge and Smashgg

namespace WindowsFormsApp1
{
    public partial class BracketEditMain : Form
    {
        public BracketEditMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int d = 0;
        private int f = 0;
        private int g = 0;
        private int h = 0;
        private int i = 0;
        private void PlayerAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerAdd.Text))
                return;
            listBox1.Items.Add(PlayerAdd.Text);
            Name1.Items.Add(PlayerAdd.Text);
            Name2.Items.Add(PlayerAdd.Text);
            Name3.Items.Add(PlayerAdd.Text);
            Name4.Items.Add(PlayerAdd.Text);
            Name5.Items.Add(PlayerAdd.Text);
            Name6.Items.Add(PlayerAdd.Text);
            Name7.Items.Add(PlayerAdd.Text);
            Name8.Items.Add(PlayerAdd.Text);
            PlayerAdd.Text = "";
        }
        private void PlayerClear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            if (Name1.Items.Count > 0)
                Name1.Items.Clear();
            if (Name2.Items.Count > 0)
                Name2.Items.Clear();
            if (Name3.Items.Count > 0)
                Name3.Items.Clear();
            if (Name4.Items.Count > 0)
                Name4.Items.Clear();
            if (Name5.Items.Count > 0)
                Name5.Items.Clear();
            if (Name6.Items.Count > 0)
                Name6.Items.Clear();
            if (Name7.Items.Count > 0)
                Name7.Items.Clear();
            if (Name8.Items.Count > 0)
                Name8.Items.Clear();
            Name1.Text = "";
            Name2.Text = "";
            Name3.Text = "";
            Name4.Text = "";
            Name5.Text = "";
            Name6.Text = "";
            Name7.Text = "";
            Name8.Text = "";
        }
        private void ClearScores_Click(object sender, EventArgs e)
        {
            Score1.Text = "0";
            Score2.Text = "0";
            Score3.Text = "0";
            Score4.Text = "0";
            Score5.Text = "0";
            Score6.Text = "0";
            Score7.Text = "0";
            Score8.Text = "0";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
        }
        private void Score1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }
        private void Score5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Score8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void Export1_Click(object sender, EventArgs e)
        {
            if
                (FolderLocation.Text == "")
            {
                MessageBox.Show("Specify a folder to save to.");
                return;
            }
            if
                (G1P1NameLocation.Text != "" || G1P1ScoreLocation.Text != "" || G1P2NameLocation.Text != "" || G1P2ScoreLocation.Text != "")
            {
                File.WriteAllText(FolderLocation.Text + "\\" + G1P1NameLocation.Text, Name1.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G1P1ScoreLocation.Text, Score1.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G1P2NameLocation.Text, Name2.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G1P2ScoreLocation.Text, Score2.Text);
            }
            else
            {
                MessageBox.Show("Specify locations for all of your files.");
            }
        }
        private void Export2_Click(object sender, EventArgs e)
        {
            if
                (FolderLocation.Text == "")
            {
                MessageBox.Show("Specify a folder to save to.");
                return;
            }
            if
                (G2P1NameLocation.Text != "" || G2P1ScoreLocation.Text != "" || G2P2NameLocation.Text != "" || G2P2ScoreLocation.Text != "")
            {
                File.WriteAllText(FolderLocation.Text + "\\" + G2P1NameLocation.Text, Name3.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G2P1ScoreLocation.Text, Score3.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G2P2NameLocation.Text, Name4.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G2P2ScoreLocation.Text, Score4.Text);
            }
            else
            {
                MessageBox.Show("Specify locations for all of your files.");
            }
        }
        private void Export3_Click(object sender, EventArgs e)
        {
            if
                (FolderLocation.Text == "")
            {
                MessageBox.Show("Specify a folder to save to.");
                return;
            }
            if
                (G3P1NameLocation.Text != "" || G3P1ScoreLocation.Text != "" || G3P2NameLocation.Text != "" || G3P2ScoreLocation.Text != "")
            {
                File.WriteAllText(FolderLocation.Text + "\\" + G3P1NameLocation.Text, Name5.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G3P1ScoreLocation.Text, Score5.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G3P2NameLocation.Text, Name6.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G3P2ScoreLocation.Text, Score6.Text);
            }
            else
            {
                MessageBox.Show("Specify locations for all of your files.");
            }
        }
        private void Export4_Click(object sender, EventArgs e)
        {
            if
                (FolderLocation.Text == "")
            {
                MessageBox.Show("Specify a folder to save to.");
                return;
            }
            if
                (G4P1NameLocation.Text != "" || G4P1ScoreLocation.Text != "" || G4P2NameLocation.Text != "" || G4P2ScoreLocation.Text != "")
            {
                File.WriteAllText(FolderLocation.Text + "\\" + G4P1NameLocation.Text, Name7.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G4P1ScoreLocation.Text, Score7.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G4P2NameLocation.Text, Name8.Text);
                File.WriteAllText(FolderLocation.Text + "\\" + G4P2ScoreLocation.Text, Score8.Text);
            }
            else
            {
                MessageBox.Show("Specify locations for all of your files.");
            }
        }
        private void Add1_Click(object sender, EventArgs e)
        {
            a++;
            Score1.Text = a.ToString();
            
        }
        private void Minus1_Click(object sender, EventArgs e)
        {
            a--;
            Score1.Text = a.ToString();
            if (a < 0)
            {
                a = 0;
                Score1.Text = "0";
            }
        }
        private void Add2_Click(object sender, EventArgs e)
        {
            b++;
            Score2.Text = b.ToString();
        }
        private void Minus2_Click(object sender, EventArgs e)
        {
            b--;
            Score2.Text = b.ToString();
            if (b < 0)
            {
                b = 0;
                Score2.Text = "0";
            }
        }
        private void Add3_Click(object sender, EventArgs e)
        {
            c++;
            Score3.Text = c.ToString();
        }
        private void Minus3_Click(object sender, EventArgs e)
        {
            c--;
            Score3.Text = c.ToString();
            if (c < 0)
            {
                c = 0;
                Score3.Text = "0";
            }
        }
        private void Add4_Click(object sender, EventArgs e)
        {
            d++;
            Score4.Text = d.ToString();
        }
        private void Minus4_Click(object sender, EventArgs e)
        {
            d--;
            Score4.Text = d.ToString();
            if (d < 0)
            {
                d = 0;
                Score4.Text = "0";
            }

        }
        private void Add5_Click(object sender, EventArgs e)
        {
            f++;
            Score5.Text = f.ToString();
        }
        private void Minus5_Click(object sender, EventArgs e)
        {
            f--;
            Score5.Text = f.ToString();
            if (f < 0)
            {
                f = 0;
                Score5.Text = "0";
            }
        }
        private void Add6_Click(object sender, EventArgs e)
        {
            g++;
            Score6.Text = g.ToString();
        }
        private void Minus6_Click(object sender, EventArgs e)
        {
            g--;
            Score6.Text = g.ToString();
            if (g < 0)
            {
                g = 0;
                Score6.Text = "0";
            }

        }
        private void Add7_Click(object sender, EventArgs e)
        {
            h++;
            Score7.Text = h.ToString();
        }
        private void Minus7_Click(object sender, EventArgs e)
        {
            h--;
            Score7.Text = h.ToString();
            if (h < 0)
            {
                h = 0;
                Score7.Text = "0";
            }

        }
        private void Add8_Click(object sender, EventArgs e)
        {
            i++;
            Score8.Text = i.ToString();
        }
        private void Minus8_Click(object sender, EventArgs e)
        {
            i--;
            Score8.Text = i.ToString();
            if (i < 0)
            {
                i = 0;
                Score8.Text = "0";
            }

        }
        private void SetGroup1_CheckedChanged(object sender, EventArgs e)
        {
            if (SetGroup1.Checked == true)
            {
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
            }
        }
        private void SetGroup2_CheckedChanged(object sender, EventArgs e)
        {
            if (SetGroup2.Checked == true)
            {
                groupBox2.Show();
                groupBox3.Hide();
                groupBox4.Hide();
            }
        }
        private void SetGroup4_CheckedChanged(object sender, EventArgs e)
        {
            if (SetGroup4.Checked == true)
            {
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
            }
        }
        private void SetFileNames1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Set Player 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                G1P1NameLocation.Text = openFileDialog.SafeFileName;
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                Title = "Set Score 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                G1P1ScoreLocation.Text = openFileDialog2.SafeFileName;
            }
            OpenFileDialog openFileDialog3 = new OpenFileDialog
            {
                Title = "Set Player 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                G1P2NameLocation.Text = openFileDialog3.SafeFileName;
            }
            OpenFileDialog openFileDialog4 = new OpenFileDialog
            {
                Title = "Set Score 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                G1P2ScoreLocation.Text = openFileDialog4.SafeFileName;
            }
        }
        private void SetFileNames2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Set Player 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                G2P1NameLocation.Text = openFileDialog.SafeFileName;
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                Title = "Set Score 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                G2P1ScoreLocation.Text = openFileDialog2.SafeFileName;
            }
            OpenFileDialog openFileDialog3 = new OpenFileDialog
            {
                Title = "Set Player 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                G2P2NameLocation.Text = openFileDialog3.SafeFileName;
            }
            OpenFileDialog openFileDialog4 = new OpenFileDialog
            {
                Title = "Set Score 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                G2P2ScoreLocation.Text = openFileDialog4.SafeFileName;
            }
        }
        private void SetFileNames3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Set Player 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                G3P1NameLocation.Text = openFileDialog.SafeFileName;
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                Title = "Set Score 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                G3P1ScoreLocation.Text = openFileDialog2.SafeFileName;
            }
            OpenFileDialog openFileDialog3 = new OpenFileDialog
            {
                Title = "Set Player 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                G3P2NameLocation.Text = openFileDialog3.SafeFileName;
            }
            OpenFileDialog openFileDialog4 = new OpenFileDialog
            {
                Title = "Set Score 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                G3P2ScoreLocation.Text = openFileDialog4.SafeFileName;
            }
        }
        private void SetFileNames4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Set Player 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                G4P1NameLocation.Text = openFileDialog.SafeFileName;
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                Title = "Set Score 1",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                G4P1ScoreLocation.Text = openFileDialog2.SafeFileName;
            }
            OpenFileDialog openFileDialog3 = new OpenFileDialog
            {
                Title = "Set Player 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                G4P2NameLocation.Text = openFileDialog3.SafeFileName;
            }
            OpenFileDialog openFileDialog4 = new OpenFileDialog
            {
                Title = "Set Score 2",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = ""
            };
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                G4P2ScoreLocation.Text = openFileDialog4.SafeFileName;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FolderLocation.Text = dialog.SelectedPath;
            }
        }
        private void OpenScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard f = new Scoreboard();
            f.Show();
        }
        private void ActiveMatch1_Click(object sender, EventArgs e)
        {
            Scoreboard frm = new Scoreboard(Name1.Text, Name2.Text, Score1.Text, Score2.Text);
            frm.Show();
        }

        private void ActiveMatch2_Click(object sender, EventArgs e)
        {
            Scoreboard frm = new Scoreboard(Name3.Text, Name4.Text, Score3.Text, Score4.Text);
            frm.Show();
        }

        private void ActiveMatch3_Click(object sender, EventArgs e)
        {
            Scoreboard frm = new Scoreboard(Name5.Text, Name6.Text, Score5.Text, Score6.Text);
            frm.Show();
        }

        private void ActiveMatch4_Click(object sender, EventArgs e)
        {
            Scoreboard frm = new Scoreboard(Name7.Text, Name8.Text, Score7.Text, Score8.Text);
            frm.Show();
        }
    }
}