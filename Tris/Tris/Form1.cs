using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tris
{
    public partial class Form1 : Form
    {
        private List<TrisButton> Griglia;
        private int Winner = 0;

        public Form1()
        {
            InitializeComponent();
            Griglia = new List<TrisButton>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Griglia.Add(trisButton1);
            Griglia.Add(trisButton2);
            Griglia.Add(trisButton3);
            Griglia.Add(trisButton4);
            Griglia.Add(trisButton5);
            Griglia.Add(trisButton6);
            Griglia.Add(trisButton7);
            Griglia.Add(trisButton8);
            Griglia.Add(trisButton9);
            NuovaPartitaToolStripMenuItem_Click(sender, e);
        }

        private void NuovaPartitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGrid();
            Program.Turno = 1;
            this.Text = "Nuova Partita";
        }

        private void ResetGrid()
        {
            foreach (TrisButton b in Griglia)
            {
                b.Reset();
                b.Enabled = true;
                b.Click -= TrisButton_Click;
                b.Click += TrisButton_Click;
            }
            Winner = 0;
            label1.Text = String.Empty;
        }
        private void SwitchTurno()
        {
            Program.Turno = (Program.Turno == 1) ? 2 : 1;
        }

        private int CheckTris(int start, bool bColumnMod = false)
        {
            TrisButton[] array = new TrisButton[3];
            array[0] = Griglia[start];
            if (bColumnMod)
            {
                array[1] = Griglia[start + 3];
                array[2] = Griglia[start + 6];
            }
            else
            {
                array[1] = Griglia[start + 1];
                array[2] = Griglia[start + 2];
            }

            return CheckTris(array);
        }

        private int CheckTris(TrisButton[] array)
        {
            int result;

            if ((array[0].Player == 0) || (array[1].Player == 0) || (array[2].Player == 0)) return 0;

            result = array[0].Player + array[1].Player + array[2].Player;

            switch (result)
            {
                case 3:
                    return 1;
                case 6:
                    return 2;
                default:
                    return 0;
            }
        }

        private bool IsGameFinished()
        {
            //Orizzontali
            Winner = CheckTris(0);
            if (Winner == 0) Winner = CheckTris(3);
            if (Winner == 0) Winner = CheckTris(6);

            //Verticali
            if (Winner == 0) Winner = CheckTris(0, true);
            if (Winner == 0) Winner = CheckTris(1, true);
            if (Winner == 0) Winner = CheckTris(2, true);

            //Diagonali
            if (Winner == 0) Winner = CheckTris(new TrisButton[] { Griglia[0], Griglia[4], Griglia[8] });
            if (Winner == 0) Winner = CheckTris(new TrisButton[] { Griglia[2], Griglia[4], Griglia[6] });

            if (Winner != 0)  {
                label1.Text = String.Format("Il giocatore {0} ha vinto!", Winner);
                return true;
            };

            foreach (TrisButton btn in Griglia)
            {
                if (btn.Text == String.Empty) return false;
            }
            return true;
        }

        private void EndGame()
        {
            if (IsGameFinished() == false) return;
            this.Text = "Partita terminata!";
            foreach (TrisButton btn in Griglia)
            {
                btn.Enabled = false;
            }
        }

        private void TrisButton_Click(object sender, EventArgs e)
        {
            TrisButton btn = (TrisButton)sender;
            switch (Program.Turno)
            {
                case 1:
                    btn.Text = "O";
                    btn.Player = 1;
                    SwitchTurno();
                    break;
                case 2:
                    btn.Text = "X";
                    btn.Player = 2;
                    SwitchTurno();
                    break;
            }
            EndGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) e.Cancel = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}
