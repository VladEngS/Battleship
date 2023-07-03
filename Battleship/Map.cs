using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Map
    {
        public int[,] map = new int[10, 10];

        //public Map()
        //{
        //    for (int i = 0; i < 10; i++)
        //        for (int j = 0; j < 10; j++)
        //            map[i, j] = 0;
        //}


        private class Ship
        {
            public int Type { get; set; }
            public string Orientation { get; set; }

        }
    }

    
}

/*
    0 - клетка пуста
    1 - клетка занята
 */