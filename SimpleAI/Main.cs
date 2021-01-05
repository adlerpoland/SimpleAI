using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAI
{
    class Main
    {
        Map map;
        int[] matrix;

        int startX;
        int startY;

        int finishX;
        int finishY;

        public Main()
        {
            //PREPARE MAP
            matrix = new int[]
            {
                0 ,0 ,0 ,1 ,0 ,0 ,1 ,1 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0,
                0 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,1,
                0 ,0 ,0 ,1 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,1 ,1,
                0 ,1 ,0 ,0 ,1 ,1 ,1 ,0 ,1 ,1 ,1 ,0 ,1 ,0 ,1 ,1,
                1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,1 ,1 ,1 ,0,
                0 ,1 ,1 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0,
                1 ,0 ,0 ,1 ,0 ,0 ,1 ,1 ,0 ,1 ,0 ,0 ,1 ,1 ,1 ,0,
                1 ,0 ,0 ,1 ,0 ,0 ,1 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0,
                1 ,0 ,0 ,1 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,0 ,1 ,0 ,1 ,1,
                0 ,1 ,0 ,0 ,1 ,0 ,1 ,1 ,1 ,1 ,0 ,1 ,0 ,0 ,0 ,0,
                0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,1 ,0 ,0 ,0,
                0 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 ,0,
                1 ,1 ,1 ,0 ,1 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,1 ,1,
                1 ,1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0,
                1 ,0 ,0 ,0 ,0 ,1 ,0 ,1 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0,
                0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,1 ,0
            };

            map = new Map(16, 16, matrix);
        }

        public void SetStartPoint(int x, int y)
        {
            this.startX = x;
            this.startY = y;
        }

        public void SetFinishPoint(int x, int y)
        {
            this.finishX = x;
            this.finishY = y;
        }

        public int getMapWidth()
        {
            if (map != null)
            {
                return map.Width;
            }
            return 0;
        }

        public int getMapHeight()
        {
            if (map != null)
            {
                return map.Height;
            }
            return 0;
        }

        public int[] getMatrix()
        {
            return matrix;
        }
    }
}
