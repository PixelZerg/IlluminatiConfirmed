using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlluminatiConfirmed
{
    public partial class Picture : Form
    {
        public static string pathpath;// = "https://lh6.googleusercontent.com/-_ASksv5DrxQ/TyQ6X4zG_7I/AAAAAAAAECg/WmVfMzj9l3Y/s1600/transparent.png";
        public Picture()
        {
            InitializeComponent();
            timer1.Start();
            try
            {
                pictureBox1.Load(pathpath);
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Picture_Load(object sender, EventArgs e)
        {
            //pictureBox1.Load(pathpath);
        }
    }
}
