using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{
    public partial class Form1 : Form
    {

        bool clicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;

        private void MyControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void MyControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Panel pn = sender as Panel;
                pn.Left = e.X + pn.Left - MouseDownLocation.X;
                pn.Top = e.Y + pn.Top - MouseDownLocation.Y;
            }
        }
    }
}
