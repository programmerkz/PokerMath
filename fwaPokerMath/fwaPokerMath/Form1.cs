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
        private Dice _myDice;
        private Random _myRnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDice_Click(object sender, EventArgs e)
        {
            _myDice = null;

            try
            {
                _myDice = new Dice((byte)nudFaceNumber.Value, (byte)nudDiceNumber.Value);
            }
            catch (Exception ex)
            {
                txtConsole.AppendText("Ошибка создания набора костей. \r\n");

                if (chkPrintException.Checked)
                    txtConsole.AppendText($"Исключение:\r\n{ex} \r\n");
                else
                    txtConsole.AppendText($"Исключение:\r\n{ex.Message} \r\n");
            }

            if (_myDice != null)
                txtConsole.AppendText("Набор костей успешно создан. \r\n");
        }

        private void txtClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void btnGetStatistic_Click(object sender, EventArgs e)
        {
            if (_myDice == null)
                txtConsole.AppendText("Ошибка! Набор костей не создан. Статистику не собрать. \r\n");
            else
            {
                if (chkDiceDouble.Checked == false)
                {
                    uint[] diceStat = new uint[1 + _myDice.FaceNumber * _myDice.DiceNumber];
                    Random rnd = new Random();

                    // сбор статистики
                    for (uint i = 0; i < nudIterCount.Value; i++)
                        diceStat[_myDice.Roll(rnd)]++;

                    //вывод статистики
                    txtConsole.AppendText("Собранная статистика:\r\n");
                    for (uint i = 0; i < diceStat.Length; i++)
                        txtConsole.AppendText($"{i}\t{diceStat[i]}\r\n");
                }
                else
                {
                    uint[] diceStat = new uint[1 + _myDice.FaceNumber * _myDice.DiceNumber * _myDice.DiceNumber];
                    Random rnd = new Random();

                    // сбор статистики
                    for (uint i = 0; i < nudIterCount.Value; i++)
                        diceStat[_myDice.RollDoble(rnd)]++;

                    //вывод статистики
                    txtConsole.AppendText("Собранная статистика:\r\n");
                    for (uint i = 0; i < diceStat.Length; i++)
                        txtConsole.AppendText($"{i}\t{diceStat[i]}\r\n");
                }
            }
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (_myDice == null)
                txtConsole.AppendText("Ошибка! Набор костей не создан. Кинуть кости нельзя. \r\n");
            else
            {
                if (_myRnd == null)
                    _myRnd = new Random();

                if (chkDiceDouble.Checked)
                    txtConsole.AppendText($"{_myDice.RollDoble(_myRnd)}\r\n");
                else
                    txtConsole.AppendText($"{_myDice.Roll(_myRnd)}\r\n");
            }

        }
    }
}
