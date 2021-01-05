using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAI
{
    class SinglePoint
    {
        bool isOccupied = false;
        int x;
        int y;

        public SinglePoint(int x, int y, bool isOccupied)
        {
            this.x = x;
            this.y = y;
            this.isOccupied = isOccupied;
        }
    }

    class Map
    {
        SinglePoint[,] map;
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(int width, int height, int[] matrix)
        {
            this.Width = width;
            this.Height = height;
            map = new SinglePoint[width,height];

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    int point = h * width + w;
                    SinglePoint singlePoint = new SinglePoint(w, h, matrix[point] == 1);
                    map[w, h] = singlePoint;
                    Console.WriteLine($"[{w},{h}] = {matrix[point]}");
                }
            }
        }
    }
}
