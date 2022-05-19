using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepegaCoin
{
    public partial class PepegaForm : Form
    {
  
        public PepegaForm()
        {
            InitializeComponent();
        }

        private void PepegaForm_Load(object sender, EventArgs e) 
        {
            timer1.Start();
            // label2.Text = Utility.GetNetworkTime().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("{0:F}", DateTime.UtcNow);

        }
    }
}