using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardOffline
{
    class Model
    {
        public List<Field> checkersList = new List<Field>();
        public List<int> activeButtons = new List<int>();
        public int cube1 = 0;
        public int cube2 = 0;
        public int selectedFieldIndex = -1;
        public int id;

        public void Start()
        {
            for (int i = 0; i < 24; i++) { checkersList.Add(new Field()); }
            checkersList[0].Change("white", 15);
            checkersList[12].Change("black", 15);

            ActivateFields1(checkersList);
            GoCubes();
        }

        public void ReplaceChecker(List<Field> l1, int pl1, int pl2)
        {
            l1[pl1].qty -= 1;
            l1[pl2].qty += 1;
            l1[pl2].color = l1[pl1].color;
            if (l1[pl1].qty == 0) l1[pl1].color = "";
        }
        public void ActivateFields1(List<Field> l1) 
        {
            // заполняет activButtons только не пустыми белыми клетками
            activeButtons.Clear();
            for(int i = 0; i< l1.Count; i++) 
            { 
                if (l1[i].qty != 0 && l1[i].color == "white") activeButtons.Add(i); 
            }
        }

        public void ActivateFields2(List<Field> l1)
        {
            // заполняет activButtons только клетками на которые возмоно сходить
            activeButtons.Clear();

            if (l1[selectedFieldIndex + cube1].color != "black")
            {
                activeButtons.Add(selectedFieldIndex + cube1);
            }
            if (l1[selectedFieldIndex + cube2].color != "black")
            {
                activeButtons.Add(selectedFieldIndex + cube2);
            }
            if (l1[selectedFieldIndex + cube1 + cube2].color != "black")
            {
                activeButtons.Add(selectedFieldIndex + cube1 + cube2);
            }


        }

        public void GoCubes()
        {
            var rnd = new Random();
            cube1 = rnd.Next(1,7);
            cube2 = rnd.Next(1,7);
        }

        public void YourTurnPart2()
        {
           
        }



    }

}
