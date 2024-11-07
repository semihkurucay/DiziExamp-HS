using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30112020_Dizi2
{
    public partial class Form1 : Form
    {
        int i = 0;
        int sayi = 0;
        Random rnd = new Random();
        int[] a = { 25, 874, 35, 4, 156, 32, 1 };
        string[] n = { "Ali", "Mehmet", "Can", "Fatma", "Ayşe", "Zeynep" };
        int[] diziX = new int[5];
        int[] diziY = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoldur1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < a.Length; i++)
            {
                list1.Items.Add(a[i]);
            }
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list1.SelectedIndex == -1)
            {
                txtSecim1.Clear();
            }
            else
            {
                txtSecim1.Text = list1.SelectedItem.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (i = 0; i < n.Length; i++)
            {
                list2.Items.Add(n[i]);
            }

            for (i = 0; i < diziX.Length; i++)
            {
                sayi = rnd.Next(1, 51);
                diziX[i] = sayi;
                list3.Items.Add(diziX[i]);
            }

            for(i=0;i<diziY.Length;i++)
            {
                sayi = rnd.Next(1, 51);
                diziY[i] = sayi;
                list4.Items.Add(diziY[i]);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                list2.Items.RemoveAt(list2.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("SEÇİM YAPIN");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                button2.Text = "Aç";
            }
            else
            {
                groupBox1.Visible = true;
                button2.Text = "Gizle";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
                button3.Text = "Aç";
            }
            else
            {
                groupBox2.Visible = true;
                button3.Text = "Gizle";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible == true)
            {
                groupBox3.Visible = false;
                button4.Text = "Aç";
            }
            else
            {
                groupBox3.Visible = true;
                button4.Text = "Gizle";
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if(list3.SelectedIndex==-1||list4.SelectedIndex==-1)
            {
                MessageBox.Show("Sayı seçiniz");
            }
            else
            {
                txtTopla.Text = (Convert.ToInt32(list3.SelectedItem) + Convert.ToInt32(list4.SelectedItem)).ToString();
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (list3.SelectedIndex == -1 || list4.SelectedIndex == -1)
            {
                MessageBox.Show("Sayı seçiniz");
            }
            else
            {
                int islem = Convert.ToInt32(list3.SelectedItem) - Convert.ToInt32(list4.SelectedItem);
                txtCikar.Text = islem.ToString();
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (list3.SelectedIndex == -1 || list4.SelectedIndex == -1)
            {
                MessageBox.Show("Sayı seçiniz");
            }
            else
            {
                int islem = Convert.ToInt32(list3.SelectedItem) * Convert.ToInt32(list4.SelectedItem);
                txtCarp.Text = islem.ToString();
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (list3.SelectedIndex == -1 || list4.SelectedIndex == -1)
            {
                MessageBox.Show("Sayı seçiniz");
            }
            else
            {
                double islem = Convert.ToInt32(list3.SelectedItem) / Convert.ToInt32(list4.SelectedItem);
                txtBol.Text = islem.ToString();
            }
        }
    }
}
