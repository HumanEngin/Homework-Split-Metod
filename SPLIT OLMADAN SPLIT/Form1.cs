using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLIT_OLMADAN_SPLIT
{
    public partial class Form1 : Form
    {
        string strDeger;
        string bosluk;
        int indexofSonKisim, exp=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            bosluk = txtBx2.Text;
            for (int i = 0; ; i++)
            {
                if (bosluk == " " && exp == 0)
                {
                    strDeger = txtBx1.Text + " ";
                    exp = 1;
                }
                else
                    strDeger = txtBx1.Text;
                indexofSonKisim = 1 + strDeger.IndexOf(bosluk, 0, strDeger.Length);
                if (indexofSonKisim > 1)
                {
                    string yeniStr = strDeger.Substring(0, indexofSonKisim);
                    lstBx1.Items.Add(yeniStr);
                }
                else
                {
                    if (txtBx1.Text == " ")
                    {
                        txtBx1.Text = "";
                    }
                    break;
                }
                txtBx1.Text = strDeger.Remove(0, indexofSonKisim);
            }
            exp = 0;

            //strDeger = txtBx1.Text + " ";
            //indexofSonKisim = 1 + strDeger.IndexOf(bosluk, 0, strDeger.Length);
            //string yeniStr = strDeger.Substring(0, indexofSonKisim);
            //lstBx1.Items.Add(yeniStr);
            //txtBx1.Text = strDeger.Remove(0, indexofSonKisim);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lstBx1.Items.Clear();
        }
    }
}
