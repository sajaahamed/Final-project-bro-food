using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Bro_Hot_Food_And_Beverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Uname = txt_user_name.Text;
            string pw = txt_password.Text;

            if (Uname=="0000"&&pw=="0000") 
            {

                
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Login Fail!");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
                
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                btn_login.PerformClick();   
            }
        }
    }
}
