using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Eyes
{
    public partial class SnakeEyesForm : Form
    {
        public SnakeEyesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            SnakeEyes snakeEyes = new SnakeEyes();

            snakeEyes.RollDice();
        }
    }
    class SnakeEyes
    {
        private int Face1;
        private int Face2;

        public SnakeEyes()
        {
            Face1 = 0;
            Face2 = 0;
        }

        public void RollDice()
        {
            Random random = new Random();
            int Dice1 = random.Next(1, 6);
            int Dice2 = random.Next(1, 6);

          

            if (( Dice1 & Dice2) == 1)
            {
                MessageBox.Show("Snake Eyes! Program End");
            }
                  
            Face1 = Dice1;
            Face2 = Dice2;

            MessageBox.Show(Face1.ToString() + " and " + Face2.ToString());
        }

    } // for SnakeEyes Class


} // for namespace
