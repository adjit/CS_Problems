using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class coords
    {
        public int x;
        public int y;

        public coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Amazon
    {
        public static int minimumDistance(int numRows, int numColumns, int[,] area)
        {
            int rightDistance = -1;
            int downDistance = -1;

            if (numRows == 0 || numColumns == 0) return -1;
            if (area[0, 1] == 1 || area[0, 1] == 9) {
                int[,] tempArea = area;
                tempArea[0, 0] = 0;
                rightDistance = follow(new coords(0, 1), tempArea, 1, numRows, numColumns);
            }
            if (area[1,0] == 1 || area[1, 0] == 9)
            {
                int[,] tempArea = area;
                tempArea[0, 0] = 0;
                downDistance = follow(new coords(1, 0), tempArea, 1, numRows, numColumns);
            }

            if (rightDistance != -1 && 
                (downDistance == -1 || rightDistance <= downDistance)) return rightDistance;
            else if (downDistance != -1 && 
                (rightDistance == -1 || downDistance <= rightDistance)) return downDistance;
            else return -1;
        }

        private static int follow(coords coord, int[,] area, int distanceTraveled, int nRows, int nCols)
        {
            if (area[coord.x, coord.y] == 9) return distanceTraveled;

            int up, down, left, right;
            up = down = left = right = -1;

            area[coord.x, coord.y] = 0;

            //Move up
            if (coord.x - 1 >= 0 && area[coord.x - 1, coord.y] != 0)
            {
                up = distanceTraveled;
                up = follow(new coords(coord.x - 1, coord.y), area, ++up, nRows, nCols);
            }

            //Move down
            if (coord.x + 1 < nCols && area[coord.x + 1, coord.y] != 0)
            {
                down = distanceTraveled;
                down = follow(new coords(coord.x + 1, coord.y), area, ++down, nRows, nCols);
            }

            //Move right
            if (coord.y + 1 < nRows && area[coord.x, coord.y+1] != 0)
            {
                right = distanceTraveled;
                right = follow(new coords(coord.x, coord.y + 1), area, ++right, nRows, nCols);
            }

            //Move left
            if (coord.y-1 >= 0 && area[coord.x, coord.y-1] != 0)
            {
                left = distanceTraveled;
                left = follow(new coords(coord.x, coord.y - 1), area, ++left, nRows, nCols);
            }

            int[] distances = new int[] { up, down, right, left };

            int max = Int32.MaxValue;

            for(int i = 0; i < distances.Length; i++)
            {
                if (distances[i] > 0 && distances[i] < max) max = distances[i];
            }

            return max == Int32.MaxValue ? -1 : max;
        }

        private enum distance
        {
            left,
            right,
            down,
            up
        }
    }
}
