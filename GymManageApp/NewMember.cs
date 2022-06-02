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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = firstNametxt.Text;
            string lname = lastNametxt.Text;
            string gender = "";
            bool isCheck = radioButton1.Checked;

            if(isCheck)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            string dob = dateTimePickerDOB.Text;
            Int64 mobileNumber = Int64.Parse(mobileTxt.Text);
            string email = emailTxt.Text;
            string joinDate = dateTimePickerJoinDate.Text;
            string gymTime = comboBoxGymTime.Text;
            string address = addressTxt.Text;
            string membershipTime = comboBoxMembership.Text;


            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "data source = DESKTOP-HUQEKLD; database = gymManage; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MemebershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobileNumber + ",'" + email + "','" + joinDate + "','" + gymTime + "','" + address + "','" + membershipTime + "') ";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            
            MessageBox.Show("Data was saved");



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            firstNametxt.Clear();
            lastNametxt.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            mobileTxt.Clear();
            emailTxt.Clear();
            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            addressTxt.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;

        }
    }
}
