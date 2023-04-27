using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NardOffline
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        private List<Button> buttons = new List<Button>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HighlightButtons()
        {
            for (int i = 0; i < model.checkersList.Count(); i ++) 
            {
                if (model.activeButtons.Contains(i)) buttons[i].Enabled = true;
                else buttons[i].Enabled = false;
            }
        }

        private void UpdateButtons()
        {
            for (int i = 0; i < 24; i++)
            {
                buttons[i].Text = model.checkersList[i].qty.ToString();
                if (model.checkersList[i].color == "white") 
                {
                    buttons[i].BackColor = Color.White;
                    buttons[i].ForeColor = Color.Green;
                }
                else if (model.checkersList[i].color == "black")
                {
                    buttons[i].BackColor = Color.Black;
                    buttons[i].ForeColor = Color.White;
                }
                else
                {
                    buttons[i].BackColor = Color.FromName("Tan");
                    buttons[i].ForeColor = Color.FromName("red");
                }
            }
        }

        private void AddButtons(List<Button> buttons)
        {
            buttons.Add(button1); buttons.Add(button2); buttons.Add(button3);
            buttons.Add(button4); buttons.Add(button5); buttons.Add(button6);
            buttons.Add(button7); buttons.Add(button8); buttons.Add(button9);
            buttons.Add(button10); buttons.Add(button11); buttons.Add(button12);
            buttons.Add(button13); buttons.Add(button14); buttons.Add(button15);
            buttons.Add(button16); buttons.Add(button17); buttons.Add(button18);
            buttons.Add(button19); buttons.Add(button20); buttons.Add(button21);
            buttons.Add(button22); buttons.Add(button23); buttons.Add(button24);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            model.Start();
            AddButtons(buttons);
            StartButton.Text =model.cube1 + "\n" + model.cube2;
            model.ActivateFields1(model.checkersList);
            HighlightButtons();
            UpdateButtons();
        }

        private void FormYourTurnPart1()
        {
            //выбираем шашку
            model.selectedFieldIndex = model.id;
            model.ActivateFields2(model.checkersList); ;
            HighlightButtons();
            UpdateButtons();
        }

        private void FormYourTurnPart2()
        {
            //выбираем куда сходить
            model.ReplaceChecker(model.checkersList, model.selectedFieldIndex, model.id);
            model.selectedFieldIndex = -1;
            model.ActivateFields1(model.checkersList);
            HighlightButtons();
            UpdateButtons();
            model.GoCubes();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            model.id = int.Parse((sender as Button).Name.Replace("button", "")) - 1;
            if (model.selectedFieldIndex == -1)
            {
                FormYourTurnPart1();
            }
            else
            {
                FormYourTurnPart2();
            }
            StartButton.Text = model.cube1 + "\n" + model.cube2;

        }
    }
}
