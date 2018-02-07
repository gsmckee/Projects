using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traverse
{
    public class Grid
    {
        
        public Grid(int i, int j)
        {
            int[,] grid = new int[i,j];
            for(int y = 0; y <= i; y++)
            {
                grid[i, y] = y;
                for(int x = 0; x <= j; x++)
                {
                    grid[x, j] = x;
                    Console.WriteLine(grid[x, y]);
                }
            }
        }

    }
}
