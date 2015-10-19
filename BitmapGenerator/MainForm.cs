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
        bool maximize = false;

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
            this.Text = "Done - " + rndbit.Width + " * " + rndbit.Height;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetPic();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            bool notPressed = true;
            if (e.Control && e.KeyCode == Keys.S && notPressed)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rndbit.SaveImage(saveFileDialog.FileName);
                    saveFileDialog.FileName = string.Empty;
                }
                notPressed = false;
            }

            if (e.KeyCode == Keys.Enter && notPressed)
            {
                SetPic();
                notPressed = false;
            }

            if (e.KeyCode == Keys.F11 && notPressed)
            {
                if (maximize)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    maximize = !maximize;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    maximize = !maximize;
                }

                notPressed = false;
            }

            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Keys shortcut"
                    + Environment.NewLine
                    + Environment.NewLine + "ctrl+s : save image"
                    + Environment.NewLine + "ENTER : Refresh image"
                    + Environment.NewLine + "F11 : Toggle full screen "
                    , "Keys shortcut", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
