using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Map
    {
        int[,] map;
        public Map()
        {
            map = new int[4, 4];
        }

        public bool OnMap(int x, int y)
        {
            return x >= 0 && x < 4 && y >= 0 && y < 4;
        }

        public int Get(int x, int y)
        {
                if (OnMap(x, y))
                    return map[x, y];
                else return -1;
        }

        public void Set(int x, int y, int number)
        {
            if (OnMap(x, y))
                map[x, y] = number;
        }

        public int[,] MatrixGet()
        {
            return map;
        }
    }
}
