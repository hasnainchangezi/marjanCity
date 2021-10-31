using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace marjanCity
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialoge = new OpenFileDialog();
                dialoge.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialoge.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialoge.FileName;
                    image1.ImageLocation = imageLocation;



                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error occured","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
