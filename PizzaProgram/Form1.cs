using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProgram
{
    public partial class Form1 : Form
    {
        const double pizza = 7;
        const double topping = 1.25;
        int numberTopping;
        double priceTopping;
        double price;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //name
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.FillRectangle(drawBrush, 0, 0, 1000, 50);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.White);
            Font drawFont2 = new Font("MV Boli", 16, FontStyle.Bold);
            g.DrawString("Rams Pizza Parlour", drawFont2, drawBrush2, 190, 10);
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberTopping = Convert.ToInt16(numberToppings.Text);
                priceTopping = numberTopping * topping;
                price = pizza + priceTopping;
                outputLabel.Text = "Your total price " + price.ToString("C");
            }
            catch
            {
                outputLabel.Text = "Enter a number of toppings please";
            }
        }
    }
}
