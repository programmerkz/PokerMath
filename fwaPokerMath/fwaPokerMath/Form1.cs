using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fwaPokerMath
{
    public partial class Form1 : Form
    {
        private Dice MyDice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDice_Click(object sender, EventArgs e)
        {
            MyDice = null;

            try
            {
                MyDice = new Dice((byte)nudFaceNumber.Value, (byte)nudDiceNumber.Value);
            }
            catch (Exception ex)
            {
                txtConsole.AppendText("Ошибка создания набора костей. \r\n");

                if (chkPrintException.Checked)
                    txtConsole.AppendText($"Исключение:\r\n{ex} \r\n");
                else
                    txtConsole.AppendText($"Исключение:\r\n{ex.Message} \r\n");
            }

            if (MyDice != null)
                txtConsole.AppendText("Набор костей успешно создан. \r\n");
        }

        private void txtClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }
    }
}
