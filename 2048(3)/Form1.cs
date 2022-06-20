using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {

        Model model = new Model();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.A)
            {
                model.Left();
                Rewrite();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            model.Start();
            Rewrite();
        }

        private void Rewrite()
        {
            button1.Text = $"{model.map1[0, 0]}";
            button2.Text = $"{model.map1[0, 1]}";
            button3.Text = $"{model.map1[0, 2]}";
            button4.Text = $"{model.map1[0, 3]}";
            button5.Text = $"{model.map1[1, 0]}";
            button6.Text = $"{model.map1[1, 1]}";
            button7.Text = $"{model.map1[1, 2]}";
            button8.Text = $"{model.map1[1, 3]}";
            button9.Text = $"{model.map1[2, 0]}";
            button10.Text = $"{model.map1[2, 1]}";
            button11.Text = $"{model.map1[2, 2]}";
            button12.Text = $"{model.map1[2, 3]}";
            button13.Text = $"{model.map1[3, 0]}";
            button14.Text = $"{model.map1[3, 1]}";
            button15.Text = $"{model.map1[3, 2]}";
            button16.Text = $"{model.map1[3, 3]}";
        }
    }
}
