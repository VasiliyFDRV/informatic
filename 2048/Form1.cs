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
        private Map lastPos = new Map();
        public Form1()
        {
            InitializeComponent();
            foreach (Button l in Controls.OfType<Button>())
            {
                l.TextChanged += (s, a) =>
                {
                    l.FlatAppearance.BorderSize = 0;
                    l.FlatStyle = FlatStyle.Flat;
                };
            }
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            model.Start();
            LoseLabel.Hide();
            esc.Show();
            Desine();
            Rewrite();
        }

        private void Desine()
        {
            foreach (Button l in Controls.OfType<Button>())
            {
                l.TextChanged += (s, a) =>
                {

                    if (l.Text == "0" || l.Text == "") { l.Text = ""; l.BackColor = Color.FromArgb(75, 75, 75); }
                    else if(l.Text == "2") { l.BackColor = Color.LightGray; l.ForeColor = Color.FromArgb(69, 50, 46); }
                    else if(l.Text == "4") { l.BackColor = Color.DarkGray; l.ForeColor = Color.FromArgb(69, 50, 46); }
                    else if(l.Text == "8") { l.BackColor = Color.LightSalmon; l.ForeColor = Color.White; }
                    else if (l.Text == "16") { l.BackColor = Color.Salmon; l.ForeColor = Color.White; }
                    else if(l.Text == "32") { l.BackColor = Color.Tomato; l.ForeColor = Color.White; }
                    else if (l.Text == "64") { l.BackColor = Color.OrangeRed; l.ForeColor = Color.White; }
                    else if (l.Text == "128") { l.BackColor = Color.Khaki; l.ForeColor = Color.White; }
                    else if (l.Text == "256") { l.BackColor = Color.FromArgb(255, 240, 120); l.ForeColor = Color.White; }
                    else if (l.Text == "512") { l.BackColor = Color.FromArgb(255, 230, 110); l.ForeColor = Color.White; }
                    else if (l.Text == "1024") { l.BackColor = Color.FromArgb(255, 225, 115); l.ForeColor = Color.White; }
                    else if (l.Text == "2048") 
                    {
                        l.BackColor = Color.Gold; l.ForeColor = Color.White;
                        LoseLabel.Text = "YOU WON!";
                        LoseLabel.Show();
                        esc.Hide();
                    }
                    
                    else { l.Text = "Error"; l.BackColor = Color.Red; l.ForeColor = Color.White; }


                };
            }
        }

        private void Rewrite()
        {
            button1.Text = $"{model.map.Get(0, 0)}";
            button2.Text = $"{model.map.Get(0, 1)}";
            button3.Text = $"{model.map.Get(0, 2)}";
            button4.Text = $"{model.map.Get(0, 3)}";
            button5.Text = $"{model.map.Get(1, 0)}";
            button6.Text = $"{model.map.Get(1, 1)}";
            button7.Text = $"{model.map.Get(1, 2)}";
            button8.Text = $"{model.map.Get(1, 3)}";
            button9.Text = $"{model.map.Get(2, 0)}";
            button10.Text = $"{model.map.Get(2, 1)}";
            button11.Text = $"{model.map.Get(2, 2)}";
            button12.Text = $"{model.map.Get(2, 3)}";
            button13.Text = $"{model.map.Get(3, 0)}";
            button14.Text = $"{model.map.Get(3, 1)}";
            button15.Text = $"{model.map.Get(3, 2)}";
            button16.Text = $"{model.map.Get(3, 3)}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                for (int x = 0; x < 4; x++)
                    for (int y = 0; y < 4; y++)
                    { lastPos.Set(x, y, model.map.Get(x, y)); }
            }

            Desine();
            if (e.KeyValue==(char)Keys.A)
            {
                model.Left();
                Rewrite();
            }
            if (e.KeyValue == (char)Keys.D)
            {
                model.Right();
                Rewrite();
            }
            if (e.KeyValue == (char)Keys.W )
            {
                model.Up();
                Rewrite();
            }
            if (e.KeyValue == (char)Keys.S )
            {
                model.Down();
                Rewrite();
            }
            if (model.IsGameOver())
            {
                LoseLabel.Show();
                esc.Hide();
            }
            label.Text = $"Очки: {model.Score}";
        }

        private void esc_Click(object sender, EventArgs e)
        {
        for (int x = 0; x < 4; x++)
            for (int y = 0; y < 4; y++)
                { model.map.Set(x, y, lastPos.Get(x, y)); }
        Rewrite();
        }

        private void New_Click(object sender, EventArgs e)
        {
            model.Start();
            LoseLabel.Hide();
            esc.Show();
            Desine();
            Rewrite();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
