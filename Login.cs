﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void singIn_Click(object sender, EventArgs e)
        {
            if(username.Text.Equals("Admin") && password.Text.Equals("admin"))
            {
                this.Hide();
                var form2 = new Dashboard();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong !");
            }
            
        }

        private void username_Enter(object sender, EventArgs e)
        {
            username.Text = " ";
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = " ";
        }
    }
}
