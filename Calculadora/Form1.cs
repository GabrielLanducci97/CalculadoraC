using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumulatedValue;
        public Form1()
        {
            InitializeComponent();
        }
		private void NumberAction_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			int buttonValue = int.Parse(button.Text);
			int currentValue = int.Parse(textValue.Text);
			currentValue = currentValue * 10 + buttonValue;

			textValue.Text = currentValue.ToString(); 
		}

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = int.Parse(textValue.Text);
            textValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty;
        }

        private void btnOpIgual_Click(object sender, EventArgs e)
        {
            int secondAcumulatedValue = int.Parse(textValue.Text);
            int result = 0;

            switch (selectedOperator) 
            { 
                case "+" :
					result = acumulatedValue + secondAcumulatedValue;
					break;

				case "-":
					result = acumulatedValue - secondAcumulatedValue;
					break;

				case "x":
					result = acumulatedValue * secondAcumulatedValue;
					break;

				case "/":
					result = acumulatedValue / secondAcumulatedValue;
					break;


			}

			textValue.Text = result.ToString();
        }
    }
}
