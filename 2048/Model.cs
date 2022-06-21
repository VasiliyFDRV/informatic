using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Model
    {
        bool isGameOver;
        bool moved;
        public int Score = 0;
        public Map map;
        public int[,] map1 = new int[4, 4];
        static Random rnd = new Random();

        public Model()
        {
            map = new Map();
        }

        public void Start()
        {
            isGameOver = false;
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                { map.Set(x, y, 0); }
            AddRandom();
            AddRandom();
        }

        private void AddRandom()
        {
            if (isGameOver) return;
            for (int j = 0; j < 100; j++)
            {
                int x = rnd.Next(0, 4);
                int y = rnd.Next(0, 4);
                if (map.Get(x, y) == 0)
                {
                    int n = rnd.Next(1, 10);
                    if (n != 4) n = 2;
                    map.Set(x, y, n);
                    return;
                }
            }
        }

        private void Lift(int x, int y, int sx, int sy)
        {
            if (map.Get(x, y) > 0)
            {
                while (map.Get(x + sx, y + sy) == 0)
                {
                    map.Set(x + sx, y + sy, map.Get(x, y));
                    map.Set(x, y, 0);
                    x += sx;
                    y += sy;
                    moved = true;
                }
            }
        }
        private void Join(int x, int y, int sx, int sy)
        {
            if (map.Get(x, y) > 0)
            {
                if (map.Get(x + sx, y + sy) == map.Get(x, y))
                {
                    Score += map.Get(x, y) * 2;
                    map.Set(x + sx, y + sy, map.Get(x, y) * 2);
                    while (map.Get(x - sx, y - sy) > 0)
                    {
                        map.Set(x, y, map.Get(x - sx, y - sy));
                        x -= sx;
                        y -= sy;
                    }
                    map.Set(x, y, 0);
                    moved = true;
                }
            }
        }

        public bool IsGameOver()
        {
            if (isGameOver) return true; 
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                {
                    if (map.Get(x, y) == 0)
                        return false;
                    if (map.Get(x, y) == map.Get(x + 1, y) || map.Get(x, y) == map.Get(x, y + 1))
                        return false;
                }
            return true;

        }


        public void Left()
        {
            moved = false;
            for (int y = 0; y <4; y++)
                for (int x = 1; x < 4; x++)
                {
                    Lift(x, y, -1, 0);
                }
            for (int y = 0; y < 4; y++)
                for (int x = 1; x < 4; x++)
                {
                    Join(x, y, -1, 0);
                }
            if (moved == true) AddRandom();
        }

        public void Right()
        {
            moved = false;
            for (int y = 0; y < 4; y++)
                for (int x = 2; x >= 0; x--)
                {
                    Lift(x, y, 1, 0);
                }
            for (int y = 0; y < 4; y++)
                for (int x = 2; x >= 0; x--)
                {
                    Join(x, y, 1, 0);
                }
            if (moved == true) AddRandom();
        }

        public void Up()
        {
            moved = false;
            for (int x = 0; x < 4; x++)
                for (int y = 1; y < 4; y++)
                {
                    Lift(x, y, 0, -1);
                }
            for (int x = 0; x < 4; x++)
                for (int y = 1; y < 4; y++)
                {
                    Join(x, y, 0, -1);
                }
            if (moved == true) AddRandom();
        }

        public void Down()
        {
            moved = false;
            for (int x = 0; x < 4; x++)
                for (int y = 2; y >= 0; y--)
                {
                    Lift(x, y, 0, 1);
                }
            for (int x = 0; x < 4; x++)
                for (int y = 2; y >= 0; y--)
                {
                    Join(x, y, 0, 1);
                }
            if (moved == true) AddRandom();
        }
    }
}
