using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SortingVizualizer
{
    public partial class Form1 : Form
    {
        int[] MainArray;
        Graphics graphics;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
            int NumberOfEntries = panel1.Width;
            int MaxValue = panel1.Height;
            MainArray = new int[NumberOfEntries];
            graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, NumberOfEntries,MaxValue);
            Random rand = new Random();
            for (int i = 0; i < NumberOfEntries; i++)
            {
                MainArray[i] = rand.Next(0, MaxValue);
            }
            for(int i = 0; i < NumberOfEntries; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.White), i, MaxValue - MainArray[i], 1, MaxValue);
            }
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            SortingEngine sortingEngine = new BubbleSort();
            sortingEngine.DoWork(MainArray, graphics, panel1.Height);
        }
    }
}
