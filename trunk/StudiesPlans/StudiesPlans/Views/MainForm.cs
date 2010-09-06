using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlans.Views;

namespace StudiesPlans
{
    public partial class MainForm : Form
    {
        Boolean isManagementShown = false;

        public MainForm()
        {
           
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managementBtn_Click(object sender, EventArgs e)
        {
            int addWidth = 300;
            int managementBtnPosition = 27;


            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                if (!this.isManagementShown)
                {
                    this.Location = new Point(this.Location.X - addWidth/2, this.Location.Y);
                    this.Width += addWidth;
                    this.managemntBtn.Location = new Point(this.managemntBtn.Location.X + addWidth, managementBtnPosition);
                    this.isManagementShown = true;
                }
                else
                {
                    this.Location = new Point(this.Location.X + addWidth/2, this.Location.Y);
                    this.Width -= addWidth;
                    this.managemntBtn.Location = new Point(this.managemntBtn.Location.X - addWidth, managementBtnPosition);
                    this.isManagementShown = false;
                    }
                }
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void updateGUI()
        {
            Application.DoEvents();
            this.Invalidate();
            this.Update();
            System.Threading.Thread.Sleep(1);
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush _TextBrush;

            TabPage _TabPage = tabControl.TabPages[e.Index];
            Rectangle _TabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Kolor tekstu i zaznaczenia zakładki
                _TextBrush = new SolidBrush(Color.Black);
                graphics.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(Color.Black);
                graphics.FillRectangle(Brushes.Silver, e.Bounds);
            }

            // Ustawienie własnej czcionki
            Font _TabFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);

            // Wypisanie tekstu, wyjustowanie
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            graphics.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));

        }

        

        
    }


}
