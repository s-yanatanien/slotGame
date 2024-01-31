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
        private Image[]img = new Image[3];

        public FrmSlot()
        {
            InitializeComponent();

            btnStop1.Enabled = false;
            btnStop2.Enabled = false;
            btnStop3.Enabled = false;

            img[0] = Image.FromFile("C:\\Users\\shinari\\Desktop\\slotGame\\p\\coin.png");
            img[1] = Image.FromFile("C:\\Users\\shinari\\Desktop\\slotGame\\p\\chaba.png");
            img[2] = Image.FromFile("C:\\Users\\shinari\\Desktop\\slotGame\\p\\ballet.png");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

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
                    pb1.Image = img[index];
                }

                if (btnStop2.Enabled)
                {
                    index = r.Next(3);
                    pb2.Image = img[index];
                }

                if (btnStop3.Enabled)
                {
                    index = r.Next(3);
                    pb3.Image = img[index];
                }

                if (btnStop1.Enabled == false &&
                   btnStop2.Enabled == false &&
                   btnStop3.Enabled == false)
                {
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
    }
}
