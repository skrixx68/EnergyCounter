using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnergyCounterCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label decreaseBy1(Label label)
        {
            label.Text = (int.Parse(label.Text) - 1).ToString();
            return label;
        }
        private Label increaseBy1(Label label)
        {
            label.Text = (int.Parse(label.Text) + 1).ToString();
            return label;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_energyUsedDecrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyUsed.Text) != 0)
            {
                lbl_energyCount = increaseBy1(lbl_energyCount);
                lbl_energyUsed = decreaseBy1(lbl_energyUsed);
            }
        }

        private void btn_energyUsedIncrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyCount.Text) != 0)
            {
                lbl_energyCount = decreaseBy1(lbl_energyCount);
                lbl_energyUsed = increaseBy1(lbl_energyUsed);
            }
        }

        private void btn_energyGainDecrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyGained.Text) != 0)
            {
                lbl_energyCount = decreaseBy1(lbl_energyCount);
                lbl_energyGained = decreaseBy1(lbl_energyGained);
            }
        }

        private void btn_energyGainIncrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyCount.Text) != 10)
            {
                lbl_energyCount = increaseBy1(lbl_energyCount);
                lbl_energyGained = increaseBy1(lbl_energyGained);
            }
        }

        private void btn_energyDestroyDecrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyDestroyed.Text) != 0)
            {
                lbl_energyCount = increaseBy1(lbl_energyCount);
                lbl_energyDestroyed = decreaseBy1(lbl_energyDestroyed);
            }
        }

        private void btn_energyDestroyIncrement_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_energyCount.Text) != 0)
            {
                lbl_energyCount = decreaseBy1(lbl_energyCount);
                lbl_energyDestroyed = increaseBy1(lbl_energyDestroyed);
            }
        }

        int round = 1;
        int lastEnergy = 3;
        private void btn_endTurn_Click(object sender, EventArgs e)
        {
            round++;
            lbl_energyCount.Text = (int.Parse(lbl_energyCount.Text) + 2).ToString();
            lbl_energyDestroyed.Text = "0";
            lbl_energyGained.Text = "0";
            lbl_energyUsed.Text = "0";
            lastEnergy = int.Parse(lbl_energyCount.Text);
            lbl_roundCount.Text = round.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_energyCount.Text = lastEnergy.ToString();
            lbl_energyDestroyed.Text = "0";
            lbl_energyGained.Text = "0";
            lbl_energyUsed.Text = "0";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            round = 1;
            lastEnergy = 3;
            lbl_roundCount.Text = "1";
            lbl_energyCount.Text = "3";
            lbl_energyDestroyed.Text = "0";
            lbl_energyGained.Text = "0";
            lbl_energyUsed.Text = "0";
        }
    }
}
