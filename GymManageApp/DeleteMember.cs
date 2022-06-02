using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManageApp
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;

            

            cmd.CommandText = "select * from NewMember";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchNumber = Int32.Parse(searchTxt.Text);

            if (searchNumber > 0)
            {




                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;

               

                cmd.CommandText = "select * from NewMember where MID = " + searchNumber;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }else {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;



                cmd.CommandText = "select * from NewMember";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int deleteNumber = Int32.Parse(searchTxt.Text);
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "delete from NewMember where MID = " + deleteNumber;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
            da.Fill(ds);
            MessageBox.Show("Data was deleted!");
            dataGridView1.DataSource = ds;
            dataGridView1.Update();



        }

        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;



            cmd.CommandText = "select * from NewMember";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
