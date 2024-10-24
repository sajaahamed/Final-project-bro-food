using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bro_Hot_Food_And_Beverage
{
    public partial class add_new_meal : Form
    {
        int no_btn = 4;
        int btn_index = 0;
        int y = 10;
        public add_new_meal()
        {
            InitializeComponent();
            addbutton();
        }

        private void add_new_meal_Load(object sender, EventArgs e)
        {

        }
        public void addbutton()
        {
            try
            {
                MySqlConnection sqlConnection = new DbCon().connectDB();
                sqlConnection.Open();
                MySqlCommand command = new MySqlCommand("select * from price_list order by food_id", sqlConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataSet set = new DataSet();


            da.Fill(set,"price_list");
                int c = set.Tables["price_list"].Rows.Count;
                int i;
                for (i = 1; i <= c; i++)
                {
                    string btnm;
                    btnm = (string)(set.Tables["price_list"].Rows[i - 1]["food_name"]);


                    Guna2Button nbutton = new Guna2Button();
                    this.Controls.Add(nbutton);
                    nbutton.Size = new Size(164, 121);
                    nbutton.Text = btnm;

                    int nwsize = 12;
                    nbutton.Font = new Font(nbutton.Font.FontFamily, nwsize);
                    nbutton.ForeColor = Color.White;
                    nbutton.FillColor = Color.DarkSlateBlue;
                    nbutton.BorderRadius = 8;
                    nbutton.CustomizableEdges.BottomRight = true;
                    nbutton.CustomizableEdges.TopRight = true;
                    nbutton.CustomizableEdges.BottomLeft = true;
                    nbutton.CustomizableEdges.TopLeft = true;
                    //nbutton.Text.t


                    if (btn_index == no_btn)
                    {
                        btn_index = 1;
                        y += nbutton.Height;
                    }
                    else
                    {
                        btn_index += 1;
                    }
                    
                    nbutton.Location = new Point(10 * 1 + (btn_index - 1) * (nbutton.Width), y);
                    pnl1.SendToBack();
                    pnl1.Controls.Add(nbutton);
                }
                sqlConnection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            addbutton();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
