using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;

namespace Client
{

    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        public ServiceClient sc = new ServiceClient();
        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (sc.Login(tb_userName.Text, tb_password.Text))
            {
                Thread thread = new Thread(openMain);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not appropriate user details");
            }
        }
        static void openMain()
        {
            Application.Run(new Main());
        }
        private void bt_register_Click(object sender, EventArgs e)
        {
            regForm reg = new regForm();
            reg.Show();
        }
    }
}
