using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGenerator
{
    public partial class MainForm : Form
    {
        RandomBitmap rndbit;

        public MainForm()
        {
            InitializeComponent();
            rndbit = new RandomBitmap();
            rndbit.Width = pic.Width;
            rndbit.Height = pic.Height;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetPic();
        }

        void SetPic()
        {
            rndbit.Width = pic.Width;
            rndbit.Height = pic.Height;
            pic.Image = rndbit.Generate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetPic();
        }
    }
}
