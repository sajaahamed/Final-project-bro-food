using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bro_Hot_Food_And_Beverage
{
    public partial class MainMenu : Form
    {
       int quantity = 0;
        double srv = 0;


        public MainMenu()
        {
            
            InitializeComponent();
            getvalue();
            timer1.Start();
            addbutton();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add_new_meal add_New_Meal = new add_new_meal();
            add_New_Meal.ShowDialog();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("sajuuu");
            }
        }

        private void guna2Button51_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button52_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button53_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button54_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button56_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button57_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button58_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button59_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button60_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button61_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button62_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button63_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button64_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button65_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button66_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button67_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button68_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button69_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button70_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button71_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button72_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button73_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button74_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con= new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text=reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();


            /* String kottuF = btn_CkottuF.Text;
             kottuF = "Chiken Kottu Full";

             txt_meal_name.Text = kottuF;
             txt_meal_price.Text = "800";*/
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


        //quantity eke button deka  (+ ekai - ekai)
        private void btn_qty_plus_Click(object sender, EventArgs e)
        {
            
                quantity++;
                txt_qty.Text = quantity.ToString();
            double a;
            if (double.TryParse(txt_meal_price.Text, out a) == false)
            {
                MessageBox.Show("invalid");
            }
            else
            {
                double Price = Convert.ToDouble(txt_meal_price.Text);
                double total = 0.00;
                quantity = Convert.ToInt32(txt_qty.Text);

                total = Price * quantity;

                txt_tot.Text = total.ToString();
            }


        }

        private void btn_qty_minus_Click(object sender, EventArgs e)
        {
                quantity--;
                txt_qty.Text = quantity.ToString();
            double total = 0.00;
            double a;
            if (double.TryParse(txt_meal_price.Text, out a) == false)
            {
                MessageBox.Show("invalid");
            }
                double Price = Convert.ToDouble(txt_meal_price.Text);
            total =Convert.ToInt32(txt_tot.Text);
            total = total - Price;
            txt_tot.Text=total.ToString();
        }

        private void btn_CkotttuR_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 2", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();




           /* String kottuR = btn_CkottuR.Text;
            kottuR = "Chiken Kottu Reguler";

            txt_meal_name.Text = kottuR;
            txt_meal_price.Text = "800";*/
        }

        //add button in qty section
        private void guna2Button77_Click(object sender, EventArgs e)
        {
            try
            {
                string meal;
                int quantity = 0;
                double Price = 0.00;
                double total = 0.00;


                meal = txt_meal_name.Text;
                quantity = Convert.ToInt32(txt_qty.Text);
                Price = Convert.ToDouble(txt_meal_price.Text);
                total = Convert.ToDouble(txt_tot.Text);



                double ntot;
                if (swtch_sch.Checked == true)
                {

                    
                    srv = total * 10 / 100;
                    ntot = total + srv;
                }
                else
                {
                    ntot = total;
                }


                dataGridView3.Rows.Add(meal, quantity, Price, srv, ntot);





                txt_meal_name.Clear();
                txt_meal_price.Clear();
                txt_qty.Clear();
                txt_tot.Clear();
                swtch_sch.Checked = false;


                srv = 0;







                /*MySqlConnection connection = new DbCon().connectDB();
                connection.Open();
                string query = "insert into bill (Meal, Quantity, price ) VALUES(@Meal, @Quantity, @price)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Meal", meal);
                command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_qty.Text));
                command.Parameters.AddWithValue("@price", Convert.ToDouble(txt_meal_price.Text));


                txt_meal_name.Clear();
                txt_meal_price.Clear();
                txt_qty.Clear();



                command.ExecuteNonQuery();*/
                MessageBox.Show("Items add succesfully");
                getvalue();
                gtitem();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            quantity = 0;
        }
        public static void nms()
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_meal_name.Clear();
            txt_meal_price.Clear();
            txt_qty.Clear();
            swtch_sch.Checked = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public  void getvalue()
        {
            
            lbl_tot.Text = "0";
            double tot;
            double tl;
            double ftot;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                tot = Convert.ToDouble(lbl_tot.Text);
                tl = Convert.ToDouble(dataGridView3.Rows[i].Cells[4].Value);
                ftot = tot + tl;
                lbl_tot.Text = ftot.ToString();
            }
        }
        public void gtitem()
        {
            lbl_tot_item.Text = "0";
            double tot;
            for(int i = 0;i < dataGridView3.Rows.Count; i++)
            {
               tot=dataGridView3.RowCount;
                lbl_tot_item.Text= tot.ToString();

            }
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double a;
                if (double.TryParse(txt_meal_price.Text, out a) == false)
                {
                    MessageBox.Show("invalid");
                }
                else
                {
                    double Price = Convert.ToDouble(txt_meal_price.Text);
                    double total = 0.00;
                    quantity = Convert.ToInt32(txt_qty.Text);

                    total = Price * quantity;

                    txt_tot.Text = total.ToString();
                }

                
            }
            if (e.KeyCode == Keys.Up)
            {

                quantity++;
                txt_qty.Text = quantity.ToString();
                double b;
                if (double.TryParse(txt_meal_price.Text, out b) == false)
                {
                    MessageBox.Show("invalid");
                }
                else
                {
                    double Price = Convert.ToDouble(txt_meal_price.Text);
                    double total = 0.00;
                    quantity = Convert.ToInt32(txt_qty.Text);

                    total = Price * quantity;

                    txt_tot.Text = total.ToString();
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                quantity--;
                txt_qty.Text = quantity.ToString();
                double total = 0.00;
                double a;
                if (double.TryParse(txt_meal_price.Text, out a) == false)
                {
                    MessageBox.Show("invalid");
                }
                double Price = Convert.ToDouble(txt_meal_price.Text);
                total = Convert.ToInt32(txt_tot.Text);
                total = total - Price;
                txt_tot.Text = total.ToString();

                if(total<0)
                {
                    MessageBox.Show("invalid");

                }
            }
        }

        private void dataGridView3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbl_tot.Text = "0";
            double tot;
            double tl;
            double ftot;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                tot = Convert.ToDouble(lbl_tot.Text);
                tl = Convert.ToDouble(dataGridView3.Rows[i].Cells[4].Value);
                ftot = tot + tl;
                lbl_tot.Text = ftot.ToString();
            }
            gtitem();
        }
        public void gettime()
        {
            SoapDateTime sp;
            DataSetDateTime dt;
            DateTime dat;
           
           
            dat= DateTime.Now;
            DateTimeOffset datOffset = dat;
            dat.GetDateTimeFormats();
            lbl_tm.Text = dat.ToString();


            for (int i = 0; i < dat.Second; i++)
            {
                

                lbl_tm.Text = dat.ToString();
                
                
            }





        }

        private void btn_BkottuF_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void btn_BkottuR_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void btn_PkottuF_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void btn_PkottuR_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void btn_SkottuF_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void btn_SkottuR_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void guna2Button45_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void guna2Button47_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void guna2Button49_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void guna2Button50_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "0";
            MySqlConnection con = new DbCon().connectDB();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select food_name,price from price_list where food_id = 1", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_meal_name.Text = reader.GetValue(0).ToString();
                txt_meal_price.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            con.Close();
            txt_qty.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tm.Text = DateTime.Now.ToString("T");
            lbl_dt.Text = DateTime.Now.ToString("D");
        }

        private void lbl_dt_Click(object sender, EventArgs e)
        {

        }

        int no_btn = 4;
        int btn_index = 0;
        int y = 10;
        int x =0;
        public void addbutton()
        {
            try
            {
                MySqlConnection sqlConnection = new DbCon().connectDB();
                sqlConnection.Open();
                MySqlCommand command = new MySqlCommand("select * from price_list order by food_id", sqlConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataSet set = new DataSet();


                da.Fill(set, "price_list");
                int c = set.Tables["price_list"].Rows.Count;
                int i;
                for (i = 1; i <= c; i++)
                {
                    string btnm;
                    int btn_tbin;
                    btnm = (string)(set.Tables["price_list"].Rows[i - 1]["food_name"]);
                    btn_tbin=(int)(set.Tables["price_list"].Rows[i - 1]["food_id"]);


                    Guna2Button nbutton = new Guna2Button();
                    this.Controls.Add(nbutton);
                    nbutton.Size = new Size(164, 121);
                    nbutton.Text = btnm;
                    nbutton.TabIndex=btn_tbin;
                    nbutton.CustomizableEdges.BottomRight = true;
                    nbutton.CustomizableEdges.TopRight = true;
                    nbutton.CustomizableEdges.BottomLeft = true;
                    nbutton.CustomizableEdges.TopLeft = true;

                    int nwsize = 12;
                    nbutton.Font = new Font(nbutton.Font.FontFamily, nwsize);
                    nbutton.ForeColor = Color.White;
                    nbutton.FillColor = Color.DarkSlateBlue;
                    nbutton.BorderRadius = 8;


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
                       
                    //pnl.SendToBack();
                    pnl.Controls.Add(nbutton);


                    nbutton.Click += (object sender, EventArgs e) =>
                    {
                        swtch_sch.Checked = false;
                        txt_tot.Text = "0.00";
                        txt_qty.Text = "0";

                        MySqlConnection con = new DbCon().connectDB();
                        con.Open();

                        
                        
                            MySqlCommand cmd = new MySqlCommand($"select food_name,price from price_list  where food_id={btn_tbin}", con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                txt_meal_name.Text = reader.GetValue(0).ToString();
                                txt_meal_price.Text = reader.GetValue(1).ToString();
                            }
                            reader.Close();
                            con.Close();
                            txt_qty.Focus();
                        
                    };
                    
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void guna2Button48_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button46_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button44_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button42_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tm_Click(object sender, EventArgs e)
        {

        }
    }
}
