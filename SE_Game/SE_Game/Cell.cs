using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE_Game
{
    class Cell
    {
        private Point index;
        private Point position;
        private int cellType;

        enum CellType
        {
            Normal,
            Goal,
            Wall,
        }


        public Cell(Point index, Point position, int cellType)
        {

        } 
        public void Draw(Graphics g)
        {

        }
    }
}
