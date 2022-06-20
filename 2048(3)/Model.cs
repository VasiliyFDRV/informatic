using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Model
    {
        bool isGameover;
        Map map;
        public int[,] map1 = new int[4, 4];
        static Random rnd = new Random();

        public Model()
        {
            map = new Map();
        }

        public void Start()
        {
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++) 
                { map1[x,y] = 0; }
            AddRandom(map1);
            AddRandom(map1);
        }

        private void AddRandom(int[,] map)
        {
            if (isGameover) return;
            for (int j = 0; j < 100; j++)
            {
                int x = rnd.Next(0, 4);
                int y = rnd.Next(0, 4);
                if (map[x,y] == 0)
                {
                    int n = rnd.Next(1, 10);
                    if (n != 4) n = 2;
                    map[x,y] = n;
                    return;
                }
            }
        }


        //private void AddRandom()
        //{
        //    if (isGameover) return;
        //    for (int j = 0; j < 100; j ++)
        //    {
        //        int x = rnd.Next(0, 4);
        //        int y = rnd.Next(0, 4);
        //        if (map.Get(x, y) == 0)
        //        {
        //            int n = rnd.Next(1, 10);
        //            if (n != 4) n = 2;
        //            map.Set(x, y, n);
        //            return;
        //        }
        //    }
        //}



        //private void Lift(int x, int y, int sx, int sy)
        //{
        //    if ( map.Get(x,y)!=0)
        //    {
        //        while
        //    }
        //}

        private List<List<int>> MoveX(int[,] map)
        {
            var l1 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                l1.Add(map[i, 1]);
            }

            var l2 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                l2.Add(map[i, 1]);
            }

            var l3 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                l3.Add(map[i, 1]);
            }

            var l4 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                l4.Add(map[i, 1]);
            }

            var finalL = new List<List<int>>() { l1, l2, l3, l4 };
            foreach (List<int> l in finalL)
            {
                foreach (int i in l)
                    if (i == 0)
                        l.Remove(i);
            }
            return finalL;
        }

        public void Left()
        {
            int[,] map2 = map1;
            var l = MoveX(map1);
            for (int j = 0; j < 4; j++)
            { 
                for (int i = 0; i < 4; i++)
                {
                    if (i < l[j].Count) map2[i, j] = l[j][i];
                    else map2[i, j] = 0;
                }
            }
            AddRandom(map2);
            map1 = map2;
        }

        public void Right()
        { }

        public void Up()
        { }

        public void Down()
        { }
    }
}
