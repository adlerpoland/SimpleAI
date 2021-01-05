using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAI
{
    public partial class Form1 : Form
    {
        Main main;

        public Form1()
        {
            InitializeComponent();
            main = new Main();

            mapView.ColumnCount = main.getMapWidth();

            var matrix = main.getMatrix();

            for(int r = 0; r < main.getMapHeight(); r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.mapView);

                for(int c = 0; c < mapView.ColumnCount; c++)
                {
                    int value = matrix[r * mapView.ColumnCount + c];
                    //ow.Cells[c].Value = value;
                    if (value == 1)
                    {
                        row.Cells[c].Style.BackColor = Color.Black;
                        row.Cells[c].Style.SelectionBackColor = Color.Transparent;
                    }
                }

                this.mapView.Rows.Add(row);
            }

            int height = this.mapView.Size.Height;
            int rowHeight = height / this.mapView.RowCount;

            //rows stretching
            for (int i = 0; i < this.mapView.Rows.Count; i++)
            {
                this.mapView.Rows[i].Height = rowHeight;
            }


            int startX = 0;
            int startY = 0;

            main.SetStartPoint(startX, startY);

            //SET START COLOR
            this.mapView.Rows[startY].Cells[startX].Style.BackColor = Color.Blue;
        }

        private void goToSelectedBtn_Click(object sender, EventArgs e)
        {
            //FIND SELECTED POINT
            if(this.mapView.SelectedCells.Count > 0)
            {
                var selectedCell = this.mapView.SelectedCells[0];
                if(selectedCell.Style.BackColor != Color.Black)
                {
                    int x = selectedCell.ColumnIndex;
                    int y = selectedCell.RowIndex;
                    Console.WriteLine($"Selected point [{x},{y}]");

                    main.SetFinishPoint(x, y);
                }
            }
        }
    }
}
