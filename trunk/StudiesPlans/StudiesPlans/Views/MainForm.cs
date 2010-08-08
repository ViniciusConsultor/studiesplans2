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
        int time = 0;

        public MainForm()
        {
           
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managementBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                time = 0;
                timer.Start();
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
            this.Invalidate();
            this.Update();
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
                graphics.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Ustawienie własnej czcionki
            Font _TabFont = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);

            // Wypisanie tekstu, wyjustowanie
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            graphics.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (!isManagementShown)
            {
                this.panel1.Visible = true;
                if (time < 10)
                {
                    this.Location = new Point(this.Location.X - 15 , this.Location.Y);
                    this.Width += 30;
                    this.managemntBtn.Location = new Point(this.managemntBtn.Location.X + 30, 27);
                    updateGUI();
                }
                else
                {
                    isManagementShown = true;
                    this.timer.Stop();
                    this.managemntBtn.Text = "<";
                }
            }
            else
            {
                if (time < 10)
                {
                    this.Location = new Point(this.Location.X + 15, this.Location.Y);
                    this.Width -= 30;
                    this.managemntBtn.Location = new Point(this.managemntBtn.Location.X - 30, 27);
                    updateGUI();
                }
                else
                {
                    this.panel1.Visible = false;
                    isManagementShown = false;
                    this.timer.Stop();
                    this.managemntBtn.Text = ">";
                }
            }

        }
    }


}
