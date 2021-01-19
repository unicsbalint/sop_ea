using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;

namespace Client
{
    public partial class regForm : Form
    {
        public ServiceClient sc = new ServiceClient();
        public regForm()
        {
            InitializeComponent();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == tb_rePassword.Text)
            {
                if (sc.Register(tb_username.Text, tb_password.Text))
                {
                    MessageBox.Show("Registered succesfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong during registration");
                }
                
            }
            else
            {
                MessageBox.Show("Passwords dont match");
            }
            
        }
    }
}
