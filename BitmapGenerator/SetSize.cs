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
    public partial class SetSize : Form
    {
        public int picWidth { get; private set; }
        public int picHeight { get; private set; }

        public SetSize()
        {
            InitializeComponent();
        }

        public SetSize(int width, int height)
        {
            InitializeComponent();

            numWidth.Value = Convert.ToDecimal(width);
            numHeight.Value = Convert.ToDecimal(height);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            picWidth = Convert.ToInt32(numWidth.Value);
            picHeight = Convert.ToInt32(numHeight.Value);
            this.Close();
        }
    }
}
