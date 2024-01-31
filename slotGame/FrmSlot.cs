using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotGame
{
    public partial class FrmSlot : Form
    {
        private String[]img = new String[3];

        public FrmSlot()
        {
            InitializeComponent();

            lblMsg.Visible = false;

            btnStop1.Enabled = false;
            btnStop2.Enabled = false;
            btnStop3.Enabled = false;

            img[0] = ("C:\\Users\\shinari\\Desktop\\slotGame\\p\\coin.png");
            img[1] = ("C:\\Users\\shinari\\Desktop\\slotGame\\p\\chaba.png");
            img[2] = ("C:\\Users\\shinari\\Desktop\\slotGame\\p\\ballet.png");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            lblMsg.Visible=false;

            btnStart.Enabled = false;

            btnStop1.Enabled = true;
            btnStop2.Enabled = true;
            btnStop3.Enabled = true;

            Random r = new Random();
            int index = 0;

            while(true)
            {

                if (btnStop1.Enabled)
                {
                    index = r.Next(3);
                    pb1.ImageLocation = img[index];
                }

                if (btnStop2.Enabled)
                {
                    index = r.Next(3);
                    pb2.ImageLocation = img[index];
                }

                if (btnStop3.Enabled)
                {
                    index = r.Next(3);
                    pb3.ImageLocation = img[index];
                }

                if (btnStop1.Enabled == false &&
                   btnStop2.Enabled == false &&
                   btnStop3.Enabled == false)
                {
                    if(pb1.ImageLocation == pb2.ImageLocation &&
                        pb2.ImageLocation == pb3.ImageLocation)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "成功！";
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "残念…";
                    }

                    btnStart.Enabled = true;
                    break;
                }

                await Task.Delay(100);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
