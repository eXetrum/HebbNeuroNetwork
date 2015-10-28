using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HebbNeuralNetwork
{
    class InputGUI : DataGridView
    {
        bool drawMode { get; set; }
        Color selectionCellColor { get; set; }

        static int cellWidth = 20;
        static int cellHeight = 20;
        static int objectCounter = 0;

        static int objectsInOneRow = 4;

        public InputGUI(int rows, int cols)
            : base()
        {
            ++objectCounter;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            
            // 
            // dataGridView
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //this.ColumnHeadersHeight = 5;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersVisible = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.MultiSelect = false;
            this.Name = "dataGridView" + objectCounter;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            //this.RowHeadersWidth = 5;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RowTemplate.Height = cellHeight;
            this.RowTemplate.ReadOnly = true;
            this.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Size = new System.Drawing.Size(cols * cellWidth + (cols -1 ), rows * cellHeight + (rows - 2));
            this.TabIndex = objectCounter;
            
            this.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);            
            this.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            

            ///////////////////
            
            ///////////////////
            ///////////////////

            this.RowCount = rows;
            this.ColumnCount = cols;


            
        }
        
        public void attachTo(Panel mainGUI)
        {
            //mainGUI.controls
            mainGUI.SuspendLayout();

            
            for (int i = 0; i < this.ColumnCount; ++i)
                this.Columns[i].Width = cellWidth;
            //this.CurrentCell.Selected = false;
            drawMode = false;
            selectionCellColor = Color.FromArgb(255, 255, 128, 255);

            mainGUI.Controls.Add(this);
            mainGUI.ResumeLayout(false);
        }

        public void SetFreeLocation()
        {
            int h = 0;
            //if ((objectCounter - 1) % objectsInOneRow == 0)
            int ratio = (objectCounter - 1) / objectsInOneRow;
            h = (objectCounter - 1) / objectsInOneRow * Height;
            if (h == 0)
            {
                Location = new Point((objectCounter - 1) * (Width + 25), h);///(objectCounter - 1) * Height);
            }
            else
            {
                Location = new Point((objectCounter - 1 - ratio * objectsInOneRow) * (Width + 25), h + (ratio * 25));
            }
        }







        private void _dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridView dgv = sender as DataGridView;
            drawMode = dgv[e.ColumnIndex, e.RowIndex].Selected;
            for (int i = 0; i < cells.Count; ++i)
                cells[i].Selected = true;*/
            //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (drawMode == false) return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = selectionCellColor;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            //mainForm.ActiveForm.Text = e.Button + " " + e.RowIndex + " " + e.ColumnIndex;
        }


        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            drawMode = true;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                this.RowsDefaultCellStyle.SelectionBackColor = selectionCellColor;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                this.RowsDefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            drawMode = false;
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            this[e.ColumnIndex, e.RowIndex].Selected = drawMode;
            if (drawMode == false) return;
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
                this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = selectionCellColor;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;


            //  dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            dataGridView1_CellMouseUp(sender, new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 0, 0, 0)));
        }

    }
}
