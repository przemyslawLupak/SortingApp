using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVizualizer
{
    class BubbleSort : SortingEngine
    {
        private bool isSorted = false;
        private int[] MainArray;
        private Graphics graphics;
        private int MaxValue;
        Brush WhiteBrush = new SolidBrush(Color.White);
        Brush BlackBrush = new SolidBrush(Color.Black);

        public void DoWork(int[] MainArray, Graphics graphics, int MaxValue)
        {
            this.MainArray = MainArray;
            this.graphics = graphics;
            this.MaxValue = MaxValue;

            while (!isSorted)
            {
                for (int i = 0; i < MainArray.Count()-1; i++)
                {
                    if (MainArray[i] > MainArray[i + 1])
                    {
                        Swap(i, i + 1);
                    } 
                }
                isSorted = Sorting();
            }
        }
        private void Swap(int i, int x)
        {
            int support = MainArray[i];
            MainArray[i] = MainArray[i + 1];
            MainArray[i + 1] = support;

            graphics.FillRectangle(BlackBrush, i, 0, 1, MaxValue);
            graphics.FillRectangle(BlackBrush, x, 0, 1, MaxValue);

            graphics.FillRectangle(WhiteBrush, i, MaxValue - MainArray[i], 1, MaxValue);
            graphics.FillRectangle(WhiteBrush, x, MaxValue - MainArray[x], 1, MaxValue);

        }
        private bool Sorting()
        {           
            for(int i = 0; i < MainArray.Count() - 1; i++)
            {
                if (MainArray[i] > MainArray[i + 1]) return false;
            }
            return true;
        }
        
    }
}
