using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudiesPlans
{
    public partial class SlideForm : Form
    {

       //Constants

        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;

        //Wykorzystanie WinAPI
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        protected override void OnLoad(EventArgs e)
        {

            //Współrzędne
            int WidthOfMain=Application.OpenForms["MainForm"].Width;
            int HeightofMain= Application.OpenForms["MainForm"].Height;
            int LocationMainX=Application.OpenForms["MainForm"].Location.X ;
            int locationMainy=Application.OpenForms["MainForm"].Location.Y;

            //Ustawienie położenia okna
            this.Location = new Point(LocationMainX+WidthOfMain,locationMainy);

            //Animacja - slide
            AnimateWindow(this.Handle, 500, AW_SLIDE |AW_HOR_POSITIVE);
        }

    }
}

