using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pwsglab2
{
    
    class Rock : PictureBox
    {
        public static int rockSize = 40;
        public Rock(Image img)
        {
            this.Image = img;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Height = rockSize;
            this.Width = rockSize;
            this.Visible = true;
            this.BackColor = Color.Transparent;

        }
    }

    class Basket : PictureBox
    {
        public static int rockSize = 40;
        public Basket(Image img)
        {
            this.Image = img;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Height = rockSize;
            this.Width = rockSize;
            this.Visible = true;
            this.BackColor = Color.Transparent;

        }
    }

}
