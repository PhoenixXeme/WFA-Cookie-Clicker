using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Clicker
{
    public partial class Shop : UserControl
    {
        public Shop()
        {
            InitializeComponent();
        }

        public Form1 MainForm { get; set; }

        private void btn_stoneUpgBuy_Click(object sender, EventArgs e)
        {
            if (Form1.cookie >= 40)
            {
                Form1.cookie -= 40;
                Form1.stoneUpg++;
                lbl_stoneUpgOwned.Text = Form1.stoneUpg.ToString();
            }
            else
            {
                MessageBox.Show("Error: You dont have enough cookie's");
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
