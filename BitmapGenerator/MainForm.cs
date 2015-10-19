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
            this.Text = "Loading...";
            rndbit.Width = pic.Width;
            rndbit.Height = pic.Height;
            pic.Image = rndbit.Generate();
            this.Text = "Done";
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetPic();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rndbit.SaveImage(saveFileDialog.FileName);
                    saveFileDialog.FileName = string.Empty;
                }
            }
        }
    }
}
