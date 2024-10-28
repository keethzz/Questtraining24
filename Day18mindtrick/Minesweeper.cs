using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18mindtrick
{
    internal class Minesweeper
    {
        private CellState[,] grid = new CellState[5, 5];
        public Minesweeper()
        {
            InitGrid();
            RenderGrid();
        }

        private void InitGrid()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    var state = (CellState)random.Next(0, 2); 
                    grid[i, j] = state;
                }
            }
        }

        private void RenderGrid()
        {
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{(int)grid[i, j]} "); 
                }
                Console.WriteLine(); 
            }
        }

    }
}
