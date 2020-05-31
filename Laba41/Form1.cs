using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba41
{
    public partial class LABA4_BLOCK1 : Form
    {
        public LABA4_BLOCK1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pen myPan = new Pen(Color.Black, 1);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.DrawRectangle(myPan, 10, 10, 50, 50);
            Rectangle rect = new Rectangle(60, 70, 100, 100);
            float startAngle = 200.0F;
            float sweepAngle = 200.0F;
            g.DrawArc(myPan, rect, startAngle, sweepAngle);
            g.DrawLine(myPan, new Point(63, 102), new Point(148, 153));
        }
        
    }
}
