using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(numericUpDownFirst.Value);
            double second = Convert.ToDouble(numericUpDownSecond.Value);
            double Result = first + second;
            labelResult.Text = Result.ToString();

            listBoxLastOp.Items.Insert(0, first.ToString() + " + " + second.ToString() + " = " + Result.ToString());
            if (listBoxLastOp.Items.Count == 6)
                listBoxLastOp.Items.RemoveAt(listBoxLastOp.Items.Count-1);
        }

        private void buttonDifference_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(numericUpDownFirst.Value);
            double second = Convert.ToDouble(numericUpDownSecond.Value);
            double Result = first - second;
            labelResult.Text = Result.ToString();

            listBoxLastOp.Items.Insert(0, first.ToString() + " - " + second.ToString() + " = " + Result.ToString());
            if (listBoxLastOp.Items.Count == 6)
                listBoxLastOp.Items.RemoveAt(listBoxLastOp.Items.Count - 1);
        }

        private void buttonMultiplay_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(numericUpDownFirst.Value);
            double second = Convert.ToDouble(numericUpDownSecond.Value);
            double Result = first * second;
            labelResult.Text = Result.ToString();

            listBoxLastOp.Items.Insert(0, first.ToString() + " * " + second.ToString() + " = " + Result.ToString());
            if (listBoxLastOp.Items.Count == 6)
                listBoxLastOp.Items.RemoveAt(listBoxLastOp.Items.Count - 1);
        }

        private void buttonDivsion_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(numericUpDownFirst.Value);
            double second = Convert.ToDouble(numericUpDownSecond.Value);
            double Result = first / second;
            labelResult.Text = Result.ToString();

            listBoxLastOp.Items.Insert(0, first.ToString() + " / " + second.ToString() + " = " + Result.ToString());
            if (listBoxLastOp.Items.Count == 6)
                listBoxLastOp.Items.RemoveAt(listBoxLastOp.Items.Count - 1);
        }

        private void numericUpDownSecond_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(numericUpDownSecond.Value) == 0)
                buttonDivsion.Enabled = false;
            else
                buttonDivsion.Enabled = true;
        }

    }
}
