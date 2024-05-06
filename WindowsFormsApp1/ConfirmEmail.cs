﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class ConfirmEmail : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        string email = CreateAccount.email;
        string password = CreateAccount.password;
        string name = CreateAccount.name;
        string code = CreateAccount.randomCode;
        DBManager manager = new DBManager();

    public ConfirmEmail()
        {
            InitializeComponent();
        }

        private void confirmbutn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (code == (OTPTxtbx.Text).ToString())
            {
                string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
                MySqlConnection connection = new MySqlConnection(con);

                string query1 = "insert into account(email,password,username,contactNumber) values('"+email+"','"+password+"','"+name+"','N/A')";
              
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                
                MessageBox.Show("Account Created Successfully");
                connection.Close();


                LoginForm.account = new Account();
                LoginForm.account.email = email;
                LoginForm.account.password = password;
                LoginForm.account.username = name;
                
                string path = @"C:\Users\USER\Desktop\GrouCord\WindowsFormsApp1\WindowsFormsApp1\Resources\user (1).png";
                manager.updateProfilePic(path, LoginForm.account.email);
                
                LoginForm.account.status = Classes.CurrStatus.AVAILABLE;
                manager.updateStatus(LoginForm.account.status.ToString(), LoginForm.account.email);
                LoginForm.hp.Show();

                connection.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect OTP code");
            }

            Cursor.Current = Cursors.Default;
        }

        private void ConfirmEmail_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
